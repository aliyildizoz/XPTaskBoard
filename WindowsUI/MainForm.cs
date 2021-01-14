using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI.EventArgs;
using WindowsUI.UserControls;
using WindowsUI.Utilities;
using Autofac;
using Business.Abstract;
using Business.DIResolvers;
using Entities;
using MaterialSkin.Controls;
using Task = Entities.Task;

namespace WindowsUI
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private IEmployeeService _employeeService;
        private ITaskService _taskService;
        private IProjectService _projectService;
        public MainForm()
        {
            _employeeService = DI.GetService<IEmployeeService>();
            _projectService = DI.GetService<IProjectService>();
            _taskService = DI.GetService<ITaskService>();
            InitializeComponent();
            this.Closed += OnClosed;
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        public void LoadData()
        {
            pnlDoing.Controls.Clear();
            pnlToDo.Controls.Clear();
            pnlDone.Controls.Clear();
            List<Entities.Task> todoList = _taskService.GetToDoList(Session.CurrentProject.Id).Data;
            List<Entities.Task> doingList = _taskService.GetDoingList(Session.CurrentProject.Id).Data;
            List<Entities.Task> doneList = _taskService.GetDoneList(Session.CurrentProject.Id).Data;

            this.Text = Session.CurrentProject.Name + " - Task Board";

            if (todoList.Count > 0)
            {
                for (int i = 1; i < todoList.Count + 1; i++)
                {
                    Task task = todoList[i - 1];
                    TaskCard card = new TaskCard()
                    {
                        Details = task.Details,
                        TaskStateNames = TaskStateBaseNames.ToDo,
                        TaskId = task.Id,
                        CreatedDate = task.CreateDate,
                        Top = i != 1 ? 143 * (i - 1) : 5,
                        Left = 15
                    };
                    card.ChangeState += OnChangeState;
                    this.pnlToDo.Controls.Add(card);
                }
            }

            if (doingList.Count > 0)
            {
                for (int i = 1; i < doingList.Count + 1; i++)
                {
                    Task task = doingList[i - 1];
                    TaskCard card = new TaskCard()
                    {
                        Details = task.Details,
                        TaskStateNames = TaskStateBaseNames.Doing,
                        TaskId = task.Id,
                        CreatedDate = task.CreateDate,
                        Top = i != 1 ? 143 * (i - 1) : 5,
                        Left = 15
                    };
                    card.ChangeState += OnChangeState;
                    this.pnlDoing.Controls.Add(card);
                }
            }

            if (doneList.Count > 0)
            {
                for (int i = 1; i < doneList.Count + 1; i++)
                {
                    Task task = doneList[i - 1];
                    TaskCard card = new TaskCard()
                    {
                        Details = task.Details,
                        TaskStateNames = TaskStateBaseNames.Done,
                        TaskId = task.Id,
                        CreatedDate = task.CreateDate,
                        Top = i != 1 ? 143 * (i - 1) : 5,
                        Left = 15
                    };
                    card.ChangeState += OnChangeState;
                    this.pnlDone.Controls.Add(card);
                }
            }

            LoadEvents();
        }

        private void LoadEvents()
        {
            eventList.Items.Clear();
            var list = _taskService.GetTracks(Session.CurrentProject.Id);
            if (list.Data.Count > 0)
            {
                foreach (var taskTrack in list.Data)
                {
                    var item = new ListViewItem(new string[] { taskTrack.TaskState.ToString(), taskTrack.EventDescription,taskTrack.CreateDate.ToString("dd.MM.yyyy - HH:mm")
                    })
                    {
                        BackColor = AppHelper.GetStateColor(taskTrack.EventDescription),
                        Tag = taskTrack.Task,
                        Font = new Font(FontFamily.GenericSansSerif, 12)
                    };

                    eventList.Items.Add(item);
                }
            }

        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            LoadData();
        }
        private void OnChangeState(object sender, ChangeStateEventArgs args)
        {
            var selected = (TaskStateBaseNames)sender;
            _taskService.UpdateState(args.TaskId, selected);
            LoadData();
        }

        private void BtnCreateTask_Click(object sender, System.EventArgs e)
        {
            TaskCreate taskCreate = new TaskCreate();
            taskCreate.Show();
        }

        private void addEmployee_Click(object sender, System.EventArgs e)
        {
            EmployeeCreate create = new EmployeeCreate();
            create.Show();
        }

        private void editEmployee_Click(object sender, System.EventArgs e)
        {
            EmployeeEdit edit = new EmployeeEdit();
            edit.Show();
        }

        private void newProject_Click(object sender, System.EventArgs e)
        {
            CreateProject project = new CreateProject();
            project.Show();
        }

        private void selectProject_Click(object sender, System.EventArgs e)
        {
            var project = AppHelper.GetCurrentForm<SelectProject>();
            project.ProjectFill();
            project.Show();
        }

        private void editProject_Click(object sender, System.EventArgs e)
        {
            EditProject project = new EditProject();
            project.Show();
        }

        private void eventList_DoubleClick(object sender, System.EventArgs e)
        {
            var selected = eventList.SelectedItems;
            if (selected.Count != 0)
            {
                var task = (Task)selected[0].Tag;
                TaskDetails details = new TaskDetails(task.Id);
                details.Show();
            }
        }
    }
}
