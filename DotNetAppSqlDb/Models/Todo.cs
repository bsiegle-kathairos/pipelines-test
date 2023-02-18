using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetAppSqlDb.Models
{
    public class Todo
    {
        public string ID { get; set; }
        public string Customer { get; set; }
        public string Location { get; set; }
        public string Site { get; set; }
        public string Status { get; set; }
        public string Tank_Size { get; set; }
        public string Comission_Date { get; set; }
        public string Telemetry_ID { get; set; }
        public string GPS { get; set; }

//         [Display(Name = "Created Date")]
//         [DataType(DataType.Date)]
//         [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
//         public DateTime CreatedDate { get; set; }
    }
}
