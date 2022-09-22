using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            monster monster1 = new monster();
            player player1 = new player();

            player1.Addat(10);

            player1.Fight(monster1.at);
            Console.WriteLine(monster1.at);
            Console.WriteLine(player1.at);
            Console.ReadLine();

         
        }
    }
}
