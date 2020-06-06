using OpenPDV.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPDV.Repository
{
    public class BancoDeDados : DbContext
    {
        public BancoDeDados() : base("name=OpenPDVDBConnectionString")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BancoDeDados, OpenPDV.Migrations.Configuration>());
        }

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}