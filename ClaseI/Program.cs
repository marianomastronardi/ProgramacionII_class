using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseI
{
    class Program
    {
        static int miNumero;
        static double miDouble;
        static string miCadena;
        static bool miBooleano;

        static void Main(string[] args)
        {
            ShowMenu();
        }

        static void ShowMenu()
        {
            int resp = 0;
            int numero1 = 0; 
            int numero2 = 0;
            double ret = 0;

            Console.WriteLine("Ingrese 2 numeros: ");
            Console.Write("Numero 1: ");
            numero1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Numero 2: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            do
            {
                Console.WriteLine("Elija una opcion del Menu: ");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Multiplicar");
                Console.WriteLine("4. Dividir");
                resp = Convert.ToInt16(Console.ReadLine());
            }
            while (resp < 1 || resp > 4);

            switch (resp)
            {
                case 1:
                    ret = Sumar(numero1, numero2);
                    break;
                case 2:
                    ret = Restar(numero1, numero2);
                    break;
                case 3:
                    ret = Multiplicar(numero1, numero2);
                    break;
                case 4:
                    ret = Dividir(numero1, numero2);
                    break;
                default:
                    break;
            }

            Console.WriteLine("El resultado es " + ret.ToString());
            Console.ReadKey();
        }

        static int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        static int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        static double Dividir(int numero1, int numero2)
        {
            return Convert.ToDouble((double)numero1 / (double)numero2);
        }
    }
}
//Ctrl + K + D = identar el codigo