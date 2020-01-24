using System;

namespace tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingrese un cateto");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro cateto");
            double b = double.Parse(Console.ReadLine());
            double c = Math.Sqrt((a * a + b * b));
            Console.WriteLine("hipotenusa=" + c);

            double d = Math.Asin(a / c);
            double e = d * (Math.PI / 180.0);
            Console.WriteLine("el ángulo e es igual a:" + e);

            double f = Math.Asin(b / c);
            double g = f * (Math.PI / 180.0);
            Console.WriteLine("el ángulo g es igual a:" + g); 
            





)
        }
    }
}
