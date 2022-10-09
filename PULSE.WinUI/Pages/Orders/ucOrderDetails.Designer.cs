namespace PULSE.WinUI.Pages.Orders
{
    partial class ucOrderDetails
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
            this.lblAddPart = new System.Windows.Forms.Label();
            this.lblAddGear = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlBottomPadding = new System.Windows.Forms.Panel();
            this.cbDelivery = new System.Windows.Forms.CheckBox();
            this.lblAddBike = new System.Windows.Forms.Label();
            this.dgvAvailableSizes = new System.Windows.Forms.DataGridView();
            this.productNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.orderDetailDGVItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.lblRemoveShipping = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnShipping = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlProcessedButtons = new System.Windows.Forms.Panel();
            this.pblDraftButtons = new System.Windows.Forms.Panel();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlDeliveredButtons = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).BeginInit();
            this.pnlProducNumberWrapper.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShippingCost)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel7.SuspendLayout();
            this.pnlProcessedButtons.SuspendLayout();
            this.pblDraftButtons.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.pnlDeliveredButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddPart
            // 
            this.lblAddPart.AutoSize = true;
            this.lblAddPart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddPart.Location = new System.Drawing.Point(742, 162);
            this.lblAddPart.Name = "lblAddPart";
            this.lblAddPart.Size = new System.Drawing.Size(59, 16);
            this.lblAddPart.TabIndex = 89;
            this.lblAddPart.Text = "Add Part";
            this.lblAddPart.Click += new System.EventHandler(this.lblAddPart_Click);
            // 
            // lblAddGear
            // 
            this.lblAddGear.AutoSize = true;
            this.lblAddGear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddGear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddGear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddGear.Location = new System.Drawing.Point(670, 162);
            this.lblAddGear.Name = "lblAddGear";
            this.lblAddGear.Size = new System.Drawing.Size(65, 16);
            this.lblAddGear.TabIndex = 88;
            this.lblAddGear.Text = "Add Gear";
            this.lblAddGear.Click += new System.EventHandler(this.lblAddGear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnUpdate.Location = new System.Drawing.Point(1, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 40);
            this.btnUpdate.TabIndex = 86;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlBottomPadding
            // 
            this.pnlBottomPadding.Location = new System.Drawing.Point(3, 172);
            this.pnlBottomPadding.MaximumSize = new System.Drawing.Size(730, 41);
            this.pnlBottomPadding.MinimumSize = new System.Drawing.Size(730, 41);
            this.pnlBottomPadding.Name = "pnlBottomPadding";
            this.pnlBottomPadding.Size = new System.Drawing.Size(730, 41);
            this.pnlBottomPadding.TabIndex = 87;
            // 
            // cbDelivery
            // 
            this.cbDelivery.AutoSize = true;
            this.cbDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.cbDelivery.Location = new System.Drawing.Point(71, 419);
            this.cbDelivery.Name = "cbDelivery";
            this.cbDelivery.Size = new System.Drawing.Size(84, 20);
            this.cbDelivery.TabIndex = 85;
            this.cbDelivery.Text = "Delivery";
            this.cbDelivery.UseVisualStyleBackColor = true;
            this.cbDelivery.CheckedChanged += new System.EventHandler(this.cbDelivery_CheckedChanged);
            // 
            // lblAddBike
            // 
            this.lblAddBike.AutoSize = true;
            this.lblAddBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblAddBike.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblAddBike.Location = new System.Drawing.Point(602, 162);
            this.lblAddBike.Name = "lblAddBike";
            this.lblAddBike.Size = new System.Drawing.Size(62, 16);
            this.lblAddBike.TabIndex = 84;
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
            this.dgvAvailableSizes.Location = new System.Drawing.Point(71, 194);
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
            this.dgvAvailableSizes.TabIndex = 83;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label6.Location = new System.Drawing.Point(69, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 79;
            this.label6.Text = "Product Number";
            // 
            // pnlProducNumberWrapper
            // 
            this.pnlProducNumberWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlProducNumberWrapper.Controls.Add(this.tbOrderNumber);
            this.pnlProducNumberWrapper.Location = new System.Drawing.Point(71, 99);
            this.pnlProducNumberWrapper.Name = "pnlProducNumberWrapper";
            this.pnlProducNumberWrapper.Size = new System.Drawing.Size(479, 35);
            this.pnlProducNumberWrapper.TabIndex = 78;
            // 
            // tbOrderNumber
            // 
            this.tbOrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.tbOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.tbOrderNumber.Location = new System.Drawing.Point(10, 9);
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
            this.label10.Location = new System.Drawing.Point(67, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 82;
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
            this.panel5.Location = new System.Drawing.Point(71, 454);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 230);
            this.panel5.TabIndex = 81;
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
            this.tbStreetAddress.Location = new System.Drawing.Point(10, 9);
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
            this.tbZipCode.Location = new System.Drawing.Point(10, 9);
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
            this.tbCity.Location = new System.Drawing.Point(10, 9);
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
            this.tbState.Location = new System.Drawing.Point(10, 9);
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
            this.tbCountry.Location = new System.Drawing.Point(10, 9);
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
            this.btnBack.Location = new System.Drawing.Point(10, 9);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(42, 40);
            this.btnBack.TabIndex = 80;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label2.Location = new System.Drawing.Point(557, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 77;
            this.label2.Text = "Customer";
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlCustomer.Controls.Add(this.tbCustomer);
            this.pnlCustomer.Location = new System.Drawing.Point(559, 99);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(242, 35);
            this.pnlCustomer.TabIndex = 76;
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
            this.tbCustomer.Size = new System.Drawing.Size(207, 17);
            this.tbCustomer.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(68, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 25);
            this.lblTitle.TabIndex = 75;
            this.lblTitle.Text = "Order details";
            // 
            // lblRemoveShipping
            // 
            this.lblRemoveShipping.AutoSize = true;
            this.lblRemoveShipping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRemoveShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.lblRemoveShipping.Location = new System.Drawing.Point(641, 423);
            this.lblRemoveShipping.Name = "lblRemoveShipping";
            this.lblRemoveShipping.Size = new System.Drawing.Size(160, 16);
            this.lblRemoveShipping.TabIndex = 90;
            this.lblRemoveShipping.Text = "Remove Shipping Details";
            this.lblRemoveShipping.Click += new System.EventHandler(this.lblRemoveShipping_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProcess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnProcess.Location = new System.Drawing.Point(244, 5);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(237, 40);
            this.btnProcess.TabIndex = 91;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnDelete.Location = new System.Drawing.Point(487, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(237, 40);
            this.btnDelete.TabIndex = 92;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblGrandTotal, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblGrandTotal.Location = new System.Drawing.Point(170, 74);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblGrandTotal.Size = new System.Drawing.Size(165, 16);
            this.lblGrandTotal.TabIndex = 80;
            this.lblGrandTotal.Text = "1000.00";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblShipping
            // 
            this.lblShipping.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblShipping, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblShipping.Location = new System.Drawing.Point(170, 42);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblShipping.Size = new System.Drawing.Size(165, 16);
            this.lblShipping.TabIndex = 78;
            this.lblShipping.Text = "1000.00";
            this.lblShipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblItemTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.errorProvider.SetIconAlignment(this.lblItemTotal, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.lblItemTotal.Location = new System.Drawing.Point(170, 11);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblItemTotal.Size = new System.Drawing.Size(165, 16);
            this.lblItemTotal.TabIndex = 76;
            this.lblItemTotal.Text = "1000.00";
            this.lblItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblGrandTotal);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.lblShipping);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.lblItemTotal);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Location = new System.Drawing.Point(273, 705);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 100);
            this.panel7.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label14.Location = new System.Drawing.Point(3, 74);
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
            this.label12.Location = new System.Drawing.Point(3, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 77;
            this.label12.Text = "Shipping";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            this.label8.Location = new System.Drawing.Point(3, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 75;
            this.label8.Text = "Item Total";
            // 
            // btnShipping
            // 
            this.btnShipping.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnShipping.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShipping.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnShipping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipping.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShipping.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnShipping.Location = new System.Drawing.Point(125, 5);
            this.btnShipping.Name = "btnShipping";
            this.btnShipping.Size = new System.Drawing.Size(237, 40);
            this.btnShipping.TabIndex = 91;
            this.btnShipping.Text = "SHIPPING STATUS";
            this.btnShipping.UseVisualStyleBackColor = false;
            this.btnShipping.Click += new System.EventHandler(this.btnShipping_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnCancel.Location = new System.Drawing.Point(368, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(237, 40);
            this.btnCancel.TabIndex = 92;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlProcessedButtons
            // 
            this.pnlProcessedButtons.Controls.Add(this.btnCancel);
            this.pnlProcessedButtons.Controls.Add(this.btnShipping);
            this.pnlProcessedButtons.Location = new System.Drawing.Point(3, 3);
            this.pnlProcessedButtons.MaximumSize = new System.Drawing.Size(725, 50);
            this.pnlProcessedButtons.MinimumSize = new System.Drawing.Size(725, 0);
            this.pnlProcessedButtons.Name = "pnlProcessedButtons";
            this.pnlProcessedButtons.Size = new System.Drawing.Size(725, 50);
            this.pnlProcessedButtons.TabIndex = 95;
            // 
            // pblDraftButtons
            // 
            this.pblDraftButtons.Controls.Add(this.btnUpdate);
            this.pblDraftButtons.Controls.Add(this.btnProcess);
            this.pblDraftButtons.Controls.Add(this.btnDelete);
            this.pblDraftButtons.Location = new System.Drawing.Point(3, 59);
            this.pblDraftButtons.MaximumSize = new System.Drawing.Size(727, 51);
            this.pblDraftButtons.MinimumSize = new System.Drawing.Size(727, 0);
            this.pblDraftButtons.Name = "pblDraftButtons";
            this.pblDraftButtons.Size = new System.Drawing.Size(727, 51);
            this.pblDraftButtons.TabIndex = 96;
            // 
            // flpButtons
            // 
            this.flpButtons.AutoSize = true;
            this.flpButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpButtons.Controls.Add(this.pnlProcessedButtons);
            this.flpButtons.Controls.Add(this.pblDraftButtons);
            this.flpButtons.Controls.Add(this.pnlDeliveredButtons);
            this.flpButtons.Controls.Add(this.pnlBottomPadding);
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpButtons.Location = new System.Drawing.Point(71, 823);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(736, 216);
            this.flpButtons.TabIndex = 97;
            // 
            // pnlDeliveredButtons
            // 
            this.pnlDeliveredButtons.Controls.Add(this.button2);
            this.pnlDeliveredButtons.Location = new System.Drawing.Point(3, 116);
            this.pnlDeliveredButtons.MaximumSize = new System.Drawing.Size(725, 50);
            this.pnlDeliveredButtons.MinimumSize = new System.Drawing.Size(725, 0);
            this.pnlDeliveredButtons.Name = "pnlDeliveredButtons";
            this.pnlDeliveredButtons.Size = new System.Drawing.Size(725, 50);
            this.pnlDeliveredButtons.TabIndex = 96;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.button2.Location = new System.Drawing.Point(244, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 40);
            this.button2.TabIndex = 91;
            this.button2.Text = "SHIPPING STATUS";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // ucOrderDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 674);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.lblRemoveShipping);
            this.Controls.Add(this.lblAddPart);
            this.Controls.Add(this.lblAddGear);
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
            this.Name = "ucOrderDetails";
            this.Size = new System.Drawing.Size(803, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableSizes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailDGVItemBindingSource)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.pnlProcessedButtons.ResumeLayout(false);
            this.pblDraftButtons.ResumeLayout(false);
            this.flpButtons.ResumeLayout(false);
            this.pnlDeliveredButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAddPart;
        private Label lblAddGear;
        private Button btnUpdate;
        private Panel pnlBottomPadding;
        private CheckBox cbDelivery;
        private Label lblAddBike;
        private DataGridView dgvAvailableSizes;
        private DataGridViewTextBoxColumn productNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Remove;
        private BindingSource orderDetailDGVItemBindingSource;
        private Label label6;
        private Panel pnlProducNumberWrapper;
        private TextBox tbOrderNumber;
        private Label label10;
        private Panel panel5;
        private NumericUpDown nudShippingCost;
        private Label label11;
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
        private Button btnBack;
        private Label label2;
        private Panel pnlCustomer;
        private TextBox tbCustomer;
        private Label lblTitle;
        private Label lblRemoveShipping;
        private Button btnProcess;
        private Button btnDelete;
        private ErrorProvider errorProvider;
        private Panel panel7;
        private Label lblGrandTotal;
        private Label label14;
        private Label lblShipping;
        private Label label12;
        private Label lblItemTotal;
        private Label label8;
        private Button btnShipping;
        private Button btnCancel;
        private FlowLayoutPanel flpButtons;
        private Panel pnlProcessedButtons;
        private Panel pblDraftButtons;
        private Panel pnlDeliveredButtons;
        private Button button2;
    }
}
