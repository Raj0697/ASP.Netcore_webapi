using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.EmployeeData
{
	public class SQLEmployeeData : IEmployeeData
	{
		private Employee_Dept_Context _employeeContext;
		public SQLEmployeeData(Employee_Dept_Context employeecontext)
		{
			_employeeContext = employeecontext;
		}
		public Employee AddEmployee(Employee employee)
		{
			employee.Employee_ID = Guid.NewGuid();
			//employee.Firstname = "Raj";
			//employee.Lastname = "kumar";
			//employee.EmailId = "rajk23@gmail.com";
			employee.Department_ID = Guid.NewGuid();
			//employee.Manager_ID = 210;
			_employeeContext.employees.Add(employee);
			_employeeContext.SaveChanges();
			return employee;
		}

		public void DeleteEmployee(Employee employee)
		{
			_employeeContext.employees.Remove(employee);
			_employeeContext.SaveChanges();
		}

		public Employee GetEmployee(Guid id)
		{
			throw new NotImplementedException();
		}

		public List<Employee> GetEmployees()
		{
			return _employeeContext.employees.ToList();
		}

		public Employee GetEmployeeStatus(Guid Employee_ID)
		{
			//return _employeeContext.employees.SingleOrDefault(x => x.Employee_ID == Employee_ID);
			var emp = _employeeContext.employees.Find(Employee_ID);
			if(emp.Manager_ID >= 1)
			{

			}
			if (emp.Employee_ID.Equals(Guid.Empty))
			{
				
			}
			return emp;
		}

		public Employee ModifyEmployee(Employee employee)
		{
			var existing_employee = _employeeContext.employees.Find(employee.Employee_ID);
			if(existing_employee != null)
			{
				_employeeContext.employees.Update(employee);
				_employeeContext.SaveChanges();
			}
			return employee;
		}

	}
}
