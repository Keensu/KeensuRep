using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Summary : IOperation
    {
        public static double sum { get; private set; }
        public void DoOperation(double i, double j)
        {
            sum = i + j;
        }
    }
    public class Substraction : IOperation
    {
        public static double sub { get; private set; }
        public void DoOperation(double i, double j)
        {
            sub = i - j;
        }
    }
    public class Division : IOperation
    {
        public static double div { get; private set; }
        public void DoOperation(double i, double j)
        {
            if (j == 0)
            {
                Console.WriteLine("Ай-ай-ай, какой плохой мальчик, на ноль тут делить удумал...");
                return;
            }
            div = i / j;
        }
    }
    public class Multiplication : IOperation
    {
        public static double mul { get; private set; }
        public void DoOperation(double i, double j)
        {
            mul = i * j;
        }
    }
}
