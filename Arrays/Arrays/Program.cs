using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //Console.WriteLine(numbers[0]);
            //numbers[0] = 10;
            //numbers[3] = -5;
            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[3]);
            //Console.WriteLine("*************************");
            //for (int i = 0; i < numbers.Length; i++) { 
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine("---------------------------");
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------------------");
            //string[] strings = new string[] { "Test", "String", "ABC"};
            //foreach (string s in strings) { 
            //    Console.WriteLine(s);
            //}
            //Console.WriteLine("---------------------------");
            //int[][] numbers2 = new int[3][];
            //numbers2[0] = new int[] { 5, 7, 3 };
            //numbers2[1] = new int[] { 4, 8 };
            //numbers2[2] = new int[] { -5, 10 };
            //Console.WriteLine(numbers2[1][0]);
            //Console.WriteLine("---------------------------");
            //foreach (int[] i in numbers2) {
            //    foreach (int j in i)
            //    {
            //        Console.Write($"{j}");
            //        if (j != i[i.Length - 1]) Console.Write(",\t");
            //        else Console.WriteLine(";");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("---------------------------");
            //int[] array = new int[10];
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++) { 
            //    array[i] = rand.Next(1, 10);
            //}
            //int max = array[0];
            //foreach (int i in array)
            //{
            //    if (i > max)
            //        max = i;
            //     Console.WriteLine(i);
            //}
            //Console.WriteLine("---------------------------");
            //Console.WriteLine($"Max value: { max}");
            float[] a = new float[5];
            Random ran = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = (float)ran.Next(1, 15);
                Console.WriteLine(a[i]);    
            }
            Console.WriteLine("---------------------------");
            float sum = 0;
            int ll = 0;
            while (ll < a.Length) { 
                sum += a[ll];
                ll++;
            }
            float p = 1;
            Console.WriteLine(sum);
            Console.WriteLine("---------------------------");
            for (int i = 0; i < a.Length; ++i) { 
                p *= a[i];
            }
            Console.WriteLine(p);
        }
    }
}
