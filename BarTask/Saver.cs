using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTask
{
    internal class Saver
    {
        public static void Save()
        {
            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Information.txt";
            FileInfo fileinfo = new FileInfo(path);
        }
        public static void SaveFriend()
        {
            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Друзяшки.txt";
            FileInfo fileinfo = new FileInfo(path);
        }
    }
}
