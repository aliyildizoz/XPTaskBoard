using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using Entities;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class XPTaskBoardDbContext : DbContext
    {
        public XPTaskBoardDbContext() : base("XPTaskBoardDB")
        {
            Database.SetInitializer(new XPTaskBoardDBInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().MapToStoredProcedures();
            modelBuilder.Entity<TaskState>().MapToStoredProcedures();
            modelBuilder.Entity<TaskTrack>().MapToStoredProcedures();
            modelBuilder.Entity<Project>().MapToStoredProcedures();
            modelBuilder.Entity<Employee>().MapToStoredProcedures();
            
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<TaskTrack> TaskTracks { get; set; }
    }
}
