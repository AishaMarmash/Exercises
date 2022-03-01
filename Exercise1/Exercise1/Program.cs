using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercise1Application
{
    public class Program
    {
        public static void Main()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var squares = new int[] { 1, 20, 9, 16, 25 };
            bool b = TestForSquares(numbers, squares);
            Console.WriteLine(b);
        }

        public static bool TestForSquares(IEnumerable<int> numbers, IEnumerable<int> squares)
        {
            if (numbers.Count() != squares.Count())
            {
                return false;
            }
            else
            {
                var query = from num in numbers
                            from sq in squares
                            where num * num == sq
                            select num;
                if (query.SequenceEqual(numbers))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

