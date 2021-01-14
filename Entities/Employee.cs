using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Employees")]
    public class Employee : EntityBase
    {
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
