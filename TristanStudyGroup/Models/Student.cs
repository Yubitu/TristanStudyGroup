using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TristanStudyGroup.Models
{
	//Class for student to be used for mvc
	public class Student
	{
        //property and decorator for student num
		[Display(Name = "Student Number")]
		public string StudentNumber { get; set; }
        //property and decorator for Name
        [Display(Name = "Name")]
        public string FirstName { get; set; }
        //property and decorator for Surname
        [Display(Name = "Surname")]
        public string LastName { get; set; }
        //property and decorator for email address
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}