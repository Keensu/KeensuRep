using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTask
{
    internal class Bar
    {
        public string barName { get; set; }
        public static void AddBar()
        {
            Bar nameOfBar = new Bar();
            nameOfBar.barName = Console.ReadLine();
            while (nameOfBar.barName == "")
            {
                Console.WriteLine("Задано пустое значение, повторите попытку:");
                nameOfBar.barName = Console.ReadLine();
            }
            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Inf\\Information.txt";
            FileInfo fileInfo = new FileInfo(path);
            File.AppendAllText(path, $"\nБар: {nameOfBar.barName}");
        }
    }

}
