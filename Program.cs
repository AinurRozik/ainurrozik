using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pemrograman_22._11._4757
{
    class program
    {
        static void Main(string[] args)
        {

            Console.Title = "Aplikasi calculator";

            Console.WriteLine("pilih menu calculator: ");
            Console.WriteLine("\n\n1. penambahan");
            Console.WriteLine("2. pengurangan");
            Console.WriteLine("3. perkalian");
            Console.WriteLine("4. pembagian");

            Console.Write("Input nomor menu[1..4] ");
            int nomor = int.Parse(Console.ReadLine());

            int a, b;
            //switch
            switch (nomor)
            {
                case 1:
                    Console.Write("\nInputkan nilai a= ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b= ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nHasil penambahan {0} + {1} = {2} ", a, b, penambahan(a, b));
                    break;

                case 2:
                    Console.Write("\nInputkan nilai a= ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b= ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nHasil penambahan {0} - {1} = {2} ", a, b, pengurangan(a, b));
                    break;

                case 3:
                    Console.Write("\nInputkan nilai a= ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b= ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nHasil penambahan {0} * {1} = {2} ", a, b, perkalian(a, b));
                    break;

                case 4:
                    Console.Write("\nInputkan nilai a= ");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Inputkan nilai b= ");
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.Write("\nHasil penambahan {0} / {1} = {2} ", a, b, pembagian(a, b));
                    break;

                default:
                     Console.Write("\nMaaf menu yang anda pilih tidak tersedia");
                    break;

            }


            Console.ReadKey();

        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }

        static int pengurangan(int a, int b)
        {
            return a - b;
        }

        static int perkalian(int a, int b)
        {
            return a * b;
        }

        static int pembagian(int a, int b)
        {
            return a / b;
        }
        }
        
}













           