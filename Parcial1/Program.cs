using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{

    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular el impuesto a las actividades económicas");
            Console.WriteLine("2. Conversor de área");

            char opcion = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (opcion)
            {
                case '1':
                    CalcularImpuesto();
                    break;
                case '2':
                    ConversorDeArea();
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void CalcularImpuesto()
        {
            Console.Write("Ingrese el monto de la actividad económica: ");
            double monto = Convert.ToDouble(Console.ReadLine());
            double impuesto = CalcularImpuestoEconomico(monto);
            Console.WriteLine($"El impuesto a pagar es: ${impuesto:F2}");
            Console.ReadLine();
        }

        static double CalcularImpuestoEconomico(double monto)
        {
            if (monto >= 0.01 && monto <= 500)
            {
                return 1.5;
            }
            else if (monto >= 500.01 && monto <= 1000)
            {
                return 1.5 + ((monto - 500.01) / 1000) * 3;
            }
            else if (monto >= 1000.01 && monto <= 2000)
            {
                return 3 + ((monto - 1000.01) / 1000) * 3;
            }
            else if (monto >= 2000.01 && monto <= 3000)
            {
                return 6 + ((monto - 2000.01) / 1000) * 3;
            }
            else if (monto >= 3000.01 && monto <= 6000)
            {
                return 9 + ((monto - 3000.01) / 1000) * 2;
            }
            else if (monto >= 8000.01 && monto <= 18000)
            {
                return 15 + ((monto - 8000.01) / 1000) * 2;
            }
            else if (monto >= 18000.01 && monto <= 30000)
            {
                return 39 + ((monto - 18000.01) / 1000) * 2;
            }
            else if (monto >= 30000.01 && monto <= 60000)
            {
                return 63 + ((monto - 30000.01) / 1000) * 1;
            }
            else if (monto >= 60000.01 && monto <= 100000)
            {
                return 93 + ((monto - 60000.01) / 1000) * 0.8;
            }
            else if (monto >= 100000.01 && monto <= 200000)
            {
                return 125 + ((monto - 100000.01) / 1000) * 0.7;
            }
            else if (monto >= 200000.01 && monto <= 300000)
            {
                return 195 + ((monto - 200000.01) / 1000) * 0.6;
            }
            else if (monto >= 300000.01 && monto <= 400000)
            {
                return 255 + ((monto - 300000.01) / 1000) * 0.45;
            }
            else if (monto >= 400000.01 && monto <= 500000)
            {
                return 300 + ((monto - 400000.01) / 1000) * 0.4;
            }
            else if (monto >= 500000.01 && monto <= 1000000)
            {
                return 340 + ((monto - 500000.01) / 1000) * 0.3;
            }
            else if (monto >= 1000000.01)
            {
                return 490 + ((monto - 1000000.01) / 1000) * 0.18;
            }
            else
            {
                return 0;
            }
        }

        static void ConversorDeArea()
        {
            Console.WriteLine("Seleccione la unidad de origen:");
            Console.WriteLine("a. Pie Cuadrado");
            Console.WriteLine("b. Vara Cuadrada");
            Console.WriteLine("c. Yarda Cuadrada");
            Console.WriteLine("d. Metro Cuadrado");
            Console.WriteLine("e. Tareas");
            Console.WriteLine("f. Manzana");
            Console.WriteLine("g. Hectárea");

            char origen = Console.ReadKey().KeyChar;
            Console.WriteLine("\nIngrese el valor a convertir:");
            double valor = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Seleccione la unidad de destino:");
            Console.WriteLine("a. Pie Cuadrado");
            Console.WriteLine("b. Vara Cuadrada");
            Console.WriteLine("c. Yarda Cuadrada");
            Console.WriteLine("d. Metro Cuadrado");
            Console.WriteLine("e. Tareas");
            Console.WriteLine("f. Manzana");
            Console.WriteLine("g. Hectárea");

            char destino = Console.ReadKey().KeyChar;

            double resultado = ConvertirArea(origen, destino, valor);
            Console.WriteLine($"\n{valor} convertido a la unidad seleccionada es: {resultado:F2}");
            Console.ReadLine();

        }

        static double ConvertirArea(char origen, char destino, double valor)
        {
            double[] conversiones = { 10.7639, 1.43083, 1.19599, 1, 0.0016, 0.0002, 0.0001 };

            int indexOrigen = ObtenerIndice(origen);
            int indexDestino = ObtenerIndice(destino);

            // Convertimos el valor a metros cuadrados primero y luego a la unidad de destino
            double valorEnMetrosCuadrados = valor / conversiones[indexOrigen];
            return valorEnMetrosCuadrados * conversiones[indexDestino];
        }

        static int ObtenerIndice(char unidad)
        {
            switch (unidad)
            {
                case 'a':
                    return 0; // Pie Cuadrado
                case 'b':
                    return 1; // Vara Cuadrada
                case 'c':
                    return 2; // Yarda Cuadrada
                case 'd':
                    return 3; // Metro Cuadrado
                case 'e':
                    return 4; // Tareas
                case 'f':
                    return 5; // Manzana
                case 'g':
                    return 6; // Hectárea
                default:
                    return 3; // Por defecto, Metro Cuadrado
            }
        }
    }

}



