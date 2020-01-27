using System;

namespace tarea_2_clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ingreso de datos
            Console.WriteLine("ingrese d, b, y");
            double dgrados = double.Parse(Console.ReadLine());
            double bgrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            //consersión a radianes 
            double d = dgrados * (Math.PI / 180);
            double b = bgrados * (Math.PI / 180);

            //cálculo de los valores
            double e = Math.PI - d - b;
            double c = Math.PI - e;
            double a = Math.PI - (Math.PI / 2) - c;
            double z = Math.Tan(c) * a;

            //resultado
            Console.WriteLine("el valor de z es igual a:"+ z);



        }
    }
}
