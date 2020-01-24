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
        }
    }
}
