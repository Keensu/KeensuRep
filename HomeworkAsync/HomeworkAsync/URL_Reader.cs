using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeworkAsync
{
    class URL_Reader
    {
        public async Task<string[]> Download(List<string> n)
        {
            using (var client = new HttpClient())
            {
                var tasks = n.Select(url => client.GetStringAsync(url)).ToList();

                string[] downloaded = await Task.WhenAll(tasks);

                return downloaded;
            }
        }
    }
}
