// See https://aka.ms/new-console-template for more information
using System;

namespace FirstMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1- Geriye deger dondurmeyen bir void metodu.
            void Lyrics()
            {
                Console.WriteLine("Papi, papi, papi chulo\r\nPapi, papi, papi, ven a mí (Ven a mí)\r\nPapi, papi, papi chulo\r\nPapi, papi, papi, ven a mí (Ven a mí)\r\nPapi, papi, papi chulo\r\nPapi, papi, papi, ven a mí (Ven a mí)\r\nPapi, papi, papi, chulo");
            }

            Lyrics();

            ////2-Geriye tam sayi donduren bir metot
            int GenerateNumber()
            {
                Random rnd = new Random();
                int n = rnd.Next();
                return n % 2;
            }


            Console.WriteLine(GenerateNumber());

            ////3.Parametre alan ve geriye deger donduren bir metot

            int Multiply(int a, int b)
            {
                return a * b;
            }

            Console.WriteLine("Lutfen carpmak istediginiz 2 sayıyı giriniz:");

            Console.Write("Birinci sayıyı girin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci sayıyı girin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Carpım sonucu " + Multiply(a, b));

            ////4.Parametre alan ve deger dondurmeyen metot
            void Greeting(string name, string surname)
            {
                Console.WriteLine($"Hoş geldiniz {name} {surname}");
            }

            Console.Write("Lütfen adınızı giriniz: ");
            string name = Console.ReadLine();

            Console.Write("Lütfen soyadınızı giriniz: ");
            string surname = Console.ReadLine();

            Greeting(name, surname);
        }
    }
}
