using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class mcbüContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=BURAK;Database=DbMCBU;Trusted_Connection=True");
        }


        public DbSet<Printer> Printers { get; set; }
        public DbSet<Toner> Toners { get; set; }
        public DbSet<TonerBrand> TonerBrands { get; set; }
        public DbSet<TonerModel> TonerModels { get; set; }
        public DbSet<PrinterModel> PrinterModels { get; set; }
        public DbSet<PrinterBrand> PrinterBrands { get; set; }
        public DbSet<PrinterImage> PrinterImages { get; set; }
        public DbSet<TonerTracking> TonerTrackings { get; set; }
        public DbSet<TonerRefilling> TonerRefillings { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    }
}   
