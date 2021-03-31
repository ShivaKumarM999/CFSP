using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CFSP.Models
{
    public class CFSPContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .MapToStoredProcedures();
        }

        public DbSet<Student> Students { get; set; }
    }
}