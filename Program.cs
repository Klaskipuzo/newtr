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
            var triangle1 = GetTriangle(height, true);
            var triangle2 = GetTriangle(height, false);

            Console.WriteLine(triangle1);
            Console.WriteLine(triangle2);
        }

        static string GetTriangle(int height, bool isHalf)
        {
            var result = "";
            for (int i = 0; i < height; i++)
            {
                

                if (isHalf)
                {
                    

                    for (int j = 0; j <= i; j++)
                    {
                        result += "*";
                    }
                }

                Console.SetCursorPosition(height - i, i + 1);
                for (int j = 0; j <= i * 2; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();


                result += "\n";
            }

            return result;
        }
    }
}
