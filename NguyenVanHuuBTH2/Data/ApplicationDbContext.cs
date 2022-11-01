using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NguyenVanHuuBTH2.Models;

namespace NguyenVanHuuBTH2.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<NguyenVanHuuBTH2.Models.Student> Student {get; set;} = default!;
        public DbSet<NguyenVanHuuBTH2.Models.Customer>? Customer { get; set; }
        public DbSet<NguyenVanHuuBTH2.Models.Person>? Person { get; set; }
        public DbSet<NguyenVanHuuBTH2.Models.Employee>? Employee { get; set; }
    }
}