using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise3Application
{
    public class Program
    {
        public static void Main()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var query = numbers.Select(num => num).Transform(num => num + 1);
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }
    }

    public delegate int MyFunction(int num);

    public static class MyClass
    {
        public static IEnumerable<int> Transform(this IEnumerable<int> data, MyFunction func)
        {
            foreach (var num in data)
            {
                yield return func(num);
            }
        }
    }
}

