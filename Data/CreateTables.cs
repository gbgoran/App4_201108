using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

// Purpose is to connect program to an SQL server and the database which Ive created, called "Inlamn2".

namespace App4_201108.Data
{
    public class CreateTables : DbContext
    {
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Customer> Issues { get; set; }
        public DbSet<Models.Customer> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseSqlServer(@"Data Source=MSI\SQLEXPGB;Initial Catalog=Inlamn2;Integrated Security=True");
        }
    }


}
