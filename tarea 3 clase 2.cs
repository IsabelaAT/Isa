
using System;

namespace tarea_3_clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("inserte w, t, c");
            double cgrados = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());

            //conversión a radianes
            double c = cgrados * (Math.PI / 180.0);

            //cálculo de los valores
            double e = Math.PI / c;
            double d = Math.Asin(t * Math.Sin(e) / w);
            double b = Math.PI - e - d;
            double x = t * Math.Sin(b) / Math.Sin(d)

                //resultado
            Console.WriteLine("el valor de x es igual a" + x);


        }
    }
}
