using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add2(2, 4);
            //burada sadece bir hesap yaptık ver sonuç döndürdük, sadece böyle yazarsak toplama işleminin sonucunu görmeyeceğiz
            //var result = Add2(20, 30);


            //int number1 = 20;
            //int number2 = 100;
            //var result3 = Add4(ref number1, number2);
            //Console.WriteLine(result3);
            //Console.WriteLine(number1);


            //number1 ilk console çalıştığında add operasyonu çalıştığı için methodun içerisinde değişir ve değer olarak 30 kullanılır
            //ref keywordü kullanıldığında ise değer tiplerini refeerans tip gibi kullanılmasını sağlar ver number1 i tek başında yazdırdığımızda yine 30 aldığını görürüz
            //ref'in bir diğer alternatifi out'tur
            //out yine ref ile benzer mantığa sahiptir: değer tipini referans tip gibi göndermek
            //out ve ref arasındaki fark ise ref'te number1 mutlaka set edilmiş olması gerekiyor. out'ta böyle bişey yok
            //out'ta mutlaka metod içerisinde bir kere set edilmiş olması lazım


            //Console.WriteLine(result);

            //var result2 = Add3(20);
            //Console.WriteLine(result2);

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2,4,5));
            Console.WriteLine(Add100(2, 3, 4, 5, 6, 7, 8, 9));

            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");

        }

        static int Add2(int number1, int number2) //parameters
        {
            var result = number1 + number2;
            return result;
            //void "programa git şunu yap" demek, o yüzden return çevirmesini istediğimizde void hata verir
            //void yerine çevirmesini istediğimiz değer tipini yazarız 
        }
        static int Add3(int number3, int number4 = 30) //default parameters
                                                       //default değerlerin metodların en sonunda olması gerekiyor, ilkine default parametre atanıp ikincisi boş mantıken bırakılamaz :)
        {
            var result2 = number3 + number4;
            return result2;

        }

        static int Add4(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        //diyelim ki sistemimizde bazen 2 bazen 3 değeri çarpabiliyor olmamız lazım, bunun için yeni bir method tanımlayıp ismi değiştirmemize gerek yok
        //Method Overload kullanılabilir 
        //"int Multiply(int number1 * int number2)" kısmına metodun imzası denir
        //aynı isimde 3 veriyi çarpacak şekilde metod yazılabilir (Method Overload)

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 *number2 * number3;
        }

        //Peki hesap makinelerindeki gibi istediği kadar sayı ile işlem yapabilmesi için?
        static int Add100(params int[] numbers)
        {
            return numbers.Sum(); //numbers.Sum() hazır bir metod
        }

        //params ile metoda aynı tipte istediğin kadar veri gönderebiliyorsun !!

        static int Add101(int number, params int[] numbers)
        {
            return numbers.Sum();   //number'ı kullanmadığımız için ilk atanan değer number'a gidecek ve işleme onu eklemediğimiz için göremeyeceğiz
            //params metodun en son parametresi olmak zorunda mantıken
        }


    }
}
