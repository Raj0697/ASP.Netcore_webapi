using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Models
{
	public class Employee_Dept_Context : DbContext
	{
		public Employee_Dept_Context(DbContextOptions<Employee_Dept_Context> options) : base(options)
		{}

		public DbSet<Employee> employees { get; set; }

		public DbSet<Department> department { get; set; }
	}
}
