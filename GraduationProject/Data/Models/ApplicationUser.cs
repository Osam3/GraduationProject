using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string RequstingParty { get; set; }
        [StringLength(10)]
        public string Type { get; set; }

        //Navigation Prop
        //this for Order
        public ICollection<Order> Order { get; set; }
    }
}
