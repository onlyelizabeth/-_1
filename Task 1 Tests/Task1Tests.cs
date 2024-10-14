using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_1;
using System;

namespace Task_1_Tests
{
    [TestClass]
    public class Task1Tests
    {
        [TestMethod]
        public void Constructor_ShouldInitialize_WithValidNaturalNumber()
        {
            int number = 5;
            NaturalNumber naturalNumber = new NaturalNumber(number);

            Assert.AreEqual(5, naturalNumber.Number);
        }

        [TestMethod]
        public void Constructor_ShouldThrowException_WhenNumberIsNegative()
        {
            int nonNaturalNumber = -5;
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                NaturalNumber naturalNumber = new NaturalNumber(nonNaturalNumber);
            });

            Assert.AreEqual("It is not a natural number.", exception.Message);
        }

        [TestMethod]
        public void Constructor_ShouldThrowException_WhenNumberIsZero()
        {
            int nonNaturalNumber = 0;
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                NaturalNumber naturalNumber = new NaturalNumber(nonNaturalNumber);
            });

            Assert.AreEqual("It is not a natural number.", exception.Message);
        }

        [TestMethod]
        public void Mutator_ShouldInitialize_WithValidNaturalNumber()
        {
            NaturalNumber naturalNumber = new NaturalNumber(5);
            naturalNumber.Number = 7;

            Assert.AreEqual(7, naturalNumber.Number);
        }

        [TestMethod]
        public void Mutator_ShouldThrowException_WhenNumberIsNegative()
        {
            NaturalNumber naturalNumber = new NaturalNumber(5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                naturalNumber.Number = -7;
            });

            Assert.AreEqual("It is not a natural number.", exception.Message);
        }

        [TestMethod]
        public void Mutator_ShouldThrowException_WhenNumberIsZero()
        {
            NaturalNumber naturalNumber = new NaturalNumber(5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                naturalNumber.Number = 0;
            });

            Assert.AreEqual("It is not a natural number.", exception.Message);
        }

        [TestMethod]
        public void Indexator_ShouldWork_WithValidDigitNumber()
        {
            NaturalNumber naturalNumber = new NaturalNumber(56700890);

            Assert.AreEqual(8, naturalNumber[6]);
        }

        [TestMethod]
        public void Indexator_ShouldThrowException_WithInvalidDigitNumber()
        {
            NaturalNumber naturalNumber = new NaturalNumber(56700890);

            var exception1 = Assert.ThrowsException<ArgumentException>(() =>
            {
                var digit1 = naturalNumber[-1];
            });

            var exception2 = Assert.ThrowsException<ArgumentException>(() =>
            {
                var digit2 = naturalNumber[0];
            });

            var exception3 = Assert.ThrowsException<ArgumentException>(() =>
            {
                var digit3 = naturalNumber[9];
            });

            Assert.AreEqual("Index is out of bounds of the number.", exception1.Message);
            Assert.AreEqual("Index is out of bounds of the number.", exception2.Message);
            Assert.AreEqual("Index is out of bounds of the number.", exception3.Message);
        }

        [TestMethod]
        public void Method_ShouldReverseNumberCorrectly()
        {
            NaturalNumber naturalNumber = new NaturalNumber(56700890);
            Assert.AreEqual(9800765, naturalNumber.ReverseNumber());
        }

        [TestMethod]
        public void Method_ShouldCalculateZerosCorrectly()
        {
            NaturalNumber naturalNumber = new NaturalNumber(56700890);
            Assert.AreEqual(3, naturalNumber.CalculateZeros());
        }
    }
}
