using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CRM.EntityFramework.CrmDbContext
{
    public class CrmDbContext : DbContext
    {
        protected DbContext();

        public CrmDbContext(DbContextOptions options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {

            base.OnConfiguring(optionsBuilder);
        }
    }
}
