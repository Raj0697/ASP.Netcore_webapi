using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegister.Models
{
	public class Department
	{
		[Key]
		public Guid Department_ID { get; set; }

		public virtual Employee Employee { get; set; }
		[Required]
		[Column(TypeName = "Varchar(10)")]
		[MaxLength(10, ErrorMessage = "department name should not exceed 10 characters")]
		public string Department_name { get; set; }
	}
}
