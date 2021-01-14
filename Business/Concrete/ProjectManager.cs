using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Results;
using Business.Validation;
using DataAccess.Abstract;
using Entities;
using Task = Entities.Task;

namespace Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private IProjectDal _projectDal;
        private Validation<ProjectValidator> _validation;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public IDataResult<Project> Add(Project project)
        {
            _validation = new Validation<ProjectValidator>();
            _validation.Validate(project);
            _projectDal.Add(project);
            return new SuccessDataResult<Project>(project);
        }

        public IDataResult<List<Project>> GetList()
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetList().ToList());
        }

        public IResult Delete(int id)
        {
            _projectDal.Delete(new Project { Id = id });
            return new SuccessResult();
        }

        public IResult Update(Project project)
        {
            _validation = new Validation<ProjectValidator>();
            _validation.Validate(project);
            _projectDal.Update(project);
            return new SuccessResult();
        }

        public IDataResult<List<Project>> Search(string search)
        {
            return new SuccessDataResult<List<Project>>(_projectDal.GetList(project => project.Name.ToLower().Contains(search.ToLower())).OrderByDescending(project => project.Id).ToList());
        }
    }
}
