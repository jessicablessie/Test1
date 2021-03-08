using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Test1.Models
{
	public class PatientModel
	{
		[Display(Name = "First Name")]
		[Required(ErrorMessage = "First Name is required.")]
		public string FirstName
		{
			get;
			set;
		}

		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "Last Name is required.")]
		public string LastName
		{
			get;
			set;
		}

	}

}