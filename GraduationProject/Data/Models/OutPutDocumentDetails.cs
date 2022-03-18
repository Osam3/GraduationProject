using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class OutPutDocumentDetails
    {
        [Key]
        public int OutPutDocumentDetailsID { get; set; }
        public int Quantity { get; set; }

        public string CommissaryName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }
        //Navigation prop
        //this for Item
        public int ItemId { get; set; }
        public Items Item { get; set; }

        //this for OutPutDocument
        public int OutPutDocumentId { get; set; }
        public OutPutDocument OutPutDocument { get; set; }

    }
}
