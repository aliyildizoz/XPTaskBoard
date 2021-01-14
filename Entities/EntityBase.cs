using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class EntityBase: IEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }

        public EntityBase()
        {
            CreateDate = DateTime.Now;
        }
    }
}
