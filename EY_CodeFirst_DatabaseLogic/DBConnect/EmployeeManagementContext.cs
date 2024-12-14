using EY_CodeFirst_BusinessEntities.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EY_CodeFirst_DatabaseLogic.DBConnect
{
    public class EmployeeManagementContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=KISHORE\SQLEXPRESS;initial Catalog=EY_CodeFirst;Integrated Security=True;");
        }
    }
}
