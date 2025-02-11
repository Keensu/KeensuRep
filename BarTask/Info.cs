using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTask
{
    internal class Info
    {
        public string calcName { get; set; }
        public string date { get; set; }
        public static void AddCalculation()
        {
            Info calc = new Info();
            calc.calcName = Console.ReadLine();
            while (calc.calcName == "")
            {
                Console.WriteLine("Задано пустое значение, повторите попытку:");
                calc.calcName = Console.ReadLine();
            }
            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Inf\\Information.txt";
            FileInfo fileInfo = new FileInfo(path);
            File.AppendAllText(path, $"\nРасчёт: {calc.calcName}");
        }
        public static void AddDate()
        {
            DateTime result;
            bool flag = true;
            Info currentDate = new Info();
            currentDate.date = Console.ReadLine();
            while(flag)
            {
                if (DateTime.TryParseExact(currentDate.date, "dd.MM.yyyy", null, DateTimeStyles.None, out result))
                {
                    flag = false;
                    Console.WriteLine($"Введена дата: {result.ToShortDateString()}");
                    
                }
                else
                {
                    Console.WriteLine("Задано недопустимое значение, повторите попытку:");
                    currentDate.date = Console.ReadLine();
                }
            }
            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Inf\\Information.txt";
            FileInfo fileInfo = new FileInfo(path);
            File.AppendAllText(fileInfo.FullName, $"\nДата: {currentDate.date} ");
        }
    }
}

