using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestRepeat.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RestRepeat.DAL
{
    public class RestaurantContext : DbContext
    {
        public RestaurantContext()
            : base("RestaurantContext")
        {
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Menu> Menus { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}