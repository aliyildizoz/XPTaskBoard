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
    public partial class EmployeeCreate : MetroFramework.Forms.MetroForm
    {
        private IEmployeeService _employeeService;
        public EmployeeCreate()
        {
            InitializeComponent();
            _employeeService = DI.GetService<IEmployeeService>();
            EmployeeListFill();
            this.Closed += OnClosed;
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            AppHelper.FocusMainForm();
        }
        public void EmployeeListFill()
        {
            EmployeeList.Items.Clear();
            var employees = _employeeService.GetList().Data;

            foreach (var employee in employees)
            {
                var item = new ListViewItem(new string[] { employee.FirstName, employee.LastName })
                {
                    Tag = employee,
                    ToolTipText = employee.ToString()
                };

                EmployeeList.Items.Add(item);
            }
        }

        private void BtnEditEmployee_Click(object sender, System.EventArgs e)
        {
            EmployeeEdit employeeEdit = new EmployeeEdit();
            employeeEdit.Show();
            this.Close();
        }

        private void BtnCreateEmployee_Click(object sender, System.EventArgs e)
        {
            Employee employee = new Employee();
            employee.FirstName = txtFirstName.Text.Trim();
            employee.LastName = txtLastName.Text.Trim();
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("missing information, please check.");
            }
            else
            {
                _employeeService.Add(employee);
                EmployeeListFill();
            }
        }
    }
}
