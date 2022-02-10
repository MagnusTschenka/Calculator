Console.WriteLine("Hej");

namespace myCalc
{

    public class Calculator
    {
        public Calculator()
        {
            Clear();
        }

        public double Accumulator { get; private set; }
        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return a + b;
        }

        public double Add(double a)
        {
            Accumulator += a ;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return a - b;
        }
        
        public double Subtract(double a)
        {
            Accumulator -= a ;
            return Accumulator;
        }
        
        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return a * b;
        }
        
        public double Multiply(double a)
        {
            Accumulator *= a;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            if (x < 0 && (exp % 1 != 0))
            {
                throw new ArgumentException();
            }
            Accumulator = Math.Pow(x, exp);
            return Math.Pow(x, exp);
        }
        
        public double Power(double exp)
        {
            if ((exp % 1 != 0))
            {
                throw new ArgumentException();
            }
            Accumulator = Math.Pow(Accumulator, exp);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            Accumulator = a / b;
            return a/b;
        }
        
        public double Divide(double a)
        {
            if (a == 0)
            {
                throw new DivideByZeroException();
            }

            Accumulator =  Accumulator / a;
            return Accumulator;
        }
        
        public void Clear()
        {
            Accumulator = 0;
        }
    }
}