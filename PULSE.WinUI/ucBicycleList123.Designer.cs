namespace PULSE.WinUI
{
    partial class ucBicycleList123
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBicycleList = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sizes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbBrand = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicycleList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBicycleList
            // 
            this.dgvBicycleList.AllowUserToAddRows = false;
            this.dgvBicycleList.AllowUserToDeleteRows = false;
            this.dgvBicycleList.AutoGenerateColumns = false;
            this.dgvBicycleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBicycleList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.dgvBicycleList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBicycleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBicycleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBicycleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBicycleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.Brand,
            this.modelDataGridViewTextBoxColumn,
            this.ProductCategory,
            this.Sizes,
            this.priceDataGridViewTextBoxColumn});
            this.dgvBicycleList.DataSource = this.bicycleBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBicycleList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBicycleList.EnableHeadersVisualStyles = false;
            this.dgvBicycleList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.dgvBicycleList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvBicycleList.Location = new System.Drawing.Point(10, 107);
            this.dgvBicycleList.Margin = new System.Windows.Forms.Padding(20);
            this.dgvBicycleList.Name = "dgvBicycleList";
            this.dgvBicycleList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBicycleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.dgvBicycleList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBicycleList.RowTemplate.DividerHeight = 1;
            this.dgvBicycleList.RowTemplate.Height = 35;
            this.dgvBicycleList.Size = new System.Drawing.Size(868, 557);
            this.dgvBicycleList.TabIndex = 0;
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.FillWeight = 30.22843F;
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Brand
            // 
            this.Brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Brand.DataPropertyName = "Brand";
            this.Brand.FillWeight = 17.22843F;
            this.Brand.HeaderText = "Brand";
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.FillWeight = 45.85785F;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductCategory
            // 
            this.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductCategory.DataPropertyName = "ProductCategory";
            this.ProductCategory.FillWeight = 20.22843F;
            this.ProductCategory.HeaderText = "Category";
            this.ProductCategory.Name = "ProductCategory";
            this.ProductCategory.ReadOnly = true;
            // 
            // Sizes
            // 
            this.Sizes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sizes.FillWeight = 15.22843F;
            this.Sizes.HeaderText = "Sizes";
            this.Sizes.Name = "Sizes";
            this.Sizes.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 15.22843F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(PULSE.Model.Bicycle);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnSearch.Location = new System.Drawing.Point(751, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbSearch.Location = new System.Drawing.Point(10, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "Search all fields";
            this.tbSearch.Size = new System.Drawing.Size(439, 17);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search bikes in database";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Location = new System.Drawing.Point(11, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 35);
            this.panel1.TabIndex = 8;
            // 
            // cbBrand
            // 
            this.cbBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.cbBrand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.cbBrand.FormattingEnabled = true;
            this.cbBrand.ItemHeight = 16;
            this.cbBrand.Items.AddRange(new object[] {
            "Select Brand"});
            this.cbBrand.Location = new System.Drawing.Point(472, 67);
            this.cbBrand.Name = "cbBrand";
            this.cbBrand.Size = new System.Drawing.Size(130, 24);
            this.cbBrand.TabIndex = 9;
            this.cbBrand.SelectedIndexChanged += new System.EventHandler(this.cbBrand_SelectedIndexChanged);
            this.cbBrand.SelectedValueChanged += new System.EventHandler(this.cbBrand_SelectedValueChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.cbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.ItemHeight = 16;
            this.cbCategory.Items.AddRange(new object[] {
            "Select Category"});
            this.cbCategory.Location = new System.Drawing.Point(611, 67);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(130, 24);
            this.cbCategory.TabIndex = 10;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.button1.Location = new System.Drawing.Point(718, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "+ ADD BIKE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ucBicycleList123
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.cbBrand);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvBicycleList);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucBicycleList123";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBicycleList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvBicycleList;
        private Button btnSearch;
        private TextBox tbSearch;
        private Label label1;
        private Panel panel1;
        private ComboBox cbBrand;
        private ComboBox cbCategory;
        private DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
        private BindingSource bicycleBindingSource;
        private Button button1;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Brand;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ProductCategory;
        private DataGridViewTextBoxColumn Sizes;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}
