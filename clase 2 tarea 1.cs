using System;

namespace tarea_1_clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("ingrese b, z, y");
            double bgrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //conversión a radianes
            double b = bgrados * (Math.PI / 180.0);

            //cálculo de los valores
            double t = Math.Sqrt(z * z + y * y);
            double a = Math.Atan(y / z);
            double w = (z / Math.Cos(a + b));
            double x = Math.Sqrt(w * w + t * t - 2 * w * t * Math.Cos(b));

            //resultado
            Console.WriteLine("x es igual a:" + x);


        }
    }
}
