using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager homeCreditManager = new HomeCreditManager();           
            ICreditManager vehicleCreditManager = new VehicleCreditManager();

            ILoggerService dataBaseLoggerServices = new DataBaseLoggerService();
            ILoggerService fileLoggerServices = new FileLoggerService();

            SummitManager summitManager = new SummitManager();
            summitManager.Summit(homeCreditManager, dataBaseLoggerServices);
          
            List<ICreditManager> credits = new List<ICreditManager>() {homeCreditManager,vehicleCreditManager };
            //summitManager.CreditInformation(credits);

        }
    }
}
