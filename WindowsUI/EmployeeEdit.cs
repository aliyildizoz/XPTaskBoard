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
    public partial class EmployeeEdit : MetroFramework.Forms.MetroForm
    {
        private IEmployeeService _employeeService;
        public EmployeeEdit()
        {
            InitializeComponent();
            _employeeService = DI.GetService<IEmployeeService>();
            EmployeeListFill(_employeeService.GetList().Data);
            TxtSearch.GotFocus += RemoveText;
            TxtSearch.LostFocus += AddText;
            this.Closed += OnClosed;
        }

        private void OnClosed(object sender, System.EventArgs e)
        {
            AppHelper.GetCurrentForm<MainForm>().LoadData();
            AppHelper.FocusMainForm();
        }
        private void TxtSearch_TextChanged(object sender, System.EventArgs e)
        {
            var search = TxtSearch.Text;
            List<Employee> employees;
            if (!string.IsNullOrEmpty(search) && !search.StartsWith(" "))
            {
                employees = _employeeService.Search(search).Data;
                EmployeeListFill(employees);
            }
            else
            {
                EmployeeListFill();
            }

        }

        public void EmployeeListFill(List<Employee> employees = null)
        {
            EmployeeList.Items.Clear();
            txtFirstName.Text = "";
            txtLastName.Text = "";
            if (employees == null)
            {
                employees = _employeeService.GetList().Data;
            }

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

        public void RemoveText(object sender, System.EventArgs e)
        {
            if (TxtSearch.Text == "Search")
            {
                TxtSearch.Text = "";
            }

            EmployeeListFill();
            ListViewItem item = new ListViewItem("");
        }

        public void AddText(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtSearch.Text))
                TxtSearch.Text = "Search";
            EmployeeListFill();
        }


        private void EmployeeList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = EmployeeList.SelectedItems;
            if (selected.Count != 0)
            {
                var employee = (Employee)selected[0].Tag;

                txtFirstName.Text = employee.FirstName;
                txtLastName.Text = employee.LastName;
            }
        }

        private void BtnUpdateEmployee_Click(object sender, System.EventArgs e)
        {
            var selected = EmployeeList.SelectedItems;
            if (selected.Count != 0)
            {
                var employee = (Employee)selected[0].Tag;
                if ((txtFirstName.Text != employee.FirstName || txtLastName.Text != employee.LastName) && !(string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtFirstName.Text)))
                {
                    employee.LastName = txtLastName.Text;
                    employee.FirstName = txtFirstName.Text;
                    _employeeService.Update(employee);
                    EmployeeListFill();
                }
                else
                {
                    MessageBox.Show("Missing information or unchanged information, please check.");
                }

            }
            else
            {
                MessageBox.Show("Select an employee.");
            }
        }

        private void BtnDeleteEmployee_Click(object sender, System.EventArgs e)
        {
            var selected = EmployeeList.SelectedItems;
            if (selected.Count != 0)
            {
                var employee = (Employee)selected[0].Tag;
                var dialogResult = MessageBox.Show("Are you sure you want to delete the selected employee ?", "Warning", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    _employeeService.Delete(employee.Id);
                }
                EmployeeListFill();
            }
            else
            {
                MessageBox.Show("Select an employee.");
            }
        }
    }
}
