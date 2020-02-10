using System;

namespace tarea_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ingresos de datos
            Console.WriteLine("Ingrese su salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tipo de contrato");
            string contrato = Console.ReadLine();
            double smlv = 877803;
            double cotizacion = salario * 0.40;
            if (cotizacion < smlv) cotizacion = salario;

            //switch
            switch (contrato)
            {
                case "independiente":
                    Console.WriteLine("Cuál es su nivel de riesgo");
                    double riesgo = double.Parse(Console.ReadLine());
                   double ipensión = cotizacion * 0.16;
                    double ieps = cotizacion * 0.125;
                    switch (riesgo)
                    {
                        case 1:
                            double arl = cotizacion * 0.00522;
                            break;
                        case 2:
                            double arl2 = cotizacion * 0.01044;
                            break;
                        case 3:
                            double arl3 = cotizacion * 0.02436;
                            break;

                        case 4:
                            double arl4 = cotizacion * 0.0435;
                            break;
                        case 5:
                            double arl5 = cotizacion * 0.0696;
                            break;

                    }
                    double salariomensuali = (salario - ipensión - ieps - riesgo);
                    double salarioanuali = salariomensuali * 12;
                    Console.WriteLine("su salario mensual es:" + salariomensuali+ "y su salario anual es:"+salarioanuali);
                    break;


                case "dependiente":
                            double pensión = cotizacion * 0.04;
                            double eps = cotizacion * 0.04;
                    double prima = salario;
                    double salariomensual = (salario - pensión - eps);
                    double salarioanual = (salariomensual * 12) + prima;
                    Console.WriteLine("su salario mensual es:" + salariomensual + "y su salario anual es:" + salarioanual);
                    break;

                   

                    









                    
            }
        }
    }
}
