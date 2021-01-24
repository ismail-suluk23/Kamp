using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager taşitKrediManager = new TaşıtKrediManager();
            IKrediManager konutKredisManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new FilebaseLoggerService();
            ILoggerService fileLoggerService = new FilebaseLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,new DatabaseLoggerService());


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,taşitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
