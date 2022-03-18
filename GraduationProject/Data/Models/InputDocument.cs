using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class InputDocument
    {
        [Key]
        public int InputDocumentID { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        //Navigation prop
        public ICollection<InputDocumentDetails> InputDocumentDetails { get; set; }
    }
}
