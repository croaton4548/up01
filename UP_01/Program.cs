using System;

namespace UP_01
{
    class Program
    {
        static void Main(string[] args)
        {
            string q = Console.ReadLine();
            switch (q)
            {
                case "1":
                    Class1 M = new Class1();
                    M.SetInfo();
                    Console.WriteLine("");
                    M.GetInfo();

                    break;
            }
        }
    }
}
