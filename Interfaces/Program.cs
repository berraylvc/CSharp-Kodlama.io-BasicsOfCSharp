using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();
            //Demo2();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
            };

            foreach (var  customerDal in customerDals)
            {
                customerDal.Add();
            }
            

            Console.ReadLine();
        }

        private static void Demo2()
        {
            //interface ve abstract gibi soyutlar new'lenemez
            //IPerson person = new IPerson(); YAZILAMAZ
            //ama
            IPerson person1 = new Student();
            IPerson person2 = new Customer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer1 = new Customer()
            {
                ID = 1,
                FirstName = "Berra",
                LastName = "Yalvac",
                Address = "Konya"
            };
            Student student = new Student
            {
                ID = 2,
                LastName = "Adb",
                FirstName = "hjk",
                Departmant = "Comp"

            };

            manager.Add(new Customer { ID = 1, FirstName = "Berra", LastName = "Yalvac", Address = "Konya" });
            manager.Add(new Student { ID = 2, LastName = "Adb", FirstName = "hjk", Departmant = "Comp" });
        }
    }

    //soyut nesne
    interface IPerson   //isimlendirme standartı I ile başlaması
    {
        //interface'lerin kullanım amacı bir temel method veya nesne oluşturup diğer classların içerisine aynı temel method veya nesneleri implemente edebilmektir

        int ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }

    //somut nesneler
    class Customer : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }

    }

    class Student : IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) //parametrelerde interface kullanmak daha verimli ama çağırabileceğiniz özellilerin interfacede olanlar olduğunu unutmamak gerek 
        {
            Console.WriteLine(person.FirstName);
        }

    }
}
