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
using Business.Results;
using Entities;
using MetroFramework.Controls;
using Task = Entities.Task;

namespace WindowsUI
{
    public partial class TaskEdit : MetroFramework.Forms.MetroForm
    {
        private ITaskService _taskService;
        private IEmployeeService _employeeService;
        private int _taskId;
        private IDataResult<Task> _task;
        public TaskEdit(int taskId)
        {
            _taskId = taskId;
            InitializeComponent();
            _taskService = DI.GetService<ITaskService>();
            _employeeService = DI.GetService<IEmployeeService>();
            LoadData(taskId);
            this.Closed += OnClosed;
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            AppHelper.GetCurrentForm<MainForm>().LoadData();
            AppHelper.FocusMainForm();
        }

        private void LoadData(int taskId)
        {
            CmbEmployeeList.Items.Clear();
            var emp = _employeeService.GetList().Data;
            _task = _taskService.GetById(taskId);

            if (_task.IsSuccessful)
            {
                rctDetails.Text = _task.Data.Details;
                rctNotes.Text = _task.Data.Notes;
                estDateTime.Value = _task.Data.EstimatedDate;
                SetState((TaskStateBaseNames)_task.Data.TaskStateId);
                CmbEmployeeList.Items.Clear();
                foreach (var employee in emp)
                {
                    if (_task.Data.Employees.FirstOrDefault(employee1 => employee1.Id == employee.Id) == null)
                    {
                        CmbEmployeeList.Items.Add(employee);
                    }
                }

                lstMembers.Items.Clear();
                lstMembers.Items.AddRange(_task.Data.Employees.ToArray());
            }

        }
        private void LoadData()
        {
            CmbEmployeeList.Items.Clear();
            var emp = _employeeService.GetList().Data;
            if (_task.IsSuccessful)
            {
                rctDetails.Text = _task.Data.Details;
                rctNotes.Text = _task.Data.Notes;
                estDateTime.Value = _task.Data.EstimatedDate;
                CmbEmployeeList.Items.Clear();
                foreach (var employee in emp)
                {
                    if (_task.Data.Employees.FirstOrDefault(employee1 => employee1.Id == employee.Id) == null)
                    {
                        CmbEmployeeList.Items.Add(employee);
                    }
                }
                lstMembers.Items.Clear();
                lstMembers.Items.AddRange(_task.Data.Employees.ToArray());
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
                _task.Data.Employees.Add(selected);
                _taskService.AddEmployee(_task.Data, selected);
                LoadData();
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
                _task.Data.Employees.Remove(selected);
                _taskService.RemoveEmployee(_task.Data, selected);
                LoadData();

            }
        }

        void SetState(TaskStateBaseNames taskStateNames)
        {
            switch (taskStateNames)
            {
                case TaskStateBaseNames.ToDo:
                    rdBtnTodo.Checked = true;
                    break;
                case TaskStateBaseNames.Doing:
                    rdBtnDoing.Checked = true;
                    break;
                case TaskStateBaseNames.Done:
                    rdBtnDone.Checked = true;
                    break;
            }
        }

        private void BtnUpdateTask_Click(object sender, System.EventArgs e)
        {
            _task.Data.Details = rctDetails.Text;
            _task.Data.Notes = rctNotes.Text;
            _taskService.Update(_task.Data);

            var form = AppHelper.GetCurrentForm<MainForm>();
            TaskDetails taskDetails = new TaskDetails(_taskId);
            this.Close();
            form.LoadData();
            taskDetails.Show();
        }

        private void OnCheckedChanged(object sender, System.EventArgs e)
        {
            var selected = (MetroRadioButton)sender;
            if (selected.Text == "To Do" && selected.Checked)
            {
                _task.Data.TaskState = new TaskState { Id = (int)TaskStateBaseNames.ToDo };
                _task.Data.TaskStateId = (int)TaskStateBaseNames.ToDo;
            }
            else if (selected.Text == "Doing" && selected.Checked)
            {
                _task.Data.TaskState = new TaskState { Id = (int)TaskStateBaseNames.Doing };
                _task.Data.TaskStateId = (int)TaskStateBaseNames.Doing;
            }
            else if (selected.Text == "Done" && selected.Checked)
            {
                _task.Data.TaskState = new TaskState { Id = (int)TaskStateBaseNames.Done };
                _task.Data.TaskStateId = (int)TaskStateBaseNames.Done;
            }
        }
    }
}
