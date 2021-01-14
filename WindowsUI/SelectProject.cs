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
using Entities;

namespace WindowsUI
{
    public partial class SelectProject : MetroFramework.Forms.MetroForm
    {
        private IProjectService _projectService;
        public SelectProject()
        {
            InitializeComponent();

            _projectService = DI.GetService<IProjectService>();
            ProjectFill();
            this.Closing += OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            var form = AppHelper.GetCurrentForm<MainForm>();
            if (form != null)
            {
                e.Cancel = true;
                this.Hide();
                AppHelper.FocusMainForm();
            }
            else
            {
                e.Cancel = false;
            }

        }

        public void ProjectFill()
        {
            CmbProjects.Items.Clear();
            CmbProjects.Items.AddRange(_projectService.GetList().Data.ToArray());
        }
        private void BtnSelect_Click(object sender, System.EventArgs e)
        {
            var selected = (Project)CmbProjects.SelectedItem;
            if (selected != null)
            {
                Session.SetCurrentProject(selected);
                this.Hide();
                var mainForm = AppHelper.GetCurrentForm<MainForm>();
                if (mainForm != null)
                {
                    mainForm.Close();
                }
                MainForm form = new MainForm();
                form.Focus();
                form.Focus();
                form.Focus();
                form.Show();

            }
            else
            {
                MessageBox.Show("Choose a project.");
            }
        }

        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            CreateProject project = new CreateProject();
            project.Show();
            this.Hide();
        }
    }
}
