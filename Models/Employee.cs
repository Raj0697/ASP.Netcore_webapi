using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Models
{
	public class Employee
	{
		
		[Key]
		public Guid Employee_ID { get; set; }  // Primary key of employee table

		[Required]
		[Column(TypeName = "Varchar(10)")]
		[MaxLength(10, ErrorMessage = "First name should not exceed 10 characters")]
		public string Firstname { get; set; }

		[Required]
		[Column(TypeName ="Varchar(10)")]
		[MaxLength(10, ErrorMessage = "Last name should not exceed 10 characters ")]
		public string Lastname { get; set; }

		[Required]
		[RegularExpression(@" ^ ([\w\.\-] +)@([\w\-] +)((\.(\w){2, 3})+)$", ErrorMessage = "Enter a Valid EmailID")]
		public string EmailId { get; set; }

		[ForeignKey("department")]
		[Required]
		public Guid Department_ID { get; set; }
		public virtual Department department { get; set; }

		[ForeignKey("IdentityUser")]
		[Required]
		public int Manager_ID { get; set; }  // Self referencing to primary key of Employee_ID of same table (i.e. Employee table). Foreign key is self referencing
		//public virtual Employee employee { get; set; }
		public virtual IdentityUser IdentityUser{ get; set; }
	}
}
