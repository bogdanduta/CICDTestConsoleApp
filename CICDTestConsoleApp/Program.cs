using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CICDTestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {            
            var t = new Timer(state =>
                {
                    File.AppendAllText("log.txt", DateTime.Now.ToString());
                }, null,
                TimeSpan.FromSeconds(0),
                TimeSpan.FromSeconds(5));

            Thread.Sleep(60 * 60 * 1000);
        }
    }
}
