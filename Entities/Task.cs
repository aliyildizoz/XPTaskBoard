using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("Tasks")]
    public class Task : EntityBase
    {
        [Required]
        public string Details { get; set; }
        public string Notes { get; set; }
        public DateTime EstimatedDate { get; set; }

        public int TaskStateId { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey("TaskStateId")]
        public virtual TaskState TaskState { get; set; }
        [ForeignKey("ProjectId")]
        public virtual Project Project { get; set; }
        public virtual ICollection<TaskTrack> TaskTracks { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public Task()
        {
            TaskStateId = (int)TaskStateNames.ToDo;
        }
        public override string ToString()
        {
            return Details;
        }
    }
}
