using GraduationProject.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraduationProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Measurements> Measurements { get; set; }
        public DbSet<Categoreis> Category { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<InputDocument> InputDocument { get; set; }
        public DbSet<InputDocumentDetails> InputDocumentDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<UnPlannedOrder> UnPlannedOrder { get; set; }
        public DbSet<AnnualOrder> AnnualOrder { get; set; }
        public DbSet<OutPutDocument> OutPutDocument { get; set; }
        public DbSet<OutPutDocumentDetails> OutPutDocumentDetails { get; set; }

    }
}
