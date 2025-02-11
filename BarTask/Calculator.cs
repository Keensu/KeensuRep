using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BarTask.Friends;

namespace BarTask
{
    internal class Calculator
    {
        public string friendSpendStr {  get; set; }
        public static void Calculate()
        {
            List<decimal> howMuchSpend = new List<decimal>();

            for (int i = 0; i < nowFriends.Count; i++)
            {
                decimal friendSpend = 0;
                bool flag = true;
                Console.WriteLine($"Введите сколько потратил {nowFriends[i]}:");
                string friendSpendStr = Console.ReadLine();
                while (flag)
                {
                    try
                    {
                        while (friendSpendStr == "")
                        {
                            Console.WriteLine("Задано пустое значение, повторите попытку:");
                            friendSpendStr = Console.ReadLine();
                        }
                        friendSpend = Convert.ToDecimal(friendSpendStr);
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("Задано недопустимое значение, повторите попытку:");
                    }
                }
                howMuchSpend.Add(friendSpend);
            }
        }
    }
}

