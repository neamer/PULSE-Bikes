namespace PULSE.WinUI.Pages.Orders
{
    partial class ucOrderList
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
            this.dgvOrderList = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeProcessedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderHeaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bicycleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.pnlSearchWrapper = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ucAddOrder1 = new PULSE.WinUI.Pages.Orders.ucAddOrder();
            this.ucCustomerSelect1 = new PULSE.WinUI.Pages.Customer.ucCustomerSelect();
            this.ucBicycleSelect1 = new PULSE.WinUI.Pages.Bicycle.ucBicycleSelect();
            this.ucGearSelect1 = new PULSE.WinUI.Pages.Gear.ucGearSelect();
            this.ucPartSelect1 = new PULSE.WinUI.Pages.Part.ucPartSelect();
            this.ucOrderDetails1 = new PULSE.WinUI.Pages.Orders.ucOrderDetails();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHeaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            this.pnlSearchWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOrderList
            // 
            this.dgvOrderList.AllowUserToAddRows = false;
            this.dgvOrderList.AllowUserToDeleteRows = false;
            this.dgvOrderList.AutoGenerateColumns = false;
            this.dgvOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.dgvOrderList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvOrderList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.timeProcessedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Customer,
            this.NoOfItems,
            this.Total});
            this.dgvOrderList.DataSource = this.orderHeaderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOrderList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderList.EnableHeadersVisualStyles = false;
            this.dgvOrderList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.dgvOrderList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvOrderList.Location = new System.Drawing.Point(10, 107);
            this.dgvOrderList.Margin = new System.Windows.Forms.Padding(20);
            this.dgvOrderList.Name = "dgvOrderList";
            this.dgvOrderList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.dgvOrderList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOrderList.RowTemplate.DividerHeight = 1;
            this.dgvOrderList.RowTemplate.Height = 35;
            this.dgvOrderList.Size = new System.Drawing.Size(868, 557);
            this.dgvOrderList.TabIndex = 25;
            this.dgvOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderList_CellDoubleClick);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeProcessedDataGridViewTextBoxColumn
            // 
            this.timeProcessedDataGridViewTextBoxColumn.DataPropertyName = "TimeProcessed";
            this.timeProcessedDataGridViewTextBoxColumn.HeaderText = "TimeProcessed";
            this.timeProcessedDataGridViewTextBoxColumn.Name = "timeProcessedDataGridViewTextBoxColumn";
            this.timeProcessedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Customer
            // 
            this.Customer.DataPropertyName = "Customer";
            this.Customer.HeaderText = "Customer";
            this.Customer.Name = "Customer";
            this.Customer.ReadOnly = true;
            // 
            // NoOfItems
            // 
            this.NoOfItems.DataPropertyName = "NoOfItems";
            this.NoOfItems.HeaderText = "No of Items";
            this.NoOfItems.Name = "NoOfItems";
            this.NoOfItems.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.FillWeight = 50F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // orderHeaderBindingSource
            // 
            this.orderHeaderBindingSource.DataSource = typeof(PULSE.Model.OrderHeader);
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(PULSE.Model.Bicycle);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnAdd.Location = new System.Drawing.Point(718, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(160, 40);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "+ ADD ORDER";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.cbState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.cbState.FormattingEnabled = true;
            this.cbState.ItemHeight = 16;
            this.cbState.Location = new System.Drawing.Point(611, 68);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(130, 24);
            this.cbState.TabIndex = 23;
            // 
            // pnlSearchWrapper
            // 
            this.pnlSearchWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlSearchWrapper.Controls.Add(this.tbSearch);
            this.pnlSearchWrapper.Location = new System.Drawing.Point(11, 63);
            this.pnlSearchWrapper.Name = "pnlSearchWrapper";
            this.pnlSearchWrapper.Size = new System.Drawing.Size(591, 35);
            this.pnlSearchWrapper.TabIndex = 21;
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
            this.tbSearch.Size = new System.Drawing.Size(578, 17);
            this.tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Orders";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnSearch.Location = new System.Drawing.Point(751, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 35);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucAddOrder1
            // 
            this.ucAddOrder1.AutoScroll = true;
            this.ucAddOrder1.AutoScrollMinSize = new System.Drawing.Size(854, 674);
            this.ucAddOrder1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ucAddOrder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucAddOrder1.CustomerID = -1;
            this.ucAddOrder1.Location = new System.Drawing.Point(0, 0);
            this.ucAddOrder1.Name = "ucAddOrder1";
            this.ucAddOrder1.Size = new System.Drawing.Size(888, 674);
            this.ucAddOrder1.TabIndex = 26;
            // 
            // ucCustomerSelect1
            // 
            this.ucCustomerSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucCustomerSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomerSelect1.Name = "ucCustomerSelect1";
            this.ucCustomerSelect1.Padding = new System.Windows.Forms.Padding(10);
            this.ucCustomerSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucCustomerSelect1.TabIndex = 31;
            // 
            // ucBicycleSelect1
            // 
            this.ucBicycleSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBicycleSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleSelect1.Name = "ucBicycleSelect1";
            this.ucBicycleSelect1.Padding = new System.Windows.Forms.Padding(10);
            this.ucBicycleSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleSelect1.TabIndex = 32;
            // 
            // ucGearSelect1
            // 
            this.ucGearSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucGearSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucGearSelect1.Name = "ucGearSelect1";
            this.ucGearSelect1.Padding = new System.Windows.Forms.Padding(10);
            this.ucGearSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucGearSelect1.TabIndex = 29;
            // 
            // ucPartSelect1
            // 
            this.ucPartSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucPartSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucPartSelect1.Name = "ucPartSelect1";
            this.ucPartSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucPartSelect1.TabIndex = 30;
            // 
            // ucOrderDetails1
            // 
            this.ucOrderDetails1.AutoScroll = true;
            this.ucOrderDetails1.AutoScrollMinSize = new System.Drawing.Size(0, 674);
            this.ucOrderDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucOrderDetails1.CustomerID = 0;
            this.ucOrderDetails1.Item = null;
            this.ucOrderDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucOrderDetails1.Name = "ucOrderDetails1";
            this.ucOrderDetails1.OrderID = 0;
            this.ucOrderDetails1.ShippingInfoID = null;
            this.ucOrderDetails1.Size = new System.Drawing.Size(888, 674);
            this.ucOrderDetails1.TabIndex = 33;
            // 
            // ucOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.ucPartSelect1);
            this.Controls.Add(this.ucGearSelect1);
            this.Controls.Add(this.ucBicycleSelect1);
            this.Controls.Add(this.ucOrderDetails1);
            this.Controls.Add(this.ucCustomerSelect1);
            this.Controls.Add(this.ucAddOrder1);
            this.Controls.Add(this.dgvOrderList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.pnlSearchWrapper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "ucOrderList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderHeaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            this.pnlSearchWrapper.ResumeLayout(false);
            this.pnlSearchWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvOrderList;
        private BindingSource bicycleBindingSource;
        private Button btnAdd;
        private ComboBox cbState;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private BindingSource orderHeaderBindingSource;
        private DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeProcessedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn NoOfItems;
        private DataGridViewTextBoxColumn Total;
        private ucAddOrder ucAddOrder1;
        private Customer.ucCustomerSelect ucCustomerSelect1;
        private Bicycle.ucBicycleSelect ucBicycleSelect1;
        private Gear.ucGearSelect ucGearSelect1;
        private Part.ucPartSelect ucPartSelect1;
        private ucOrderDetails ucOrderDetails1;
    }
}
