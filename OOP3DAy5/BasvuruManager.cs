using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3DAy5
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //başvuran bilgilerini değerlendirme vs eklenir
            //

            krediManager.Hesapla();
            loggerService.Log(); //dependency injection 





        }

        public void KrediOnBilgilendirmesiYap1(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();

            }

        }

    }
    }
