using System;

namespace tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte un ángulo menor a 90");
            double a = double.Parse(Console.ReadLine());
            double b = a * (Math.PI / 180.0);

            Console.WriteLine("inserte hipotenusa");
            double t = double.Parse(Console.ReadLine());

            double c = (90 - b);
            Console.WriteLine("el ángulo c es igual a:" + c);
        
            double z = (t * Math.Sin c);
            Console.WriteLine("el lado z es igual a:" + z);
            double y = ( t * Math.Cos c);
            Console.WriteLine("el lado y es igual a:");



        }
    }
}
