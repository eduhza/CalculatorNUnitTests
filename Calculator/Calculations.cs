
namespace CalculationLibrary {
    public class Calculations {

        public double Add(double x, double y)
        {
            //throw new NotImplementedException("Please create a test first.");
            return x + y;
        }
        public double Subtract(double x, double y)
        {
            //throw new NotImplementedException("Please create a test first.");
            return x - y;

        }
        public double Multiply(double x, double y)
        {
            //throw new NotImplementedException("Please create a test first.");
            return x * y;

        }
        public double Divide(double x, double y)
        {
            //throw new NotImplementedException("Please create a test first.");
            //return x / y;

            // Refactor
            if(y != 0)
            {
                return x / y;
            }

            return 0;

        }
    }
}
