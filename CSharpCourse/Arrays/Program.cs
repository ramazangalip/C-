using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Ramazan";
            students[1] = "Esma";
            students[2] = "Elisa";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[7, 3]
            {
                {"a","b" ,"c"},
                {"d","e","f" },
                {"g","ğ","h"},
                {"ı","i","j" },
                {"k","l","m" },
                {"n","o","ö" },
                {"p","r","s" },
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++) 
                { 
                    Console.WriteLine (regions[i,j]);
                }
                Console.WriteLine("---------------");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
