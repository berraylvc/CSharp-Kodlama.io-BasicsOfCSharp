using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();


            //do-whihle döngüsünün farkı önce çalışıp sonra şarta bakar, yani şart sağlanmasa bile 1 kere çalışmış olacak

            //DoWhileLoop();

            //ForeachLoop();

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i == 0 )
                {
                    result = false;
                    i = number;  //performans açısından asal olmadığını bir kere bulduğunda devam etmemesi için "break" ifadesi gibi kullandık

                }
            }
            return result;
        }
        private static void ForeachLoop()
        {
            string[] students = { "Berra", "Ali", "Ahmet" };
            foreach (var student in students)
            {
                //foreach döngüsü içerisinde döndüğünüz elemanları değiştiremiyorsunuz
                //student="Engin" denilemez
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;

            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;

            while (number >= 0)
            {
                Console.WriteLine(number); //sayı 0'dan büyük olduğu sürece sonsuza kadar çalışır.
                number--; //sonsuza kadar çalışmaması için
            }
            Console.WriteLine("Current number is {0}", number); //(-1)
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++) //( "i+=2" yazmak ile "i=i+2" yazmak aynı şey)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished");

            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}