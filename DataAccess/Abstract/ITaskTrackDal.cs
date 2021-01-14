using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete;
using Entities;

namespace DataAccess.Abstract
{
    public interface ITaskTrackDal : IEntityRepository<TaskTrack>
    {
    }
}
