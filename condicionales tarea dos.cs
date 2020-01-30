using System;

namespace condicionales_tarea_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.WriteLine("Ingrese su salario");
            double salario = double.Parse(Console.ReadLine());

           // Cálculo de la tarifa
            if (salario < 1755606)
            {
                Console.WriteLine("su tarifa es A y debe pagar 3.400 pesos");
            }
            else if (1755606 <= salario && salario <= 4389015)
            {
                Console.WriteLine("su tarifa es B y debe pagar 13.500 pesos");
            }
            else { Console.WriteLine("su tarifa es C y debe pagar 33.600 pesos"); }

        }
    }
}
