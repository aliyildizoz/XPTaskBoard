
namespace WindowsUI
{
    partial class TaskEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskEdit));
            this.rdBtnTodo = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtnDoing = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtnDone = new MetroFramework.Controls.MetroRadioButton();
            this.BtnUpdateTask = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.estDateTime = new MetroFramework.Controls.MetroDateTime();
            this.rctNotes = new System.Windows.Forms.RichTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.rctDetails = new System.Windows.Forms.RichTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveMember = new Bunifu.Framework.UI.BunifuImageButton();
            this.CmbEmployeeList = new MetroFramework.Controls.MetroComboBox();
            this.btnAddMember = new Bunifu.Framework.UI.BunifuImageButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).BeginInit();
            this.SuspendLayout();
            // 
            // rdBtnTodo
            // 
            this.rdBtnTodo.AutoSize = true;
            this.rdBtnTodo.Checked = true;
            this.rdBtnTodo.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdBtnTodo.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rdBtnTodo.Location = new System.Drawing.Point(38, 206);
            this.rdBtnTodo.Name = "rdBtnTodo";
            this.rdBtnTodo.Size = new System.Drawing.Size(77, 25);
            this.rdBtnTodo.Style = MetroFramework.MetroColorStyle.Red;
            this.rdBtnTodo.TabIndex = 27;
            this.rdBtnTodo.TabStop = true;
            this.rdBtnTodo.Text = "To Do";
            this.rdBtnTodo.UseCustomBackColor = true;
            this.rdBtnTodo.UseSelectable = true;
            this.rdBtnTodo.UseStyleColors = true;
            this.rdBtnTodo.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // rdBtnDoing
            // 
            this.rdBtnDoing.AutoSize = true;
            this.rdBtnDoing.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdBtnDoing.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rdBtnDoing.Location = new System.Drawing.Point(152, 206);
            this.rdBtnDoing.Name = "rdBtnDoing";
            this.rdBtnDoing.Size = new System.Drawing.Size(79, 25);
            this.rdBtnDoing.Style = MetroFramework.MetroColorStyle.Yellow;
            this.rdBtnDoing.TabIndex = 28;
            this.rdBtnDoing.Text = "Doing";
            this.rdBtnDoing.UseCustomBackColor = true;
            this.rdBtnDoing.UseSelectable = true;
            this.rdBtnDoing.UseStyleColors = true;
            this.rdBtnDoing.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // rdBtnDone
            // 
            this.rdBtnDone.AutoSize = true;
            this.rdBtnDone.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.rdBtnDone.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.rdBtnDone.Location = new System.Drawing.Point(275, 206);
            this.rdBtnDone.Name = "rdBtnDone";
            this.rdBtnDone.Size = new System.Drawing.Size(73, 25);
            this.rdBtnDone.Style = MetroFramework.MetroColorStyle.Green;
            this.rdBtnDone.TabIndex = 29;
            this.rdBtnDone.Text = "Done";
            this.rdBtnDone.UseCustomBackColor = true;
            this.rdBtnDone.UseSelectable = true;
            this.rdBtnDone.UseStyleColors = true;
            this.rdBtnDone.CheckedChanged += new System.EventHandler(this.OnCheckedChanged);
            // 
            // BtnUpdateTask
            // 
            this.BtnUpdateTask.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnUpdateTask.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BtnUpdateTask.Highlight = true;
            this.BtnUpdateTask.Location = new System.Drawing.Point(23, 446);
            this.BtnUpdateTask.Name = "BtnUpdateTask";
            this.BtnUpdateTask.Size = new System.Drawing.Size(141, 43);
            this.BtnUpdateTask.TabIndex = 26;
            this.BtnUpdateTask.Text = "Save";
            this.BtnUpdateTask.UseSelectable = true;
            this.BtnUpdateTask.Click += new System.EventHandler(this.BtnUpdateTask_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 178);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Task State";
            // 
            // estDateTime
            // 
            this.estDateTime.Location = new System.Drawing.Point(23, 411);
            this.estDateTime.MinimumSize = new System.Drawing.Size(0, 29);
            this.estDateTime.Name = "estDateTime";
            this.estDateTime.Size = new System.Drawing.Size(425, 29);
            this.estDateTime.TabIndex = 24;
            // 
            // rctNotes
            // 
            this.rctNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rctNotes.Location = new System.Drawing.Point(23, 262);
            this.rctNotes.Name = "rctNotes";
            this.rctNotes.Size = new System.Drawing.Size(425, 124);
            this.rctNotes.TabIndex = 22;
            this.rctNotes.Text = "";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 240);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(43, 19);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "Notes";
            // 
            // rctDetails
            // 
            this.rctDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rctDetails.Location = new System.Drawing.Point(23, 79);
            this.rctDetails.Name = "rctDetails";
            this.rctDetails.Size = new System.Drawing.Size(425, 96);
            this.rctDetails.TabIndex = 23;
            this.rctDetails.Text = "";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 389);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "Estimated Date";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 57);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Details";
            // 
            // lstMembers
            // 
            this.lstMembers.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 34;
            this.lstMembers.Location = new System.Drawing.Point(454, 79);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(189, 310);
            this.lstMembers.TabIndex = 34;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveMember.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMember.Image")));
            this.btnRemoveMember.ImageActive = null;
            this.btnRemoveMember.Location = new System.Drawing.Point(613, 446);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemoveMember.TabIndex = 33;
            this.btnRemoveMember.TabStop = false;
            this.btnRemoveMember.Zoom = 10;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // CmbEmployeeList
            // 
            this.CmbEmployeeList.FormattingEnabled = true;
            this.CmbEmployeeList.ItemHeight = 23;
            this.CmbEmployeeList.Location = new System.Drawing.Point(454, 411);
            this.CmbEmployeeList.Name = "CmbEmployeeList";
            this.CmbEmployeeList.Size = new System.Drawing.Size(153, 29);
            this.CmbEmployeeList.TabIndex = 32;
            this.CmbEmployeeList.UseSelectable = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageActive = null;
            this.btnAddMember.Location = new System.Drawing.Point(613, 411);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(30, 29);
            this.btnAddMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddMember.TabIndex = 31;
            this.btnAddMember.TabStop = false;
            this.btnAddMember.Zoom = 10;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(450, 54);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 30;
            this.materialLabel6.Text = "Members";
            // 
            // TaskEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 501);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.CmbEmployeeList);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.rdBtnTodo);
            this.Controls.Add(this.rdBtnDoing);
            this.Controls.Add(this.rdBtnDone);
            this.Controls.Add(this.BtnUpdateTask);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.estDateTime);
            this.Controls.Add(this.rctNotes);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.rctDetails);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TaskEdit";
            this.Text = "TaskEdit";
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroRadioButton rdBtnTodo;
        private MetroFramework.Controls.MetroRadioButton rdBtnDoing;
        private MetroFramework.Controls.MetroRadioButton rdBtnDone;
        private MetroFramework.Controls.MetroButton BtnUpdateTask;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroDateTime estDateTime;
        private System.Windows.Forms.RichTextBox rctNotes;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.RichTextBox rctDetails;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ListBox lstMembers;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveMember;
        private MetroFramework.Controls.MetroComboBox CmbEmployeeList;
        private Bunifu.Framework.UI.BunifuImageButton btnAddMember;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}