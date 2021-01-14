using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    [Table("TaskTracks")]
    public class TaskTrack : EntityBase
    {
        public string EventDescription { get; set; }

        public virtual TaskState TaskState { get; set; }
        public virtual Task Task { get; set; }
    }
}
