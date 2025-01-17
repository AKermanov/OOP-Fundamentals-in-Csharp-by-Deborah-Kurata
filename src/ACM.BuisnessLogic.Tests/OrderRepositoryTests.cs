﻿namespace ACM.BuisnessLogic.Tests
{
    using System;
    using NUnit.Framework;
    using ACM.BusinessLogic;
    using ACM.BusinessLogic.Repositories;
    public class OrderRepositoryTests
    {
        [Test]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                             new TimeSpan(7, 0, 0)),
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);
        }
    }
}
