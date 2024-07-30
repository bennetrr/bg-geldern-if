using System;

namespace EuklidischerAlgorithmus
{
    class Program
    {
        private static int EuklidischerAlgorithmus(int x, int y)
        {
            if (x <= 0 || y <= 0) throw new ArgumentException("x and y have to be greater than 0");
            if (x < y) (x, y) = (y, x);
            x -= y;
            return x == y ? x : EuklidischerAlgorithmus(x, y);
        }

        private static void Main(string[] args)
        {
            var x = int.Parse(args[0]);
            var y = int.Parse(args[1]);
            Console.WriteLine(EuklidischerAlgorithmus(x, y));
        }
    }
}
