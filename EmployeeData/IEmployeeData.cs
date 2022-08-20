using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.EmployeeData
{
	public interface IEmployeeData
	{
		List<Employee> GetEmployees();
		Employee GetEmployeeStatus(Guid Employee_ID);
		Employee AddEmployee(Employee employee);
		void DeleteEmployee(Employee employee);
		Employee GetEmployee(Guid id);
		Employee ModifyEmployee(Employee employee);
	}
}
