using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HRApp.Models
{
    [Table("vi_emp_this_month")]
    public class vi_emp_this_month
    {
        public int ID { get; set; }
        [Column("Code")]
        public string Code { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("depName")]
        public string depName { get; set; }

         
        public DateTime DayDate { get; set; }
        [Column("State")] 
        public int State { get; set; }

      
        public DateTime InHour { get; set; }

        
        [Column("OutHour")]
        public DateTime OutHour { get; set; }
        [Column("EarlyOverTime")]
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
