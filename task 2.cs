using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string str;
            int age;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("How old are you" + name + "?");
            str = Console.ReadLine();
            age = Convert.ToInt32(str);
            Console.WriteLine("My name is " + name + ".My age is " + age);
        }
    }
}
