using System;


namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double doubleVar = 32.29;

            float floatVar = 59.92f;

            string stringVar = "Привет, мир";

            char charVar = 'X';

            Console.WriteLine(doubleVar);
            Console.WriteLine(floatVar);
            Console.WriteLine(charVar);

            string name = "Холмамат";

            int age = 41;

            Console.WriteLine("Меня зовут {0}, мне {1} лет.", name, age);

        }
    }
}
