using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.db;
using Project.DomainObjects;

namespace Project.DAL.Logging
{
    internal static class LoggingDAL
    {
        internal static void AddLogging(string app, string type, string accId, int eventId, string routine, int user, DateTime time, int loc)
        {
            using (var context = DataUtility.GetDbContext()) //this basically defines the database model
            {
                var newEvent = new tblLogging();
                newEvent.ApplicationName = app;
                newEvent.IdentifierType = type;
                newEvent.Identifier = accId;
                newEvent.EventID = eventId;
                newEvent.Routine = routine;
                newEvent.LocationID = loc;
                newEvent.CreatedDT = time;
                newEvent.CreatedByID = user;

                context.Loggings.AddObject(newEvent); //specifies the table I'm targetting
                context.SaveChanges(); //does an INSERT INTO
            }
        }
    }
}