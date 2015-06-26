using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DomainObjects;

namespace Project.DAL.Logging
{
    public class LoggingDAO:ILoggingDAO
    {
        public void AddLogging(string app, string type, string accId, int eventId, string routine, int user, DateTime time, int loc)
        {
            LoggingDAL.AddLogging(app, type, accId, eventId, routine, user, time, loc);
        }

    }
}