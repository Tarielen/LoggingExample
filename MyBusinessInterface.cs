using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DomainObjects;

namespace Project.BusinessLogic
{
    public interface ILoggingBL
    {
        void AddLogging(string app, string type, string accId, int eventId, string routine, int user, DateTime time, int loc);
    }
}
