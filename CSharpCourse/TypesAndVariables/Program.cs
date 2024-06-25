using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            
            double number5 = 10.4;
            decimal number6 = 10.4M;
            char character = 'A';
            bool condition1 = true;
            bool condition2 = false;
            byte number4 = 255;
            short number3 = 10000;
            int number1 = 1000000000;
            long number2 = 1000000000000000000;
            var number7 = 10;
          
            Console.WriteLine("1.sayi " + number1);
            Console.WriteLine("2.sayi " + number2);
            Console.WriteLine("3.sayi " + number3);
            Console.WriteLine("4.sayi " + number4);
            Console.WriteLine("5.sayi " + number5);
            Console.WriteLine("Character is {0}",(int)character);
            Console.WriteLine((int)Days.Cuma);
            Console.ReadLine();
        }
    }
    enum Days
    {
        Pazartesi,Salı,Çarşamba,Perşembe, Cuma,Cumartesi,Pazar
    }
}
