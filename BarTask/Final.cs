using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BarTask
{
    internal class Final
    {
        public static void Solve()
        {
            bool flag = true;
            Console.WriteLine("Здравствуйте, введите название расчёта:");
            Info.AddCalculation();
            Console.WriteLine("Введите дату посещения в формате 11.11.1111 :");
            Info.AddDate();
            Console.WriteLine("Введите название заведения:");
            Bar.AddBar();
            Console.WriteLine("Введите имя посетителя:");
            Friends.AddFriend();
            while (flag)
            {
                Console.WriteLine("Желаете добавить ещё посетителей? (Да/Нет)");
                string moreClients = Console.ReadLine();
                while (moreClients == "")
                {
                    Console.WriteLine("Задано пустое значение, повторите попытку:");
                    moreClients = Console.ReadLine();
                }
                while (moreClients != "Да" && moreClients != "Нет")
                {
                    Console.WriteLine("Задано недопустимое значение, повторите попытку:");
                    moreClients = Console.ReadLine();
                }
                if (moreClients == "Да")
                {
                    Console.WriteLine("Введите имя посетителя:");
                    Friends.AddFriend();
                }
                if (moreClients == "Нет")
                {
                    flag = false;
                    Console.WriteLine("Перехожу к финансовым операциям...");
                }
            }
            Calculator.Calculate();

        }
    }
}
