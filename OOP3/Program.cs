using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService mailLoggerService = new MailLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,mailLoggerService);

            List<IKrediManager> krediManagers = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager, new AraçKrediManager() };
            List<ILoggerService> loggerServices = new List<ILoggerService>() {fileLoggerService,mailLoggerService };
            basvuruManager.KrediOnBilgilendirmeYap(krediManagers,loggerServices);
        }
    }
}
