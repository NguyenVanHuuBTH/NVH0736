using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NGUYENVANHUUBTH2.Models;

namespace NGUYENVANHUUBTH2.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
        public DbSet<NGUYENVANHUUBTH2.Models.Student> Student {get; set;} = default!;
        public DbSet<NGUYENVANHUUBTH2.Models.Customer>? Customer { get; set; }
        public DbSet<NGUYENVANHUUBTH2.Models.Person>? Person { get; set; }
        public DbSet<NGUYENVANHUUBTH2.Models.Employee>? Employee { get; set; }
    }
}