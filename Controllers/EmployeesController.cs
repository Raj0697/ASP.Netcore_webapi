using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeRegister.EmployeeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeRegister.Models;

namespace EmployeeRegister.Controllers
{
	[ApiController]
	public class EmployeesController : ControllerBase
	{
		private IEmployeeData _employeedata;
		public EmployeesController(IEmployeeData employeeData)
		{
			_employeedata = employeeData;
		}

		[HttpGet]
		[Route("api/[controller]")]
		public IActionResult GetEmployees()
		{
			return Ok(_employeedata.GetEmployees());
		}

		[HttpGet]
		[Route("api/[controller]")]
		public IActionResult GetEmployeestatus(Employee employee)
		{
			try
			{
				var emp = _employeedata.GetEmployee(employee.Employee_ID);
				if (emp != null)
				{
					if (emp.Manager_ID != 0)
					{
						return Ok();
					}
					return Ok();
				}
			}
			catch(Exception ex)
			{

			}
			return Ok();
		}

		[HttpPost]
		[Route("api/[controller]")]
		public IActionResult AddEmployee(Employee employee)
		{
			_employeedata.AddEmployee(employee);
			return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.Employee_ID, employee);
		}

		[HttpDelete]
		[Route("api/[controller]")]
		public IActionResult DeleteEmployee(Employee employee)
		{
			var emp = _employeedata.GetEmployee(employee.Employee_ID);
			if(emp != null)
			{
				_employeedata.DeleteEmployee(employee);
				return Ok();
			}

			return NotFound($"Employee with id: {employee.Employee_ID} was not found");
		}

		[HttpPatch]
		[Route("api/[controller]/{id}")]
		public IActionResult ModifyEmployee(Employee employee)
		{
			try
			{
				var existing_employee = _employeedata.GetEmployee(employee.Employee_ID);
				if (existing_employee != null)
				{
					employee.Employee_ID = existing_employee.Employee_ID;
					_employeedata.ModifyEmployee(employee);
				}
			}
			
			catch (Exception ex)
			{

			}
			return Ok(employee);
		}
	}
}
