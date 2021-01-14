using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Business.Abstract;
using Business.DIResolvers;
using Business.Results;
using Entities;
using XPTaskBoard.Test.Business.Abstract;

namespace XPTaskBoard.Test
{
    [TestClass]
    public class TaskManagerUnitTest : ITaskServiceUnitTest
    {
        private ITaskService _taskService;
        [TestInitialize]
        public void Initialize()
        {
            _taskService = DI.GetService<ITaskService>();
        }
        [TestMethod]
        public void Add()
        {
            Task task = new Task
            {
                Details = "Test details",
                EstimatedDate = DateTime.Now,
                Notes = "Test notes",
                ProjectId = 1,
                TaskStateId = 4
            };
            var result = _taskService.Add(task);
            Assert.AreEqual(true, result.IsSuccessful);
        }
        [TestMethod]
        public void Delete()
        {
            var result = _taskService.Delete(6);
            Assert.AreEqual(true, result.IsSuccessful);
        }
        [TestMethod]
        public void AddEmployee()
        {
            var result = _taskService.AddEmployee(new Task() { Id = 4 }, new Employee() { Id = 1 });
            Assert.AreEqual(true, result.IsSuccessful);
        }

    }
}
