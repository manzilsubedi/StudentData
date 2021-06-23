using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentData.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 5)]
        [DisplayName("First Name")]

        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        [StringLength(100, MinimumLength = 5)]
        public string LastName { get; set; }
        [StringLength(100,MinimumLength =5)]
        public string Address { get; set; }
        [StringLength(14)]
        public string Phone { get; set; }

    }
}
