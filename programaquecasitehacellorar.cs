using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5 {
    class Program {
        static void Main(string[] args) {
            double total = 0;
            Console.WriteLine("ingrese el número de datos");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string nombremaximo = "", nombreminimo = "";

            while (i < n) {
                Console.WriteLine("Ingrese su nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("ingrese su edad:");
                int edad = int.Parse(Console.ReadLine());
                if (edad > max) {
                    max = edad;
                    nombremaximo = nombre;
                }
                if (edad < min) {
                    min = edad;
                    nombreminimo = nombre;
                }
                

                total += edad;
                i++;
            }
            double promedio = total / n;
            Console.WriteLine("promedio:" + promedio);
            Console.WriteLine("mayor:" + max +  " " + nombremaximo);
            Console.WriteLine("menor:" + min +""+ nombreminimo);




        }
    }
}
