using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //number 1
            //Random rand = new Random();
            //int a, b, c;

            //a = rand.Next(15);
            //b = rand.Next(15);
            //c = rand.Next(15);


            //Console.Write(a);
            //Console.Write(" ");
            //Console.Write(b);
            //Console.Write(" ");
            //Console.Write(c);

            //Console.ReadKey();
            //number2
            //Console.WriteLine(5);
            //Console.WriteLine(10);
            //Console.WriteLine(21);
            //Console.ReadKey();
            //number3
            //double distance = 3.15;
            // distance = Convert.ToInt32;
            //number4and5
            //int day = 234;
            //int  week= day / 7;
            //Console.WriteLine(week);
            //int number = 23;
            //int unit = number % 10;
            //int  decade = number /10;
            //var sum = unit + decade;
            //var composition = unit * decade;


            //Console.WriteLine(decade);
            //Console.WriteLine(unit);
            //Console.WriteLine(sum);
            //Console.WriteLine(composition);
            //number6
            //bool A = true;
            //bool B = false;
            //bool C = false;

            //bool result1 = A || B;
            //bool result2 = A && B;
            //bool result3 = B || C;

            //Console.WriteLine("A || B = " + result1);
            //Console.WriteLine("A && B = " + result2);
            //Console.WriteLine("B || C = " + result3);

            //Console.ReadLine();
            //7

            //int side = 2;
            //int radius = 3;

            //double CircleSquare = 3.14 * Math.Pow(radius, 2);
            //double Square = Math.Pow(side, 2);

            //Console.WriteLine(CircleSquare);
            //Console.WriteLine(Square);

            //if (CircleSquare < Square)
            //{
            //    Console.WriteLine("Площодь квадрата больше площади круга");
            //}
            //else Console.WriteLine("Площодь круга больше площади квадрата");

            //Console.ReadKey();

            //number8

            double volume1, mass1, volume2, mass2;

            Console.WriteLine("У какого материала бoльшая плотность?\n");

            Console.WriteLine("Материал 1");
            Console.Write("Объем: ");
            volume1 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass1 = Double.Parse(Console.ReadLine());

            double density1 = Density(mass1, volume1);
            Console.WriteLine("Плотность: " + density1);

            Console.WriteLine("\nМатериал 2");
            Console.Write("Объем: ");
            volume2 = Double.Parse(Console.ReadLine());
            Console.Write("Масса: ");
            mass2 = Double.Parse(Console.ReadLine());

            double density2 = Density(mass2, volume2);
            Console.WriteLine("Плотность: " + density2);

            string answer = density1 > density2 ? "первого" : "второго";
            Console.WriteLine("\nНаибольшая плотность у {0} материала", answer);

            Console.ReadLine();
        }

        private static double Density(double mass1, double volume1)
        {
            throw new NotImplementedException();
        }
    }
}
