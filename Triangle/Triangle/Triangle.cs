using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Triangle
{
    class Triangle
    {
        protected int a;
        protected int b;
        protected int c;

        public Triangle ()
        {
            Random rand = new Random();
            while (a + b <= c || a + c <= b || b + c <= a)
            {
                a = rand.Next(1, 15);
                b = rand.Next(1, 15);
                c = rand.Next(1, 15);
            }
        }

        public int SideA
        {
            get
            {
                return a;
            }
            set
            {
                if(value + b <= c || value + c <= b || value >= b + c)
                {
                    Console.WriteLine("Не iснує");
                }
                else
                {
                    Console.WriteLine("Iснує");
                    a = value;
                }
            }
        }

        public int SideB
        {
            get
            {
                return b;
            }
            set
            {
                if (value + a <= c || value + c <= a || value >= a + c)
                {
                    Console.WriteLine("Не iснує");
                }
                else
                {
                    Console.WriteLine("Iснує");
                    b = value;
                }
            }
        }

        public int SideC
        {
            get
            {
                return c;
            }
            set
            {
                if (value + b <= a || value + a <= b || value >= b + a)
                {
                    Console.WriteLine("Не iснує");
                }
                else
                {
                    Console.WriteLine("Iснує");
                    c = value;
                }
            }
        }
        static int Perimeter(int a, int b, int c)
        {
                return a + b + c;

        }

        static double Square(int a, int b , int c)
        {
                double halfPer = ((double)a + (double)b + (double)c) / 2.0;
                Console.WriteLine(halfPer);
                return Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
        }

        public static void Output(int a, int b, int c)
        {
            Console.WriteLine("A = {0} cm   B = {1} cm   C= {2} cm", a, b, c);
            Console.WriteLine(" Perimetr: {0}", Perimeter(a, b, c));
            Console.WriteLine("Square: {0}", Square(a, b, c));
            Console.WriteLine();
        }
    }
}
