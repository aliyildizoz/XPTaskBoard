
namespace WindowsUI
{
    partial class EmployeeEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EmployeeList = new MetroFramework.Controls.MetroListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnUpdateEmployee = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.BtnDeleteEmployee = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtSearch
            // 
            this.TxtSearch.Depth = 0;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Hint = "";
            this.TxtSearch.Location = new System.Drawing.Point(360, 81);
            this.TxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.Size = new System.Drawing.Size(185, 23);
            this.TxtSearch.TabIndex = 11;
            this.TxtSearch.Text = "Search";
            this.TxtSearch.UseSystemPasswordChar = false;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // EmployeeList
            // 
            this.EmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName});
            this.EmployeeList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmployeeList.FullRowSelect = true;
            this.EmployeeList.Location = new System.Drawing.Point(345, 111);
            this.EmployeeList.MultiSelect = false;
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.OwnerDraw = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 273);
            this.EmployeeList.TabIndex = 13;
            this.EmployeeList.UseCompatibleStateImageBehavior = false;
            this.EmployeeList.UseSelectable = true;
            this.EmployeeList.View = System.Windows.Forms.View.Details;
            this.EmployeeList.SelectedIndexChanged += new System.EventHandler(this.EmployeeList_SelectedIndexChanged);
            // 
            // firstName
            // 
            this.firstName.Text = "First name";
            this.firstName.Width = 100;
            // 
            // lastName
            // 
            this.lastName.Text = "Last name";
            this.lastName.Width = 100;
            // 
            // BtnUpdateEmployee
            // 
            this.BtnUpdateEmployee.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnUpdateEmployee.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnUpdateEmployee.Highlight = true;
            this.BtnUpdateEmployee.Location = new System.Drawing.Point(147, 302);
            this.BtnUpdateEmployee.Name = "BtnUpdateEmployee";
            this.BtnUpdateEmployee.Size = new System.Drawing.Size(141, 43);
            this.BtnUpdateEmployee.TabIndex = 27;
            this.BtnUpdateEmployee.Text = "Save";
            this.BtnUpdateEmployee.UseSelectable = true;
            this.BtnUpdateEmployee.Click += new System.EventHandler(this.BtnUpdateEmployee_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(53, 190);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(129, 190);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(185, 23);
            this.txtFirstName.TabIndex = 29;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Hint = "";
            this.txtLastName.Location = new System.Drawing.Point(129, 239);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(185, 23);
            this.txtLastName.TabIndex = 31;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(53, 239);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Last name";
            // 
            // BtnDeleteEmployee
            // 
            this.BtnDeleteEmployee.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDeleteEmployee.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDeleteEmployee.Highlight = true;
            this.BtnDeleteEmployee.Location = new System.Drawing.Point(381, 404);
            this.BtnDeleteEmployee.Name = "BtnDeleteEmployee";
            this.BtnDeleteEmployee.Size = new System.Drawing.Size(141, 43);
            this.BtnDeleteEmployee.TabIndex = 27;
            this.BtnDeleteEmployee.Text = "Delete";
            this.BtnDeleteEmployee.UseSelectable = true;
            this.BtnDeleteEmployee.Click += new System.EventHandler(this.BtnDeleteEmployee_Click);
            // 
            // EmployeeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 470);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnDeleteEmployee);
            this.Controls.Add(this.BtnUpdateEmployee);
            this.Controls.Add(this.EmployeeList);
            this.Controls.Add(this.TxtSearch);
            this.Name = "EmployeeEdit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSearch;
        private MetroFramework.Controls.MetroListView EmployeeList;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private MetroFramework.Controls.MetroButton BtnUpdateEmployee;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton BtnDeleteEmployee;
    }
}