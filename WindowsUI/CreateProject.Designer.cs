
namespace WindowsUI
{
    partial class CreateProject
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
            this.BtnCreateProject = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtProjectName
            // 
            this.txtProjectName.Depth = 0;
            this.txtProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProjectName.Hint = "";
            this.txtProjectName.Location = new System.Drawing.Point(146, 84);
            this.txtProjectName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.PasswordChar = '\0';
            this.txtProjectName.SelectedText = "";
            this.txtProjectName.SelectionLength = 0;
            this.txtProjectName.SelectionStart = 0;
            this.txtProjectName.Size = new System.Drawing.Size(185, 23);
            this.txtProjectName.TabIndex = 46;
            this.txtProjectName.UseSystemPasswordChar = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(70, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 45;
            this.metroLabel1.Text = "Name";
            // 
            // BtnCreateProject
            // 
            this.BtnCreateProject.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnCreateProject.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnCreateProject.Highlight = true;
            this.BtnCreateProject.Location = new System.Drawing.Point(165, 130);
            this.BtnCreateProject.Name = "BtnCreateProject";
            this.BtnCreateProject.Size = new System.Drawing.Size(141, 43);
            this.BtnCreateProject.TabIndex = 44;
            this.BtnCreateProject.Text = "Create";
            this.BtnCreateProject.UseSelectable = true;
            this.BtnCreateProject.Click += new System.EventHandler(this.BtnCreateProject_Click);
            // 
            // CreateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 228);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnCreateProject);
            this.Name = "CreateProject";
            this.Text = "Create Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtProjectName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnCreateProject;
    }
}