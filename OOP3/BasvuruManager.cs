using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();
        }
        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediManagers,List<ILoggerService> loggerServices)
        {
            foreach (var kredi in krediManagers)
            {
                kredi.Hesapla();
            }
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
    }
}
