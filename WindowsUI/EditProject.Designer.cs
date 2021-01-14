
namespace WindowsUI
{
    partial class EditProject
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
            this.txtProjectName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnEditProject = new MetroFramework.Controls.MetroButton();
            this.ProjectList = new MetroFramework.Controls.MetroListView();
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TxtSearch = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnDeleteProject = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjectName.Hint = "";
            this.txtProjectName.Location = new System.Drawing.Point(98, 194);
            this.txtProjectName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.Size = new System.Drawing.Size(185, 23);
            this.txtProjectName.TabIndex = 43;
            this.txtProjectName.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(22, 194);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 42;
            this.metroLabel1.Text = "Name";
            // 
            // BtnEditProject
            // 
            this.BtnEditProject.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnEditProject.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnEditProject.Highlight = true;
            this.BtnEditProject.Location = new System.Drawing.Point(113, 261);
            this.BtnEditProject.Name = "BtnEditProject";
            this.BtnEditProject.Size = new System.Drawing.Size(141, 43);
            this.BtnEditProject.TabIndex = 40;
            this.BtnEditProject.Text = "Edit";
            this.BtnEditProject.UseSelectable = true;
            this.BtnEditProject.Click += new System.EventHandler(this.BtnEditProject_Click);
            // 
            // ProjectList
            // 
            this.ProjectList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectName});
            this.ProjectList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProjectList.FullRowSelect = true;
            this.ProjectList.Location = new System.Drawing.Point(314, 115);
            this.ProjectList.MultiSelect = false;
            this.ProjectList.Name = "ProjectList";
            this.ProjectList.OwnerDraw = true;
            this.ProjectList.Size = new System.Drawing.Size(216, 273);
            this.ProjectList.TabIndex = 39;
            this.ProjectList.UseCompatibleStateImageBehavior = false;
            this.ProjectList.UseSelectable = true;
            this.ProjectList.View = System.Windows.Forms.View.Details;
            this.ProjectList.SelectedIndexChanged += new System.EventHandler(this.ProjectList_SelectedIndexChanged);
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "Project name";
            this.ProjectName.Width = 211;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Depth = 0;
            this.TxtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSearch.Hint = "";
            this.TxtSearch.Location = new System.Drawing.Point(326, 86);
            this.TxtSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.PasswordChar = '\0';
            this.TxtSearch.SelectedText = "";
            this.TxtSearch.SelectionLength = 0;
            this.TxtSearch.SelectionStart = 0;
            this.TxtSearch.Size = new System.Drawing.Size(185, 23);
            this.TxtSearch.TabIndex = 44;
            this.TxtSearch.Text = "Search";
            this.TxtSearch.UseSystemPasswordChar = false;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // BtnDeleteProject
            // 
            this.BtnDeleteProject.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnDeleteProject.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnDeleteProject.Highlight = true;
            this.BtnDeleteProject.Location = new System.Drawing.Point(351, 403);
            this.BtnDeleteProject.Name = "BtnDeleteProject";
            this.BtnDeleteProject.Size = new System.Drawing.Size(141, 43);
            this.BtnDeleteProject.TabIndex = 40;
            this.BtnDeleteProject.Text = "Delete";
            this.BtnDeleteProject.UseSelectable = true;
            this.BtnDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 469);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnDeleteProject);
            this.Controls.Add(this.BtnEditProject);
            this.Controls.Add(this.ProjectList);
            this.Name = "EditProject";
            this.Text = "EditProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnEditProject;
        private MetroFramework.Controls.MetroListView ProjectList;
        private System.Windows.Forms.ColumnHeader ProjectName;
        private MaterialSkin.Controls.MaterialSingleLineTextField TxtSearch;
        private MetroFramework.Controls.MetroButton BtnDeleteProject;
    }
}