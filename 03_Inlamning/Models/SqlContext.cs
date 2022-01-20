using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Inlamning.Models;
using Microsoft.EntityFrameworkCore;

namespace _03_Inlamning.Models
{
    internal class SqlContext : DbContext
    {
        public SqlContext()
        {

        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\WIN21\Datalagring\03_Inlamning\03_Inlamning\03_Inlamning\Data\Uppg_database.mdf;Integrated Security=True;Connect Timeout=30");
        }

    }
}
