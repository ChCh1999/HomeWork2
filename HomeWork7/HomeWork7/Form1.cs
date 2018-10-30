using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork6;
namespace HomeWork7
{
    public partial class Form1 : Form
    {
        OrderService myService = new OrderService();
        Edit edit1 = new Edit();
        Edit edit2 = new Edit();
        AddPro addpro = new AddPro();
        AddOrder addorder = new AddOrder();
        //初始化
        public void init()
        {
            //初始化订单数据
            myService.init();
            //初始化数据提交按钮功能
            edit1.button1.Click += new System.EventHandler(update1);
            edit2.button1.Click += new System.EventHandler(update2);
            addpro.button1.Click += new System.EventHandler(updatePro);
            addorder.button1.Click += new System.EventHandler(updateOrder);
            //绑定订单数据
            dataGridView1.DataSource = new BindingList<Order>(myService.ListOfOrder);
            //初始化表格权限
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.ReadOnly = true;
            dataGridView2.AllowUserToAddRows = false;
        }
        public Form1()
        {
            InitializeComponent();
            init();
        }
        //刷新
        public void refreshData()
        {
            myService.update();
            dataGridView1.DataSource = new BindingList<Order>(myService.ListOfOrder);
            dataGridView2.DataSource = null;
        }
        //导入
        private void button1_Click(object sender, EventArgs e)
        {

            String FileSource = textBox1.Text;
            try
            {
                myService.Import(FileSource);
                dataGridView1.DataSource = new BindingList<Order>(myService.ListOfOrder);
                ImportError.Text = "导入成功";
            }
            catch(Exception e1)
            {
                ImportError.Text = "文件路径错误";
            }
            
        }
        //导出
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                myService.Export(myService.ListOfOrder, textBox2.Text);
                ExportInfo.Text = "输出成功";
            }
            catch ( Exception ee)
            {
                ExportInfo.Text = "输出失败";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //刷新
        private void FlushTable_Click(object sender, EventArgs e)
        {
            myService.update();
            dataGridView1.DataSource = new BindingList<Order>(myService.ListOfOrder);

        }
        //搜索
        private void button3_Click(object sender, EventArgs e)
        {
            String SearchData = textBox3.Text;
            List<Order> result = new List<Order>();
            switch (SearchType.SelectedIndex)
            {
                case 0:
                    result = myService.SearchMoreThan(myService.ListOfOrder, double.Parse(SearchData));
                    break;
                case 1:
                    result = myService.SearchByNum(SearchData);
                    break;
                case 2:
                    result = myService.SearchByCustomer(SearchData);
                    break;
                case 3:
                    result = myService.SearchByPro(SearchData);
                    break;
            }
            dataGridView1.DataSource = new BindingList<Order>(result);
            dataGridView2.DataSource = null;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            //行号
            int nRow = dataGridView1.CurrentRow.Index;
            dataGridView2.DataSource = new BindingList<OrderDetails>
                (myService.ListOfOrder[nRow].ListOfProduct);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nRow = e.RowIndex;
            try
            {
                dataGridView2.DataSource = new
                   BindingList<OrderDetails>(myService.ListOfOrder[nRow].ListOfProduct);
            }
            catch(System.ArgumentOutOfRangeException aooe)
            {

            }
        }

        //双击呼出编辑窗口
        private void dataGridView1_CellMouseDoubleClick(object sender, 
            DataGridViewCellMouseEventArgs e)
        {
            
            if (e.ColumnIndex != 2)
            {
                edit1.init(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
                , e.RowIndex, e.ColumnIndex);
                edit1.ShowDialog();
            }
            
            
        }
        private void dataGridView2_CellMouseDoubleClick(object sender, 
            DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex != 3)
            {
                edit2.init(dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()
                , e.RowIndex, e.ColumnIndex);
                edit2.ShowDialog();
            }
        }
        
        //删除当前行订单
        private void button4_Click(object sender, EventArgs e)
        {
            int cRow = dataGridView1.CurrentRow.Index;
            myService.ListOfOrder.Remove(myService.ListOfOrder[cRow]);
            refreshData();
        }
        //添加产品
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index >= 0)
            {
                addpro.init();
                addpro.ShowDialog();
            }
                
        }
        //添加订单
        private void button6_Click(object sender, EventArgs e)
        {
            addorder.init();
            addorder.ShowDialog();
        }
        //提交函数
        public void update1(object sender, EventArgs e)
        {
            try
            {
                switch (edit1.column)
                {
                    case 0:
                        myService.ListOfOrder[edit1.row].OrderNum = edit1.Target;
                        edit1.Visible = false;
                        break;
                    case 1:
                        myService.ListOfOrder[edit1.row].Customer = edit1.Target;
                        edit1.Visible = false;
                        break;

                }
            }
            catch (Exception eIn1)
            {
                edit1.label1.Text = "数据错误";
            }
        }
        public void update2(object sender, EventArgs e)
        {
            try
            {
                switch (edit2.column)
                {
                    case 0:
                        dataGridView2.Rows[edit2.row].Cells[edit2.column].Value = edit2.Target;
                        edit2.Visible = false;
                        break;
                    case 1:
                        dataGridView2.Rows[edit2.row].Cells[edit2.column].Value =
                            double.Parse(edit2.Target);
                        myService.update();
                        edit2.Visible = false;
                        break;
                    case 2:
                        dataGridView2.Rows[edit2.row].Cells[edit2.column].Value =
                            int.Parse(edit2.Target);
                        myService.update();
                        edit2.Visible = false;
                        break;

                }
                dataGridView1.DataSource = new BindingList<Order>(myService.ListOfOrder);
                dataGridView2.DataSource = new BindingList<OrderDetails>
                    (myService.ListOfOrder[dataGridView1.CurrentRow.Index].ListOfProduct);
            }
            catch (Exception eIn2)
            {
                edit2.label1.Text = "数据错误";
            }
        }
        public void updatePro(object sender, EventArgs e)
        {
            if (addpro.success)
            {
                myService.ListOfOrder[dataGridView1.CurrentRow.Index].ListOfProduct.Add
                (addpro.newOrderDetail);
                refreshData();
                addpro.Visible = false;
            }


        }
        public void updateOrder(object sender, EventArgs e)
        {
            if (addorder.success)
            {
                myService.ListOfOrder.Add(addorder.newOrder);
                refreshData();
                addorder.Visible = false;
            }
        }


    }
}

