using System;

namespace tarea_4_clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("ingrese w, x, d");
            double w = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double dgrados = double.Parse(Console.ReadLine());

            //conversión a radianes
            double d = dgrados * (Math.PI / 180.0);

            //cálculo de los valores
            double t = Math.Sqrt(w * w + x * x - (2 * w * x * Math.Cos(d)));
            double c = Math.Asin(w * Math.Sin(d) / t);
            double a = (Math.PI / 2) - c;
            double y = t * Math.Sin(a) / Math.Sin(Math.PI / 2);



        }
    }
}
