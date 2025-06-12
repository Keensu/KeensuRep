using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Program
    {
        public static double result { get; set; }
        static void Main(string[] args)
        {
            result = 0;
            CalculatorMaster master = new CalculatorMaster();
            Console.WriteLine("Введите уравнение, каждый символ через пробел:");
            string equation = Console.ReadLine();
            List<string> splitted = new List<string>(equation.Split(' '));

            for (int m = 1; m < splitted.Count - 1;)
            {
                string o = splitted[m];
                if (o == "*" || o == "/")
                {
                    if (o == "*")
                    {
                        master.SetWork(new Multiplication()); master.DoOper(Convert.ToInt32(splitted[m - 1]), Convert.ToInt32(splitted[m + 1]));
                        result = Multiplication.mul;
                    }
                    else if (o == "/")
                    {
                        master.SetWork(new Division()); master.DoOper(Convert.ToInt32(splitted[m - 1]), Convert.ToInt32(splitted[m + 1]));
                        result = Division.div;
                    }

                    splitted.RemoveRange(m - 1, 3);
                    splitted.Insert(m - 1, Convert.ToString(result));
                }
                else { m += 2; }
            }

            for (int n = 1; n < splitted.Count - 1;)
            {
                string o = splitted[n];
                if (o == "+" || o == "-")
                {
                    if (o == "+")
                    {
                        master.SetWork(new Summary()); master.DoOper(Convert.ToInt32(splitted[n - 1]), Convert.ToInt32(splitted[n + 1]));
                        result = Summary.sum;
                    }
                    else if (o == "-")
                    {
                        master.SetWork(new Substraction()); master.DoOper(Convert.ToInt32(splitted[n - 1]), Convert.ToInt32(splitted[n + 1]));
                        result = Substraction.sub;
                    }

                    splitted.RemoveRange(n - 1, 3);
                    splitted.Insert(n - 1, Convert.ToString(result));
                }
            }
            Console.WriteLine(result);
        }
    }
}
