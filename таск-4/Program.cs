using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace таск_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func();
            Console.ReadKey();
       


        }
        static void Func()
        {
            Random rnd = new Random();
            for (int x = 1; x <= 10; x++)
            {
                int number = rnd.Next(-40,40);
                Console.WriteLine($"{x}-е число={number}");
            }
            }
    }
}
