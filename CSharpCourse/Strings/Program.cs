using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string city = "Ankara";
            ////Console.WriteLine(city[0]);

            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //string city2 = " İstanbul";
            //string result = city +  city2;

            //Console.WriteLine(result);
            string sentence = "Benim adım ramazan";

            var result = sentence.Length;
            var result2 = sentence.Clone();
            bool result3 = sentence.EndsWith("n"); 
            var result4 = sentence.Insert(0,"Merhaba ");
            Console.WriteLine(result4);
            Console.WriteLine(result3);
            Console.WriteLine(result2);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
