using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] formula = new string[] { "Circulo", "Trapezio", "Losangulo" };

            for (int contador = 0; contador < 3; contador++)
            {
                Console.Write(contador + " - " + formula[contador] + " ");
            }
            Console.WriteLine();
            int calculo = Int32.Parse(Console.ReadLine());

            switch (calculo)
            {
                case 0:
                    Console.WriteLine("Raio");
                    double r = double.Parse(Console.ReadLine());
                    double pi = 3.14;

                    double area = pi * (r * r);

                    Console.WriteLine(area);
                    Console.WriteLine("Calculo Finalizado");


                    break;

                case 1:
                    Console.WriteLine("Base maior");
                    double B = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura");
                    double h = double.Parse(Console.ReadLine());

                    double area2 = (B * b) * h / 2;

                    Console.WriteLine(area2);
                    Console.WriteLine("Calculo Finalizado");
                    break;

                case 2:
                    Console.WriteLine("Diagonal Maior");
                    double D = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diagonal Menor");
                    double d = double.Parse(Console.ReadLine());

                    double area3 = (D * d) / 2;

                    Console.WriteLine(area3 + "Calculo Finalizado");
                    
                    Console.ReadKey();
                    break;
                   
            } Console.ReadKey();
        }
    }
}

