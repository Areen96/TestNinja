﻿using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }
        
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Add(1, 2);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnsTheFirstArgument()
        {
            var result = _math.Max(2, 1);
            Assert.That(result,Is.EqualTo(2));
        }
        
        [Test]
        public void Max_SecondArgumentIsGreater_ReturnsTheSecondArgument()
        {
            var result = _math.Max(1, 2);
            Assert.That(result,Is.EqualTo(2));
        } 
        
        [Test]
        public void Max_ArgumentsAreEqual_ReturnsTheSameArgument()
        {
            var result = _math.Max(2, 2);
            Assert.That(result,Is.EqualTo(2));
        }
    }
}