namespace PULSE.WinUI.Pages.Gear
{
    partial class ucGearDetails
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
            nudQuantity = new NumericUpDown();
            label6 = new Label();
            pnlProducNumberWrapper = new Panel();
            tbProductNumber = new TextBox();
            label9 = new Label();
            label7 = new Label();
            btnBack = new Button();
            label5 = new Label();
            rtbDescription = new RichTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbCategory = new ComboBox();
            cbBrand = new ComboBox();
            pnlModelWrapper = new Panel();
            tbModel = new TextBox();
            lblTitle = new Label();
            btnSubmit = new Button();
            pnlBottomPadding = new Panel();
            errorProvider = new ErrorProvider(components);
            label12 = new Label();
            nudPrice = new NumericUpDown();
            lblAddImage = new Label();
            dgvImages = new DataGridView();
            Image = new DataGridViewImageColumn();
            ImageAction = new DataGridViewButtonColumn();
            productImageDGVModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).BeginInit();
            pnlProducNumberWrapper.SuspendLayout();
            pnlModelWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvImages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImageDGVModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nudQuantity
            // 
            nudQuantity.BackColor = Color.FromArgb(53, 53, 64);
            nudQuantity.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudQuantity.ForeColor = Color.FromArgb(211, 211, 213);
            nudQuantity.Location = new Point(75, 441);
            nudQuantity.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(146, 24);
            nudQuantity.TabIndex = 66;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(173, 173, 177);
            label6.Location = new Point(71, 66);
            label6.Name = "label6";
            label6.Size = new Size(118, 16);
            label6.TabIndex = 51;
            label6.Text = "Product Number";
            // 
            // pnlProducNumberWrapper
            // 
            pnlProducNumberWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlProducNumberWrapper.Controls.Add(tbProductNumber);
            pnlProducNumberWrapper.Location = new Point(73, 93);
            pnlProducNumberWrapper.Name = "pnlProducNumberWrapper";
            pnlProducNumberWrapper.Size = new Size(542, 35);
            pnlProducNumberWrapper.TabIndex = 49;
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
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(173, 173, 177);
            label9.Location = new Point(69, 501);
            label9.Name = "label9";
            label9.Size = new Size(58, 16);
            label9.TabIndex = 59;
            label9.Text = "Images";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(173, 173, 177);
            label7.Location = new Point(73, 410);
            label7.Name = "label7";
            label7.Size = new Size(133, 16);
            label7.TabIndex = 56;
            label7.Text = "Available Quantity";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(53, 53, 64);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(211, 211, 213);
            btnBack.Location = new Point(12, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(42, 40);
            btnBack.TabIndex = 55;
            btnBack.Text = "<";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(173, 173, 177);
            label5.Location = new Point(72, 230);
            label5.Name = "label5";
            label5.Size = new Size(86, 16);
            label5.TabIndex = 54;
            label5.Text = "Description";
            // 
            // rtbDescription
            // 
            rtbDescription.BackColor = Color.FromArgb(53, 53, 64);
            rtbDescription.BorderStyle = BorderStyle.None;
            rtbDescription.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rtbDescription.ForeColor = Color.FromArgb(211, 211, 213);
            rtbDescription.Location = new Point(73, 257);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(730, 120);
            rtbDescription.TabIndex = 53;
            rtbDescription.Text = "";
            rtbDescription.Validating += rtbDescription_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(173, 173, 177);
            label4.Location = new Point(623, 145);
            label4.Name = "label4";
            label4.Size = new Size(70, 16);
            label4.TabIndex = 52;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(173, 173, 177);
            label3.Location = new Point(623, 66);
            label3.Name = "label3";
            label3.Size = new Size(48, 16);
            label3.TabIndex = 50;
            label3.Text = "Brand";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(173, 173, 177);
            label2.Location = new Point(71, 145);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 48;
            label2.Text = "Model";
            // 
            // cbCategory
            // 
            cbCategory.BackColor = Color.FromArgb(53, 53, 64);
            cbCategory.FlatStyle = FlatStyle.Flat;
            cbCategory.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategory.ForeColor = Color.FromArgb(211, 211, 213);
            cbCategory.FormattingEnabled = true;
            cbCategory.ItemHeight = 16;
            cbCategory.Location = new Point(623, 172);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(180, 24);
            cbCategory.TabIndex = 46;
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
            cbBrand.Location = new Point(623, 93);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(180, 24);
            cbBrand.TabIndex = 45;
            cbBrand.Validating += cbBrand_Validating;
            // 
            // pnlModelWrapper
            // 
            pnlModelWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlModelWrapper.Controls.Add(tbModel);
            pnlModelWrapper.Location = new Point(73, 172);
            pnlModelWrapper.Name = "pnlModelWrapper";
            pnlModelWrapper.Size = new Size(542, 35);
            pnlModelWrapper.TabIndex = 44;
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
            lblTitle.Location = new Point(71, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(111, 25);
            lblTitle.TabIndex = 43;
            lblTitle.Text = "Add Gear";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(53, 53, 64);
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmit.ForeColor = Color.FromArgb(211, 211, 213);
            btnSubmit.Location = new Point(317, 782);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(262, 40);
            btnSubmit.TabIndex = 67;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pnlBottomPadding
            // 
            pnlBottomPadding.Location = new Point(71, 822);
            pnlBottomPadding.Name = "pnlBottomPadding";
            pnlBottomPadding.Size = new Size(730, 41);
            pnlBottomPadding.TabIndex = 68;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(173, 173, 177);
            label12.Location = new Point(231, 410);
            label12.Name = "label12";
            label12.Size = new Size(43, 16);
            label12.TabIndex = 70;
            label12.Text = "Price";
            // 
            // nudPrice
            // 
            nudPrice.BackColor = Color.FromArgb(53, 53, 64);
            nudPrice.DecimalPlaces = 2;
            nudPrice.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nudPrice.ForeColor = Color.FromArgb(211, 211, 213);
            nudPrice.Location = new Point(235, 441);
            nudPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(146, 24);
            nudPrice.TabIndex = 69;
            // 
            // lblAddImage
            // 
            lblAddImage.AutoSize = true;
            lblAddImage.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            lblAddImage.ForeColor = Color.FromArgb(173, 173, 177);
            lblAddImage.Location = new Point(767, 500);
            lblAddImage.Name = "lblAddImage";
            lblAddImage.Size = new Size(32, 16);
            lblAddImage.TabIndex = 72;
            lblAddImage.Text = "Add";
            lblAddImage.Click += lblAddImage_Click;
            // 
            // dgvImages
            // 
            dgvImages.AllowUserToAddRows = false;
            dgvImages.AllowUserToDeleteRows = false;
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
            dgvImages.Columns.AddRange(new DataGridViewColumn[] { Image, ImageAction });
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
            dgvImages.Location = new Point(74, 536);
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
            dgvImages.TabIndex = 71;
            dgvImages.CellContentClick += dgvImages_CellContentClick;
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
            // ucGearDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMinSize = new Size(854, 674);
            BackColor = Color.FromArgb(39, 39, 49);
            Controls.Add(lblAddImage);
            Controls.Add(dgvImages);
            Controls.Add(label12);
            Controls.Add(nudPrice);
            Controls.Add(btnSubmit);
            Controls.Add(nudQuantity);
            Controls.Add(pnlBottomPadding);
            Controls.Add(label6);
            Controls.Add(pnlProducNumberWrapper);
            Controls.Add(label9);
            Controls.Add(label7);
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
            Name = "ucGearDetails";
            Size = new Size(825, 627);
            ((System.ComponentModel.ISupportInitialize)nudQuantity).EndInit();
            pnlProducNumberWrapper.ResumeLayout(false);
            pnlProducNumberWrapper.PerformLayout();
            pnlModelWrapper.ResumeLayout(false);
            pnlModelWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvImages).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImageDGVModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudQuantity;
        private Label label6;
        private Panel pnlProducNumberWrapper;
        private TextBox tbProductNumber;
        private Label label9;
        private Label label7;
        private Button btnBack;
        private Label label5;
        private RichTextBox rtbDescription;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbCategory;
        private ComboBox cbBrand;
        private Panel pnlModelWrapper;
        private TextBox tbModel;
        private Label lblTitle;
        private Button btnSubmit;
        private Panel pnlBottomPadding;
        private ErrorProvider errorProvider;
        private Label label12;
        private NumericUpDown nudPrice;
        private Label lblAddImage;
        private DataGridView dgvImages;
        private BindingSource productImageDGVModelBindingSource;
        private DataGridViewImageColumn Image;
        private DataGridViewButtonColumn ImageAction;
    }
}
