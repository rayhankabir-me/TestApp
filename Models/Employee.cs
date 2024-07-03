using System;
using System.ComponentModel.DataAnnotations;
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
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
	}
}

