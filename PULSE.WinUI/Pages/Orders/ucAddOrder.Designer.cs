namespace PULSE.WinUI.Pages.Orders
{
    partial class ucAddOrder
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
            this.bicycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.availableSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblAddBike = new System.Windows.Forms.Label();
            this.dgvAvailableSizes = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderDetailDGVItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pnlProducNumberWrapper = new System.Windows.Forms.Panel();
            this.tbOrderNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.nudShippingCost = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbStreetAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Country = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCountry = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlBottomPadding = new System.Windows.Forms.Panel();
            this.lblAddGear = new System.Windows.Forms.Label();
            this.lblAddPart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).BeginInit();
            this.pnlProducNumberWrapper.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShippingCost)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(PULSE.Model.Bicycle);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblItemTotal, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblItemTotal.Location = new System.Drawing.Point(173, 10);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblItemTotal.Size = new System.Drawing.Size(165, 16);
            this.lblItemTotal.TabIndex = 76;
            this.lblItemTotal.Text = "1000.00";
            this.lblItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipping
            // 
            this.lblShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblShipping, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblShipping.Location = new System.Drawing.Point(173, 41);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShipping.Size = new System.Drawing.Size(165, 16);
            this.lblShipping.TabIndex = 78;
            this.lblShipping.Text = "1000.00";
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblGrandTotal, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblGrandTotal.Location = new System.Drawing.Point(173, 73);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrandTotal.Size = new System.Drawing.Size(165, 16);
            this.lblGrandTotal.TabIndex = 80;
            this.lblGrandTotal.Text = "1000.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // availableSizeBindingSource
            // 
            this.availableSizeBindingSource.DataSource = typeof(PULSE.Model.AvailableSize);
            // 
            // lblAddBike
            // 
            this.lblAddBike.AutoSize = true;
            this.lblAddBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddBike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddBike.Location = new System.Drawing.Point(602, 163);
            this.lblAddBike.Name = "lblAddBike";
            this.lblAddBike.Size = new System.Drawing.Size(62, 16);
            this.lblAddBike.TabIndex = 69;
            this.lblAddBike.Text = "Add Bike";
            this.lblAddBike.Click += new System.EventHandler(this.lblAddBike_Click);
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
            this.dgvAvailableSizes.Location = new System.Drawing.Point(71, 195);
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
            this.dgvAvailableSizes.Size = new System.Drawing.Size(730, 190);
            this.dgvAvailableSizes.TabIndex = 68;
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
            // orderDetailDGVItemBindingSource
            // 
            this.orderDetailDGVItemBindingSource.DataSource = typeof(PULSE.WinUI.Pages.Orders.ProductDetailDGVItem);
            // 
            // orderDetailBindingSource
            // 
            this.orderDetailBindingSource.DataSource = typeof(PULSE.Model.OrderDetail);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label6.Location = new System.Drawing.Point(69, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "Product Number";
            // 
            // pnlProducNumberWrapper
            // 
            this.pnlProducNumberWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlProducNumberWrapper.Controls.Add(this.tbOrderNumber);
            this.pnlProducNumberWrapper.Location = new System.Drawing.Point(71, 100);
            this.pnlProducNumberWrapper.Name = "pnlProducNumberWrapper";
            this.pnlProducNumberWrapper.Size = new System.Drawing.Size(479, 35);
            this.pnlProducNumberWrapper.TabIndex = 51;
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbOrderNumber.Location = new System.Drawing.Point(10, 8);
            this.tbOrderNumber.MaxLength = 100;
            this.tbOrderNumber.Name = "tbOrderNumber";
            this.tbOrderNumber.Size = new System.Drawing.Size(445, 17);
            this.tbOrderNumber.TabIndex = 2;
            this.tbOrderNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbOrderNumber_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label10.Location = new System.Drawing.Point(67, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 62;
            this.label10.Text = "Products";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.nudShippingCost);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.Country);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(71, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 230);
            this.panel5.TabIndex = 60;
            // 
            // nudShippingCost
            // 
            this.nudShippingCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.nudShippingCost.DecimalPlaces = 2;
            this.nudShippingCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudShippingCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.nudShippingCost.Location = new System.Drawing.Point(3, 203);
            this.nudShippingCost.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudShippingCost.Name = "nudShippingCost";
            this.nudShippingCost.Size = new System.Drawing.Size(146, 24);
            this.nudShippingCost.TabIndex = 64;
            this.nudShippingCost.ValueChanged += new System.EventHandler(this.nudShippingCost_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label11.Location = new System.Drawing.Point(1, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 16);
            this.label11.TabIndex = 63;
            this.label11.Text = "Shipping Cost";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.tbStreetAddress);
            this.panel6.Location = new System.Drawing.Point(497, 116);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(238, 35);
            this.panel6.TabIndex = 60;
            // 
            // tbStreetAddress
            // 
            this.tbStreetAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbStreetAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreetAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbStreetAddress.Location = new System.Drawing.Point(10, 8);
            this.tbStreetAddress.MaxLength = 100;
            this.tbStreetAddress.Name = "tbStreetAddress";
            this.tbStreetAddress.Size = new System.Drawing.Size(196, 17);
            this.tbStreetAddress.TabIndex = 2;
            this.tbStreetAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbStreetAddress_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label7.Location = new System.Drawing.Point(496, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 16);
            this.label7.TabIndex = 61;
            this.label7.Text = "Street Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label3.Location = new System.Drawing.Point(-2, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "City";
            // 
            // Country
            // 
            this.Country.AutoSize = true;
            this.Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.Country.Location = new System.Drawing.Point(-2, 2);
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(59, 16);
            this.Country.TabIndex = 57;
            this.Country.Text = "Country";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.tbZipCode);
            this.panel3.Location = new System.Drawing.Point(247, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 35);
            this.panel3.TabIndex = 58;
            // 
            // tbZipCode
            // 
            this.tbZipCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbZipCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZipCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbZipCode.Location = new System.Drawing.Point(10, 8);
            this.tbZipCode.MaxLength = 100;
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(196, 17);
            this.tbZipCode.TabIndex = 2;
            this.tbZipCode.Validating += new System.ComponentModel.CancelEventHandler(this.tbZipCode_Validating);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.tbCity);
            this.panel4.Location = new System.Drawing.Point(0, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(238, 35);
            this.panel4.TabIndex = 60;
            // 
            // tbCity
            // 
            this.tbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbCity.Location = new System.Drawing.Point(10, 8);
            this.tbCity.MaxLength = 100;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(197, 17);
            this.tbCity.TabIndex = 2;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.tbState);
            this.panel2.Location = new System.Drawing.Point(370, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 35);
            this.panel2.TabIndex = 54;
            // 
            // tbState
            // 
            this.tbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbState.Location = new System.Drawing.Point(10, 8);
            this.tbState.MaxLength = 100;
            this.tbState.Name = "tbState";
            this.tbState.Size = new System.Drawing.Size(325, 17);
            this.tbState.TabIndex = 2;
            this.tbState.Validating += new System.ComponentModel.CancelEventHandler(this.tbState_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label5.Location = new System.Drawing.Point(247, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "Zip Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tbCountry);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 35);
            this.panel1.TabIndex = 56;
            // 
            // tbCountry
            // 
            this.tbCountry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCountry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbCountry.Location = new System.Drawing.Point(10, 8);
            this.tbCountry.MaxLength = 100;
            this.tbCountry.Name = "tbCountry";
            this.tbCountry.Size = new System.Drawing.Size(330, 17);
            this.tbCountry.TabIndex = 2;
            this.tbCountry.Validating += new System.ComponentModel.CancelEventHandler(this.tbCountry_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label4.Location = new System.Drawing.Point(370, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 16);
            this.label4.TabIndex = 55;
            this.label4.Text = "State or Province";
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
            this.btnBack.TabIndex = 57;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(557, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 50;
            this.label2.Text = "Customer";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlCustomer.Controls.Add(this.tbCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(559, 100);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(242, 35);
            this.pnlCustomer.TabIndex = 46;
            this.pnlCustomer.Click += new System.EventHandler(this.pnlCustomer_Click);
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbCustomer.Location = new System.Drawing.Point(10, 8);
            this.tbCustomer.MaxLength = 100;
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(207, 17);
            this.tbCustomer.TabIndex = 2;
            this.tbCustomer.Click += new System.EventHandler(this.tbModel_Click);
            this.tbCustomer.Validating += new System.ComponentModel.CancelEventHandler(this.tbCustomer_Validating);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(69, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(231, 25);
            this.lblTitle.TabIndex = 45;
            this.lblTitle.Text = "Register a new order";
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.cbDelivery.Location = new System.Drawing.Point(71, 420);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(84, 20);
            this.cbDelivery.TabIndex = 70;
            this.cbDelivery.Text = "Delivery";
            this.cbDelivery.UseVisualStyleBackColor = true;
            this.cbDelivery.CheckedChanged += new System.EventHandler(this.cbDelivery_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnSubmit.Location = new System.Drawing.Point(306, 824);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(262, 40);
            this.btnSubmit.TabIndex = 71;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlBottomPadding
            // 
            this.pnlBottomPadding.Location = new System.Drawing.Point(72, 864);
            this.pnlBottomPadding.Name = "pnlBottomPadding";
            this.pnlBottomPadding.Size = new System.Drawing.Size(730, 41);
            this.pnlBottomPadding.TabIndex = 72;
            // 
            // lblAddGear
            // 
            this.lblAddGear.AutoSize = true;
            this.lblAddGear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddGear.Location = new System.Drawing.Point(670, 163);
            this.lblAddGear.Name = "lblAddGear";
            this.lblAddGear.Size = new System.Drawing.Size(65, 16);
            this.lblAddGear.TabIndex = 73;
            this.lblAddGear.Text = "Add Gear";
            this.lblAddGear.Click += new System.EventHandler(this.lblAddGear_Click);
            // 
            // lblAddPart
            // 
            this.lblAddPart.AutoSize = true;
            this.lblAddPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddPart.Location = new System.Drawing.Point(742, 163);
            this.lblAddPart.Name = "lblAddPart";
            this.lblAddPart.Size = new System.Drawing.Size(59, 16);
            this.lblAddPart.TabIndex = 74;
            this.lblAddPart.Text = "Add Part";
            this.lblAddPart.Click += new System.EventHandler(this.lblAddPart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Item Total";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblGrandTotal);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.lblShipping);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.lblItemTotal);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(264, 706);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 100);
            this.panel7.TabIndex = 77;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label14.Location = new System.Drawing.Point(3, 73);
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
            this.label12.Location = new System.Drawing.Point(3, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Shipping";
            // 
            // ucAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 674);
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblAddPart);
            this.Controls.Add(this.lblAddGear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlBottomPadding);
            this.Controls.Add(this.cbDelivery);
            this.Controls.Add(this.lblAddBike);
            this.Controls.Add(this.dgvAvailableSizes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pnlProducNumberWrapper);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucAddOrder";
            this.Size = new System.Drawing.Size(854, 674);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailBindingSource)).EndInit();
            this.pnlProducNumberWrapper.ResumeLayout(false);
            this.pnlProducNumberWrapper.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShippingCost)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bicycleBindingSource;
        private ErrorProvider errorProvider;
        private Label lblAddBike;
        private DataGridView dgvAvailableSizes;
        private BindingSource availableSizeBindingSource;
        private Label label6;
        private Panel pnlProducNumberWrapper;
        private TextBox tbOrderNumber;
        private Label label10;
        private Panel panel5;
        private Button btnBack;
        private Label label2;
        private Panel pnlCustomer;
        private TextBox tbCustomer;
        private Label lblTitle;
        private CheckBox cbDelivery;
        private Panel panel6;
        private TextBox tbStreetAddress;
        private Label label7;
        private Label label3;
        private Label Country;
        private Panel panel3;
        private TextBox tbZipCode;
        private Panel panel4;
        private TextBox tbCity;
        private Panel panel2;
        private TextBox tbState;
        private Label label5;
        private Panel panel1;
        private TextBox tbCountry;
        private Label label4;
        private Label lblAddPart;
        private Label lblAddGear;
        private Button btnSubmit;
        private Panel pnlBottomPadding;
        private Label label11;
        private NumericUpDown nudShippingCost;
        private BindingSource orderDetailBindingSource;
        private BindingSource orderDetailDGVItemBindingSource;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Remove;
        private Panel panel7;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblShipping;
        private Label label12;
        private Label lblItemTotal;
        private Label label1;
    }
}
