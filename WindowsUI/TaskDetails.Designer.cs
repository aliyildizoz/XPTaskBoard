
namespace WindowsUI
{
    partial class TaskDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskDetails));
            this.pnlDetail = new MetroFramework.Drawing.Html.HtmlPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.pnlNotes = new MetroFramework.Drawing.Html.HtmlPanel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblCreatedDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblEstimatedDate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.lblEndDate = new MaterialSkin.Controls.MaterialLabel();
            this.lblCurrentState = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.btnUpdateTask = new Bunifu.Framework.UI.BunifuImageButton();
            this.lstMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveMember = new Bunifu.Framework.UI.BunifuImageButton();
            this.CmbEmployeeList = new MetroFramework.Controls.MetroComboBox();
            this.btnAddMember = new Bunifu.Framework.UI.BunifuImageButton();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lstViewEvents = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteTask = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTask)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.AutoScroll = true;
            this.pnlDetail.AutoScrollMinSize = new System.Drawing.Size(301, 0);
            this.pnlDetail.BackColor = System.Drawing.Color.Navy;
            this.pnlDetail.Location = new System.Drawing.Point(37, 99);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(301, 100);
            this.pnlDetail.TabIndex = 1;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(33, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Details";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(33, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Notes";
            // 
            // pnlNotes
            // 
            this.pnlNotes.AutoScroll = true;
            this.pnlNotes.AutoScrollMinSize = new System.Drawing.Size(301, 0);
            this.pnlNotes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlNotes.Location = new System.Drawing.Point(37, 237);
            this.pnlNotes.Name = "pnlNotes";
            this.pnlNotes.Size = new System.Drawing.Size(301, 144);
            this.pnlNotes.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 421);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(96, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Created Date";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Depth = 0;
            this.lblCreatedDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCreatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCreatedDate.Location = new System.Drawing.Point(32, 446);
            this.lblCreatedDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(92, 19);
            this.lblCreatedDate.TabIndex = 5;
            this.lblCreatedDate.Text = "CreatedDate";
            // 
            // lblEstimatedDate
            // 
            this.lblEstimatedDate.AutoSize = true;
            this.lblEstimatedDate.Depth = 0;
            this.lblEstimatedDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEstimatedDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEstimatedDate.Location = new System.Drawing.Point(144, 446);
            this.lblEstimatedDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEstimatedDate.Name = "lblEstimatedDate";
            this.lblEstimatedDate.Size = new System.Drawing.Size(108, 19);
            this.lblEstimatedDate.TabIndex = 6;
            this.lblEstimatedDate.Text = "EstimatedDate";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(144, 420);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(112, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Estimated Date";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(573, 77);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(54, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Events";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(272, 420);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(67, 19);
            this.materialLabel7.TabIndex = 7;
            this.materialLabel7.Text = "End date";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Depth = 0;
            this.lblEndDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndDate.Location = new System.Drawing.Point(273, 446);
            this.lblEndDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(65, 19);
            this.lblEndDate.TabIndex = 6;
            this.lblEndDate.Text = "EndDate";
            // 
            // lblCurrentState
            // 
            this.lblCurrentState.AutoSize = true;
            this.lblCurrentState.Depth = 0;
            this.lblCurrentState.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCurrentState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCurrentState.Location = new System.Drawing.Point(143, 396);
            this.lblCurrentState.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCurrentState.Name = "lblCurrentState";
            this.lblCurrentState.Size = new System.Drawing.Size(109, 19);
            this.lblCurrentState.TabIndex = 15;
            this.lblCurrentState.Text = "lblCurrentState";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(32, 396);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(105, 19);
            this.materialLabel9.TabIndex = 16;
            this.materialLabel9.Text = "Current State :";
            // 
            // btnUpdateTask
            // 
            this.btnUpdateTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnUpdateTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateTask.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTask.Image")));
            this.btnUpdateTask.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnUpdateTask.ImageActive")));
            this.btnUpdateTask.Location = new System.Drawing.Point(890, 39);
            this.btnUpdateTask.Name = "btnUpdateTask";
            this.btnUpdateTask.Size = new System.Drawing.Size(67, 54);
            this.btnUpdateTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdateTask.TabIndex = 18;
            this.btnUpdateTask.TabStop = false;
            this.btnUpdateTask.Zoom = 10;
            this.btnUpdateTask.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lstMembers
            // 
            this.lstMembers.Font = new System.Drawing.Font("Microsoft Tai Le", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMembers.FormattingEnabled = true;
            this.lstMembers.ItemHeight = 34;
            this.lstMembers.Location = new System.Drawing.Point(378, 99);
            this.lstMembers.Name = "lstMembers";
            this.lstMembers.Size = new System.Drawing.Size(189, 276);
            this.lstMembers.TabIndex = 25;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveMember.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveMember.Image")));
            this.btnRemoveMember.ImageActive = null;
            this.btnRemoveMember.Location = new System.Drawing.Point(537, 437);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemoveMember.TabIndex = 24;
            this.btnRemoveMember.TabStop = false;
            this.btnRemoveMember.Zoom = 10;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // CmbEmployeeList
            // 
            this.CmbEmployeeList.FormattingEnabled = true;
            this.CmbEmployeeList.ItemHeight = 23;
            this.CmbEmployeeList.Location = new System.Drawing.Point(378, 402);
            this.CmbEmployeeList.Name = "CmbEmployeeList";
            this.CmbEmployeeList.Size = new System.Drawing.Size(153, 29);
            this.CmbEmployeeList.TabIndex = 23;
            this.CmbEmployeeList.UseSelectable = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddMember.Image = ((System.Drawing.Image)(resources.GetObject("btnAddMember.Image")));
            this.btnAddMember.ImageActive = null;
            this.btnAddMember.Location = new System.Drawing.Point(537, 402);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(30, 29);
            this.btnAddMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddMember.TabIndex = 22;
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
            this.materialLabel6.Location = new System.Drawing.Point(374, 74);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(72, 19);
            this.materialLabel6.TabIndex = 21;
            this.materialLabel6.Text = "Members";
            // 
            // lstViewEvents
            // 
            this.lstViewEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstViewEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstViewEvents.HideSelection = false;
            this.lstViewEvents.Location = new System.Drawing.Point(574, 99);
            this.lstViewEvents.Name = "lstViewEvents";
            this.lstViewEvents.Size = new System.Drawing.Size(456, 276);
            this.lstViewEvents.TabIndex = 26;
            this.lstViewEvents.UseCompatibleStateImageBehavior = false;
            this.lstViewEvents.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "State";
            this.columnHeader1.Width = 118;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 195;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Date";
            this.columnHeader3.Width = 138;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteTask.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.Image")));
            this.btnDeleteTask.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnDeleteTask.ImageActive")));
            this.btnDeleteTask.Location = new System.Drawing.Point(963, 39);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Padding = new System.Windows.Forms.Padding(10);
            this.btnDeleteTask.Size = new System.Drawing.Size(67, 54);
            this.btnDeleteTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDeleteTask.TabIndex = 27;
            this.btnDeleteTask.TabStop = false;
            this.btnDeleteTask.Zoom = 10;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // TaskDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 485);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.lstViewEvents);
            this.Controls.Add(this.lstMembers);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.CmbEmployeeList);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnUpdateTask);
            this.Controls.Add(this.lblCurrentState);
            this.Controls.Add(this.materialLabel9);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblEstimatedDate);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pnlNotes);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.pnlDetail);
            this.Name = "TaskDetails";
            this.Text = "Task details";
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemoveMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Drawing.Html.HtmlPanel pnlDetail;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MetroFramework.Drawing.Html.HtmlPanel pnlNotes;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblCreatedDate;
        private MaterialSkin.Controls.MaterialLabel lblEstimatedDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel lblEndDate;
        private MaterialSkin.Controls.MaterialLabel lblCurrentState;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private Bunifu.Framework.UI.BunifuImageButton btnUpdateTask;
        private System.Windows.Forms.ListBox lstMembers;
        private Bunifu.Framework.UI.BunifuImageButton btnRemoveMember;
        private MetroFramework.Controls.MetroComboBox CmbEmployeeList;
        private Bunifu.Framework.UI.BunifuImageButton btnAddMember;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ListView lstViewEvents;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private Bunifu.Framework.UI.BunifuImageButton btnDeleteTask;
    }
}