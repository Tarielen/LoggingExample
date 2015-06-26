using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Project.DomainObjects.db;

namespace Project.Models.BindingModels
{
    public class LogBindingModel
    {
        public class AddLogging
        {
            [Required]
            public string app { get; set; }
            [Required]
            public string type { get; set; }
            [Required]
            public string accId { get; set; }
            [Required]
            public int eventID { get; set; }
            [Required]
            public string routine { get; set; }
            [Required]
            public int user { get; set; }
            [Required]
            public DateTime time { get; set; }
            [Required]
            public int loc { get; set; }
        }
    }
}