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
    public partial class CreateProject : MetroForm
    {
        private IProjectService _projectService;
        private IBusinessHelper _businessHelper;
        public CreateProject()
        {
            _businessHelper = DI.GetService<IBusinessHelper>();
            _projectService = DI.GetService<IProjectService>();
            InitializeComponent();

        }


        private void BtnCreateProject_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProjectName.Text))
            {
                Project project = new Project();
                project.Name = txtProjectName.Text;
                AppHelper.ValidationHandling(() =>
                {
                    var dataResult = _projectService.Add(project);
                    Session.SetCurrentProject(dataResult.Data);

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
                    this.Close();
                    AppHelper.GetCurrentForm<SelectProject>().ProjectFill();
                });



            }
            else
            {
                MessageBox.Show("missing information, please check.");
            }
        }
    }
}
