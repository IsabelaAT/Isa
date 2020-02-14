using System;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //entradas
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, cartanueva = 0, total=0;
            string continuar = "s";

            //ciclos
            while (continuar == "s" && total <= 21)
            {

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine("Carta 1:" + carta1 + "" + "Carta 2:" + carta2);
                Console.WriteLine("¿desea añadir otra carta?, presione 1 para si o 2 para no");
                int respuesta = int.Parse(Console.ReadLine());

                if (respuesta == 1)
                {
                    cartanueva = aleatorio.Next(1, 11);
                    Console.WriteLine("Su nueva carta es:" + cartanueva);
                    total += carta1 + carta2 + cartanueva;
                    Console.WriteLine("Total:" + total);
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    continuar = Console.ReadLine();
                }
                else
                {
                    total = carta1 + carta1;
                    Console.WriteLine("Total:" + total);
                }



                        

            }
            if(21<=total)
            Console.WriteLine("Superaste 21 puntos, ¿no sabes jugar?");
            else
            {
                Console.WriteLine("gracias por participar");

            }




        }
    }
}
