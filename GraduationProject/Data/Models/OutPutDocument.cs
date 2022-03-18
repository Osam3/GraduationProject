using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class OutPutDocument
    {
        [Key]
        public int OutPutDocumentID { get; set; }

        //Navigation Prop
        //this for Order
        public int OrderId { get; set; }
        public Order Order { get; set; }

        //this for OutPutDocumentDetails
        public ICollection<OutPutDocumentDetails> OutPutDocumentDetails { get; set; }


    }
}
