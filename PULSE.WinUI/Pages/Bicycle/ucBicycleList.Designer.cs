namespace PULSE.WinUI.Pages.Bicycle
{
    partial class ucBicycleList
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnAdd = new Button();
            cbCategory = new ComboBox();
            cbBrand = new ComboBox();
            pnlSearchWrapper = new Panel();
            tbSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            bicycleBindingSource = new BindingSource(components);
            dgvBicycleList = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pnlDetails = new Panel();
            ucBicycleDetails1 = new ucBicycleDetails();
            productNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Brand = new DataGridViewTextBoxColumn();
            modelDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ProductCategory = new DataGridViewTextBoxColumn();
            Sizes = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pnlSearchWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bicycleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBicycleList).BeginInit();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(53, 53, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(211, 211, 213);
            btnAdd.Location = new Point(718, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(160, 40);
            btnAdd.TabIndex = 17;
            btnAdd.Text = "+ ADD BIKE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(53, 53, 64);
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(211, 211, 213);
            cbCategory.FormattingEnabled = true;
            cbCategory.ItemHeight = 16;
            cbCategory.Location = new Point(611, 68);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(130, 24);
            cbCategory.TabIndex = 16;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbBrand
            // 
            cbBrand.BackColor = Color.FromArgb(53, 53, 64);
            cbBrand.FlatStyle = FlatStyle.Flat;
            cbBrand.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.ForeColor = Color.FromArgb(211, 211, 213);
            cbBrand.FormattingEnabled = true;
            cbBrand.ItemHeight = 16;
            cbBrand.Location = new Point(472, 68);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(130, 24);
            cbBrand.TabIndex = 15;
            cbBrand.SelectedIndexChanged += cbBrand_SelectedIndexChanged;
            // 
            // pnlSearchWrapper
            // 
            pnlSearchWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlSearchWrapper.Controls.Add(tbSearch);
            pnlSearchWrapper.Location = new Point(11, 63);
            pnlSearchWrapper.Name = "pnlSearchWrapper";
            pnlSearchWrapper.Size = new Size(452, 35);
            pnlSearchWrapper.TabIndex = 14;
            // 
            // tbSearch
            // 
            tbSearch.BackColor = Color.FromArgb(53, 53, 64);
            tbSearch.BorderStyle = BorderStyle.None;
            tbSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tbSearch.ForeColor = Color.FromArgb(211, 211, 213);
            tbSearch.Location = new Point(10, 8);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Search all fields";
            tbSearch.Size = new Size(439, 17);
            tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(10, 19);
            label1.Name = "label1";
            label1.Size = new Size(279, 25);
            label1.TabIndex = 13;
            label1.Text = "Search bikes in database";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(53, 53, 64);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(211, 211, 213);
            btnSearch.Location = new Point(751, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 35);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // bicycleBindingSource
            // 
            bicycleBindingSource.DataSource = typeof(Model.Bicycle);
            // 
            // dgvBicycleList
            // 
            dgvBicycleList.AllowUserToAddRows = false;
            dgvBicycleList.AllowUserToDeleteRows = false;
            dgvBicycleList.AutoGenerateColumns = false;
            dgvBicycleList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBicycleList.BackgroundColor = Color.FromArgb(53, 53, 64);
            dgvBicycleList.BorderStyle = BorderStyle.None;
            dgvBicycleList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(173, 173, 177);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBicycleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBicycleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBicycleList.Columns.AddRange(new DataGridViewColumn[] { productNumberDataGridViewTextBoxColumn, Brand, modelDataGridViewTextBoxColumn, ProductCategory, Sizes, priceDataGridViewTextBoxColumn });
            dgvBicycleList.DataSource = bicycleBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBicycleList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBicycleList.EnableHeadersVisualStyles = false;
            dgvBicycleList.GridColor = Color.FromArgb(95, 95, 111);
            dgvBicycleList.ImeMode = ImeMode.On;
            dgvBicycleList.Location = new Point(10, 107);
            dgvBicycleList.Margin = new Padding(20);
            dgvBicycleList.Name = "dgvBicycleList";
            dgvBicycleList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBicycleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(211, 211, 213);
            dgvBicycleList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBicycleList.RowTemplate.DividerHeight = 1;
            dgvBicycleList.RowTemplate.Height = 35;
            dgvBicycleList.Size = new Size(868, 557);
            dgvBicycleList.TabIndex = 18;
            dgvBicycleList.CellDoubleClick += dgvBicycleList_CellDoubleClick;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(ucBicycleDetails1);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(888, 674);
            pnlDetails.TabIndex = 19;
            pnlDetails.Visible = false;
            // 
            // ucBicycleDetails1
            // 
            ucBicycleDetails1.AutoScroll = true;
            ucBicycleDetails1.AutoScrollMinSize = new Size(854, 674);
            ucBicycleDetails1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ucBicycleDetails1.BackColor = Color.FromArgb(39, 39, 49);
            ucBicycleDetails1.Dock = DockStyle.Fill;
            ucBicycleDetails1.Location = new Point(0, 0);
            ucBicycleDetails1.Name = "ucBicycleDetails1";
            ucBicycleDetails1.Padding = new Padding(0, 0, 0, 50);
            ucBicycleDetails1.Size = new Size(888, 674);
            ucBicycleDetails1.TabIndex = 0;
            ucBicycleDetails1.TitleAdd = "Add a New Bicycle";
            ucBicycleDetails1.TitleEdit = "Edit Bicycle";
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            productNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            productNumberDataGridViewTextBoxColumn.FillWeight = 30.22843F;
            productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Brand
            // 
            Brand.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Brand.DataPropertyName = "Brand";
            Brand.FillWeight = 17.22843F;
            Brand.HeaderText = "Brand";
            Brand.Name = "Brand";
            Brand.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            modelDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            modelDataGridViewTextBoxColumn.FillWeight = 45.85785F;
            modelDataGridViewTextBoxColumn.HeaderText = "Model";
            modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductCategory
            // 
            ProductCategory.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ProductCategory.DataPropertyName = "ProductCategory";
            ProductCategory.FillWeight = 20.22843F;
            ProductCategory.HeaderText = "Category";
            ProductCategory.Name = "ProductCategory";
            ProductCategory.ReadOnly = true;
            // 
            // Sizes
            // 
            Sizes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Sizes.DataPropertyName = "formattedSizes";
            Sizes.FillWeight = 15.22843F;
            Sizes.HeaderText = "Sizes";
            Sizes.Name = "Sizes";
            Sizes.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.FillWeight = 15.22843F;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ucBicycleList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 49);
            Controls.Add(pnlDetails);
            Controls.Add(dgvBicycleList);
            Controls.Add(btnAdd);
            Controls.Add(cbCategory);
            Controls.Add(cbBrand);
            Controls.Add(pnlSearchWrapper);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "ucBicycleList";
            Padding = new Padding(10);
            Size = new Size(888, 674);
            pnlSearchWrapper.ResumeLayout(false);
            pnlSearchWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bicycleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBicycleList).EndInit();
            pnlDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private ComboBox cbCategory;
        private ComboBox cbBrand;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private BindingSource bicycleBindingSource;
        private DataGridView dgvBicycleList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel pnlDetails;
        private ucBicycleDetails ucBicycleDetails1;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn Sizes;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}
