  using System;

namespace condicionales_tarea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ingreso de datos
            Console.WriteLine("ingrese su salario mensual");
            double salario = double.Parse(Console.ReadLine());

            // Cálculo de la tarifa
            if (salario < 1755.803) { Console.WriteLine("usted es tarifa A"); }

            else if (1755.803 <= salario && salario <= 3511.212)
            {
                Console.WriteLine("usted es tarifa B");
            }
            else (salario > 1755.803){ 
                     
                Console.WriteLine("usted es tarifa C");
            }
        }

    } }
