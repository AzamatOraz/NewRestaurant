namespace RestRepeat.Migrations
{
    using RestRepeat.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using RestRepeat.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<RestRepeat.DAL.RestaurantContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(RestRepeat.DAL.RestaurantContext context)
        {
            var staffs = new List<Staff>
            {
                new Staff{FirstName="Serik",LastName="Seidagalimov", Mail = "serik@gmail.com", Password = "qwerty123456",HireDate=DateTime.Parse("2016-05-01")},
                new Staff{FirstName="Sharafat",LastName="Tolysbaeva", Mail = "sharafat@gmail.com",Password = "qwerty123456",HireDate=DateTime.Parse("2016-05-01")},
                new Staff{FirstName="Azamat",LastName="Oraz",Mail = "azamat@gmail.com", Password = "qwerty123456",HireDate=DateTime.Parse("2016-05-01")}
            };

            staffs.ForEach(s => context.Staffs.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();

            var clients = new List<Client>
            {
                new Client{ FirstName = "Dinara", LastName = "Tusupova",  Accumulation = 20000},
                new Client{ FirstName = "Goshan", LastName = "Nurbek",  Accumulation = 30000},
                new Client{ FirstName = "Danil", LastName = "Parshukov", Accumulation = 40000}
            };
            clients.ForEach(s => context.Clients.AddOrUpdate(p => p.FirstName, s));
            context.SaveChanges();

            var dept = new List<Department>
            {
                new Department{ DepartmentName = "Administration"},
                new Department{ DepartmentName = "Human Resources"},
                new Department{ DepartmentName = "Accounting"},
                new Department{ DepartmentName = "Products"}
            };
            dept.ForEach(s => context.Departments.AddOrUpdate(p => p.DepartmentName, s));
            context.SaveChanges();

            var menu = new List<Menu>
            {
                new Menu{ FoodType = "Meat"},
                new Menu{ FoodType = "Drinks"},
                new Menu{ FoodType = "Fruits"}
            };
            menu.ForEach(s => context.Menus.AddOrUpdate(p => p.FoodType, s));
            context.SaveChanges();

            foreach (Client e in clients)
            {
                var clientInDataBase = context.Clients.Where(
                    s =>
                         s.Manager.ID == e.ID).SingleOrDefault();
                if (clientInDataBase == null)
                {
                    context.Clients.Add(e);
                }
            }
            context.SaveChanges();
        }
    }
}
