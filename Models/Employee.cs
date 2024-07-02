using System;
using Microsoft.EntityFrameworkCore;
using TestApp.Data;

namespace TestApp.Models
{

	public class EmployeeContext : ApplicationDbContext
	{
        public EmployeeContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

		public DbSet<Employee> Employees { get; set; }
    }

	public class Employee
	{
		public int id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Gender { get; set; }
	}
}

