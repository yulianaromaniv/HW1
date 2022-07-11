using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int a;
            Console.WriteLine("Input value a:");
            str = Console.ReadLine();
            a = Convert.ToInt32(str);
            int area = a * a;
            int perimetr = 4 * a;
            Console.WriteLine("Perimetr= " + perimetr);
            Console.WriteLine("Area= " + area);
        }
    }
}
