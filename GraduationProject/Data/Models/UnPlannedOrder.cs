using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class UnPlannedOrder
    {
        [Key]
        public int UnPlannedOrderID { get; set; }

        public int Quantity { get; set; }

        [StringLength(100)]
        public string Comment { get; set; }

        [StringLength(155)]
        public string Description { get; set; }

        [StringLength(100)]
        public string Reason { get; set; }

        //Navigation prop
        //this for Item
        public int ItemId { get; set; }
        public Items Item { get; set; }

        //this for Order
        public int OrderId { get; set; }
        public Order Order { get; set; }



    }
}
