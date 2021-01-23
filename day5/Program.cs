using OOP2DAY2;
using System;

namespace day5
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.CustomerNumber = "12345";
            musteri1.Name = "Seden";
            musteri1.Surname = "Kurt";
            musteri1.TcNumber = "1234567890";

            //kodlama.io şirketi 

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.CustomerNumber = "23456";
            musteri2.CompanyName = "Kodlama.io";
            musteri2.TaxNumber = "123456789";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //musteri classı gerçek ve tüzel müsteri referanslarını tutabiliyor. 

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            // tuzel veya gerçek fark etmeden yöneticiye müsteri tanımlayabiiriz çünkü inheritance verdik



               

        }
    }
}
