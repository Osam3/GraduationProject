using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class Measurements
    {
        [Key]
        public int MeasurmentID { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        //Navigation prop
        //this for Items
        public ICollection<Items> Items { get; set; }
    }
}
