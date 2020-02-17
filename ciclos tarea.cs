        using System;

namespace ciclos_tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int total = 0, dado1 = 0, dado2 = 0, vidas = 3, veces = 0;

            string continuar = "s";

            while (continuar == "s")
            {
                dado1 = aleatorio.Next(1, 7);
                 total += dado1;
                Console.WriteLine("dado 1:" + dado1+ " total: "+total );
                
                

                if ((veces==2))
                {
                    vidas -= 1;
                    Console.WriteLine("Perdiste una vida, vidas: " + vidas);

                }
                if (veces==3)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    total += dado1 + dado2;
                    Console.WriteLine("dado 1: " + dado1 + " dado2: " + dado2+ " total: "+total);
                    

                }
                if (dado1==dado2)
                {
                    vidas+=1;
                }
                if (total >= 100)
                {
                    Console.WriteLine("ganaste, tu puntaje fue:" + total);
                    Console.WriteLine("Gracias por participar");
                    continuar = "n";


                }
                
                 else if(vidas==0)
                {

                    continuar = "n";
                    Console.WriteLine("perdiste, tu puntaje fue:" + total);
                    Console.WriteLine("Gracias por participar");

                }
                else
                {
                    Console.WriteLine("desea continuar (s/n):");
                    continuar = Console.ReadLine();
                }
                veces++;
            }
            
        }
        }
}
