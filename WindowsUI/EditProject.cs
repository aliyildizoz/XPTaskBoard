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
using DevExpress.Utils.Extensions;
using Entities;
using MetroFramework.Forms;

namespace WindowsUI
{
    public partial class EditProject : MetroForm
    {

        private IProjectService _projectService;
        private IBusinessHelper _businessHelper;

        public EditProject()
        {
            _businessHelper = DI.GetService<IBusinessHelper>();
            InitializeComponent();
            _projectService = DI.GetService<IProjectService>();
            ProjectListFill(_projectService.GetList().Data);
            TxtSearch.GotFocus += RemoveText;
            TxtSearch.LostFocus += AddText;
            this.Closed += OnClosed;
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            AppHelper.FocusMainForm();
        }


        private void TxtSearch_TextChanged(object sender, System.EventArgs e)
        {
            var search = TxtSearch.Text;
            List<Project> projects;
            if (!string.IsNullOrEmpty(search) && !search.StartsWith(" "))
            {
                projects = _projectService.Search(search).Data;
                ProjectListFill(projects);
            }
            else
            {
                ProjectListFill();
            }

        }

        public void ProjectListFill(List<Project> projects = null)
        {
            ProjectList.Items.Clear();
            txtProjectName.Text = "";
            if (projects == null)
            {
                projects = _projectService.GetList().Data;
            }

            foreach (var project in projects)
            {
                var item = new ListViewItem(new string[] { project.Name })
                {
                    Tag = project,
                    ToolTipText = project.ToString(),
                    Selected = project.Id == Session.CurrentProject.Id
                };

                ProjectList.Items.Add(item);
            }
        }

        public void RemoveText(object sender, System.EventArgs e)
        {
            if (TxtSearch.Text == "Search")
            {
                TxtSearch.Text = "";
            }

            ProjectListFill();
            ListViewItem item = new ListViewItem("");
        }

        public void AddText(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
                TxtSearch.Text = "Search";
            ProjectListFill();
        }

        private void BtnEditProject_Click(object sender, System.EventArgs e)
        {
            var selected = ProjectList.SelectedItems;
            if (selected.Count != 0)
            {
                var project = (Project)selected[0].Tag;

                if (txtProjectName.Text != project.Name && !string.IsNullOrEmpty(txtProjectName.Text))
                {
                    project.Name = txtProjectName.Text;

                    AppHelper.ValidationHandling(() =>
                    {
                        _projectService.Update(project);
                        if (Session.CurrentProject.Id == project.Id)
                        {
                            Session.CurrentProject.Name = project.Name;
                            var mainForm = AppHelper.GetCurrentForm<MainForm>();
                            mainForm.Close();
                            MainForm form = new MainForm();
                            form.Show();
                            this.Close();
                        }
                        ProjectListFill();
                    });

                }
                else
                {
                    MessageBox.Show("Missing information or unchanged information, please check.");
                }
            }
            else
            {
                MessageBox.Show("Select a project.");
            }
        }

        private void BtnDeleteProject_Click(object sender, System.EventArgs e)
        {
            var selected = ProjectList.SelectedItems;
            if (selected.Count != 0)
            {
                var project = (Project)selected[0].Tag;
                var dialogResult = MessageBox.Show("Are you sure you want to delete the selected project ?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _projectService.Delete(project.Id);
                    if (Session.CurrentProject.Id == project.Id)
                    {
                        Session.CurrentProject.Name = project.Name;
                        var mainForm = AppHelper.GetCurrentForm<MainForm>();
                        mainForm.Close();
                        this.Close();
                        var selectProject = AppHelper.GetCurrentForm<SelectProject>();
                        selectProject.ProjectFill();
                        selectProject.Show();
                    }
                    else
                    {
                        ProjectListFill();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a project.");
            }
        }

        private void ProjectList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = ProjectList.SelectedItems;
            if (selected.Count != 0)
            {
                var project = (Project)selected[0].Tag;

                txtProjectName.Text = project.Name;
            }
        }
    }
}
