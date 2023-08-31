using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCalculator
{
    internal class Calculator
    {
        public event EventHandler DivideByZero;

        public double Add(double a, double b) => a + b;

        public double Subtract(double a, double b) => a - b;
     

        public double Multiply(double a, double b) => a * b;
     

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                OnDivideByZero();
                return 0;
            }

            return a / b;
        }

        protected virtual void OnDivideByZero()
        {
            DivideByZero?.Invoke(this, EventArgs.Empty);
        }
    }
}
