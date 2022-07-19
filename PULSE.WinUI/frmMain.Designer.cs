namespace PULSE.WinUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlNavLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavBikes = new System.Windows.Forms.Panel();
            this.btnNavBikesCategories = new System.Windows.Forms.Button();
            this.btnNavBikesSearch = new System.Windows.Forms.Button();
            this.btnNavBikes = new System.Windows.Forms.Button();
            this.pnlNavGear = new System.Windows.Forms.Panel();
            this.btnNavGearCategories = new System.Windows.Forms.Button();
            this.btnNavGearSearch = new System.Windows.Forms.Button();
            this.btnNavGear = new System.Windows.Forms.Button();
            this.tmrNavBikes = new System.Windows.Forms.Timer(this.components);
            this.tmrNavGear = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ucGearList1 = new PULSE.WinUI.ucGearList();
            this.ucBicycleList1 = new PULSE.WinUI.ucBicycleList();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNavLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavBikes.SuspendLayout();
            this.pnlNavGear.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlNavLogo);
            this.flowLayoutPanel1.Controls.Add(this.pnlNavBikes);
            this.flowLayoutPanel1.Controls.Add(this.pnlNavGear);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 674);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pnlNavLogo
            // 
            this.pnlNavLogo.Controls.Add(this.pictureBox1);
            this.pnlNavLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlNavLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavLogo.Name = "pnlNavLogo";
            this.pnlNavLogo.Size = new System.Drawing.Size(230, 139);
            this.pnlNavLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNavBikes
            // 
            this.pnlNavBikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNavBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.pnlNavBikes.Controls.Add(this.btnNavBikesCategories);
            this.pnlNavBikes.Controls.Add(this.btnNavBikesSearch);
            this.pnlNavBikes.Controls.Add(this.btnNavBikes);
            this.pnlNavBikes.Location = new System.Drawing.Point(0, 139);
            this.pnlNavBikes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavBikes.MaximumSize = new System.Drawing.Size(230, 117);
            this.pnlNavBikes.MinimumSize = new System.Drawing.Size(230, 40);
            this.pnlNavBikes.Name = "pnlNavBikes";
            this.pnlNavBikes.Size = new System.Drawing.Size(230, 40);
            this.pnlNavBikes.TabIndex = 1;
            // 
            // btnNavBikesCategories
            // 
            this.btnNavBikesCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBikesCategories.FlatAppearance.BorderSize = 0;
            this.btnNavBikesCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBikesCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBikesCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavBikesCategories.Location = new System.Drawing.Point(0, 80);
            this.btnNavBikesCategories.Name = "btnNavBikesCategories";
            this.btnNavBikesCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavBikesCategories.Size = new System.Drawing.Size(230, 35);
            this.btnNavBikesCategories.TabIndex = 3;
            this.btnNavBikesCategories.Text = "Categories";
            this.btnNavBikesCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBikesCategories.UseVisualStyleBackColor = true;
            // 
            // btnNavBikesSearch
            // 
            this.btnNavBikesSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBikesSearch.FlatAppearance.BorderSize = 0;
            this.btnNavBikesSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBikesSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBikesSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavBikesSearch.Location = new System.Drawing.Point(0, 42);
            this.btnNavBikesSearch.Name = "btnNavBikesSearch";
            this.btnNavBikesSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavBikesSearch.Size = new System.Drawing.Size(230, 35);
            this.btnNavBikesSearch.TabIndex = 2;
            this.btnNavBikesSearch.Text = "Search";
            this.btnNavBikesSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBikesSearch.UseVisualStyleBackColor = true;
            this.btnNavBikesSearch.Click += new System.EventHandler(this.btnNavBikesSearch_Click);
            // 
            // btnNavBikes
            // 
            this.btnNavBikes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavBikes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBikes.FlatAppearance.BorderSize = 0;
            this.btnNavBikes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBikes.ForeColor = System.Drawing.Color.White;
            this.btnNavBikes.Location = new System.Drawing.Point(0, 0);
            this.btnNavBikes.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavBikes.Name = "btnNavBikes";
            this.btnNavBikes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavBikes.Size = new System.Drawing.Size(230, 40);
            this.btnNavBikes.TabIndex = 1;
            this.btnNavBikes.Text = "BIKES";
            this.btnNavBikes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBikes.UseVisualStyleBackColor = false;
            this.btnNavBikes.Click += new System.EventHandler(this.btnNavBikes_Click);
            // 
            // pnlNavGear
            // 
            this.pnlNavGear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNavGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.pnlNavGear.Controls.Add(this.btnNavGearCategories);
            this.pnlNavGear.Controls.Add(this.btnNavGearSearch);
            this.pnlNavGear.Controls.Add(this.btnNavGear);
            this.pnlNavGear.Location = new System.Drawing.Point(0, 179);
            this.pnlNavGear.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavGear.MaximumSize = new System.Drawing.Size(230, 117);
            this.pnlNavGear.MinimumSize = new System.Drawing.Size(230, 40);
            this.pnlNavGear.Name = "pnlNavGear";
            this.pnlNavGear.Size = new System.Drawing.Size(230, 40);
            this.pnlNavGear.TabIndex = 4;
            // 
            // btnNavGearCategories
            // 
            this.btnNavGearCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavGearCategories.FlatAppearance.BorderSize = 0;
            this.btnNavGearCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGearCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavGearCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavGearCategories.Location = new System.Drawing.Point(0, 80);
            this.btnNavGearCategories.Name = "btnNavGearCategories";
            this.btnNavGearCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavGearCategories.Size = new System.Drawing.Size(230, 35);
            this.btnNavGearCategories.TabIndex = 3;
            this.btnNavGearCategories.Text = "Categories";
            this.btnNavGearCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGearCategories.UseVisualStyleBackColor = true;
            // 
            // btnNavGearSearch
            // 
            this.btnNavGearSearch.FlatAppearance.BorderSize = 0;
            this.btnNavGearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavGearSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavGearSearch.Location = new System.Drawing.Point(0, 42);
            this.btnNavGearSearch.Name = "btnNavGearSearch";
            this.btnNavGearSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavGearSearch.Size = new System.Drawing.Size(230, 35);
            this.btnNavGearSearch.TabIndex = 2;
            this.btnNavGearSearch.Text = "Search";
            this.btnNavGearSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGearSearch.UseVisualStyleBackColor = true;
            this.btnNavGearSearch.Click += new System.EventHandler(this.btnNavGearSearch_Click);
            // 
            // btnNavGear
            // 
            this.btnNavGear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavGear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavGear.FlatAppearance.BorderSize = 0;
            this.btnNavGear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavGear.ForeColor = System.Drawing.Color.White;
            this.btnNavGear.Location = new System.Drawing.Point(0, 0);
            this.btnNavGear.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavGear.Name = "btnNavGear";
            this.btnNavGear.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavGear.Size = new System.Drawing.Size(230, 40);
            this.btnNavGear.TabIndex = 1;
            this.btnNavGear.Text = "GEAR";
            this.btnNavGear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavGear.UseVisualStyleBackColor = false;
            this.btnNavGear.Click += new System.EventHandler(this.btnNavGear_Click);
            // 
            // tmrNavBikes
            // 
            this.tmrNavBikes.Interval = 10;
            this.tmrNavBikes.Tick += new System.EventHandler(this.tmrNavBikes_Tick);
            // 
            // tmrNavGear
            // 
            this.tmrNavGear.Interval = 10;
            this.tmrNavGear.Tick += new System.EventHandler(this.tmrNavGear_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.pnlMain.Controls.Add(this.ucGearList1);
            this.pnlMain.Controls.Add(this.ucBicycleList1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(230, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(888, 674);
            this.pnlMain.TabIndex = 1;
            // 
            // ucGearList1
            // 
            this.ucGearList1.BackColor = System.Drawing.Color.Transparent;
            this.ucGearList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGearList1.Location = new System.Drawing.Point(0, 0);
            this.ucGearList1.Name = "ucGearList1";
            this.ucGearList1.Size = new System.Drawing.Size(888, 674);
            this.ucGearList1.TabIndex = 1;
            // 
            // ucBicycleList1
            // 
            this.ucBicycleList1.BackColor = System.Drawing.Color.Transparent;
            this.ucBicycleList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBicycleList1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleList1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBicycleList1.Name = "ucBicycleList1";
            this.ucBicycleList1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleList1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 674);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNavLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavBikes.ResumeLayout(false);
            this.pnlNavGear.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlNavLogo;
        private Panel pnlNavBikes;
        private Button btnNavBikes;
        private Button btnNavBikesCategories;
        private Button btnNavBikesSearch;
        private System.Windows.Forms.Timer tmrNavBikes;
        private Panel pnlNavGear;
        private Button btnNavGearCategories;
        private Button btnNavGearSearch;
        private Button btnNavGear;
        private System.Windows.Forms.Timer tmrNavGear;
        private Panel pnlMain;
        private ucBicycleList ucBicycleList1;
        private ucGearList ucGearList1;
        private PictureBox pictureBox1;
    }
}