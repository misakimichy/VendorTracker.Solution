using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OrderTracker.Models;

namespace OrderTracker.Tests
{
    [TestClass]
    public class OrderTest : IDisposable
    {
        public void Dispose()
        {
            Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreateInstancesOfOrder_Order()
        {
            Order newOrder = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }

        [TestMethod]
        public void GetTitle_ReturnOrderTitle_String()
        {
            string title = "Baguette";
            Order newOrder = new Order(title, "This is test.", 5.5, new DateTime(2020, 01, 01));
            string result = newOrder.Title;

            Assert.AreEqual(title, result);
        }

        [TestMethod]
        public void SetTitle_SetTitle_String()
        {
            Order newOrder = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            string updatedTitle = "Croissant";
            newOrder.Title = updatedTitle;
            string result = newOrder.Title;

            Assert.AreEqual(updatedTitle, result);
        }

        [TestMethod]
        public void GetDescription_ReturnOrderDescription_String()
        {
            string description = "This is test.";
            Order newOrder = new Order("Baguette", description, 5.5, new DateTime(2020, 01, 01));
            string result = newOrder.Description;

            Assert.AreEqual(description, result);
        }

        [TestMethod]
        public void SetDescription_SetDescription_String()
        {
            Order newOrder = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            string updatedDescription = "This is test2!";
            newOrder.Description = updatedDescription;
            string result = newOrder.Description;

            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetPrice_ReturnOrderPrice_Double()
        {
            double price = 5.5;
            Order newOrder = new Order("Baguette", "This is test.", price, new DateTime(2020, 01, 01));
            double result = newOrder.Price;

            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void SetPrice_SetPrice_Double()
        {
            Order newOrder = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            double updatedPrice = 10.5;
            newOrder.Price = updatedPrice;
            double result = newOrder.Price;

            Assert.AreEqual(updatedPrice, result);
        }

        [TestMethod]
        public void GetDate_ReturnOrderDate_DateTime()
        {
            DateTime date = new DateTime(2020, 01, 01);
            Order newOrder = new Order("Baguette", "This is test.", 5.5, date);
            DateTime result = newOrder.Date;

            Assert.AreEqual(date, result);
        }

        [TestMethod]
        public void SetDate_SetDate_DateTime()
        {
            Order newOrder = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            DateTime updatedDate = new DateTime(2020, 01, 20);
            newOrder.Date = updatedDate;
            DateTime result = newOrder.Date;

            Assert.AreEqual(updatedDate, result);
        }

        [TestMethod]
        public void GetAll_ReturnsOrder_OrderList()
        {
            Order newOrder1 = new Order("Baguette", "This is test.", 5.5, new DateTime(2020, 01, 01));
            Order newOrder2 = new Order("Croissant", "This is test2!", 10.5, new DateTime(2020, 01, 20));
            List<Order> newList = new List<Order> {newOrder1, newOrder2};
            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }
    }
}