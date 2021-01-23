using System;
using System.Collections.Generic;

namespace OOP3DAy5
{
    class Program
    {
        static void Main(string[] args)
        {
              IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
              IKrediManager  tasitKrediManager = new TasitKrediManager();
              IKrediManager konutKrediManager = new KonutKrediManager();

            // interface ona implemente edilen classın referansını tutabilir.
            ILoggerService databaseLoggerService = new DataBaseLoggerService(); //bu şekilde de tanımlanabilir
            ILoggerService fileLogerService = new FileLoggerService(); 
            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new DataBaseLoggerService()); // polimorfizm böyle de tanımlanabilir

            List<IKrediManager> krediler = new List<IKrediManager>()
            {
                ihtiyacKrediManager,tasitKrediManager
            };
           // basvuruManager.KrediOnBilgilendirmesiYap1(krediler);
            // interfaceleri birbirinin alternatifi olan fakat kod içerikleri aynı olan durumlar için kullanırız.
        }
    }
}
