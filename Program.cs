using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newtr
{
    internal class Program
    {//Trianglee
        static void Main(string[] args)
        {
            Console.WriteLine("hello, what is the height of the triangle ! ");
            var height = int.Parse(Console.ReadLine());
            var triangle1 = GetTriangle(height);
            Console.WriteLine(triangle1);
        }
        static string GetTriangle(int height)
        {
            var result = "";
            for (int i = 0; i < height; i++)
            {
                for (int d = height; d > i; d--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                    Console.Write("+");
                }
                //УРА
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("+");
                }
                for (int j = height; j > i; j--)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            return result;
        }
    }
}
