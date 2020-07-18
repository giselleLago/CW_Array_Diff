using System;

namespace CW_Array_Diff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.ArrayDiff(new int[] { 1, 2 , 3 }, new int[] { 1 }));
            Console.ReadKey();
        }
    }
}
