namespace PULSE.WinUI.Pages.Bicycle
{
    partial class ucBicycleDetails
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnSubmit = new Button();
            cbCategory = new ComboBox();
            cbBrand = new ComboBox();
            pnlModelWrapper = new Panel();
            tbModel = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rtbDescription = new RichTextBox();
            label5 = new Label();
            btnBack = new Button();
            panel3 = new Panel();
            tbWheelSize = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            pnlBottomPadding = new Panel();
            nudWeight = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            nudPrice = new NumericUpDown();
            label6 = new Label();
            pnlProducNumberWrapper = new Panel();
            tbProductNumber = new TextBox();
            nudProductionYear = new NumericUpDown();
            errorProvider = new ErrorProvider(components);
            bicycleBindingSource = new BindingSource(components);
            dgvAvailableSizes = new DataGridView();
            bicycleSizeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            availableSizeBindingSource = new BindingSource(components);
            label1 = new Label();
            dgvImages = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Image = new DataGridViewImageColumn();
            ImageAction = new DataGridViewButtonColumn();
            productImageDGVModelBindingSource = new BindingSource(components);
            lblAddImage = new Label();
            pnlModelWrapper.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            pnlProducNumberWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductionYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bicycleBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableSizes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableSizeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImageDGVModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(53, 53, 64);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.FromArgb(211, 211, 213);
            btnSubmit.Location = new Point(314, 1039);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(262, 40);
            btnSubmit.TabIndex = 23;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(53, 53, 64);
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(211, 211, 213);
            cbCategory.FormattingEnabled = true;
            cbCategory.ItemHeight = 16;
            cbCategory.Location = new Point(624, 172);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(180, 24);
            cbCategory.TabIndex = 22;
            cbCategory.Validating += cbCategory_Validating;
            // 
            // cbBrand
            // 
            cbBrand.BackColor = Color.FromArgb(53, 53, 64);
            cbBrand.FlatStyle = FlatStyle.Flat;
            cbBrand.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbBrand.ForeColor = Color.FromArgb(211, 211, 213);
            cbBrand.FormattingEnabled = true;
            cbBrand.ItemHeight = 16;
            cbBrand.Location = new Point(624, 93);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(180, 24);
            cbBrand.TabIndex = 21;
            cbBrand.Validating += cbBrand_Validating;
            // 
            // pnlModelWrapper
            // 
            pnlModelWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlModelWrapper.Controls.Add(tbModel);
            pnlModelWrapper.Location = new Point(74, 172);
            pnlModelWrapper.Name = "pnlModelWrapper";
            pnlModelWrapper.Size = new Size(542, 35);
            pnlModelWrapper.TabIndex = 20;
            // 
            // tbModel
            // 
            tbModel.BackColor = Color.FromArgb(53, 53, 64);
            tbModel.BorderStyle = BorderStyle.None;
            tbModel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbModel.ForeColor = Color.FromArgb(211, 211, 213);
            tbModel.Location = new Point(10, 8);
            tbModel.MaxLength = 100;
            tbModel.Name = "tbModel";
            tbModel.Size = new Size(510, 17);
            tbModel.TabIndex = 2;
            tbModel.Validating += tbModel_Validating;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonFace;
            lblTitle.Location = new Point(72, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(208, 25);
            lblTitle.TabIndex = 19;
            lblTitle.Text = "Add a New Bicycle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(173, 173, 177);
            label2.Location = new Point(72, 145);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 24;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(173, 173, 177);
            label3.Location = new Point(624, 66);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 25;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(173, 173, 177);
            label4.Location = new Point(624, 145);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 26;
            label4.Text = "Category";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(53, 53, 64);
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescription.ForeColor = Color.FromArgb(211, 211, 213);
            rtbDescription.Location = new Point(74, 257);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(730, 120);
            rtbDescription.TabIndex = 27;
            rtbDescription.Text = "";
            rtbDescription.Validating += rtbDescription_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 173, 177);
            label5.Location = new Point(73, 230);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 28;
            label5.Text = "Description";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(53, 53, 64);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(211, 211, 213);
            btnBack.Location = new Point(13, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 40);
            btnBack.TabIndex = 29;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(53, 53, 64);
            panel3.Controls.Add(tbWheelSize);
            panel3.Location = new Point(77, 437);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 35);
            panel3.TabIndex = 22;
            // 
            // tbWheelSize
            // 
            tbWheelSize.BackColor = Color.FromArgb(53, 53, 64);
            tbWheelSize.BorderStyle = BorderStyle.None;
            tbWheelSize.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbWheelSize.ForeColor = Color.FromArgb(211, 211, 213);
            tbWheelSize.Location = new Point(10, 8);
            tbWheelSize.Name = "tbWheelSize";
            tbWheelSize.Size = new Size(229, 17);
            tbWheelSize.TabIndex = 2;
            tbWheelSize.Validating += tbWheelSize_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(173, 173, 177);
            label7.Location = new Point(500, 407);
            label7.Name = "label7";
            label7.Size = new Size(118, 16);
            label7.TabIndex = 31;
            label7.Text = "Production Year";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(173, 173, 177);
            label8.Location = new Point(74, 407);
            label8.Name = "label8";
            label8.Size = new Size(85, 16);
            label8.TabIndex = 32;
            label8.Text = "Wheel Size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(173, 173, 177);
            label9.Location = new Point(70, 506);
            label9.Name = "label9";
            label9.Size = new Size(58, 16);
            label9.TabIndex = 34;
            label9.Text = "Images";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(173, 173, 177);
            label10.Location = new Point(70, 775);
            label10.Name = "label10";
            label10.Size = new Size(115, 16);
            label10.TabIndex = 36;
            label10.Text = "Available Sizes";
            // 
            // pnlBottomPadding
            // 
            pnlBottomPadding.Location = new Point(76, 1080);
            pnlBottomPadding.Name = "pnlBottomPadding";
            pnlBottomPadding.Size = new Size(730, 41);
            pnlBottomPadding.TabIndex = 37;
            // 
            // nudWeight
            // 
            nudWeight.BackColor = Color.FromArgb(53, 53, 64);
            nudWeight.DecimalPlaces = 2;
            nudWeight.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudWeight.ForeColor = Color.FromArgb(211, 211, 213);
            nudWeight.Location = new Point(347, 438);
            nudWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nudWeight.Name = "nudWeight";
            nudWeight.Size = new Size(146, 24);
            nudWeight.TabIndex = 38;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(173, 173, 177);
            label11.Location = new Point(341, 407);
            label11.Name = "label11";
            label11.Size = new Size(55, 16);
            label11.TabIndex = 39;
            label11.Text = "Weight";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(173, 173, 177);
            label12.Location = new Point(654, 407);
            label12.Name = "label12";
            label12.Size = new Size(43, 16);
            label12.TabIndex = 41;
            label12.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(53, 53, 64);
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudPrice.ForeColor = Color.FromArgb(211, 211, 213);
            nudPrice.Location = new Point(658, 438);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(146, 24);
            nudPrice.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(173, 173, 177);
            label6.Location = new Point(72, 66);
            label6.Name = "label6";
            label6.Size = new Size(118, 16);
            label6.TabIndex = 26;
            label6.Text = "Product Number";
            // 
            // pnlProducNumberWrapper
            // 
            pnlProducNumberWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlProducNumberWrapper.Controls.Add(tbProductNumber);
            pnlProducNumberWrapper.Location = new Point(74, 93);
            pnlProducNumberWrapper.Name = "pnlProducNumberWrapper";
            pnlProducNumberWrapper.Size = new Size(542, 35);
            pnlProducNumberWrapper.TabIndex = 25;
            // 
            // tbProductNumber
            // 
            tbProductNumber.BackColor = Color.FromArgb(53, 53, 64);
            tbProductNumber.BorderStyle = BorderStyle.None;
            tbProductNumber.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbProductNumber.ForeColor = Color.FromArgb(211, 211, 213);
            tbProductNumber.Location = new Point(10, 8);
            tbProductNumber.MaxLength = 100;
            tbProductNumber.Name = "tbProductNumber";
            tbProductNumber.Size = new Size(510, 17);
            tbProductNumber.TabIndex = 2;
            tbProductNumber.Validating += tbProductNumber_Validating;
            // 
            // nudProductionYear
            // 
            nudProductionYear.BackColor = Color.FromArgb(53, 53, 64);
            nudProductionYear.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudProductionYear.ForeColor = Color.FromArgb(211, 211, 213);
            nudProductionYear.Location = new Point(502, 438);
            nudProductionYear.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudProductionYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudProductionYear.Name = "nudProductionYear";
            nudProductionYear.Size = new Size(146, 24);
            nudProductionYear.TabIndex = 42;
            nudProductionYear.Value = new decimal(new int[] { 2022, 0, 0, 0 });
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // bicycleBindingSource
            // 
            bicycleBindingSource.DataSource = typeof(Model.Bicycle);
            // 
            // dgvAvailableSizes
            // 
            dgvAvailableSizes.AllowUserToAddRows = false;
            dgvAvailableSizes.AllowUserToDeleteRows = false;
            dgvAvailableSizes.AutoGenerateColumns = false;
            dgvAvailableSizes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvailableSizes.BackgroundColor = Color.FromArgb(53, 53, 64);
            dgvAvailableSizes.BorderStyle = BorderStyle.None;
            dgvAvailableSizes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(173, 173, 177);
            dataGridViewCellStyle5.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvAvailableSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvAvailableSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableSizes.Columns.AddRange(new DataGridViewColumn[] { bicycleSizeDataGridViewTextBoxColumn, availableQtyDataGridViewTextBoxColumn, Action });
            dgvAvailableSizes.DataSource = availableSizeBindingSource;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvAvailableSizes.DefaultCellStyle = dataGridViewCellStyle6;
            dgvAvailableSizes.EnableHeadersVisualStyles = false;
            dgvAvailableSizes.GridColor = Color.FromArgb(95, 95, 111);
            dgvAvailableSizes.ImeMode = ImeMode.On;
            dgvAvailableSizes.Location = new Point(74, 807);
            dgvAvailableSizes.Margin = new Padding(20);
            dgvAvailableSizes.Name = "dgvAvailableSizes";
            dgvAvailableSizes.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvAvailableSizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(211, 211, 213);
            dgvAvailableSizes.RowsDefaultCellStyle = dataGridViewCellStyle8;
            dgvAvailableSizes.RowTemplate.DividerHeight = 1;
            dgvAvailableSizes.RowTemplate.Height = 35;
            dgvAvailableSizes.Size = new Size(730, 190);
            dgvAvailableSizes.TabIndex = 43;
            dgvAvailableSizes.CellContentClick += dgvAvailableSizes_CellContentClick;
            dgvAvailableSizes.CellDoubleClick += dgvAvailableSizes_CellDoubleClick;
            // 
            // bicycleSizeDataGridViewTextBoxColumn
            // 
            bicycleSizeDataGridViewTextBoxColumn.DataPropertyName = "BicycleSize";
            bicycleSizeDataGridViewTextBoxColumn.FillWeight = 170F;
            bicycleSizeDataGridViewTextBoxColumn.HeaderText = "BicycleSize";
            bicycleSizeDataGridViewTextBoxColumn.Name = "bicycleSizeDataGridViewTextBoxColumn";
            bicycleSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availableQtyDataGridViewTextBoxColumn
            // 
            availableQtyDataGridViewTextBoxColumn.DataPropertyName = "AvailableQty";
            availableQtyDataGridViewTextBoxColumn.FillWeight = 170F;
            availableQtyDataGridViewTextBoxColumn.HeaderText = "AvailableQty";
            availableQtyDataGridViewTextBoxColumn.Name = "availableQtyDataGridViewTextBoxColumn";
            availableQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Text = "Delete";
            Action.UseColumnTextForButtonValue = true;
            // 
            // availableSizeBindingSource
            // 
            availableSizeBindingSource.DataSource = typeof(Model.AvailableSize);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(173, 173, 177);
            label1.Location = new Point(769, 775);
            label1.Name = "label1";
            label1.Size = new Size(32, 16);
            label1.TabIndex = 44;
            label1.Text = "Add";
            label1.Click += label1_Click;
            // 
            // dgvImages
            // 
            dgvImages.AllowUserToAddRows = false;
            dgvImages.AllowUserToDeleteRows = false;
            dgvImages.AutoGenerateColumns = false;
            dgvImages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImages.BackgroundColor = Color.FromArgb(53, 53, 64);
            dgvImages.BorderStyle = BorderStyle.None;
            dgvImages.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(173, 173, 177);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvImages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvImages.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, Image, ImageAction });
            dgvImages.DataSource = productImageDGVModelBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvImages.DefaultCellStyle = dataGridViewCellStyle2;
            dgvImages.EnableHeadersVisualStyles = false;
            dgvImages.GridColor = Color.FromArgb(95, 95, 111);
            dgvImages.ImeMode = ImeMode.On;
            dgvImages.Location = new Point(77, 542);
            dgvImages.Margin = new Padding(20);
            dgvImages.Name = "dgvImages";
            dgvImages.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvImages.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(211, 211, 213);
            dgvImages.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvImages.RowTemplate.DividerHeight = 1;
            dgvImages.RowTemplate.Height = 35;
            dgvImages.Size = new Size(730, 190);
            dgvImages.TabIndex = 45;
            dgvImages.CellContentClick += dgvImages_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.FillWeight = 44.27554F;
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.FillWeight = 136.28566F;
            Image.HeaderText = "Image";
            Image.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Image.Name = "Image";
            Image.ReadOnly = true;
            // 
            // ImageAction
            // 
            ImageAction.FillWeight = 51.9260979F;
            ImageAction.HeaderText = "Action";
            ImageAction.Name = "ImageAction";
            ImageAction.ReadOnly = true;
            ImageAction.Text = "DELETE";
            // 
            // productImageDGVModelBindingSource
            // 
            productImageDGVModelBindingSource.DataSource = typeof(ProductImage.ProductImageDGVModel);
            // 
            // lblAddImage
            // 
            lblAddImage.AutoSize = true;
            lblAddImage.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblAddImage.ForeColor = Color.FromArgb(173, 173, 177);
            lblAddImage.Location = new Point(769, 506);
            lblAddImage.Name = "lblAddImage";
            lblAddImage.Size = new Size(32, 16);
            lblAddImage.TabIndex = 46;
            lblAddImage.Text = "Add";
            lblAddImage.Click += lblAddImage_Click;
            // 
            // ucBicycleDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(854, 674);
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(39, 39, 49);
            Controls.Add(lblAddImage);
            Controls.Add(dgvImages);
            Controls.Add(label1);
            Controls.Add(dgvAvailableSizes);
            Controls.Add(nudProductionYear);
            Controls.Add(label6);
            Controls.Add(btnSubmit);
            Controls.Add(pnlProducNumberWrapper);
            Controls.Add(label12);
            Controls.Add(nudPrice);
            Controls.Add(label11);
            Controls.Add(nudWeight);
            Controls.Add(pnlBottomPadding);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(btnBack);
            Controls.Add(label5);
            Controls.Add(rtbDescription);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbCategory);
            Controls.Add(cbBrand);
            Controls.Add(pnlModelWrapper);
            Controls.Add(lblTitle);
            Name = "ucBicycleDetails";
            Padding = new Padding(0, 0, 0, 50);
            Size = new Size(838, 600);
            Load += ucBicycleDetails_Load;
            pnlModelWrapper.ResumeLayout(false);
            pnlModelWrapper.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            pnlProducNumberWrapper.ResumeLayout(false);
            pnlProducNumberWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudProductionYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)bicycleBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableSizes).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableSizeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImageDGVModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private ComboBox cbCategory;
        private ComboBox cbBrand;
        private Panel pnlModelWrapper;
        private TextBox tbModel;
        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label label4;
        private RichTextBox rtbDescription;
        private Label label5;
        private Button btnBack;
        private Panel panel3;
        private TextBox tbWheelSize;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel pnlBottomPadding;
        private NumericUpDown nudWeight;
        private Label label11;
        private Label label12;
        private NumericUpDown nudPrice;
        private Label label6;
        private Panel pnlProducNumberWrapper;
        private TextBox tbProductNumber;
        private NumericUpDown nudProductionYear;
        private ErrorProvider errorProvider;
        private Label label1;
        private DataGridView dgvAvailableSizes;
        private BindingSource bicycleBindingSource;
        private DataGridViewTextBoxColumn bicycleSizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableQtyDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
        private BindingSource availableSizeBindingSource;
        private DataGridView dgvImages;
        private Label lblAddImage;
        private DataGridViewImageColumn dataDataGridViewImageColumn;
        private BindingSource productImageDGVModelBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Image;
        private DataGridViewButtonColumn ImageAction;
    }
}
