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
            this.btnNavBikesSizes = new System.Windows.Forms.Button();
            this.btnNavBikesCategories = new System.Windows.Forms.Button();
            this.btnNavBikesSearch = new System.Windows.Forms.Button();
            this.btnNavBikes = new System.Windows.Forms.Button();
            this.pnlNavGear = new System.Windows.Forms.Panel();
            this.btnNavGearCategories = new System.Windows.Forms.Button();
            this.btnNavGearSearch = new System.Windows.Forms.Button();
            this.btnNavGear = new System.Windows.Forms.Button();
            this.pnlNavParts = new System.Windows.Forms.Panel();
            this.btnNavPartsCategories = new System.Windows.Forms.Button();
            this.btnNavPartsSearch = new System.Windows.Forms.Button();
            this.btnNavParts = new System.Windows.Forms.Button();
            this.btnNavBrands = new System.Windows.Forms.Button();
            this.btnNavOrders = new System.Windows.Forms.Button();
            this.btnNavServicing = new System.Windows.Forms.Button();
            this.btnNavStaff = new System.Windows.Forms.Button();
            this.tmrNavBikes = new System.Windows.Forms.Timer(this.components);
            this.tmrNavGear = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.ucStaffList1 = new PULSE.WinUI.Pages.Staff.ucStaffList();
            this.ucServicingList1 = new PULSE.WinUI.Pages.Servicing.ucServicingList();
            this.ucBicycleSizeList1 = new PULSE.WinUI.Pages.Bicycle.ucBicycleSizeList();
            this.ucBrandList1 = new PULSE.WinUI.Pages.Brands.ucBrandList();
            this.ucPartCategoryList1 = new PULSE.WinUI.Pages.Part.ucPartCategoryList();
            this.ucGearCategoryList1 = new PULSE.WinUI.Pages.Gear.ucGearCategoryList();
            this.ucPartList1 = new PULSE.WinUI.Pages.Part.ucPartList();
            this.ucGearList1 = new PULSE.WinUI.Pages.Gear.ucGearList();
            this.ucBicycleCategoryList1 = new PULSE.WinUI.Pages.Bicycle.ucBicycleCategoryList();
            this.ucBicycleList1 = new PULSE.WinUI.Pages.Bicycle.ucBicycleList();
            this.tmrNavParts = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogout = new System.Windows.Forms.PictureBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.ucOrderList2 = new PULSE.WinUI.Pages.Orders.ucOrderList();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlNavLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavBikes.SuspendLayout();
            this.pnlNavGear.SuspendLayout();
            this.pnlNavParts.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.flowLayoutPanel1.Controls.Add(this.pnlNavLogo);
            this.flowLayoutPanel1.Controls.Add(this.pnlNavBikes);
            this.flowLayoutPanel1.Controls.Add(this.pnlNavGear);
            this.flowLayoutPanel1.Controls.Add(this.pnlNavParts);
            this.flowLayoutPanel1.Controls.Add(this.btnNavBrands);
            this.flowLayoutPanel1.Controls.Add(this.btnNavOrders);
            this.flowLayoutPanel1.Controls.Add(this.btnNavServicing);
            this.flowLayoutPanel1.Controls.Add(this.btnNavStaff);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(230, 611);
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
            this.pnlNavBikes.Controls.Add(this.btnNavBikesSizes);
            this.pnlNavBikes.Controls.Add(this.btnNavBikesCategories);
            this.pnlNavBikes.Controls.Add(this.btnNavBikesSearch);
            this.pnlNavBikes.Controls.Add(this.btnNavBikes);
            this.pnlNavBikes.Location = new System.Drawing.Point(0, 139);
            this.pnlNavBikes.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavBikes.MaximumSize = new System.Drawing.Size(230, 152);
            this.pnlNavBikes.Name = "pnlNavBikes";
            this.pnlNavBikes.Size = new System.Drawing.Size(230, 40);
            this.pnlNavBikes.TabIndex = 1;
            // 
            // btnNavBikesSizes
            // 
            this.btnNavBikesSizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBikesSizes.FlatAppearance.BorderSize = 0;
            this.btnNavBikesSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBikesSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBikesSizes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavBikesSizes.Location = new System.Drawing.Point(0, 116);
            this.btnNavBikesSizes.Name = "btnNavBikesSizes";
            this.btnNavBikesSizes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavBikesSizes.Size = new System.Drawing.Size(230, 35);
            this.btnNavBikesSizes.TabIndex = 4;
            this.btnNavBikesSizes.Text = "Sizes";
            this.btnNavBikesSizes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBikesSizes.UseVisualStyleBackColor = true;
            this.btnNavBikesSizes.Click += new System.EventHandler(this.btnNavBikesSizes_Click);
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
            this.btnNavBikesCategories.Click += new System.EventHandler(this.btnNavBikesCategories_Click);
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
            this.btnNavBikes.EnabledChanged += new System.EventHandler(this.btnNavBikes_EnabledChanged);
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
            this.btnNavGearCategories.Click += new System.EventHandler(this.btnNavGearCategories_Click);
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
            // pnlNavParts
            // 
            this.pnlNavParts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNavParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(62)))));
            this.pnlNavParts.Controls.Add(this.btnNavPartsCategories);
            this.pnlNavParts.Controls.Add(this.btnNavPartsSearch);
            this.pnlNavParts.Controls.Add(this.btnNavParts);
            this.pnlNavParts.Location = new System.Drawing.Point(0, 219);
            this.pnlNavParts.Margin = new System.Windows.Forms.Padding(0);
            this.pnlNavParts.MaximumSize = new System.Drawing.Size(230, 117);
            this.pnlNavParts.Name = "pnlNavParts";
            this.pnlNavParts.Size = new System.Drawing.Size(230, 40);
            this.pnlNavParts.TabIndex = 5;
            // 
            // btnNavPartsCategories
            // 
            this.btnNavPartsCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPartsCategories.FlatAppearance.BorderSize = 0;
            this.btnNavPartsCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPartsCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavPartsCategories.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavPartsCategories.Location = new System.Drawing.Point(0, 80);
            this.btnNavPartsCategories.Name = "btnNavPartsCategories";
            this.btnNavPartsCategories.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavPartsCategories.Size = new System.Drawing.Size(230, 35);
            this.btnNavPartsCategories.TabIndex = 3;
            this.btnNavPartsCategories.Text = "Categories";
            this.btnNavPartsCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPartsCategories.UseVisualStyleBackColor = true;
            this.btnNavPartsCategories.Click += new System.EventHandler(this.btnNavPartsCategories_Click);
            // 
            // btnNavPartsSearch
            // 
            this.btnNavPartsSearch.FlatAppearance.BorderSize = 0;
            this.btnNavPartsSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPartsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavPartsSearch.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNavPartsSearch.Location = new System.Drawing.Point(0, 42);
            this.btnNavPartsSearch.Name = "btnNavPartsSearch";
            this.btnNavPartsSearch.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNavPartsSearch.Size = new System.Drawing.Size(230, 35);
            this.btnNavPartsSearch.TabIndex = 2;
            this.btnNavPartsSearch.Text = "Search";
            this.btnNavPartsSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPartsSearch.UseVisualStyleBackColor = true;
            this.btnNavPartsSearch.Click += new System.EventHandler(this.btnNavPartsSearch_Click);
            // 
            // btnNavParts
            // 
            this.btnNavParts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavParts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavParts.FlatAppearance.BorderSize = 0;
            this.btnNavParts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavParts.ForeColor = System.Drawing.Color.White;
            this.btnNavParts.Location = new System.Drawing.Point(0, 0);
            this.btnNavParts.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavParts.Name = "btnNavParts";
            this.btnNavParts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavParts.Size = new System.Drawing.Size(230, 40);
            this.btnNavParts.TabIndex = 1;
            this.btnNavParts.Text = "PARTS";
            this.btnNavParts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavParts.UseVisualStyleBackColor = false;
            this.btnNavParts.Click += new System.EventHandler(this.btnNavParts_Click);
            // 
            // btnNavBrands
            // 
            this.btnNavBrands.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavBrands.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavBrands.FlatAppearance.BorderSize = 0;
            this.btnNavBrands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBrands.ForeColor = System.Drawing.Color.White;
            this.btnNavBrands.Location = new System.Drawing.Point(0, 259);
            this.btnNavBrands.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavBrands.Name = "btnNavBrands";
            this.btnNavBrands.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavBrands.Size = new System.Drawing.Size(230, 40);
            this.btnNavBrands.TabIndex = 4;
            this.btnNavBrands.Text = "BRANDS";
            this.btnNavBrands.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBrands.UseVisualStyleBackColor = false;
            this.btnNavBrands.Click += new System.EventHandler(this.btnNavBrands_Click);
            // 
            // btnNavOrders
            // 
            this.btnNavOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavOrders.FlatAppearance.BorderSize = 0;
            this.btnNavOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavOrders.ForeColor = System.Drawing.Color.White;
            this.btnNavOrders.Location = new System.Drawing.Point(0, 299);
            this.btnNavOrders.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavOrders.Name = "btnNavOrders";
            this.btnNavOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavOrders.Size = new System.Drawing.Size(230, 40);
            this.btnNavOrders.TabIndex = 6;
            this.btnNavOrders.Text = "ORDERS";
            this.btnNavOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavOrders.UseVisualStyleBackColor = false;
            this.btnNavOrders.Click += new System.EventHandler(this.btnNavOrders_Click);
            // 
            // btnNavServicing
            // 
            this.btnNavServicing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavServicing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavServicing.FlatAppearance.BorderSize = 0;
            this.btnNavServicing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavServicing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavServicing.ForeColor = System.Drawing.Color.White;
            this.btnNavServicing.Location = new System.Drawing.Point(0, 339);
            this.btnNavServicing.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavServicing.Name = "btnNavServicing";
            this.btnNavServicing.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavServicing.Size = new System.Drawing.Size(230, 40);
            this.btnNavServicing.TabIndex = 7;
            this.btnNavServicing.Text = "SERVICING";
            this.btnNavServicing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavServicing.UseVisualStyleBackColor = false;
            this.btnNavServicing.Click += new System.EventHandler(this.btnNavServicing_Click);
            // 
            // btnNavStaff
            // 
            this.btnNavStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.btnNavStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavStaff.FlatAppearance.BorderSize = 0;
            this.btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavStaff.ForeColor = System.Drawing.Color.White;
            this.btnNavStaff.Location = new System.Drawing.Point(0, 379);
            this.btnNavStaff.Margin = new System.Windows.Forms.Padding(0);
            this.btnNavStaff.Name = "btnNavStaff";
            this.btnNavStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNavStaff.Size = new System.Drawing.Size(230, 40);
            this.btnNavStaff.TabIndex = 8;
            this.btnNavStaff.Text = "STAFF";
            this.btnNavStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStaff.UseVisualStyleBackColor = false;
            this.btnNavStaff.Click += new System.EventHandler(this.btnNavStaff_Click);
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
            this.pnlMain.Controls.Add(this.ucOrderList2);
            this.pnlMain.Controls.Add(this.ucStaffList1);
            this.pnlMain.Controls.Add(this.ucServicingList1);
            this.pnlMain.Controls.Add(this.ucBicycleSizeList1);
            this.pnlMain.Controls.Add(this.ucBrandList1);
            this.pnlMain.Controls.Add(this.ucPartCategoryList1);
            this.pnlMain.Controls.Add(this.ucGearCategoryList1);
            this.pnlMain.Controls.Add(this.ucPartList1);
            this.pnlMain.Controls.Add(this.ucGearList1);
            this.pnlMain.Controls.Add(this.ucBicycleCategoryList1);
            this.pnlMain.Controls.Add(this.ucBicycleList1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMain.Location = new System.Drawing.Point(230, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(888, 674);
            this.pnlMain.TabIndex = 1;
            // 
            // ucStaffList1
            // 
            this.ucStaffList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucStaffList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucStaffList1.Location = new System.Drawing.Point(0, 0);
            this.ucStaffList1.Name = "ucStaffList1";
            this.ucStaffList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucStaffList1.Size = new System.Drawing.Size(888, 674);
            this.ucStaffList1.TabIndex = 11;
            // 
            // ucServicingList1
            // 
            this.ucServicingList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucServicingList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucServicingList1.Location = new System.Drawing.Point(0, 0);
            this.ucServicingList1.Name = "ucServicingList1";
            this.ucServicingList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucServicingList1.Size = new System.Drawing.Size(888, 674);
            this.ucServicingList1.TabIndex = 9;
            // 
            // ucBicycleSizeList1
            // 
            this.ucBicycleSizeList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBicycleSizeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBicycleSizeList1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleSizeList1.Name = "ucBicycleSizeList1";
            this.ucBicycleSizeList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucBicycleSizeList1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleSizeList1.TabIndex = 8;
            // 
            // ucBrandList1
            // 
            this.ucBrandList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBrandList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBrandList1.Location = new System.Drawing.Point(0, 0);
            this.ucBrandList1.Name = "ucBrandList1";
            this.ucBrandList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucBrandList1.Size = new System.Drawing.Size(888, 674);
            this.ucBrandList1.TabIndex = 2;
            // 
            // ucPartCategoryList1
            // 
            this.ucPartCategoryList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucPartCategoryList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPartCategoryList1.Location = new System.Drawing.Point(0, 0);
            this.ucPartCategoryList1.Name = "ucPartCategoryList1";
            this.ucPartCategoryList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucPartCategoryList1.Size = new System.Drawing.Size(888, 674);
            this.ucPartCategoryList1.TabIndex = 7;
            // 
            // ucGearCategoryList1
            // 
            this.ucGearCategoryList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucGearCategoryList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGearCategoryList1.Location = new System.Drawing.Point(0, 0);
            this.ucGearCategoryList1.Name = "ucGearCategoryList1";
            this.ucGearCategoryList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucGearCategoryList1.Size = new System.Drawing.Size(888, 674);
            this.ucGearCategoryList1.TabIndex = 6;
            // 
            // ucPartList1
            // 
            this.ucPartList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucPartList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPartList1.Location = new System.Drawing.Point(0, 0);
            this.ucPartList1.Name = "ucPartList1";
            this.ucPartList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucPartList1.Size = new System.Drawing.Size(888, 674);
            this.ucPartList1.TabIndex = 5;
            // 
            // ucGearList1
            // 
            this.ucGearList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucGearList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGearList1.Location = new System.Drawing.Point(0, 0);
            this.ucGearList1.Name = "ucGearList1";
            this.ucGearList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucGearList1.Size = new System.Drawing.Size(888, 674);
            this.ucGearList1.TabIndex = 4;
            // 
            // ucBicycleCategoryList1
            // 
            this.ucBicycleCategoryList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBicycleCategoryList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBicycleCategoryList1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleCategoryList1.Name = "ucBicycleCategoryList1";
            this.ucBicycleCategoryList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucBicycleCategoryList1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleCategoryList1.TabIndex = 3;
            // 
            // ucBicycleList1
            // 
            this.ucBicycleList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBicycleList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBicycleList1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleList1.Name = "ucBicycleList1";
            this.ucBicycleList1.Padding = new System.Windows.Forms.Padding(10);
            this.ucBicycleList1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleList1.TabIndex = 2;
            // 
            // tmrNavParts
            // 
            this.tmrNavParts.Interval = 10;
            this.tmrNavParts.Tick += new System.EventHandler(this.tmrNavParts_Tick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(29)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pbLogout);
            this.panel1.Controls.Add(this.lblRole);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(0, 608);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 66);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.panel2.Location = new System.Drawing.Point(15, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 3;
            // 
            // pbLogout
            // 
            this.pbLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLogout.Image = global::PULSE.WinUI.Properties.Resources.logout;
            this.pbLogout.Location = new System.Drawing.Point(176, 12);
            this.pbLogout.Name = "pbLogout";
            this.pbLogout.Size = new System.Drawing.Size(43, 43);
            this.pbLogout.TabIndex = 2;
            this.pbLogout.TabStop = false;
            this.pbLogout.Click += new System.EventHandler(this.pbLogout_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRole.Location = new System.Drawing.Point(12, 36);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(36, 16);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsername.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(12, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(119, 16);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Name Lastname";
            // 
            // ucOrderList2
            // 
            this.ucOrderList2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucOrderList2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOrderList2.Location = new System.Drawing.Point(0, 0);
            this.ucOrderList2.Name = "ucOrderList2";
            this.ucOrderList2.Padding = new System.Windows.Forms.Padding(10);
            this.ucOrderList2.SelectModeIsAdd = true;
            this.ucOrderList2.Size = new System.Drawing.Size(888, 674);
            this.ucOrderList2.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 674);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "PULSE Bikes v0.1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed_1);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlNavLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavBikes.ResumeLayout(false);
            this.pnlNavGear.ResumeLayout(false);
            this.pnlNavParts.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogout)).EndInit();
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
        private PictureBox pictureBox1;
        private Pages.Bicycle.ucBicycleList ucBicycleList1;
        private Pages.Bicycle.ucBicycleCategoryList ucBicycleCategoryList1;
        private Pages.Gear.ucGearList ucGearList1;
        private Panel pnlNavParts;
        private Button btnNavPartsCategories;
        private Button btnNavPartsSearch;
        private Button btnNavParts;
        private System.Windows.Forms.Timer tmrNavParts;
        private Pages.Part.ucPartList ucPartList1;
        private Pages.Gear.ucGearCategoryList ucGearCategoryList1;
        private Pages.Part.ucPartCategoryList ucPartCategoryList1;
        private Button btnNavBrands;
        private Pages.Brands.ucBrandList ucBrandList1;
        private Button btnNavBikesSizes;
        private Pages.Bicycle.ucBicycleSizeList ucBicycleSizeList1;
        private Button btnNavOrders;
        private Button btnNavServicing;
        private Pages.Servicing.ucServicingList ucServicingList1;
        private Button btnNavStaff;
        private Pages.Staff.ucStaffList ucStaffList1;
        private Panel panel1;
        private PictureBox pbLogout;
        private Label lblRole;
        private Label lblUsername;
        private Panel panel2;
        private Pages.Orders.ucOrderList ucOrderList2;
    }
}