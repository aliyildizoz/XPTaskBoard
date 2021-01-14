using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Projects")]
    public class Project : EntityBase
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
