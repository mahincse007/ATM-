using System;

namespace Atm
{
    class Program
    {
        static void Main(string[] args)
        {
            Transaction obj = new Transaction();
            obj.Start();

            Console.ReadKey();
        }
    }
}