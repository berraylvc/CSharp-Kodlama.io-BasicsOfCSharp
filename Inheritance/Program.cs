using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer{FirstName="Engin"}, new Student{FirstName="Derin"}, new Person{FirstName="Ali"}
            };
            foreach(var  person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();
        }
    }
    class Person  //interfaceler tek başına bir anlam ifade etmiyordu ama classlarda hem tek başına hem de inheritance verdiği noktada anlam ifade ediyor.
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person  //interfacelerden farklı olan bir diğer özelliği de; interfacelerde birden fazla kez kullanılabiliyorken, inheritance'ler sadece bir kez kulanılabilir.
    { //hem inheritance hem de interface kullanılacaksa önce inheritance sonra interface/interfaceler yazılır.
        public string City {get;set;}
    }
    class Student: Person
    {
        public string Department { get; set; }
    }
}

//özellikle abstract classlarda inheritance çok önemli yer teşkil ediyor fakat bir proojede genel olarak interface kullanabiliyorsan interface kullan 
