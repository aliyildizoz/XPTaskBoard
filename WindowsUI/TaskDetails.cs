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
using Business.Utilities;
using Entities;
using MetroFramework;
using Task = Entities.Task;

namespace WindowsUI
{
    public partial class TaskDetails : MetroFramework.Forms.MetroForm
    {
        private ITaskService _taskService;
        private IEmployeeService _employeeService;
        private int _taskId;
        private IDataResult<Task> _task;
        public TaskDetails(int taskId = 0)
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

        private void DoneDateLoad()
        {
            var result = DI.GetService<IBusinessHelper>().DoneDate(Session.CurrentProject.Id, _taskId);
            this.lblEndDate.Visible = result.IsSuccessful;
            this.materialLabel7.Visible = result.IsSuccessful;
            this.lblEndDate.Text = result.Data.ToString("dd.MM.yyyy");
        }
        private void LoadData(int taskId)
        {
            
            CmbEmployeeList.Items.Clear();
            var emp = _employeeService.GetList().Data;
            _task = _taskService.GetByIdWithTaskTracks(taskId);

            if (_task.IsSuccessful)
            {
                lblCreatedDate.Text = _task.Data.CreateDate.ToString("dd.MM.yyyy");
                lblEstimatedDate.Text = _task.Data.EstimatedDate.ToString("dd.MM.yyyy");
                pnlDetail.Text = _task.Data.Details;
                pnlNotes.Text = _task.Data.Notes;
                CmbEmployeeList.Items.Clear();
                lblCurrentState.Text = _task.Data.TaskState.Name;
                foreach (var employee in emp)
                {
                    if (_task.Data.Employees.FirstOrDefault(employee1 => employee1.Id == employee.Id) == null)
                    {
                        CmbEmployeeList.Items.Add(employee);
                    }
                }

                lstMembers.Items.Clear();
                lstMembers.Items.AddRange(_task.Data.Employees.ToArray());
                LoadEvents();
                DoneDateLoad();
            }

        }
        private void LoadData()
        {
            CmbEmployeeList.Items.Clear();
            var emp = _employeeService.GetList().Data;
            if (_task.IsSuccessful)
            {
                lblCreatedDate.Text = _task.Data.CreateDate.ToString("dd.MM.yyyy");
                lblEstimatedDate.Text = _task.Data.EstimatedDate.ToString("dd.MM.yyyy");
                pnlDetail.Text = _task.Data.Details;
                pnlNotes.Text = _task.Data.Notes;
                CmbEmployeeList.Items.Clear();
                lblCurrentState.Text = _task.Data.TaskState.Name;
                foreach (var employee in emp)
                {
                    if (_task.Data.Employees.FirstOrDefault(employee1 => employee1.Id == employee.Id) == null)
                    {
                        CmbEmployeeList.Items.Add(employee);
                    }
                }

                lstMembers.Items.Clear();
                lstMembers.Items.AddRange(_task.Data.Employees.ToArray());
                LoadEvents();
            }

        }

        void LoadEvents()
        {
            lstViewEvents.Items.Clear();
            _task = _taskService.GetByIdWithTaskTracks(_taskId);
            var list = _task.Data.TaskTracks.OrderByDescending(track => track.CreateDate).ToList();
            if (list.Count > 0)
            {
                foreach (var taskTrack in list)
                {
                    var item = new ListViewItem(new string[] { taskTrack.TaskState.ToString(), taskTrack.EventDescription,taskTrack.CreateDate.ToString("dd.MM.yyyy - HH:mm")
                })
                    {
                        BackColor = AppHelper.GetStateColor(taskTrack.EventDescription),
                        Font = new Font(FontFamily.GenericSansSerif, 10)
                    };

                    lstViewEvents.Items.Add(item);
                }
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

        private void bunifuImageButton1_Click(object sender, System.EventArgs e)
        {
            TaskEdit edit = new TaskEdit(_taskId);
            this.Hide();
            edit.Show();
        }

        private void btnDeleteTask_Click(object sender, System.EventArgs e)
        {
            if (_task.IsSuccessful)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to delete the selected employee ?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _taskService.Delete(_task.Data.Id);

                    this.Close();
                    AppHelper.FocusMainForm();
                }
            }
            else
            {
                MessageBox.Show("Select an employee.");
            }
        }
    }
}
