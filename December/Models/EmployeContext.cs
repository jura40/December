using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace December.Models
{
    public class EmployeContext : DbContext
    {
        public EmployeContext(DbContextOptions<EmployeContext> options) : base(options)
        {

        }
        public DbSet<Employe> Employes { get; set; }
        public DbSet<Company> Companys { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

       
       
        
    }
}
