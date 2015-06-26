using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.DAL.Logging;

namespace Project.BusinessLogic
{
    public class LoggingBL:ILoggingBL
    {
        #region Private Variables
        private readonly ILoggingDAO _dataAccess;
        #endregion

        #region Constructors
        public LoggingBL() : this(new LoggingDAO()) { }

        public LoggingBL(ILoggingDAO dataAccess)
        {
            _dataAccess = dataAccess;
        }
        #endregion

        public void AddLogging(string app, string type, string accId, int eventId, string routine, int user, DateTime time, int loc)
        {
            _dataAccess.AddLogging(app, type, accId, eventId, routine, user, time, loc);
        }
    }
}