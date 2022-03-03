using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_3_Assigment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Jacksons super projects

            int age;
            string name;
            DateTime now = DateTime.Today;
            int year = Convert.ToInt32(now.ToString("yyyy"));


            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, how old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Okay {name}, the year is currently {year}, you are {age} years old, which leads me to believe that you were born in the year {year - age}");
            Console.WriteLine();



            int num1;
            int num2;
            int num3;

            Console.WriteLine("Give me a Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Good number, Now give me another number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Great number, now give me on last number");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"What a grand set of numbers, all of those number combined equals {num1 + num2 + num3}");
            Console.WriteLine("");


            double km1;
            double km2;
            double km3;

            Console.WriteLine("What do you think is the distance between your house and the school is in kilometers?");
            km1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Interesting, what is the farthest distance you have ever travelled in a car in kilomters?");
            km2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Exceptional, What is the distance between the school and the public library in kilometers");
            km3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The average distance between all of these distances is {Math.Round((km1 + km2 + km3) / 3, 2) }km");


            double length1;
            double length2;
            double hyp;

            Console.WriteLine("Give me the length of a leg of a right angeled triangle in centimeters");
            length1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Excellent, now give the other leg in centimeters");
            length2 = Convert.ToInt32(Console.ReadLine());
            hyp = ((length1 * length1) + (length2 * length2));
            Console.WriteLine($"The Hypontenuse of the triangle stated is {Math.Round((Math.Sqrt(hyp)), 2)}cm");













            Console.ReadLine();
        }
    }
}
