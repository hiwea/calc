using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeProjectFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter U Age ");
            String Age = Console.ReadLine();
            int a = int.Parse(Age);

            Console.WriteLine("..............H.I.W.A....A.Z.I.Z...................................");



            int month = a * 12;
            Console.WriteLine("u are " + month + "  Month old  ");

            Console.WriteLine("...........................................................");
            int days = a * 365;
            Console.WriteLine("u are " + days + " Days old  ");

            Console.WriteLine("...........................................................");
            int hours = a * 365 * 24;
            Console.WriteLine("u are " + hours + " hours old  ");

            Console.WriteLine("...........................................................");
            int minute = a * 365 * 24 * 60;
            Console.WriteLine("u are " + minute + " minutes old  ");

            Console.WriteLine("...........................................................");
            int second = a * 365 * 24 * 60 * 60;
            Console.WriteLine("u are " + second + " Seconds old  ");

            Console.ReadKey();
        }
    }
}
