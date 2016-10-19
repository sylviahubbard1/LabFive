
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.WriteLine("Learn your Square and Cubes!");
                Console.Write("Enter an integer: ");
                int numRepeat = int.Parse(Console.ReadLine());
                CalculateSquareAndCube cal = new CalculateSquareAndCube();
                Console.WriteLine("Number\t\tSquared\t\tCubed");
                Console.WriteLine("======\t\t=====\t\t======");
                for (int i = 1; i <= numRepeat; i++)
                {
                    Console.WriteLine($"{i} \t\t {cal.SquareNumber(i)} \t\t{cal.CubeNumber(i)}");
                }
                Console.WriteLine("Continue?(y/n)");
                ans = Console.ReadLine();
            } while (ans == "y");


            //Console.WriteLine(cal.SquareNumber(numRepeat));   
        }
    }
}