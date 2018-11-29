using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeWork6
{

    [Serializable]
    [Table("order.orderlist")]
    public class Order
    {
        public List<OrderDetails> ListOfProduct = new List<OrderDetails>();

        private String ordernum;

        [Key]
        [StringLength(32)]
        public String OrderNum
        {
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{4}[01][0-9][0123][0-9]-[0-9]{3}$"))
                    ordernum = value;
                else
                    throw new WrongData();
            }
            get
            {
                return ordernum;
            }
        }

        [StringLength(255)]
        public String Customer { set; get; }


        private String telnum;
        [Column("tel-num")]
        [StringLength(32)]
        public String TelNum
        {
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{11}$"))
                    telnum = value;
                else
                    throw new WrongData();
            }

            get
            {
                return telnum;
            }
        }


        private double money;

        public double Money
        {
            set
            {
                money = 0;
                foreach (OrderDetails ele in ListOfProduct)
                {
                    money += ele.Money;
                }
            }
            get { return money; }
        }

       // public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public Order(String ordernum)
        {
            this.OrderNum = ordernum;
            
        }
        public Order(String ordernum,String telnum,String customer="Mr.")
        {
            this.OrderNum = ordernum;
            this.TelNum = telnum;
            this.Customer = customer;
        }
        public Order()
        {

        }
    }


    [Table("order.orderdetail")]
    public class OrderDetails
    {


        private String ordernum;
        //[Key]
        [Column("ordernum")]
        [StringLength(32)]
        public String OrderNum
        {
            set
            {
                if (Regex.IsMatch(value, @"^[0-9]{4}[01][0-9][0123][0-9]-[0-9]{3}$"))
                    ordernum = value;
                else
                    throw new WrongData();
            }
            get
            {
                return ordernum;
            }
        }
        [Key]
        [Column("product")]
        [StringLength(255)]
        public String TypeOfProduct { set; get; }
        [Column("price")]
        public double PriceOfProduct { set; get; }
        [Column("amount")]
        public int AmountOfProduct { set; get; }
        private double money;
        [Column("money")]
        public double Money
        {
            set
            {
                money = PriceOfProduct * AmountOfProduct;
            }
            get
            {
                return money;
            }
        }


        //public virtual Order Order { get; set; }
        public OrderDetails(Order ele,String type="empty",double price=0,int amount=0)
        {
            this.ordernum = ele.OrderNum;
            this.TypeOfProduct = type;
            this.PriceOfProduct = price;
            this.AmountOfProduct = amount;
            this.Money = 0;
        }
        public OrderDetails() { }
    }
    public class OrderService
    {
        public List<Order> ListOfOrder = new List<Order>();
        //static String connstr =
        //       "Database=order;datasource=127.0.0.1;port=3306;user=root;password=123456;";
        //MySqlConnection conn = new MySqlConnection(connstr);
        //public bool createSQL(){
        //    bool ifsuccess= true;
        //    try
        //    {

        //        using (MySqlCommand addTable =
        //        new MySqlCommand(
        //        "CREATE TABLE `orderlist` (`ordernum`  varchar(32) NOT NULL," +
        //        "`customer`  varchar(255) NULL," +
        //        "`tel-num` varchar(32) NULL," +
        //        "`money`  float  NULL," +
        //        "PRIMARY KEY (`ordernum`));", conn))
        //        {
        //            addTable.ExecuteNonQuery();

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ifsuccess = false;
        //    }
        //    try
        //    {
        //        using (MySqlCommand addTable =
        //        new MySqlCommand(
        //        "CREATE TABLE `orderdetail`(`ordernum`  varchar(32) NOT NULL," +
        //        "`product`  varchar(255) NULL," +
        //        "`price` float NULL," +
        //        "`amount`  int NULL," +
        //        "`money`  float  NULL," +
        //        "FOREIGN KEY (`ordernum`) REFERENCES `orderlist` (`ordernum`));", conn))
        //        {
        //            addTable.ExecuteNonQuery();
        //        }
        //        return ifsuccess;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
        
        //刷新钱数
        public void update()
        {
            foreach (Order ele in ListOfOrder)
            {
                foreach (OrderDetails de in ele.ListOfProduct)
                    de.Money = 0;
                ele.Money = 0;
            }
        }
        
        //添加订单
        public bool addOrder(Order neworder)
        {
            if ((from b in this.ListOfOrder where b.OrderNum == neworder.OrderNum select b).Count() == 0)
            {
                using (var db = new OrderDB())
                {
                    db.Orders.Add(neworder);
                    db.SaveChanges();
                }
                this.ListOfOrder.Add(neworder);
                return true;
            }
            else
                return false;

           
        }
        //删除订单
        public void deleteOrder(Order ele)
        {
            using(var db=new OrderDB())
            {
                var orderitem =from b in db.OrderDetails where b.OrderNum==ele.OrderNum select b;
                db.OrderDetails.RemoveRange(orderitem);
                var target = db.Orders.Find(ele.OrderNum);
                db.Orders.Remove(target);
                db.SaveChanges();
            }
        }
        //添加产品
        public void addOrderDetail(OrderDetails pro)
        {
            using(var db=new OrderDB())
            {
                var target = db.Orders.Find(pro.OrderNum);
                var order = from e in this.ListOfOrder where e.OrderNum == pro.OrderNum select e;
                foreach (Order ele in order)
                    ele.ListOfProduct.Add(pro);
                target.ListOfProduct.Add(pro);
                db.OrderDetails.Add(pro);
                db.SaveChanges();
            }
        }
        //根据客户查找
        public List<Order> SearchByCustomer(String NameOfCustomer)
        {
            List<Order> result = new List<Order>();
            var t = from n in ListOfOrder where n.Customer == NameOfCustomer select n;
            foreach (Order ele in t)
            {
                result.Add(ele);
            }
            return result;
        }
        //根据订单号查找
        public List<Order> SearchByNum(String NumOfPro)
        {
            List<Order> result = new List<Order>();
            foreach (Order ele in ListOfOrder)
            {
                if (ele.OrderNum == NumOfPro) result.Add(ele);
            }
            return result;
        }
        //根据产品种类查找
        public List<Order> SearchByPro(String NameOfProduct)
        {
            List<Order> result = new List<Order>();
            //foreach (Order ele in ListOfOrder)
            //{
            //    foreach (OrderDetails product in ele.ListOfProduct)
            //        if (product.TypeOfProduct == NameOfProduct) result.Add(ele);
            //}
            var res = from n in ListOfOrder from k in n.ListOfProduct where k.TypeOfProduct == NameOfProduct select n;
            foreach (Order ele in res) result.Add(ele);
            return result;
        }

        


        //修改订单
        public void changeCustomerOfOrder(Order ele, String newCustomer)
        {
            ele.Customer = newCustomer;
            using (var db = new OrderDB())
            {
                var target = db.Orders.Find(ele.OrderNum);
                target.Customer = newCustomer;
                db.SaveChanges();
            }
        }
        public bool changeOrderNumOfOrder(Order ele, String newNum)
        {
            ele.OrderNum = newNum;
            using (var db = new OrderDB())
            {
                var orderitem = from b in db.OrderDetails where b.OrderNum == ele.OrderNum select b;
                var target = db.Orders.Find(ele.OrderNum);
                try
                {
                    target.Customer = newNum;
                    foreach (OrderDetails el in orderitem)
                        el.OrderNum = newNum;
                    db.SaveChanges();
                    return true;
                }
                catch(Exception e)
                {
                    return false;
                }
                
            }
        }
        //更新数据
        public void update(Order order)
        {
            using(OrderDB db=new OrderDB())
            {
                db.Orders.Attach(order);
                db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        public void update(OrderDetails order)
        {
            using (OrderDB db = new OrderDB())
            {
                db.OrderDetails.Attach(order);
                db.Entry(order).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }

        }
        //查询大于10000的订单
        public List<Order> SearchMoreThan(List<Order> allOrder, double TargetMoney)
        {
            List<Order> result = new List<Order>();
            var t = from n in allOrder where n.Money > TargetMoney select n;
            foreach (Order ele in t)
            {
                result.Add(ele);
            }
            return result;
        }
        //导出xml
        public void Export(List<Order> OrderList, String Orderpath)
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            FileStream mytype = new FileStream(
                @"../../" + Orderpath, FileMode.Create, FileAccess.ReadWrite);
            xmlser.Serialize(mytype, OrderList);
            mytype.Close();
        }
        //从xml导入订单list
        public bool Import(String Orderpath)
        {
            bool ifImport = true;
            FileStream XmlPath = new FileStream(@"../../" + Orderpath, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            List<Order> temp = (List<Order>)xmlser.Deserialize(XmlPath);
            foreach (Order ele in temp)
            {
                if (ListOfOrder.Where(a => a.OrderNum == ele.OrderNum).Count() == 0)
                {
                    ListOfOrder.Add(ele);
                    this.addOrder(ele);
                }
                    
                else
                    ifImport = false;
            }
            XmlPath.Close();
            return ifImport;
        }
        //导出为HTML
        public bool ToHTML(String InPath, String OutPath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../" + InPath);

            XPathNavigator nav = doc.CreateNavigator();
            FileStream OutAsHTML = new FileStream(
                OutPath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XslTransform xl = new XslTransform();
            xl.Load("../../CheckOrder.xslt");
            xl.Transform(nav, null, OutAsHTML);
            OutAsHTML.Close();
            return true;
        }
        public void init()
        {
            using(OrderDB db=new OrderDB())
            {
                foreach (Order e in db.Orders)
                {
                    ListOfOrder.Add(e);       
                }
            }
            using(OrderDB db =new OrderDB())
            {
                var list = db.OrderDetails.ToList();
                foreach(OrderDetails e in db.OrderDetails)
                {
                    foreach(Order target in ListOfOrder)
                        if(target.OrderNum==e.OrderNum)
                    target.ListOfProduct.Add(e);
                }
                
            }
            
        }



        //命令行程序
        //输出结果
        public void WriteResult(List<Order> result)
        {
            if (result != null)
            {
                foreach (Order ele in result)
                {
                    Console.WriteLine("序号：" + result.FindIndex(a => a == ele) +
                        " 客户名：" + ele.Customer + " 订单号：" + ele.OrderNum
                        + " 订单总金额：" + ele.Money);
                    foreach (OrderDetails pro in ele.ListOfProduct)
                    {
                        Console.WriteLine("产品名：" + pro.TypeOfProduct + " 数目：" + pro.AmountOfProduct + " 价格："
                            + pro.PriceOfProduct + " 总金额：" + pro.Money);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("选择您要进行的操作：1.删除； 2.修改； 3.返回主菜单");
                int whichFun = 0;
                while (whichFun == 0)
                {
                    try
                    {
                        whichFun = int.Parse(Console.ReadLine());
                        if (whichFun < 1 || whichFun > 3) throw new System.FormatException();
                    }
                    catch (System.FormatException e)
                    {
                        whichFun = 0;
                        Console.Write(e.Message);
                        Console.WriteLine("请重新输入");
                    }
                }
                switch (whichFun)
                {
                    case 1:
                        Console.Write("输入您要删除的订单的序号：");
                        int index = -1;
                        while (index == -1)
                        {
                            try
                            {
                                index = int.Parse(Console.ReadLine());
                                Order temp = result[index];
                            }
                            catch (System.ArgumentOutOfRangeException e)
                            {
                                index = -1;
                                Console.WriteLine("序号无效，请重新输入");
                            }
                            catch (System.FormatException e)
                            {
                                index = -1;
                                Console.Write(e.Message);
                                Console.WriteLine("请重新输入");
                            }
                        }
                        deleteOrder(result[index]);
                        break;
                    case 2:
                        Console.WriteLine("选择您要进行的操作：1.修改客户名； 2.修改订单号；3.修改产品信息  4.返回主菜单");
                        int whichChange = 0;
                        while (whichChange == 0)
                        {
                            try
                            {
                                whichChange = int.Parse(Console.ReadLine());
                                if (whichChange < 1 || whichChange > 4) throw new System.FormatException();
                            }
                            catch (System.FormatException e)
                            {
                                whichChange = 0;
                                Console.Write(e.Message);
                                Console.WriteLine("请重新输入");
                            }
                        }
                        switch (whichChange)
                        {
                            case 1:
                                Console.Write("输入您要修改的订单的序号");
                                int index1 = -1;
                                while (index1 == -1)
                                {
                                    try
                                    {
                                        index1 = int.Parse(Console.ReadLine());
                                        Order temp = result[index1];
                                    }
                                    catch (System.ArgumentOutOfRangeException e)
                                    {
                                        index1 = -1;
                                        Console.WriteLine("序号无效，请重新输入");
                                    }
                                    catch (System.FormatException e)
                                    {
                                        index1 = -1;
                                        Console.Write(e.Message);
                                        Console.WriteLine("请重新输入");
                                    }
                                }
                                if (result[index1] != null)
                                {
                                    Console.Write("原用户名为：" + result[index1].Customer);
                                }
                                Console.Write(" 输入新的客户名：");
                                changeCustomerOfOrder(result[index1], Console.ReadLine());
                                break;
                            case 2:
                                Console.Write("输入您要修改的订单的序号");
                                int index2 = -1;
                                while (index2 == -1)
                                {
                                    try
                                    {
                                        index2 = int.Parse(Console.ReadLine());
                                        Order temp = result[index2];
                                    }
                                    catch (System.ArgumentOutOfRangeException e)
                                    {
                                        index2 = -1;
                                        Console.WriteLine("序号无效，请重新输入");
                                    }
                                    catch (System.FormatException e)
                                    {
                                        index2 = -1;
                                        Console.Write(e.Message);
                                        Console.WriteLine("请重新输入");
                                    }
                                }
                                if (result[index2] != null)
                                {
                                    Console.Write("原订单号为：" + result[index2].OrderNum);
                                }
                                Console.Write(" 输入新的订单号为：");
                                changeOrderNumOfOrder(result[index2], Console.ReadLine());
                                break;
                            case 3:
                                Console.Write("输入您要修改的订单的序号");
                                int index3 = -1;
                                while (index3 == -1)
                                {
                                    try
                                    {
                                        index3 = int.Parse(Console.ReadLine());
                                        Order temp = result[index3];
                                    }
                                    catch (System.ArgumentOutOfRangeException e)
                                    {
                                        index3 = -1;
                                        Console.WriteLine("序号无效，请重新输入");
                                    }
                                    catch (System.FormatException e)
                                    {
                                        index3 = -1;
                                        Console.Write(e.Message);
                                        Console.WriteLine("请重新输入");
                                    }
                                }
                                Console.Write("请输入您要修改的产品名称");
                                changeOrderDetailOfOrder(result[index3], Console.ReadLine());
                                break;
                            case 4:
                                return;
                        }
                        break;
                    case 3:
                        return;
                }
            }
            else throw new NoSearchResult();

        }
        //添加新订单
        public void NewOrder()
        {
            
            Console.Write("输入客户名： ");
            String  customer = Console.ReadLine();
            Console.Write("输入订单号： ");
            String orderNum = Console.ReadLine();
            Order temp = new Order(orderNum,customer);
            int Type = 0;
            Console.Write("请输入订单中商品种类： ");
            while (Type == 0)
            {
                try
                {
                    Type = int.Parse(Console.ReadLine());
                    if (Type <= 0) throw new System.FormatException();
                }
                catch (System.FormatException e)
                {
                    Type = 0;
                    Console.Write(e.Message);
                    Console.WriteLine("请重新输入： ");
                }
            }

            for (int nType = 0; nType < Type; nType++)
            {

                
                Console.Write("请输入第" + (nType + 1) + "种商品名称： ");
                String newTypeOfProduct = Console.ReadLine();
                Console.Write("请输入商品数目： ");
                int newAmountOfProduct = -1;
                while (newAmountOfProduct == -1)
                {
                    try
                    {
                        newAmountOfProduct = int.Parse(Console.ReadLine());
                        if (newAmountOfProduct <= 0) throw new System.FormatException();
                    }
                    catch (System.FormatException e)
                    {
                        newAmountOfProduct = -1;
                        Console.Write(e.Message);
                        Console.WriteLine("请重新输入：");
                    }
                }
                Console.Write("请输入商品单价： ");
                double newPriceOfProduct = -1;
                while (newPriceOfProduct == -1)
                {
                    try
                    {
                        newPriceOfProduct = int.Parse(Console.ReadLine());
                        if (newPriceOfProduct <= 0) throw new System.FormatException();
                        
                    }
                    catch (System.FormatException e)
                    {
                        newAmountOfProduct = -1;
                        Console.Write(e.Message);
                        Console.WriteLine("请重新输入：");
                    }
                }
                OrderDetails detail = new OrderDetails(temp,newTypeOfProduct,newPriceOfProduct,newAmountOfProduct);
                temp.ListOfProduct.Add(detail);
                temp.Money = 0;
            }
            ListOfOrder.Add(temp);
        }
        //修改产品信息
        private void changeOrderDetailOfOrder(Order ele, String product)
        {
            bool ifproduct = false;
            foreach (OrderDetails pro in ele.ListOfProduct)
            {
                if (pro.TypeOfProduct == product)
                {
                    ifproduct = true;
                    Console.WriteLine("选择您要进行的服务: 1.修改产品名称； 2.修改产品数目；3.修改产品单价；4.退出；");
                    int whichFun = 0;
                    while (whichFun == 0)
                    {
                        try
                        {
                            whichFun = int.Parse(Console.ReadLine());
                            if (whichFun < 1 || whichFun > 3) throw new System.FormatException();
                        }
                        catch (System.FormatException e)
                        {
                            whichFun = 0;
                            Console.Write(e.Message);
                            Console.WriteLine("请重新输入");
                        }
                    }
                    switch (whichFun)
                    {
                        case 1:
                            pro.TypeOfProduct = Console.ReadLine();
                            break;
                        case 2:
                            pro.AmountOfProduct = -1;
                            while (pro.AmountOfProduct == -1)
                            {
                                try
                                {
                                    pro.AmountOfProduct = int.Parse(Console.ReadLine());
                                    if (pro.AmountOfProduct <= 0) throw new System.FormatException();
                                    pro.Money = 0;
                                    ele.Money = 0;
                                }
                                catch (System.FormatException e)
                                {
                                    pro.AmountOfProduct = -1;
                                    Console.Write(e.Message);
                                    Console.WriteLine("请重新输入：");
                                }
                            }
                            break;
                        case 3:
                            pro.PriceOfProduct = -1;
                            while (pro.PriceOfProduct == -1)
                            {
                                try
                                {
                                    pro.PriceOfProduct = double.Parse(Console.ReadLine());
                                    if (pro.PriceOfProduct <= 0) throw new System.FormatException();
                                    pro.Money = 0;
                                    ele.Money = 0;
                                }
                                catch (System.FormatException e)
                                {
                                    pro.PriceOfProduct = -1;
                                    Console.Write(e.Message);
                                    Console.WriteLine("请重新输入：");
                                }
                            }
                            break;
                    }
                }
            }
            if (ifproduct == false)
            {
                Console.WriteLine("未找到对应的产品");
            }
        }

      
    }
    public class NoSearchResult : ApplicationException
    {
        public String NoResult = "无符合条件的结果";
    }
    public class WrongData : ApplicationException
    {
        public override String ToString()
        {
            return "数据格式有误"; 
        }
        public override string Message => "Input WrongDate";
    }
    class Program
    {
        static void Main(string[] args)
        {
            OrderService myOrder = new OrderService();
            myOrder.init();
            mainService(myOrder);

        }
        //主操作函数
        static public void mainService(OrderService myOrder)
        {
            Console.WriteLine("选择您要进行的服务: 1.添加订单； 2.查询订单；" +
                "3.打印全部订单； 4.打印金额大于10000的订单； 5.输出xml； 6.退出");
            int whichFunction = 0;
            while (whichFunction == 0)
            {
                try
                {
                    whichFunction = int.Parse(Console.ReadLine());
                    if (whichFunction < 1 || whichFunction > 6) throw new System.FormatException();
                }
                catch (System.FormatException e)
                {
                    whichFunction = 0;
                    Console.Write(e.Message);
                    Console.WriteLine("请重新输入");
                }
            }
            switch (whichFunction)
            {
                case 1:
                    myOrder.NewOrder();
                    break;
                case 2:
                    SearchOrder(myOrder);
                    break;
                case 3:
                    try
                    {
                        myOrder.WriteResult(myOrder.ListOfOrder);
                    }
                    catch (NoSearchResult e)
                    {
                        Console.WriteLine(e.NoResult);
                    }
                    break;
                case 4:
                    List<Order> Morethanres = myOrder.SearchMoreThan(myOrder.ListOfOrder, 10000);
                    myOrder.WriteResult(Morethanres);
                    break;
                case 5:
                    myOrder.Export(myOrder.ListOfOrder, @"AllOrder.txt");
                    break;
                case 6:
                    return;
                default:
                    break;
            }
            mainService(myOrder);
        }
        //搜索操作
        static public void SearchOrder(OrderService myOrder)
        {
            List<Order> SearchResult = new List<Order>();
            Console.WriteLine
                ("选择您要进行的服务: 1.根据客户查找； 2.根据订单号查找；3.根据产品种类查找；4.返回主菜单");
            int whichFun = 0;
            while (whichFun == 0)
            {
                try
                {
                    whichFun = int.Parse(Console.ReadLine());
                    if (whichFun < 1 || whichFun > 4) throw new System.FormatException();
                }
                catch (System.FormatException e)
                {
                    whichFun = 0;
                    Console.Write(e.Message);
                    Console.WriteLine("请重新输入");
                }
            }
            switch (whichFun)
            {
                case 1:
                    Console.WriteLine("输入客户名: ");
                    String CustomerName = Console.ReadLine();
                    SearchResult = myOrder.SearchByCustomer(CustomerName);
                    break;
                case 2:
                    Console.WriteLine("输入订单号: ");
                    String OrderNum = Console.ReadLine();
                    SearchResult = myOrder.SearchByNum(OrderNum);
                    break;
                case 3:
                    Console.WriteLine("输入产品名: ");
                    String ProductName = Console.ReadLine();
                    SearchResult = myOrder.SearchByPro(ProductName);
                    break;
                case 4:
                    return;

            }
            try
            {
                myOrder.WriteResult(SearchResult);
            }
            catch (NoSearchResult e)
            {
                Console.WriteLine(e.NoResult);
            }

        }
    }
}
