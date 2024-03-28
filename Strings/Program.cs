using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Ratatoille";
            var result = sentence.Length;
            var result2 = sentence.Clone();  //ilgili string değerin bir referansını daha oluşturmaya yarar
            Console.WriteLine(result2);
            sentence = "My name is Aang"; //sentence değişti ama result2 değişmediği için üstteki Console bşr önceki cümleyi yazar

            bool result3 = sentence.EndsWith("e"); //sonucun bool şeklinde döndürüldüğüne dikkat
            bool result4 = sentence.StartsWith("My");
            var result5 = sentence.IndexOf("name"); //bulamadığında -1 döndürür
            var result6 = sentence.IndexOf(" "); //ilk bulduğunda çalışmayı bırakacak ve baştan başlıyor
            var result7 = sentence.LastIndexOf(" "); //aramaya sondan başlar ama index numaralandırması değişmez karıştırma
            var result8 = sentence.Insert(0, "Hello, "); //bir ifadeye başka bir metni eklemek için kullanılır
            var result9 = sentence.Substring(3); //metni parçalamak için kullanılır
            var result10 = sentence.ToLower(); //hepsini küçük karakterlere çevirir
            var result11 = sentence.ToUpper(); //hepsini büyük karakterlere çevrir
            var result12 = sentence.Replace(" ","-"); //bir metin içerisinde belli karakterleri değiştirmek için kullanılır
            var result13 = sentence.Remove(3,4); //metinde belirli bir indexten sonrasını atmak için kullanılır



            Console.WriteLine(result13);


            Console.ReadLine();

        }

        private static void Intro()
        {
            string city = "Ankara";
            string city2 = "İstanbul";

            string result = city + city2;

            Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(result);
            Console.WriteLine(String.Format("{0} {1}", city, city2));
            //3. bir değişken atamamıza gerek kalmadığı için bunu kullanmak daha iyi
        }
    }
}
