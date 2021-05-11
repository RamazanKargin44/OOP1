using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SummitManager
    {
        public void Summit(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Hesapla();
            loggerService.Log();

        }
        public void CreditInformation(List<ICreditManager> Credits)
        {
            foreach (var Credit in Credits)
            {
                Credit.Hesapla();
            }
        }
    }
}
