using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsUI.EventArgs;
using Entities;
using MaterialSkin.Controls;
using MetroFramework.Controls;

namespace WindowsUI.UserControls
{
    public partial class TaskCard : UserControl
    {
        private TaskStateBaseNames _taskStateNames;
        private string _details;
        private DateTime _createdDate;
        private bool firstInitial = false;
        public TaskCard()
        {
            InitializeComponent();
        }


        public TaskStateBaseNames TaskStateNames
        {
            get
            {
                return _taskStateNames;
            }
            set
            {
                SetColor(value);

                _taskStateNames = value;
            }
        }

        public int TaskId { get; set; }
        private void SetColor(TaskStateBaseNames taskStateNames)
        {
            switch (taskStateNames)
            {
                case TaskStateBaseNames.ToDo:
                    bar.BackColor = Color.Red;
                    firstInitial = true;
                    rdBtnTodo.Checked = true;
                    break;
                case TaskStateBaseNames.Doing:
                    bar.BackColor = Color.Yellow;
                    firstInitial = true;
                    rdBtnDoing.Checked = true;
                    break;
                case TaskStateBaseNames.Done:
                    bar.BackColor = Color.LawnGreen;
                    firstInitial = true;
                    rdBtnDone.Checked = true;
                    break;
                case TaskStateBaseNames.Default:
                    bar.BackColor = Color.MediumPurple;
                    break;
                default:
                    bar.BackColor = Color.MediumPurple;
                    break;
            }

        }
        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                if (value.Length > 90)
                {
                    value = value.Substring(0, 80) + "...";
                }

                pnlDetails.Text = value;
                _details = value;
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                lblCreatedDate.Text = value.ToString("dd.MM.yyyy");
                _createdDate = value;
            }
        }

        public event EventHandler<ChangeStateEventArgs> ChangeState;
        private void btnDetail_Click(object sender, System.EventArgs e)
        {
            TaskDetails details = new TaskDetails(TaskId);
            details.Show();
        }

        protected virtual void OnChangeState(object sender, System.EventArgs e)
        {
            if (!firstInitial)
            {
                var selected = (MetroRadioButton)sender;
                var isInvoke = false;
                if (selected.Text == "To Do" && selected.Checked)
                {
                    _taskStateNames = TaskStateBaseNames.ToDo;
                    isInvoke = true;
                }
                else if (selected.Text == "Doing" && selected.Checked)
                {
                    _taskStateNames = TaskStateBaseNames.Doing;
                    isInvoke = true;
                }
                else if (selected.Text == "Done" && selected.Checked)
                {
                    _taskStateNames = TaskStateBaseNames.Done;
                    isInvoke = true;
                }

                if (isInvoke)
                {
                    ChangeState?.Invoke(_taskStateNames, new ChangeStateEventArgs(TaskId));
                }
            }
            else
            {
                firstInitial = false;
            }

        }
    }
}
