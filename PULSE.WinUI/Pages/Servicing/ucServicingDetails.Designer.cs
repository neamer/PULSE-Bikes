namespace PULSE.WinUI.Pages.Servicing
{
    partial class ucServicingDetails
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
            this.orderDetailDGVItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblParts = new System.Windows.Forms.Label();
            this.lblLabour = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlButtonsReview = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlFlowOffer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtbOfferDetails = new System.Windows.Forms.RichTextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.nudLabourCost = new System.Windows.Forms.NumericUpDown();
            this.dgvAvailableSizes = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAddPart = new System.Windows.Forms.Label();
            this.pnlContextBase = new System.Windows.Forms.Panel();
            this.lblSubmitOffer = new System.Windows.Forms.Label();
            this.lblCancelOffer = new System.Windows.Forms.Label();
            this.lblAddOffer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rtbRequest = new System.Windows.Forms.RichTextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProducNumberWrapper = new System.Windows.Forms.Panel();
            this.tbServicingNumber = new System.Windows.Forms.TextBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlButtonsPayment = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.pnlButtonsServicing = new System.Windows.Forms.Panel();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnCancel3 = new System.Windows.Forms.Button();
            this.pnlBottomPadding = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlButtonsReview.SuspendLayout();
            this.pnlFlowOffer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLabourCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).BeginInit();
            this.pnlContextBase.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlProducNumberWrapper.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlButtonsPayment.SuspendLayout();
            this.pnlButtonsServicing.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDetailDGVItemBindingSource
            // 
            this.orderDetailDGVItemBindingSource.DataSource = typeof(PULSE.WinUI.Pages.Orders.ProductDetailDGVItem);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblParts
            // 
            this.lblParts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblParts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblParts, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblParts.Location = new System.Drawing.Point(168, 4);
            this.lblParts.Name = "lblParts";
            this.lblParts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblParts.Size = new System.Drawing.Size(165, 16);
            this.lblParts.TabIndex = 76;
            this.lblParts.Text = "1000.00";
            this.lblParts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLabour
            // 
            this.lblLabour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLabour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLabour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblLabour, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblLabour.Location = new System.Drawing.Point(168, 35);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLabour.Size = new System.Drawing.Size(165, 16);
            this.lblLabour.TabIndex = 78;
            this.lblLabour.Text = "1000.00";
            this.lblLabour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblGrandTotal, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblGrandTotal.Location = new System.Drawing.Point(168, 67);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrandTotal.Size = new System.Drawing.Size(165, 16);
            this.lblGrandTotal.TabIndex = 80;
            this.lblGrandTotal.Text = "1000.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(69, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 25);
            this.lblTitle.TabIndex = 95;
            this.lblTitle.Text = "Servicing Details";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 40);
            this.btnBack.TabIndex = 100;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlButtonsReview
            // 
            this.pnlButtonsReview.Controls.Add(this.btnUpdate);
            this.pnlButtonsReview.Controls.Add(this.btnCancel);
            this.pnlButtonsReview.Location = new System.Drawing.Point(3, 1040);
            this.pnlButtonsReview.MaximumSize = new System.Drawing.Size(850, 86);
            this.pnlButtonsReview.MinimumSize = new System.Drawing.Size(850, 0);
            this.pnlButtonsReview.Name = "pnlButtonsReview";
            this.pnlButtonsReview.Size = new System.Drawing.Size(850, 86);
            this.pnlButtonsReview.TabIndex = 118;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnUpdate.Location = new System.Drawing.Point(178, 39);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 40);
            this.btnUpdate.TabIndex = 120;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnCancel.Location = new System.Drawing.Point(421, 39);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 40);
            this.btnCancel.TabIndex = 119;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlFlowOffer
            // 
            this.pnlFlowOffer.Controls.Add(this.panel1);
            this.pnlFlowOffer.Controls.Add(this.panel7);
            this.pnlFlowOffer.Controls.Add(this.label5);
            this.pnlFlowOffer.Controls.Add(this.label11);
            this.pnlFlowOffer.Controls.Add(this.nudLabourCost);
            this.pnlFlowOffer.Controls.Add(this.dgvAvailableSizes);
            this.pnlFlowOffer.Controls.Add(this.label10);
            this.pnlFlowOffer.Controls.Add(this.lblAddPart);
            this.pnlFlowOffer.Location = new System.Drawing.Point(3, 361);
            this.pnlFlowOffer.MaximumSize = new System.Drawing.Size(850, 678);
            this.pnlFlowOffer.MinimumSize = new System.Drawing.Size(850, 0);
            this.pnlFlowOffer.Name = "pnlFlowOffer";
            this.pnlFlowOffer.Size = new System.Drawing.Size(850, 673);
            this.pnlFlowOffer.TabIndex = 117;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.rtbOfferDetails);
            this.panel1.Location = new System.Drawing.Point(5, 369);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(840, 191);
            this.panel1.TabIndex = 115;
            // 
            // rtbOfferDetails
            // 
            this.rtbOfferDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.rtbOfferDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOfferDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbOfferDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rtbOfferDetails.Location = new System.Drawing.Point(12, 13);
            this.rtbOfferDetails.Name = "rtbOfferDetails";
            this.rtbOfferDetails.Size = new System.Drawing.Size(817, 167);
            this.rtbOfferDetails.TabIndex = 46;
            this.rtbOfferDetails.Text = "";
            this.rtbOfferDetails.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbOfferDetails_KeyPress);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblGrandTotal);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.lblLabour);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.lblParts);
            this.panel7.Controls.Add(this.label123);
            this.panel7.Location = new System.Drawing.Point(251, 570);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 100);
            this.panel7.TabIndex = 112;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label14.Location = new System.Drawing.Point(3, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 16);
            this.label14.TabIndex = 79;
            this.label14.Text = "Grand Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label12.Location = new System.Drawing.Point(3, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Labour Cost";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label123.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label123.Location = new System.Drawing.Point(3, 4);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(43, 16);
            this.label123.TabIndex = 75;
            this.label123.Text = "Parts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label5.Location = new System.Drawing.Point(3, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 116;
            this.label5.Text = "Offer Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label11.Location = new System.Drawing.Point(1, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 110;
            this.label11.Text = "Labour Cost";
            // 
            // nudLabourCost
            // 
            this.nudLabourCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.nudLabourCost.DecimalPlaces = 2;
            this.nudLabourCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudLabourCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.nudLabourCost.Location = new System.Drawing.Point(5, 287);
            this.nudLabourCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudLabourCost.Name = "nudLabourCost";
            this.nudLabourCost.Size = new System.Drawing.Size(146, 24);
            this.nudLabourCost.TabIndex = 109;
            this.nudLabourCost.ValueChanged += new System.EventHandler(this.nudLabourCost_ValueChanged);
            // 
            // dgvAvailableSizes
            // 
            this.dgvAvailableSizes.AllowUserToAddRows = false;
            this.dgvAvailableSizes.AutoGenerateColumns = false;
            this.dgvAvailableSizes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableSizes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.dgvAvailableSizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAvailableSizes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableSizes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNumberDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.Remove});
            this.dgvAvailableSizes.DataSource = this.orderDetailDGVItemBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableSizes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableSizes.EnableHeadersVisualStyles = false;
            this.dgvAvailableSizes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.dgvAvailableSizes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvAvailableSizes.Location = new System.Drawing.Point(5, 42);
            this.dgvAvailableSizes.Margin = new System.Windows.Forms.Padding(20);
            this.dgvAvailableSizes.Name = "dgvAvailableSizes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableSizes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.dgvAvailableSizes.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAvailableSizes.RowTemplate.DividerHeight = 1;
            this.dgvAvailableSizes.RowTemplate.Height = 35;
            this.dgvAvailableSizes.Size = new System.Drawing.Size(840, 190);
            this.dgvAvailableSizes.TabIndex = 103;
            this.dgvAvailableSizes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableSizes_CellContentClick);
            this.dgvAvailableSizes.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAvailableSizes_CellEndEdit);
            this.dgvAvailableSizes.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgvAvailableSizes_CellValidating);
            this.dgvAvailableSizes.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvAvailableSizes_EditingControlShowing);
            // 
            // productNumberDataGridViewTextBoxColumn
            // 
            this.productNumberDataGridViewTextBoxColumn.DataPropertyName = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.FillWeight = 85F;
            this.productNumberDataGridViewTextBoxColumn.HeaderText = "ProductNumber";
            this.productNumberDataGridViewTextBoxColumn.Name = "productNumberDataGridViewTextBoxColumn";
            this.productNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.FillWeight = 50F;
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.FillWeight = 50F;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.FillWeight = 60F;
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            this.unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.FillWeight = 45F;
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Remove.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Remove.Text = "X";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label10.Location = new System.Drawing.Point(5, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 102;
            this.label10.Text = "Parts Needed";
            // 
            // lblAddPart
            // 
            this.lblAddPart.AutoSize = true;
            this.lblAddPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddPart.Location = new System.Drawing.Point(787, 10);
            this.lblAddPart.Name = "lblAddPart";
            this.lblAddPart.Size = new System.Drawing.Size(59, 16);
            this.lblAddPart.TabIndex = 108;
            this.lblAddPart.Text = "Add Part";
            this.lblAddPart.Click += new System.EventHandler(this.lblAddPart_Click);
            // 
            // pnlContextBase
            // 
            this.pnlContextBase.Controls.Add(this.lblSubmitOffer);
            this.pnlContextBase.Controls.Add(this.lblCancelOffer);
            this.pnlContextBase.Controls.Add(this.lblAddOffer);
            this.pnlContextBase.Controls.Add(this.label4);
            this.pnlContextBase.Controls.Add(this.panel2);
            this.pnlContextBase.Controls.Add(this.panel8);
            this.pnlContextBase.Controls.Add(this.label1);
            this.pnlContextBase.Controls.Add(this.label3);
            this.pnlContextBase.Controls.Add(this.label6);
            this.pnlContextBase.Controls.Add(this.pnlProducNumberWrapper);
            this.pnlContextBase.Controls.Add(this.pnlCustomer);
            this.pnlContextBase.Controls.Add(this.label2);
            this.pnlContextBase.Location = new System.Drawing.Point(3, 3);
            this.pnlContextBase.Name = "pnlContextBase";
            this.pnlContextBase.Size = new System.Drawing.Size(850, 352);
            this.pnlContextBase.TabIndex = 115;
            // 
            // lblSubmitOffer
            // 
            this.lblSubmitOffer.AutoSize = true;
            this.lblSubmitOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSubmitOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblSubmitOffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblSubmitOffer.Location = new System.Drawing.Point(682, 322);
            this.lblSubmitOffer.Name = "lblSubmitOffer";
            this.lblSubmitOffer.Size = new System.Drawing.Size(70, 18);
            this.lblSubmitOffer.TabIndex = 119;
            this.lblSubmitOffer.Text = "SUBMIT";
            this.lblSubmitOffer.Click += new System.EventHandler(this.lblSubmitOffer_Click);
            // 
            // lblCancelOffer
            // 
            this.lblCancelOffer.AutoSize = true;
            this.lblCancelOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCancelOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblCancelOffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblCancelOffer.Location = new System.Drawing.Point(769, 322);
            this.lblCancelOffer.Name = "lblCancelOffer";
            this.lblCancelOffer.Size = new System.Drawing.Size(74, 18);
            this.lblCancelOffer.TabIndex = 118;
            this.lblCancelOffer.Text = "CANCEL";
            this.lblCancelOffer.Click += new System.EventHandler(this.lblCancelOffer_Click);
            // 
            // lblAddOffer
            // 
            this.lblAddOffer.AutoSize = true;
            this.lblAddOffer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddOffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAddOffer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddOffer.Location = new System.Drawing.Point(742, 322);
            this.lblAddOffer.Name = "lblAddOffer";
            this.lblAddOffer.Size = new System.Drawing.Size(103, 18);
            this.lblAddOffer.TabIndex = 117;
            this.lblAddOffer.Text = "ADD OFFER";
            this.lblAddOffer.Click += new System.EventHandler(this.label7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label4.Location = new System.Drawing.Point(2, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "SERVICING OFFER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.rtbRequest);
            this.panel2.Location = new System.Drawing.Point(5, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(840, 191);
            this.panel2.TabIndex = 113;
            // 
            // rtbRequest
            // 
            this.rtbRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.rtbRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rtbRequest.Location = new System.Drawing.Point(11, 12);
            this.rtbRequest.Name = "rtbRequest";
            this.rtbRequest.Size = new System.Drawing.Size(817, 166);
            this.rtbRequest.TabIndex = 46;
            this.rtbRequest.Text = "";
            this.rtbRequest.EnabledChanged += new System.EventHandler(this.rtbRequest_EnabledChanged);
            this.rtbRequest.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbRequest_KeyPress);
            this.rtbRequest.Validating += new System.ComponentModel.CancelEventHandler(this.rtbRequest_Validating);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel8.Controls.Add(this.tbStatus);
            this.panel8.Location = new System.Drawing.Point(289, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(274, 35);
            this.panel8.TabIndex = 100;
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbStatus.Location = new System.Drawing.Point(10, 9);
            this.tbStatus.MaxLength = 100;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Size = new System.Drawing.Size(241, 17);
            this.tbStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(287, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(5, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 114;
            this.label3.Text = "Request";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label6.Location = new System.Drawing.Point(3, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 16);
            this.label6.TabIndex = 99;
            this.label6.Text = "Servicing Number";
            // 
            // pnlProducNumberWrapper
            // 
            this.pnlProducNumberWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlProducNumberWrapper.Controls.Add(this.tbServicingNumber);
            this.pnlProducNumberWrapper.Location = new System.Drawing.Point(5, 28);
            this.pnlProducNumberWrapper.Name = "pnlProducNumberWrapper";
            this.pnlProducNumberWrapper.Size = new System.Drawing.Size(273, 35);
            this.pnlProducNumberWrapper.TabIndex = 98;
            // 
            // tbServicingNumber
            // 
            this.tbServicingNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbServicingNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServicingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbServicingNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbServicingNumber.Location = new System.Drawing.Point(10, 9);
            this.tbServicingNumber.MaxLength = 100;
            this.tbServicingNumber.Name = "tbServicingNumber";
            this.tbServicingNumber.Size = new System.Drawing.Size(241, 17);
            this.tbServicingNumber.TabIndex = 2;
            this.tbServicingNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbServicingNumber_Validating);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlCustomer.Controls.Add(this.tbCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(572, 28);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(273, 35);
            this.pnlCustomer.TabIndex = 96;
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbCustomer.Location = new System.Drawing.Point(10, 9);
            this.tbCustomer.MaxLength = 100;
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(233, 17);
            this.tbCustomer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(570, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 97;
            this.label2.Text = "Customer";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.pnlContextBase);
            this.flowLayoutPanel1.Controls.Add(this.pnlFlowOffer);
            this.flowLayoutPanel1.Controls.Add(this.pnlButtonsReview);
            this.flowLayoutPanel1.Controls.Add(this.pnlButtonsPayment);
            this.flowLayoutPanel1.Controls.Add(this.pnlButtonsServicing);
            this.flowLayoutPanel1.Controls.Add(this.pnlBottomPadding);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 79);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(856, 1371);
            this.flowLayoutPanel1.TabIndex = 116;
            // 
            // pnlButtonsPayment
            // 
            this.pnlButtonsPayment.Controls.Add(this.btnPayment);
            this.pnlButtonsPayment.Controls.Add(this.btnCancel2);
            this.pnlButtonsPayment.Location = new System.Drawing.Point(3, 1132);
            this.pnlButtonsPayment.MaximumSize = new System.Drawing.Size(850, 86);
            this.pnlButtonsPayment.MinimumSize = new System.Drawing.Size(850, 0);
            this.pnlButtonsPayment.Name = "pnlButtonsPayment";
            this.pnlButtonsPayment.Size = new System.Drawing.Size(850, 86);
            this.pnlButtonsPayment.TabIndex = 121;
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnPayment.Location = new System.Drawing.Point(178, 39);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(237, 40);
            this.btnPayment.TabIndex = 120;
            this.btnPayment.Text = "REGISTER PAYMENT";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCancel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnCancel2.Location = new System.Drawing.Point(421, 39);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(237, 40);
            this.btnCancel2.TabIndex = 119;
            this.btnCancel2.Text = "CANCEL";
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // pnlButtonsServicing
            // 
            this.pnlButtonsServicing.Controls.Add(this.btnCompleted);
            this.pnlButtonsServicing.Controls.Add(this.btnCancel3);
            this.pnlButtonsServicing.Location = new System.Drawing.Point(3, 1224);
            this.pnlButtonsServicing.MaximumSize = new System.Drawing.Size(850, 86);
            this.pnlButtonsServicing.MinimumSize = new System.Drawing.Size(850, 0);
            this.pnlButtonsServicing.Name = "pnlButtonsServicing";
            this.pnlButtonsServicing.Size = new System.Drawing.Size(850, 86);
            this.pnlButtonsServicing.TabIndex = 122;
            // 
            // btnCompleted
            // 
            this.btnCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnCompleted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCompleted.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnCompleted.Location = new System.Drawing.Point(178, 39);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(237, 40);
            this.btnCompleted.TabIndex = 120;
            this.btnCompleted.Text = "COMPLETED";
            this.btnCompleted.UseVisualStyleBackColor = false;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnCancel3
            // 
            this.btnCancel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCancel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnCancel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnCancel3.Location = new System.Drawing.Point(421, 39);
            this.btnCancel3.Name = "btnCancel3";
            this.btnCancel3.Size = new System.Drawing.Size(237, 40);
            this.btnCancel3.TabIndex = 119;
            this.btnCancel3.Text = "CANCEL";
            this.btnCancel3.UseVisualStyleBackColor = false;
            this.btnCancel3.Click += new System.EventHandler(this.btnCancel3_Click);
            // 
            // pnlBottomPadding
            // 
            this.pnlBottomPadding.Location = new System.Drawing.Point(3, 1316);
            this.pnlBottomPadding.Name = "pnlBottomPadding";
            this.pnlBottomPadding.Size = new System.Drawing.Size(850, 52);
            this.pnlBottomPadding.TabIndex = 119;
            // 
            // ucServicingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 674);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Name = "ucServicingDetails";
            this.Size = new System.Drawing.Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlButtonsReview.ResumeLayout(false);
            this.pnlFlowOffer.ResumeLayout(false);
            this.pnlFlowOffer.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLabourCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).EndInit();
            this.pnlContextBase.ResumeLayout(false);
            this.pnlContextBase.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.pnlProducNumberWrapper.ResumeLayout(false);
            this.pnlProducNumberWrapper.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlButtonsPayment.ResumeLayout(false);
            this.pnlButtonsServicing.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource orderDetailDGVItemBindingSource;
        private ErrorProvider errorProvider;
        private Label lblTitle;
        private Button btnBack;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel pnlContextBase;
        private Label label4;
        private Panel panel2;
        private RichTextBox rtbRequest;
        private Panel panel8;
        private TextBox tbStatus;
        private Label label1;
        private Label label3;
        private Label label6;
        private Panel pnlProducNumberWrapper;
        private TextBox tbServicingNumber;
        private Panel pnlCustomer;
        private TextBox tbCustomer;
        private Label label2;
        private Panel pnlFlowOffer;
        private Panel panel1;
        private RichTextBox rtbOfferDetails;
        private Panel panel7;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblLabour;
        private Label label12;
        private Label lblParts;
        private Label label123;
        private Label label5;
        private Label label11;
        private NumericUpDown nudLabourCost;
        private DataGridView dgvAvailableSizes;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Remove;
        private Label label10;
        private Label lblAddPart;
        private Panel pnlButtonsReview;
        private Button btnCancel;
        private Label lblAddOffer;
        private Label lblSubmitOffer;
        private Label lblCancelOffer;
        private Panel pnlBottomPadding;
        private Button btnUpdate;
        private Panel pnlButtonsPayment;
        private Button btnPayment;
        private Button btnCancel2;
        private Panel pnlButtonsServicing;
        private Button btnCompleted;
        private Button btnCancel3;
    }
}
