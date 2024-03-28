using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer
    {
        //field tanımlamak
        //public string FirstName;

        //property tanımlamak

        //otoproperty biçimi; (daha yaygın kullanım)
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //encapsulation
        //uygulamada set veya get esnasında farklı bir şey yapılmak istenirse (ismin başına Mrs. getirmek gibi) bu esnada propertylerdeki get ve set metodları daha spesifik tanımlanarak yapılır.
        
        
        //single responsibility'ye aykırı işlemler yapıldığı için artık bunu pek kullanmıyoruz, onun yerine yukarıdaki gibi tanımlıyoruz
        string _nickName;
        public string NickName { get { return "Mrs." + _nickName; } set { _nickName = value; } }

    }
}
