using EmployeeRegister.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.DepartmentData
{
	public class SQLDepartmentData : IDepartmentData
	{
		private Employee_Dept_Context _employeeContext;

		public SQLDepartmentData(Employee_Dept_Context employee_Dept_Context)
		{
			_employeeContext = employee_Dept_Context;
		}
		public Department AddDepartment(Department department)
		{
			department.Department_ID = Guid.NewGuid();
			_employeeContext.department.Add(department);
			_employeeContext.SaveChanges();
			return department;
		}

		public void DeleteDepartment(Department department)
		{
			throw new NotImplementedException();
		}

		public List<Department> GetDepartments()
		{
			throw new NotImplementedException();
		}

		public Department ModifyDepartment(Department department)
		{
			throw new NotImplementedException();
		}
	}
}
