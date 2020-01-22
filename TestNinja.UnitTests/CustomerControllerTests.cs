﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnsNotFound()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(0);
            
            //NotFound
            Assert.That(result, Is.TypeOf<NotFound>());
            
            //NotFound or one of its derivatives
           // Assert.That(result, Is.InstanceOf<NotFound>());
        }

        [Test]
        public void GetCustomer_IdIsNotZero_ReturnsOk()
        {
            var controller = new CustomerController();
            var result = controller.GetCustomer(3);
            
            //NotFound
            Assert.That(result, Is.TypeOf<Ok>());
            
            //NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<Ok>());
        }
    }
}