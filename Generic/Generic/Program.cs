using Generic;
using System;
class Program
{
    private static void Main(string[] args)
    {
        //Test<int, string> tet1 = new Test<int, string>(5, "string");
        //tet1.print();
        int[] ints = { 15, 25, 48, 45, 147 };
        string[] strings = { "mnmnmer", "417", "wcrev" };
        Shop<int> sh1 = new Shop<int>(ints);
        sh1.PrintObject();
        Console.WriteLine("********************");
        Shop<string> sh2 = new Shop<string>(strings);
        sh2.PrintObject();
    }
}