namespace CalculationLibrary.Tests
{
    public class CalculationsTests
    {

        private Calculations Calculator { get; set; }

        [SetUp]
        public void Setup()
        {
            //Arrange
            Calculator = new Calculations();
        }


        [Theory]
        [TestCase(4, 2, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, 0)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, 2468)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Subtract(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, -1522756)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Multiply(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, -1)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Divide(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
