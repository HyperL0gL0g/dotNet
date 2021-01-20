using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_10_q2
{
    class ArthematicOperation
    {
        public double result;
        public double Add(double num1, double num2)
        {
            result = num1 + num2;
            return result;
        }

        public double Sub(double num1, double num2)
        {
            result = num1 - num2;
            return result;
        }

        public double Mul(double num1, double num2)
        {
            result = num1 * num2;
            return result;
        }

        public double Div(double num1, double num2)
        {
            result = num1 / num2;
            return result;
        }

        public double Max(double num1, double num2)
        {
            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }
    }
}
