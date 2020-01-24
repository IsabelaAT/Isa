using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EejemploClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese x1: ");
            double x1 = double.Parse(Console.ReadLine());

            Console.Write("ingrese x2: ");
            double x2 = double.Parse(Console.ReadLine());

            Console.Write("ingrese y1: ");
            double y1 = double.Parse(Console.ReadLine());

            Console.Write("ingrese y2: ");
            double y2 = double.Parse(Console.ReadLine());

            double m = (y2 - y1) / (x2 - x1);
            double b = y1 - (m * x1);
            double d = Math.Sqrt((y2 - y1) * (y2 - y1) + (x2 - x1) * (x2 - x1));

            Console.WriteLine("su pendiente es: " + m + "el intercepto es: " + b + "la distancia es: " + d);

            
            
            
    

        }
    }
}
