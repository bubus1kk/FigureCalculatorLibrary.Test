using FigureCalculatorLibrary;

namespace FigureCalculatorLibraryTest
{
    [TestClass]
    public class FigureCalculatorTests
    {
        private FigureCalculator _calculator = null!;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new FigureCalculator();
        }

        [TestMethod]
        public void CalculateCircleArea_WithValidRadius_ReturnsCorrectValue()
        {
            double result = FigureCalculator.CalculateCircleArea(2);
            Assert.AreEqual(Math.PI * 4, result);
        }

        [TestMethod]
        public void CalculateCircleArea_WithZeroRadius_ThrowsArgumentException()
        {
            try
            {
                FigureCalculator.CalculateCircleArea(0);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateCircleArea_WithNegativeRadius_ThrowsArgumentException()
        {
            try
            {
                FigureCalculator.CalculateCircleArea(-5);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateCircleCircumference_WithValidRadius_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateCircleСircumference(3);
            Assert.AreEqual(2 * Math.PI * 3, result);
        }

        [TestMethod]
        public void CalculateCircleCircumference_WithZeroRadius_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateCircleСircumference(0);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateCircleDiameter_WithValidRadius_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateCircleDiameter(4);
            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void CalculateCircleDiameter_WithNegativeRadius_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateCircleDiameter(-1);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateRectangleArea_WithValidSides_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateRectangleArea(6, 3);
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void CalculateRectangleArea_WithZeroLength_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateRectangleArea(0, 3);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateRectangleArea_WithNegativeWidth_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateRectangleArea(6, -1);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateRectanglePerimeter_WithValidSides_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateRectanglePerimeter(6, 3);
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void CalculateRectanglePerimeter_WithZeroWidth_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateRectanglePerimeter(6, 0);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateSquareArea_WithValidSide_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateSquareArea(5);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void CalculateSquareArea_WithZeroSide_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateSquareArea(0);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateSquarePerimeter_WithValidSide_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateSquarePerimeter(4);
            Assert.AreEqual(16, result);
        }

        [TestMethod]
        public void CalculateSquarePerimeter_WithNegativeSide_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateSquarePerimeter(-2);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void ValidateTriangle_WithValidSides_DoesNotThrowException()
        {
            _calculator.ValidateTriangle(3, 4, 5);
        }

        [TestMethod]
        public void ValidateTriangle_WithInvalidTriangle_ThrowsArgumentException()
        {
            try
            {
                _calculator.ValidateTriangle(1, 2, 10);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void ValidateTriangle_WithNegativeSide_ThrowsArgumentException()
        {
            try
            {
                _calculator.ValidateTriangle(-3, 4, 5);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateTriangleArea_WithValidSides_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateTriangleArea(3, 4, 5);
            Assert.AreEqual(6, result, 0.00001);
        }

        [TestMethod]
        public void CalculateTriangleArea_WithInvalidTriangle_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateTriangleArea(1, 2, 10);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }

        [TestMethod]
        public void CalculateTrianglePerimeter_WithValidSides_ReturnsCorrectValue()
        {
            double result = _calculator.CalculateTrianglePerimeter(3, 4, 5);
            Assert.AreEqual(12, result, 0.00001);
        }

        [TestMethod]
        public void CalculateTrianglePerimeter_WithNegativeSide_ThrowsArgumentException()
        {
            try
            {
                _calculator.CalculateTrianglePerimeter(-3, 4, 5);
                Assert.Fail("Ожидалось исключение ArgumentException, но оно не было выброшено.");
            }
            catch (ArgumentException)
            {
            }
        }
    }
}