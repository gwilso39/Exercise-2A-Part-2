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
            int i = 0;
            int n = 0;
            int t = 0;
            int sum = 0;
            double avg;

            Console.Write("How many test scores do you have? ");
            t = int.Parse(Console.ReadLine());
            if (t > 0)
            {
                Console.Write("Input your test scores: ");
            }
            else
            {
                Console.WriteLine("Come on, Really?  You don't at least have one score?");
                t=1;
            }


            for (i = 1; i <= t;)
            {
                Console.Write("Number - {0} : ", i);
                n = int.Parse(Console.ReadLine());

                if ((n >= 0) && (n <= 100))
                {
                    sum += n;
                    i++;
                }
                else
                {
                    Console.WriteLine("Your input is invalid. Try again");
                }
            }
            avg = sum / t;

            Console.Write("The sum of your {0} tests is: {1}\nThe Average is: {2}\n", t, sum, avg);

            if (avg >= 90)
            {
                Console.WriteLine("Your Grade is an A\n");
            }
            else if (avg >= 80)
            {
                Console.WriteLine("Your Grade is a B\n");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Your Grade is a C\n");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Your Grade is a D\n");
            }
            else if (avg < 60)
            {
                Console.WriteLine("Your Grade is a F\n");
            }
            

            i = 1;
            sum = 0;

            Console.WriteLine("For this next one, I don't know how many test scores you have to enter\n");
            Console.Write("Input your test scores (Input -1 when done): ");

            var val = 0;
            while (val != -1)
            {
                Console.Write("Test number - {0}: ", i);
                val = int.Parse(Console.ReadLine());

                if ((val >= 0) && (val <= 100))
                {
                    sum += val;
                    i++;
                }
                else if (val == -1)
                {
                    ;
                }
                else
                {
                    Console.WriteLine("Your input is invalid. Try again");
                }
            }
            if (i > 1)
            {
                avg = sum / (i - 1);

                Console.Write("The sum of your {0} tests is: {1}\nThe Average is: {2}\n", (i - 1), sum, avg);

                if (avg >= 90)
                {
                    Console.WriteLine("Your Grade is an A\n");
                }
                else if (avg >= 80)
                {
                    Console.WriteLine("Your Grade is a B\n");
                }
                else if (avg >= 70)
                {
                    Console.WriteLine("Your Grade is a C\n");
                }
                else if (avg >= 60)
                {
                    Console.WriteLine("Your Grade is a D\n");
                }
                else if (avg < 60)
                {
                    Console.WriteLine("Your Grade is a F\n");
                }
            }
            else
            {
                Console.WriteLine("You need at least 1 test score for this to work correctly");
            }

            Console.WriteLine("Thank you for playing, have a nice day... :)");
        }
    }
}
