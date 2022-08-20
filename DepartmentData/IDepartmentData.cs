using System;
using EmployeeRegister.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.DepartmentData
{
	public interface IDepartmentData
	{
		List<Department> GetDepartments();
		Department AddDepartment(Department department);
		void DeleteDepartment(Department department);
		Department ModifyDepartment(Department department);
	}
}
