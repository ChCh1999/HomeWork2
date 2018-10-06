using System.Collections.Generic;
using System;
namespace HomeWork4._2
{
    public class Order
    {
        List<OrderDetails> ListOfProduct = new List<OrderDetails>();
        public String OrderNum { set; get; }
        public String Customer { set; get; }
    }
    public class OrderDetails
    {
        public String TypeOfProduct { set; get; }
        public int AmountOfProduct { set; get; }
    }
    public class OrderService
    {
        List <Order> ListOfOrder = new List <Order>();
        public void NewOrder()
        {
            Order temp = new Order();
            Console.Write("输入客户名： ");
            temp.Customer = Console.ReadLine();
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
