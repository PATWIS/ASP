using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ASP.Models;

namespace ASP.DAL
{
    public class AppInitializer : DropCreateDatabaseAlways<AppContext>
    {

        protected override void Seed(AppContext context)
        {
            SeedAppData(context);
            base.Seed(context);
        }

        private void SeedAppData(AppContext context)
        {

            var companies = new List<Company>
            {
                new Company() {CompanyId = 1, Name="TestCompany1" }
            };

            companies.ForEach(c => context.Companies.Add(c));
            context.SaveChanges();



            var employees = new List<Employee>
            {
                new Employee() {EmployeeId = 1, Name="TestUser1", MedicalExamDate = DateTime.Now, CompanyId = 1}
            };

            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();
        }
    }
}