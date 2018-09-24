using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHubHello
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            WaitConsole();
        }

        static void SayHello()
        {
            Console.WriteLine("Just wanted to say hello.");
        }

        static void WaitConsole()
        {
            Console.WriteLine("Press Enter...");
            Console.Read();
        }
    }
}
