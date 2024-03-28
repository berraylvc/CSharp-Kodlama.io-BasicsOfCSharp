using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new String[3];
            //students[0] = "Berra";
            //students[1] = "Ali";
            //students[2] = "Ayşe";

            string[] students = { "Berra", "Ali", "Ahmet" };

            //array sınırlarına dikkat etmek gerek

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //MULTİDİMENSİONAL ARRAYS
            string[,] regions0 = new string[7, 3]; //7 bölge var her birine 3 şşehhir tanımlamak istiyorum demek
            //7 satır 3 kolon
            regions0[0, 0] = "İstanbul";

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Balıkesir" },
                { "Ankara","Konya","Kırıkkale"},
                { "Antalya","Adana","Mersin"},
                { "Rize","Trabzon","Samsun"},
                { "İzmir","Muğla","Manisa"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)   //"<=" olduğuna dikkat!!!
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("******");
            }

            Console.ReadLine();

        }
    }
}
