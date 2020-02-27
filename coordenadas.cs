using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//coordenadas de los puntos
            Console.WriteLine("los puntos son: 0,0 , 2,1 , 3,5 , 7, 6");
            double[] coordenadasx = {0,2,3,7};
            double[] coordenadasy = { 0, 1, 5, 6 };

            //comprobar si son de la misma linea por la pendiente

            double pendiente1 = (coordenadasy[0] - coordenadasy[1]) / (coordenadasx[0] - coordenadasx[1]);
            double pendiente2 = (coordenadasy[0] - coordenadasy[2]) / (coordenadasx[0] - coordenadasx[2]);
            double pendiente3 = (coordenadasy[0] - coordenadasy[3]) / (coordenadasx[0] - coordenadasx[3]);
            
            if (pendiente1==pendiente2 && pendiente2 == pendiente3)
            {
                Console.WriteLine("Los puntos son colineales");
            }
            else
            {
                Console.WriteLine("Los puntos no son colineales");
            }

            //distancia mayor
            double max = 0;
            double distancia1 = Math.Sqrt(((coordenadasy[0] - coordenadasy[1]) * (coordenadasy[0] - coordenadasy[1])) + ((coordenadasx[0] - coordenadasx[1]) * coordenadasx[0] - coordenadasx[1]));
            if (max < distancia1) max = distancia1;
            double distancia2 = Math.Sqrt(((coordenadasy[0] - coordenadasy[2]) * (coordenadasy[0] - coordenadasy[2])) + ((coordenadasx[0] - coordenadasx[2]) * coordenadasx[0] - coordenadasx[2]));
            if (max < distancia2) max = distancia2;
            double distancia3 = Math.Sqrt(((coordenadasy[0] - coordenadasy[3]) * (coordenadasy[0] - coordenadasy[3])) + ((coordenadasx[0] - coordenadasx[3]) * coordenadasx[0] - coordenadasx[3]));
            if (max < distancia3) max = distancia3;
            double distancia4 = Math.Sqrt(((coordenadasy[1] - coordenadasy[2]) * (coordenadasy[1] - coordenadasy[2])) + ((coordenadasx[1] - coordenadasx[2]) * coordenadasx[1] - coordenadasx[2]));
            if (max < distancia4) max = distancia4;
            double distancia5 = Math.Sqrt(((coordenadasy[1] - coordenadasy[3]) * (coordenadasy[1] - coordenadasy[3])) + ((coordenadasx[1] - coordenadasx[3]) * coordenadasx[1] - coordenadasx[3]));
            if (max < distancia5) max = distancia5;
            double distancia6 = Math.Sqrt(((coordenadasy[2] - coordenadasy[3]) * (coordenadasy[2] - coordenadasy[3])) + ((coordenadasx[2] - coordenadasx[3]) * coordenadasx[2] - coordenadasx[3]));
            if (max < distancia6) max = distancia6;
            Console.WriteLine("La distancia mayor es de: " + max);









        }
    }
}
