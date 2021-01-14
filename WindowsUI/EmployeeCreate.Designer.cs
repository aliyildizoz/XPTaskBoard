
namespace WindowsUI
{
    partial class EmployeeCreate
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
            this.txtLastName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtFirstName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnCreateEmployee = new MetroFramework.Controls.MetroButton();
            this.EmployeeList = new MetroFramework.Controls.MetroListView();
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnEditEmployee = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Depth = 0;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastName.Hint = "";
            this.txtLastName.Location = new System.Drawing.Point(96, 231);
            this.txtLastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PasswordChar = '\0';
            this.txtLastName.SelectedText = "";
            this.txtLastName.SelectionLength = 0;
            this.txtLastName.SelectionStart = 0;
            this.txtLastName.Size = new System.Drawing.Size(185, 23);
            this.txtLastName.TabIndex = 38;
            this.txtLastName.UseSystemPasswordChar = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(20, 231);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(68, 19);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "Last name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Depth = 0;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirstName.Hint = "";
            this.txtFirstName.Location = new System.Drawing.Point(96, 182);
            this.txtFirstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PasswordChar = '\0';
            this.txtFirstName.SelectedText = "";
            this.txtFirstName.SelectionLength = 0;
            this.txtFirstName.SelectionStart = 0;
            this.txtFirstName.Size = new System.Drawing.Size(185, 23);
            this.txtFirstName.TabIndex = 36;
            this.txtFirstName.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 182);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "First name";
            // 
            // BtnCreateEmployee
            // 
            this.BtnCreateEmployee.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnCreateEmployee.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnCreateEmployee.Highlight = true;
            this.BtnCreateEmployee.Location = new System.Drawing.Point(120, 278);
            this.BtnCreateEmployee.Name = "BtnCreateEmployee";
            this.BtnCreateEmployee.Size = new System.Drawing.Size(141, 43);
            this.BtnCreateEmployee.TabIndex = 34;
            this.BtnCreateEmployee.Text = "Create";
            this.BtnCreateEmployee.UseSelectable = true;
            this.BtnCreateEmployee.Click += new System.EventHandler(this.BtnCreateEmployee_Click);
            // 
            // EmployeeList
            // 
            this.EmployeeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.firstName,
            this.lastName});
            this.EmployeeList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.EmployeeList.FullRowSelect = true;
            this.EmployeeList.Location = new System.Drawing.Point(312, 103);
            this.EmployeeList.MultiSelect = false;
            this.EmployeeList.Name = "EmployeeList";
            this.EmployeeList.OwnerDraw = true;
            this.EmployeeList.Size = new System.Drawing.Size(216, 273);
            this.EmployeeList.TabIndex = 33;
            this.EmployeeList.UseCompatibleStateImageBehavior = false;
            this.EmployeeList.UseSelectable = true;
            this.EmployeeList.View = System.Windows.Forms.View.Details;
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
            // BtnEditEmployee
            // 
            this.BtnEditEmployee.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnEditEmployee.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnEditEmployee.Highlight = true;
            this.BtnEditEmployee.Location = new System.Drawing.Point(352, 384);
            this.BtnEditEmployee.Name = "BtnEditEmployee";
            this.BtnEditEmployee.Size = new System.Drawing.Size(141, 43);
            this.BtnEditEmployee.TabIndex = 34;
            this.BtnEditEmployee.Text = "Edit";
            this.BtnEditEmployee.UseSelectable = true;
            this.BtnEditEmployee.Click += new System.EventHandler(this.BtnEditEmployee_Click);
            // 
            // EmployeeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnEditEmployee);
            this.Controls.Add(this.BtnCreateEmployee);
            this.Controls.Add(this.EmployeeList);
            this.Name = "EmployeeCreate";
            this.Text = "EmployeeCreate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtLastName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFirstName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnCreateEmployee;
        private MetroFramework.Controls.MetroListView EmployeeList;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private MetroFramework.Controls.MetroButton BtnEditEmployee;
    }
}