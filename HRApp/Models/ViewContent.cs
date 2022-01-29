using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRApp.Models
{
    public class ViewContent
    {
        public string Name { get; set; }
        public string depName { get; set; }
        public int depId { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime? DayDate { get; set; }

       
        public DateTime? InHour { get; set; }
        public DateTime? OutHour { get; set; }
        public string Time_InHour { get; set; }
        public string Time_OutHour { get; set; }

        public float EarlyOverTime { get; set; }
        [Column("LateHour")]
        public float LateHour { get; set; }
        [Column("LateType")]
        public int LateType { get; set; }
        [Column("EarlyOut")]
        public float EarlyOut { get; set; }
        [Column("EarlyOutType")]
        public int EarlyOutType { get; set; }
        [Column("OverTime1")]
        public float OverTime1 { get; set; }
    }
}
