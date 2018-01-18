using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2A_Part_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, t, sum = 0;
            double avg;
            Console.Write("How many test scores do you have? ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input your test scores: ");

            for (i=1; i<=t; i++)
            {
                Console.Write("Number - {0} : ", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / t;

            Console.Write("The sum of your {0} tests is: {1}\nThe Average is: {2}\n", t, sum, avg);

            if (avg >= 90)
            {
                Console.WriteLine("Your Grade is an A");
            }
            else if (avg >= 80)
            {
                Console.WriteLine("Your Grade is a B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Your Grade is a C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Your Grade is a D");
            }
            else if (avg < 60)
            {
                Console.WriteLine("Your Grade is a F");
            }
            

            i = 0;
            n = 0;
            t = 1;
            sum = 0;
            string decision;

            //Console.Write("How many test scores do you have? ");
            //t = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Input your test scores: ");
            
            for (i=1; i<=t; i++)
            {
                Console.Write("Number - {0} : ", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
                Console.Write("Do you have more?  Enter Y to continue:  ");
                decision = Console.ReadLine();
                //???SYNTAX??? ARGH!
            }
            avg = sum / t;

            Console.Write("The sum of your {0} tests is: {1}\nThe Average is: {2}\n", t, sum, avg);

            if (avg >= 90)
            {
                Console.WriteLine("Your Grade is an A");
            }
            else if (avg >= 80)
            {
                Console.WriteLine("Your Grade is a B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Your Grade is a C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Your Grade is a D");
            }
            else if (avg< 60)
            {
                Console.WriteLine("Your Grade is a F");
            }

        }

    }
}
