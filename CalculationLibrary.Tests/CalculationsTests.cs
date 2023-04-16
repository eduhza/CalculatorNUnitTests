namespace CalculationLibrary.Tests
{
    public class CalculationsTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Theory]
        [TestCase(4, 2, 6)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, 0)]
        public void AddShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations calculator = new Calculations();

            //Act
            double actual = calculator.Add(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, 2468)]
        public void SubtractShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations calculator = new Calculations();

            //Act
            double actual = calculator.Subtract(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 8)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, -1522756)]
        public void MultiplyShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations calculator = new Calculations();

            //Act
            double actual = calculator.Multiply(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Theory]
        [TestCase(4, 2, 2)]
        [TestCase(0, 0, 0)]
        [TestCase(1234, -1234, -1)]
        public void DivideShouldReturnExpectedValue(double x, double y, double expected)
        {
            //Arrange
            Calculations calculator = new Calculations();

            //Act
            double actual = calculator.Divide(x, y);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
