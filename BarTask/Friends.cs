using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarTask
{
    internal class Friends
    {
        public string friendName { get; set; }
        public static List<string> nowFriends = new List<string>();
        public static void AddFriend()
        {

            string path = "C:\\Users\\yar10\\OneDrive\\Рабочий стол\\Inf\\Друзяшки.txt";
            Friends friend = new Friends();
            friend.friendName = Console.ReadLine();
            while (friend.friendName == "")
            {
                Console.WriteLine("Задано пустое значение, повторите попытку:");
                friend.friendName = Console.ReadLine();
            }

            nowFriends.Add(friend.friendName);
            FileInfo fileinfo = new FileInfo(path);
            File.AppendAllText(path,$"\n{friend.friendName}");
        }
    }
}
