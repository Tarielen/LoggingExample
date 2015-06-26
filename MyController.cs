using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Project.BusinessLogic;
using Project.DomainObjects;
using Project.DomainObjects.db;
using Project.Models;
using Project.Models.BindingModels;

namespace Project.Controllers
{
    public class SharedController : Controller
    {
        
        #region Private Variables
        private readonly ILoggingBL _logRepository;
        #endregion

        #region Constructors
        public SharedController()
        {
            _logRepository = new LoggingBL();
        }
        #endregion

        #region Actions
		// POST: /Shared/AddLog
		[HttpPost, ActionName("AddLog")]
		public void AddLog(string bindingModel)
		{
		    LogBindingModel.AddLogging logActivity = JsonConvert.DeserializeObject<LogBindingModel.AddLogging>(bindingModel);
		    _logRepository.AddLogging(logActivity.app, logActivity.type, logActivity.accId, logActivity.eventID, logActivity.routine, logActivity.user, logActivity.time, logActivity.loc);
		}
        #endregion
    }
}