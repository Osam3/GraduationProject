using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class Categoreis
    {
        [Key]
        public int CategoryID { get; set; }

        [StringLength(15)]
        public string Name { get; set; }

        [StringLength(7)]
        public string ShortCutName { get; set; }

        //Navigation Prop
        //this for SelfJoin
        public int? MainCategoryId { get; set; }
        public Categoreis MainCategory { get; set; }

        //this for Items
        public ICollection<Items> Items { get; set; }
        public ICollection<Categoreis> Category { get; set; }
    }
}
