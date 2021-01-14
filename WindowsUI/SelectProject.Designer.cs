
namespace WindowsUI
{
    partial class SelectProject
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
            this.CmbProjects = new MetroFramework.Controls.MetroComboBox();
            this.BtnSelect = new MetroFramework.Controls.MetroButton();
            this.BtnCreate = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // CmbProjects
            // 
            this.CmbProjects.FormattingEnabled = true;
            this.CmbProjects.ItemHeight = 23;
            this.CmbProjects.Location = new System.Drawing.Point(23, 102);
            this.CmbProjects.Name = "CmbProjects";
            this.CmbProjects.Size = new System.Drawing.Size(222, 29);
            this.CmbProjects.TabIndex = 7;
            this.CmbProjects.UseSelectable = true;
            // 
            // BtnSelect
            // 
            this.BtnSelect.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnSelect.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnSelect.Highlight = true;
            this.BtnSelect.Location = new System.Drawing.Point(251, 102);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(143, 29);
            this.BtnSelect.TabIndex = 45;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseSelectable = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnCreate.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnCreate.Highlight = true;
            this.BtnCreate.Location = new System.Drawing.Point(249, 137);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(145, 29);
            this.BtnCreate.TabIndex = 46;
            this.BtnCreate.Text = "Create a project";
            this.BtnCreate.UseSelectable = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 189);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnSelect);
            this.Controls.Add(this.CmbProjects);
            this.Name = "SelectProject";
            this.Text = "Select a project";
            this.Click += new System.EventHandler(this.BtnSelect_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox CmbProjects;
        private MetroFramework.Controls.MetroButton BtnSelect;
        private MetroFramework.Controls.MetroButton BtnCreate;
    }
}