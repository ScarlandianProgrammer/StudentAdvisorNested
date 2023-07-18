using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdvisorNested
{
    /// <summary>
    /// Represents an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// The legal first name of the student
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The legal last name of the student
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The date of birth of the student
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// The school email address of the student
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The student's preferred phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The advisor assigned to the student
        /// </summary>
        public Advisor Advisor { get; set; }
    }
}
