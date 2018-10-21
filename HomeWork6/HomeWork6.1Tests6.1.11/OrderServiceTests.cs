using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeWork6._1;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        OrderService newopt = new OrderService();

        [TestMethod()]
        public void SearchByCustomerTest1()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByCustomer("张三");
            Assert.IsTrue(temp.Count == 1);
        }
        [TestMethod()]
        public void SearchByCustomerTest2()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByCustomer("赵四");
            Assert.IsTrue(temp.Count == 1);
        }
        [TestMethod()]
        public void SearchByNumTest1()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByNum("001");
            Assert.IsTrue(temp.Count == 1);
        }
        [TestMethod()]
        public void SearchByNumTest2()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByNum("005");
            Assert.IsTrue(temp.Count == 1);
        }

        [TestMethod()]
        public void SearchByProTest1()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByPro("car");
            Assert.IsTrue(temp.Count != 0);
        }
        [TestMethod()]
        public void SearchByProTest2()
        {
            newopt.init();
            List<Order> temp = newopt.SearchByPro("vechel");
            Assert.IsTrue(temp.Count != 0);
        }

        [TestMethod()]
        public void SearchMoreThanTest1()
        {
            newopt.init();
            List<Order> temp = newopt.SearchMoreThan(newopt.ListOfOrder, 10000);
            Assert.IsTrue(temp.Count != 0);
        }
        [TestMethod()]
        public void SearchMoreThanTest2()
        {
            newopt.init();
            List<Order> temp = newopt.SearchMoreThan(newopt.ListOfOrder, 5000000);
            Assert.IsTrue(temp.Count != 0);
        }

        [TestMethod()]
        public void ExportTest1()
        {
            String path = @"Test1.txt";
            newopt.init();
            newopt.Export(newopt.ListOfOrder,path);
            FileStream mytype = new FileStream(
               path, FileMode.Open, FileAccess.Read);
            FileStream XmlPath = new FileStream(path, FileMode.Open, FileAccess.Read);
           
            Assert.IsTrue(XmlPath.Length!=0);
        }
        [TestMethod()]
        public void ExportTest2()
        {
            String path = @"Test1.txt";
            newopt.init();
            List<Order> temp = new List<Order>();
            newopt.Export(temp, path);
            FileStream mytype = new FileStream(
               path, FileMode.Open, FileAccess.Read);
            FileStream XmlPath = new FileStream(path, FileMode.Open, FileAccess.Read);

            Assert.IsTrue(XmlPath.Length != 0);
        }
    }
}