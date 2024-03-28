using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //class ismi PascalCase, ama nun örneğinin ismi camelCase yazılır
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add1();
            productManager.Update1();

            Customer customer1 = new Customer();
            customer1.City = "Konya";
            customer1.FirstName = "Berra";
            customer1.LastName = "Abc";
            customer1.Id = 1;
            customer1.NickName = "hujihuj";

            Customer customer2 = new Customer
            {
                Id = 2,
                LastName = "Bng",
                FirstName = "Derin",
                City = "İstanbul",
                NickName = "uhuj"


            };

            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();

        }
    }

}
