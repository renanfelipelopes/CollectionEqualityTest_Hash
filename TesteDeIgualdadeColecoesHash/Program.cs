using System;
using System.Collections.Generic;
using TesteDeIgualdadeColecoesHash.Entities;

namespace TesteDeIgualdadeColecoesHash
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV", 3.000));
            a.Add(new Product("Notebook", 1.200));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1.200);
            Console.WriteLine(a.Contains(prod));

            Point point = new Point();
            Console.WriteLine(b.Contains(point));
        }
    }
}
