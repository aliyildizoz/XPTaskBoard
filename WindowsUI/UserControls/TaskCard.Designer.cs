
namespace WindowsUI.UserControls
{
    partial class TaskCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskCard));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lblCreatedDate = new MetroFramework.Controls.MetroLabel();
            this.btnDetail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rdBtnDone = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtnDoing = new MetroFramework.Controls.MetroRadioButton();
            this.rdBtnTodo = new MetroFramework.Controls.MetroRadioButton();
            this.bar = new MaterialSkin.Controls.MaterialLabel();
            this.pnlDetails = new MetroFramework.Drawing.Html.HtmlPanel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel1.Location = new System.Drawing.Point(98, 86);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(73, 15);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Created date";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblCreatedDate.Location = new System.Drawing.Point(177, 86);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(30, 15);
            this.lblCreatedDate.TabIndex = 7;
            this.lblCreatedDate.Text = "date";
            this.lblCreatedDate.UseCustomBackColor = true;
            // 
            // btnDetail
            // 
            this.btnDetail.Activecolor = System.Drawing.Color.Silver;
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDetail.BorderRadius = 1;
            this.btnDetail.ButtonText = "Details";
            this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetail.DisabledColor = System.Drawing.Color.Gray;
            this.btnDetail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDetail.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDetail.Iconimage")));
            this.btnDetail.Iconimage_right = null;
            this.btnDetail.Iconimage_right_Selected = null;
            this.btnDetail.Iconimage_Selected = null;
            this.btnDetail.IconMarginLeft = 0;
            this.btnDetail.IconMarginRight = 0;
            this.btnDetail.IconRightVisible = true;
            this.btnDetail.IconRightZoom = 90D;
            this.btnDetail.IconVisible = true;
            this.btnDetail.IconZoom = 60D;
            this.btnDetail.IsTab = false;
            this.btnDetail.Location = new System.Drawing.Point(2, 64);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDetail.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDetail.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnDetail.selected = true;
            this.btnDetail.Size = new System.Drawing.Size(90, 37);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Details";
            this.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDetail.Textcolor = System.Drawing.Color.White;
            this.btnDetail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // rdBtnDone
            // 
            this.rdBtnDone.AutoSize = true;
            this.rdBtnDone.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdBtnDone.Location = new System.Drawing.Point(229, 64);
            this.rdBtnDone.Name = "rdBtnDone";
            this.rdBtnDone.Size = new System.Drawing.Size(58, 19);
            this.rdBtnDone.Style = MetroFramework.MetroColorStyle.Green;
            this.rdBtnDone.TabIndex = 10;
            this.rdBtnDone.Text = "Done";
            this.rdBtnDone.UseCustomBackColor = true;
            this.rdBtnDone.UseSelectable = true;
            this.rdBtnDone.UseStyleColors = true;
            this.rdBtnDone.CheckedChanged += new System.EventHandler(this.OnChangeState);
            // 
            // rdBtnDoing
            // 
            this.rdBtnDoing.AutoSize = true;
            this.rdBtnDoing.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdBtnDoing.Location = new System.Drawing.Point(161, 64);
            this.rdBtnDoing.Name = "rdBtnDoing";
            this.rdBtnDoing.Size = new System.Drawing.Size(62, 19);
            this.rdBtnDoing.Style = MetroFramework.MetroColorStyle.Yellow;
            this.rdBtnDoing.TabIndex = 10;
            this.rdBtnDoing.Text = "Doing";
            this.rdBtnDoing.UseCustomBackColor = true;
            this.rdBtnDoing.UseSelectable = true;
            this.rdBtnDoing.UseStyleColors = true;
            this.rdBtnDoing.CheckedChanged += new System.EventHandler(this.OnChangeState);
            // 
            // rdBtnTodo
            // 
            this.rdBtnTodo.AutoSize = true;
            this.rdBtnTodo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rdBtnTodo.Location = new System.Drawing.Point(98, 64);
            this.rdBtnTodo.Name = "rdBtnTodo";
            this.rdBtnTodo.Size = new System.Drawing.Size(61, 19);
            this.rdBtnTodo.Style = MetroFramework.MetroColorStyle.Red;
            this.rdBtnTodo.TabIndex = 10;
            this.rdBtnTodo.Text = "To Do";
            this.rdBtnTodo.UseCustomBackColor = true;
            this.rdBtnTodo.UseSelectable = true;
            this.rdBtnTodo.UseStyleColors = true;
            this.rdBtnTodo.CheckedChanged += new System.EventHandler(this.OnChangeState);
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.Color.Transparent;
            this.bar.Depth = 0;
            this.bar.Font = new System.Drawing.Font("Roboto", 11F);
            this.bar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bar.Location = new System.Drawing.Point(2, 51);
            this.bar.MouseState = MaterialSkin.MouseState.HOVER;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(286, 10);
            this.bar.TabIndex = 11;
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoScroll = true;
            this.pnlDetails.AutoScrollMinSize = new System.Drawing.Size(293, 0);
            this.pnlDetails.BackColor = System.Drawing.Color.DimGray;
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(293, 45);
            this.pnlDetails.TabIndex = 12;
            // 
            // TaskCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.rdBtnTodo);
            this.Controls.Add(this.rdBtnDoing);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.rdBtnDone);
            this.Controls.Add(this.btnDetail);
            this.Name = "TaskCard";
            this.Size = new System.Drawing.Size(293, 110);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuFlatButton btnDetail;
        private MetroFramework.Controls.MetroLabel lblCreatedDate;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rdBtnDone;
        private MetroFramework.Controls.MetroRadioButton rdBtnDoing;
        private MetroFramework.Controls.MetroRadioButton rdBtnTodo;
        private MaterialSkin.Controls.MaterialLabel bar;
        private MetroFramework.Drawing.Html.HtmlPanel pnlDetails;
    }
}
