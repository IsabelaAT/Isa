
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 12, 18, 12, 6, 9, 3, 6, 0, 6, 12, 18 };
            int[] B = { 6, 0, 12, 18, 4, 0, 18, 16, 6, 10, 14, 2, 12, 8, 2 };
            int temp = 0;

            List<int> union = new List<int>();//Lista union
            for (int i = 0; i < A.Length; i++)//se agregan datos de A
            {
                union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)//Se agregan datos de B
            {
                union.Add(B[i]);
            }

            //Se organizan los datos

            for (int j = 0; j <= union.Count - 2; j++)
            {
                for (int i = 0; i <= union.Count - 2; i++)
                {
                    if (union[i] > union[i + 1])
                    {
                        temp = union[i + 1];
                        union[i + 1] = union[i];
                        union[i] = temp;
                    }
                }


                    for (int i = 0; i < union.Count - 1; i++)
                    {
                        if (union[i] == union[i + 1])//eliminar los datos repetidos
                        {
                            union.RemoveAt(i);
                            i = 0;
                        }
                    }

                    for (int i = 0; i < union.Count; i++)//escribir la unión
                    {
                        Console.WriteLine("Unión: " + union[i]);
                    }


                    List<int> interseccion = new List<int>();//Lista intersección
                    for (int i = 0; i < A.Length; i++)//Datos de A
                    {
                        for (int j = 0; j < B.Length; j++)//Datos de B
                        {
                            if (A[i] == B[j])//ver datos repetidos
                            {
                                interseccion.Add(i);//agregar datos iguales
                            }
                        }
                    }
                    for (int i = 0; i < interseccion.Count; i++)//escribir la intersección
                    {
                        Console.WriteLine("Intersección: " + interseccion[i]);
                    }

                List<int> complemento = new List<int>();//Lista complemento
                for (int i = 0; i<A.Length;i++)//datos A
                {
                    for (int j= 0; j<B.Length; j++)//datos B
                    {
                        if (A[i] != B[j])
                        {
                            complemento.Add(i);//agregar datos diferentes
                        }
                    }
                }
                for (int i = 0; i < complemento.Count; i++)//escribir el complemento
                {
                    Console.WriteLine("Intersección: " + interseccion[i]);
                }



            }
        }
    }
}
