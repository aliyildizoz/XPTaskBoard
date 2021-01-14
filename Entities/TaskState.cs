using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("TaskStates")]
    public class TaskState : EntityBase
    {
        [Required]
        public string Name { get; set; }

        public virtual ICollection<TaskTrack> TaskTracks { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
