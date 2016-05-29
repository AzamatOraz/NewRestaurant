using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestRepeat.Models;
using System.Data.Entity;


namespace RestRepeat.DAL
{
    public class RestaurantInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            var staffs = new List<Staff>
            {
                new Staff{FirstName="Serik",LastName="Seidagalimov", Mail = "Serik@gmail.com",HireDate=DateTime.Parse("2016-05-01")},
                new Staff{FirstName="Sharafat",LastName="Tolysbaeva", Mail = "Sharafat@gmail.com",HireDate=DateTime.Parse("2016-05-01")},
                new Staff{FirstName="Azamat",LastName="Oraz",Mail = "Azamat@gmail.com", HireDate=DateTime.Parse("2016-05-01")}
            };

            staffs.ForEach(s => context.Staffs.Add(s));
            context.SaveChanges();
            var clients = new List<Client>
            {
                new Client{ FirstName = "Dinara", LastName = "Tusupova", Accumulation = 20000},
                new Client{ FirstName = "Goshan", LastName = "Nurbek",  Accumulation = 30000},
                new Client{ FirstName = "Danil", LastName = "Parshukov", Accumulation = 40000}
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();
            var dept = new List<Department>
            {
                new Department{ DepartmentName = "Administration"},
                new Department{ DepartmentName = "Human Resources"},
                new Department{ DepartmentName = "Accounting"},
                new Department{ DepartmentName = "Products"}
            };
            dept.ForEach(s => context.Departments.Add(s));
            context.SaveChanges();

            var menu = new List<Menu>
            {
                new Menu{ FoodType = "Meat"},
                new Menu{ FoodType = "Drinks"},
                new Menu{ FoodType = "Fruits"}
            };
            menu.ForEach(s => context.Menus.Add(s));
            context.SaveChanges();
        }

    }
}