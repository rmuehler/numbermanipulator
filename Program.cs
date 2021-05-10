using System;

namespace numbermanipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = Int32.Parse(Console.ReadLine());
            x *= x;
            x += 14;
            x -= 3;
            Console.WriteLine(x);
        }
    }
}
