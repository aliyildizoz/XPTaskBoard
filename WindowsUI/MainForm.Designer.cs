
namespace WindowsUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.editProject = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnCreateTask = new MetroFramework.Controls.MetroTile();
            this.eventList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDoing = new MetroFramework.Controls.MetroPanel();
            this.pnlToDo = new MetroFramework.Controls.MetroPanel();
            this.pnlDone = new MetroFramework.Controls.MetroPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1880, 975);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip);
            this.panel2.Controls.Add(this.BtnCreateTask);
            this.panel2.Controls.Add(this.eventList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1122, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 1000);
            this.panel2.TabIndex = 6;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(778, 33);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProject,
            this.toolStripSeparator1,
            this.selectProject,
            this.toolStripSeparator2,
            this.editProject});
            this.projectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projectToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(83, 29);
            this.projectToolStripMenuItem.Text = "Project";
            // 
            // newProject
            // 
            this.newProject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newProject.Image = ((System.Drawing.Image)(resources.GetObject("newProject.Image")));
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(172, 24);
            this.newProject.Text = "New project";
            this.newProject.Click += new System.EventHandler(this.newProject_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // selectProject
            // 
            this.selectProject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectProject.Image = ((System.Drawing.Image)(resources.GetObject("selectProject.Image")));
            this.selectProject.Name = "selectProject";
            this.selectProject.Size = new System.Drawing.Size(172, 24);
            this.selectProject.Text = "Select project";
            this.selectProject.Click += new System.EventHandler(this.selectProject_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // editProject
            // 
            this.editProject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editProject.Image = ((System.Drawing.Image)(resources.GetObject("editProject.Image")));
            this.editProject.Name = "editProject";
            this.editProject.Size = new System.Drawing.Size(172, 24);
            this.editProject.Text = "Edit project";
            this.editProject.Click += new System.EventHandler(this.editProject_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployee,
            this.toolStripSeparator3,
            this.editEmployee});
            this.employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployee
            // 
            this.addEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmployee.Image = ((System.Drawing.Image)(resources.GetObject("addEmployee.Image")));
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(180, 24);
            this.addEmployee.Text = "Add employee";
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // editEmployee
            // 
            this.editEmployee.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editEmployee.Image = ((System.Drawing.Image)(resources.GetObject("editEmployee.Image")));
            this.editEmployee.Name = "editEmployee";
            this.editEmployee.Size = new System.Drawing.Size(180, 24);
            this.editEmployee.Text = "Edit employee";
            this.editEmployee.Click += new System.EventHandler(this.editEmployee_Click);
            // 
            // BtnCreateTask
            // 
            this.BtnCreateTask.ActiveControl = null;
            this.BtnCreateTask.Location = new System.Drawing.Point(13, 850);
            this.BtnCreateTask.Name = "BtnCreateTask";
            this.BtnCreateTask.Size = new System.Drawing.Size(169, 92);
            this.BtnCreateTask.TabIndex = 1;
            this.BtnCreateTask.Text = "Create new task";
            this.BtnCreateTask.TileImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateTask.TileImage")));
            this.BtnCreateTask.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnCreateTask.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.BtnCreateTask.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.BtnCreateTask.UseSelectable = true;
            this.BtnCreateTask.UseTileImage = true;
            this.BtnCreateTask.Click += new System.EventHandler(this.BtnCreateTask_Click);
            // 
            // eventList
            // 
            this.eventList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.eventList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eventList.HideSelection = false;
            this.eventList.Location = new System.Drawing.Point(13, 53);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(751, 791);
            this.eventList.TabIndex = 0;
            this.eventList.UseCompatibleStateImageBehavior = false;
            this.eventList.View = System.Windows.Forms.View.Details;
            this.eventList.DoubleClick += new System.EventHandler(this.eventList_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "State";
            this.columnHeader1.Width = 183;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pnlDoing);
            this.panel1.Controls.Add(this.pnlToDo);
            this.panel1.Controls.Add(this.pnlDone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 1000);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "To Do";
            // 
            // pnlDoing
            // 
            this.pnlDoing.AutoScroll = true;
            this.pnlDoing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDoing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDoing.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDoing.HorizontalScrollbar = true;
            this.pnlDoing.HorizontalScrollbarBarColor = true;
            this.pnlDoing.HorizontalScrollbarHighlightOnWheel = true;
            this.pnlDoing.HorizontalScrollbarSize = 10;
            this.pnlDoing.Location = new System.Drawing.Point(384, 53);
            this.pnlDoing.Name = "pnlDoing";
            this.pnlDoing.Size = new System.Drawing.Size(330, 889);
            this.pnlDoing.TabIndex = 2;
            this.pnlDoing.UseCustomBackColor = true;
            this.pnlDoing.UseCustomForeColor = true;
            this.pnlDoing.UseStyleColors = true;
            this.pnlDoing.VerticalScrollbar = true;
            this.pnlDoing.VerticalScrollbarBarColor = true;
            this.pnlDoing.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDoing.VerticalScrollbarSize = 10;
            // 
            // pnlToDo
            // 
            this.pnlToDo.AutoScroll = true;
            this.pnlToDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlToDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlToDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlToDo.HorizontalScrollbar = true;
            this.pnlToDo.HorizontalScrollbarBarColor = true;
            this.pnlToDo.HorizontalScrollbarHighlightOnWheel = true;
            this.pnlToDo.HorizontalScrollbarSize = 10;
            this.pnlToDo.Location = new System.Drawing.Point(11, 53);
            this.pnlToDo.Name = "pnlToDo";
            this.pnlToDo.Size = new System.Drawing.Size(330, 889);
            this.pnlToDo.TabIndex = 1;
            this.pnlToDo.UseCustomBackColor = true;
            this.pnlToDo.UseCustomForeColor = true;
            this.pnlToDo.UseStyleColors = true;
            this.pnlToDo.VerticalScrollbar = true;
            this.pnlToDo.VerticalScrollbarBarColor = true;
            this.pnlToDo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlToDo.VerticalScrollbarSize = 10;
            // 
            // pnlDone
            // 
            this.pnlDone.AutoScroll = true;
            this.pnlDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlDone.HorizontalScrollbar = true;
            this.pnlDone.HorizontalScrollbarBarColor = true;
            this.pnlDone.HorizontalScrollbarHighlightOnWheel = true;
            this.pnlDone.HorizontalScrollbarSize = 10;
            this.pnlDone.Location = new System.Drawing.Point(753, 53);
            this.pnlDone.Name = "pnlDone";
            this.pnlDone.Size = new System.Drawing.Size(330, 889);
            this.pnlDone.TabIndex = 2;
            this.pnlDone.UseCustomBackColor = true;
            this.pnlDone.UseCustomForeColor = true;
            this.pnlDone.UseStyleColors = true;
            this.pnlDone.VerticalScrollbar = true;
            this.pnlDone.VerticalScrollbarBarColor = true;
            this.pnlDone.VerticalScrollbarHighlightOnWheel = false;
            this.pnlDone.VerticalScrollbarSize = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 41);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Done";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectProject;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem editProject;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployee;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem editEmployee;
        private MetroFramework.Controls.MetroTile BtnCreateTask;
        private System.Windows.Forms.ListView eventList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroPanel pnlDoing;
        private MetroFramework.Controls.MetroPanel pnlToDo;
        private MetroFramework.Controls.MetroPanel pnlDone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

