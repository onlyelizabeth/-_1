using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;
using System;

namespace Task_2_Tests
{
    [TestClass]
    public class Task2Tests
    {
        // TCircle
        [TestMethod]
        public void Constructor_ShouldInitialize_WithoutParameters()
        {
            TCircle circle = new TCircle();

            Assert.AreEqual(1, circle.Radius);
        }

        [TestMethod]
        public void Constructor_ShouldInitialize_WithValidRadius()
        {
            TCircle circle = new TCircle(5);
            Assert.AreEqual(5, circle.Radius);
        }

        [TestMethod]
        public void Constructor_ShouldThrowException_WithInvalidRadius()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCircle circle = new TCircle(-5);
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Constructor_ShouldCopyCircleCorrectly()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(circle1);

            Assert.AreEqual(circle1.Radius, circle2.Radius);
        }

        [TestMethod]
        public void Mutator_ShouldInitialize_WithValidRadius()
        {
            TCircle circle = new TCircle(5);
            circle.Radius = 7;

            Assert.AreEqual(7, circle.Radius);
        }

        [TestMethod]
        public void Mutator_ShouldThrowException_WithInvalidRadius()
        {
            TCircle circle = new TCircle(5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                circle.Radius = -7;
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void ToString_ShouldWorkCorrectly()
        {
            TCircle circle = new TCircle(5);
            string result = circle.ToString();

            Assert.AreEqual("Circle with a radius 5.", result);
        }

        [TestMethod]
        public void CalculateArea_ShouldWorkCorrectly()
        {
            TCircle circle = new TCircle(5);

            double expectedArea = 78.5398163397448;
            double delta = 0.0000001;

            Assert.AreEqual(expectedArea, circle.CalculateArea(), delta);
        }

        [TestMethod]
        public void CalculateLength_ShouldWorkCorrectly()
        {
            TCircle circle = new TCircle(5);

            double expectedLength = 31.4159265358979;
            double delta = 0.0000001;

            Assert.AreEqual(expectedLength, circle.CalculateLength(), delta);
        }

        [TestMethod]
        public void Compare_ShouldWorkCorrectly()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(7);
            TCircle circle3 = new TCircle(5);

            TCircle circ = new TCircle();
            Assert.AreEqual(-1, circ.Compare(circle1, circle2));
            Assert.AreEqual(1, circ.Compare(circle2, circle1));
            Assert.AreEqual(0, circ.Compare(circle1, circle3));
        }

        [TestMethod]
        public void OperationAdding_ShouldWorkCorrectly()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(7);

            TCircle circle3 = circle1 + circle2;
            Assert.AreEqual(12, circle3.Radius);
        }

        [TestMethod]
        public void OperationSubstracting_ShouldWorkCorrectly()
        {
            TCircle circle1 = new TCircle(5);
            TCircle circle2 = new TCircle(7);

            TCircle circle3 = circle1 - circle2;
            Assert.AreEqual(2, circle3.Radius);
        }

        [TestMethod]
        public void OperationMultiplying_ShouldWorkCorrectly()
        {
            TCircle circle1 = new TCircle(5);
            double num = 3;
            TCircle circle2 = circle1 * num;
            TCircle circle3 = num * circle1;

            Assert.AreEqual(15, circle2.Radius);
            Assert.AreEqual(15, circle3.Radius);
        }

        // TCylinder
        [TestMethod]
        public void Constructor2_ShouldInitialize_WithoutParameters()
        {
            TCylinder cylinder = new TCylinder();

            Assert.AreEqual(1, cylinder.Radius);
            Assert.AreEqual(1, cylinder.Height);
        }

        [TestMethod]
        public void Constructor2_ShouldInitialize_WithValidRadiusAndHeight()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            Assert.AreEqual(5, cylinder.Radius);
            Assert.AreEqual(5, cylinder.Height);
        }

        [TestMethod]
        public void Constructor2_ShouldThrowException_WithInvalidRadius()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCylinder cylinder = new TCylinder(-5, 5);
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Constructor2_ShouldThrowException_WithInvalidHeight()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCylinder cylinder = new TCylinder(5, -5);
            });

            Assert.AreEqual("Height can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Constructor2_ShouldThrowException_WithInvalidRadiusAndHeight()
        {
            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCylinder cylinder = new TCylinder(-5, -5);
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Constructor_ShouldCopyCylinderCorrectly()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            TCylinder cylinder2 = new TCylinder(cylinder1);

            Assert.AreEqual(cylinder1.Radius, cylinder2.Radius);
            Assert.AreEqual(cylinder1.Height, cylinder2.Height);
        }

        [TestMethod]
        public void Mutator_ShouldInitialize_WithValidRadiusAndHeight()
        {
            TCylinder cylinder = new TCylinder(5, 5);
            cylinder.Radius = 7;
            cylinder.Height = 7;

            Assert.AreEqual(7, cylinder.Radius);
        }

        [TestMethod]
        public void Mutator2_ShouldThrowException_WithInvalidRadius()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                cylinder.Radius = -7;
                cylinder.Height = 7;
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Mutator_ShouldThrowException_WithInvalidHeight()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                cylinder.Radius = 7;
                cylinder.Height = -7;
            });

            Assert.AreEqual("Height can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void Mutator_ShouldThrowException_WithInvalidRadiusAndHeight()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
            {
                cylinder.Radius = -7;
                cylinder.Height = -7;
            });

            Assert.AreEqual("Radius can't be a negative number.", exception.Message);
        }

        [TestMethod]
        public void ToString2_ShouldWorkCorrectly()
        {
            TCylinder cylinder = new TCylinder(5, 5);
            string result = cylinder.ToString();

            Assert.AreEqual("Cylinder with a radius 5 and a height 5.", result);
        }

        [TestMethod]
        public void CalculateArea2_ShouldWorkCorrectly()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            double expectedArea = 314.159265358979;
            double delta = 0.0000001;

            Assert.AreEqual(expectedArea, cylinder.CalculateArea(), delta);
        }

        [TestMethod]
        public void CalculateVolume_ShouldWorkCorrectly()
        {
            TCylinder cylinder = new TCylinder(5, 5);

            double expectedVolume = 392.699081698724;
            double delta = 0.0000001;

            Assert.AreEqual(expectedVolume, cylinder.CalculateVolume(), delta);
        }

        [TestMethod]
        public void Compare2_ShouldWorkCorrectly()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            TCylinder cylinder2 = new TCylinder(7, 7);
            TCylinder cylinder3 = new TCylinder(5, 5);

            TCylinder cylin = new TCylinder();
            Assert.AreEqual(-1, cylin.Compare(cylinder1, cylinder2));
            Assert.AreEqual(1, cylin.Compare(cylinder2, cylinder1));
            Assert.AreEqual(0, cylin.Compare(cylinder1, cylinder3));
        }

        [TestMethod]
        public void OperationAdding2_ShouldWorkCorrectly()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            TCylinder cylinder2 = new TCylinder(7, 7);

            TCylinder cylinder3 = cylinder1 + cylinder2;
            Assert.AreEqual(12, cylinder3.Radius);
            Assert.AreEqual(12, cylinder3.Height);
        }

        [TestMethod]
        public void OperationSubstracting2_ShouldWorkCorrectly()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            TCylinder cylinder2 = new TCylinder(7, 7);

            TCylinder cylinder3 = cylinder1 - cylinder2;
            Assert.AreEqual(2, cylinder3.Radius);
            Assert.AreEqual(2, cylinder3.Height);
        }

        [TestMethod]
        public void OperationMultiplying2_ShouldWorkCorrectly()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            double num = 3;
            TCylinder cylinder2 = cylinder1 * num;
            TCylinder cylinder3 = num * cylinder1;

            Assert.AreEqual(15, cylinder3.Radius);
            Assert.AreEqual(15, cylinder3.Height);
        }

        [TestMethod]
        public void OperationMultiplying2_ShouldNotWorkWithNegativeNumber()
        {
            TCylinder cylinder1 = new TCylinder(5, 5);
            double num = -3;

            var exception1 = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCylinder cylinder2 = cylinder1 * num;
            });

            Assert.AreEqual("Radius can't be a negative number.", exception1.Message);

            var exception2 = Assert.ThrowsException<ArgumentException>(() =>
            {
                TCylinder cylinder3 = num * cylinder1;
            });

            Assert.AreEqual("Radius can't be a negative number.", exception2.Message);
        }
    }
}
