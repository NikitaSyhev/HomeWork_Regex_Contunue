using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HomeWork_Regex_Contunue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1.1");
            {
                //Измените код таким образом, чтобы при вводе «Program.exe 123s dgfs  123 12» он нашёл 3 числа - 123 123 и 12.

                string input = "123s dgfs  123 12 ";
                for (int i = 0; i <= input.Length; i++)
                {
                    input = args[i];
                    Regex regex = new Regex(@"(\d+)");
                    MatchCollection matchFind = regex.Matches(input);
                    
                    foreach (var item in matchFind)
                    {
                        Console.WriteLine($"Совпадение  {item}");
                       
                    }
                }


                // Измените код таким образом, чтобы он корректно принимал отрицательные числа типа int.
                Console.WriteLine("Task 1.2");
                string input1 = "123s dgfs  123 12 ";
                for (int i = 0; i <= input1.Length; i++)
                {
                    input1 = args[i];
                    Regex regex = new Regex(@"((-)+\d+)");
                    MatchCollection matchFind = regex.Matches(input1);

                    foreach (var item in matchFind)
                    {
                        Console.WriteLine($"Совпадение  {item}");
                    }

                }

                Console.WriteLine("Task 2.0");






                Console.ReadLine();
            }
        }
    }
}
