using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите ребра а,б,с:\n");
            Paralelepiped paraleli = new Paralelepiped(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Площадь поверхности - " + paraleli.Squere);
            Console.WriteLine("Диагональ паралелепипеда = {0:F}", paraleli.Diagonal());
            Console.WriteLine("Площадь круга = {0:F}", paraleli.Kryg(4, 4));
            Console.ReadLine();

        }
    }

    class Paralelepiped
    {
        double a;
        double b;
        double c;

        public Paralelepiped(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Squere
        {
            get { return 2 * (a * b + b * c + a * c); }
        }

        public double V
        {
            get { return a * b * c; }
        }

        public double Diagonal()
        {
            return Math.Sqrt(a * a + b * b + c * c);
        }

        public double Kryg(int a, int b)
        {
            return Math.PI * Math.Pow(a / 2, 2);
        }
    }
}
