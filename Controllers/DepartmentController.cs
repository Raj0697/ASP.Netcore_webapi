using EmployeeRegister.DepartmentData;
using EmployeeRegister.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Controllers
{
	[ApiController]
	public class DepartmentController : ControllerBase
	{
		private IDepartmentData _departmentdata;

		public DepartmentController(IDepartmentData departmentData)
		{
			_departmentdata = departmentData;
		}

		[HttpPost]
		[Route("api/[controller]")]
		public IActionResult AddDepartment(Department department)
		{
			_departmentdata.AddDepartment(department);
			return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/"
				+ department.Department_ID, department);
		}

		[HttpGet]
		[Route("api/[controller]")]
		public IActionResult GetDepartment()
		{
			return Ok(_departmentdata.GetDepartments());
		}
	}
}
