using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI.Utilities;
using Business.Abstract;
using Business.DIResolvers;
using Business.Utilities;
using DevExpress.Xpo;
using Entities;
using MetroFramework.Controls;
using Session = WindowsUI.Utilities.Session;
using Task = Entities.Task;

namespace WindowsUI
{
    public partial class TaskCreate : MetroFramework.Forms.MetroForm
    {
        private ITaskService _taskService;
        private IEmployeeService _employeeService;
        private TaskStateBaseNames _taskStateNames;
        private Entities.Task createTask;
        private List<Employee> selectedEmployees;
        public TaskCreate()
        {
            _taskService = DI.GetService<ITaskService>();
            _employeeService = DI.GetService<IEmployeeService>();
            InitializeComponent();
            createTask = new Entities.Task();
            _taskStateNames = TaskStateBaseNames.ToDo;
            selectedEmployees = new List<Employee>();
            LoadData();
            this.Closed += OnClosed;
            estDateTime.Value= DI.GetService<IBusinessHelper>().AvgTaskEstimated(Session.CurrentProject.Id);
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            AppHelper.GetCurrentForm<MainForm>().LoadData();
            AppHelper.FocusMainForm();
        }

        protected virtual void OnChangeState(object sender, System.EventArgs e)
        {
            var selected = (MetroRadioButton)sender;
            if (selected.Text == "To do" && selected.Checked)
            {
                _taskStateNames = TaskStateBaseNames.ToDo;
            }
            else if (selected.Text == "Doing" && selected.Checked)
            {
                _taskStateNames = TaskStateBaseNames.Doing;
            }
            else if (selected.Text == "Done" && selected.Checked)
            {
                _taskStateNames = TaskStateBaseNames.Done;
            }
        }

        private void BtnCreateTask_Click(object sender, System.EventArgs e)
        {
            createTask.TaskStateId = (int)_taskStateNames;
            createTask.Details = rctDetails.Text;
            createTask.Notes = rctNotes.Text;
            createTask.ProjectId = Session.CurrentProject.Id;
            createTask.EstimatedDate = estDateTime.Value;
            var result = _taskService.Add(createTask);
            if (result.IsSuccessful)
            {
                AddRangeEmployee(result.Data);
            }
            var form = AppHelper.GetCurrentForm<MainForm>();
            this.Close();
            form.Show();
            form.LoadData();
        }

        void AddRangeEmployee(Task task)
        {
            selectedEmployees.ForEach(employee =>
            {
                _taskService.AddEmployee(task, employee);
            });
        }
        void LoadData(List<Employee> employees = null)
        {
            CmbEmployeeList.Items.Clear();
            var emp = _employeeService.GetList().Data;
            if (employees == null)
            {
                CmbEmployeeList.Items.AddRange(emp.ToArray());
            }
            else
            {

                foreach (var employee in emp)
                {
                    if (employees.FirstOrDefault(employee1 => employee1.Id == employee.Id) == null)
                    {
                        CmbEmployeeList.Items.Add(employee);
                    }
                }

                lstMembers.Items.Clear();
                lstMembers.Items.AddRange(employees.ToArray());
            }
        }

        private void btnAddMember_Click(object sender, System.EventArgs e)
        {
            var selected = (Employee)CmbEmployeeList.SelectedItem;

            if (selected == null)
            {
                MessageBox.Show("Choose an employee.");
            }
            else
            {
                selectedEmployees.Add(selected);
                LoadData(selectedEmployees);
            }
        }

        private void btnRemoveMember_Click(object sender, System.EventArgs e)
        {
            var selected = (Employee)lstMembers.SelectedItem;

            if (selected == null)
            {
                MessageBox.Show("Choose an employee in grid.");
            }
            else
            {
                selectedEmployees.Remove(selected);
                LoadData(selectedEmployees);

            }
        }
    }
}
