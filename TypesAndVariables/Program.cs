using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");
            
            double number5 = 10.4; //virgülden sonra 15/16 tane değer tutabiliyor
            decimal number6 = 10.5m; //virgülden sonra 28/29 tane değer tutabiliyor    sondaki m harfi küçük veya büyük olabillir
            char character = 'A'; // string type bir char array'dir ! char için tek tırnak
            bool condition = false;
            byte number4 = 255;
            short number3 = -4567;
            int number1 = 234567896;
            long number2 = 34567890346789678;
            var number7 = 10; //var tipinde ne atanırsa karşısına onu alır değer tipi olarak YANİ,
            number7 = 'A'; //dersek A harfini int gördüğü için 65 yazacaktır A yerine 
            //number7 = "A"; denemez string olduğu için hata verir

            Console.WriteLine("Number1 is {0}", number1);
            //süslü parantez içini string ifade olarak yazdırmıyor, virgülden sonraki ifadelerden index seçiyor ve onu yazdırıyoruz
            Console.WriteLine("Number2 is {0}", number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number7 is {0}", number7);
            Console.WriteLine("Character is {0}", character);
            Console.WriteLine("Character is {0}", (int)character);
            //klavyerdeki her değerin sayısal bir karşılığı vardır 
            Console.WriteLine(Days.Friday);
            Console.WriteLine((int)Days.Friday);
            //enum sabitlerinin değeri (bu değer değiştirilebilir default index yerine)

            Console.ReadLine();
        }
    }
    enum Days
    {
        Monday=10, Tuesday, Wednesday, Friday, Sunday
    }
}

