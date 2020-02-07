using System;

namespace tarea_bool
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingreso de datos

            Console.WriteLine("inserte números de votos del partido 1");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte números de votos del partido 2");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte números de votos en blanco");
            double blancos = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte números de votos nulos");
            double nulos = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte números de habitantes");
            double población = double.Parse(Console.ReadLine());
            Console.WriteLine("inserte el porcentaje de mayores de edad");
            double mayores = double.Parse(Console.ReadLine());

            //booles

            bool a = (A + B + blancos + nulos) > población;
            bool b = A - B < (A + B + blancos + nulos) * 0.10;
            bool c = (A + B + blancos + nulos) < población * 0.30;

            if ((a || b) && c) Console.WriteLine("las elecciones deben hacerse nuevamente");
            else
            {
                if (A > B) Console.WriteLine("el ganador es el partido 1");
                else Console.WriteLine("el ganador es el partido 2");
            }


        }
    }
}
