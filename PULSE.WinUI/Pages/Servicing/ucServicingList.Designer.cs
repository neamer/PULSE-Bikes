namespace PULSE.WinUI.Pages.Servicing
{
    partial class ucServicingList
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
            this.dgvServicingList = new System.Windows.Forms.DataGridView();
            this.servicingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.pnlSearchWrapper = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ucAddServicing1 = new PULSE.WinUI.Pages.Servicing.ucAddServicing();
            this.ucCustomerSelect1 = new PULSE.WinUI.Pages.Customer.ucCustomerSelect();
            this.ucServicingDetails1 = new PULSE.WinUI.Pages.Servicing.ucServicingDetails();
            this.ucPartSelect1 = new PULSE.WinUI.Pages.Part.ucPartSelect();
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicingBindingSource)).BeginInit();
            this.pnlSearchWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // bicycleBindingSource
            // 
            this.bicycleBindingSource.DataSource = typeof(PULSE.Model.Bicycle);
            // 
            // dgvServicingList
            // 
            this.dgvServicingList.AllowUserToAddRows = false;
            this.dgvServicingList.AllowUserToDeleteRows = false;
            this.dgvServicingList.AutoGenerateColumns = false;
            this.dgvServicingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicingList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.dgvServicingList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvServicingList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicingList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvServicingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicingNumberDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.customerDataGridViewTextBoxColumn,
            this.CreatedAt});
            this.dgvServicingList.DataSource = this.servicingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServicingList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvServicingList.EnableHeadersVisualStyles = false;
            this.dgvServicingList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.dgvServicingList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvServicingList.Location = new System.Drawing.Point(10, 107);
            this.dgvServicingList.Margin = new System.Windows.Forms.Padding(20);
            this.dgvServicingList.Name = "dgvServicingList";
            this.dgvServicingList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServicingList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.dgvServicingList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvServicingList.RowTemplate.DividerHeight = 1;
            this.dgvServicingList.RowTemplate.Height = 35;
            this.dgvServicingList.Size = new System.Drawing.Size(868, 557);
            this.dgvServicingList.TabIndex = 25;
            this.dgvServicingList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicingList_CellDoubleClick);
            // 
            // servicingNumberDataGridViewTextBoxColumn
            // 
            this.servicingNumberDataGridViewTextBoxColumn.DataPropertyName = "ServicingNumber";
            this.servicingNumberDataGridViewTextBoxColumn.HeaderText = "ServicingNumber";
            this.servicingNumberDataGridViewTextBoxColumn.Name = "servicingNumberDataGridViewTextBoxColumn";
            this.servicingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "StatusName";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            this.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            this.customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            this.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            this.customerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CreatedAt
            // 
            this.CreatedAt.DataPropertyName = "CreatedAt";
            this.CreatedAt.HeaderText = "Date Added";
            this.CreatedAt.Name = "CreatedAt";
            this.CreatedAt.ReadOnly = true;
            // 
            // servicingBindingSource
            // 
            this.servicingBindingSource.DataSource = typeof(PULSE.Model.Servicing);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnAdd.Location = new System.Drawing.Point(721, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(157, 40);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "+ REGISTER";
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
            this.pnlSearchWrapper.Size = new System.Drawing.Size(592, 35);
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
            this.tbSearch.Size = new System.Drawing.Size(560, 17);
            this.tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Servicing";
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
            // ucAddServicing1
            // 
            this.ucAddServicing1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ucAddServicing1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucAddServicing1.CustomerID = -1;
            this.ucAddServicing1.Location = new System.Drawing.Point(0, 0);
            this.ucAddServicing1.Name = "ucAddServicing1";
            this.ucAddServicing1.Size = new System.Drawing.Size(888, 674);
            this.ucAddServicing1.TabIndex = 26;
            // 
            // ucCustomerSelect1
            // 
            this.ucCustomerSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucCustomerSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucCustomerSelect1.Name = "ucCustomerSelect1";
            this.ucCustomerSelect1.Padding = new System.Windows.Forms.Padding(10);
            this.ucCustomerSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucCustomerSelect1.TabIndex = 27;
            // 
            // ucServicingDetails1
            // 
            this.ucServicingDetails1.AutoScroll = true;
            this.ucServicingDetails1.AutoScrollMinSize = new System.Drawing.Size(0, 674);
            this.ucServicingDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucServicingDetails1.Entity = null;
            this.ucServicingDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucServicingDetails1.Name = "ucServicingDetails1";
            this.ucServicingDetails1.Size = new System.Drawing.Size(888, 674);
            this.ucServicingDetails1.TabIndex = 28;
            // 
            // ucPartSelect1
            // 
            this.ucPartSelect1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucPartSelect1.Location = new System.Drawing.Point(0, 0);
            this.ucPartSelect1.Name = "ucPartSelect1";
            this.ucPartSelect1.Size = new System.Drawing.Size(888, 674);
            this.ucPartSelect1.TabIndex = 29;
            // 
            // ucServicingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.ucPartSelect1);
            this.Controls.Add(this.ucServicingDetails1);
            this.Controls.Add(this.ucCustomerSelect1);
            this.Controls.Add(this.ucAddServicing1);
            this.Controls.Add(this.dgvServicingList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbState);
            this.Controls.Add(this.pnlSearchWrapper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "ucServicingList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)(this.bicycleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicingBindingSource)).EndInit();
            this.pnlSearchWrapper.ResumeLayout(false);
            this.pnlSearchWrapper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BindingSource bicycleBindingSource;
        private DataGridView dgvServicingList;
        private Button btnAdd;
        private ComboBox cbState;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridViewTextBoxColumn servicingNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CreatedAt;
        private BindingSource servicingBindingSource;
        private ucAddServicing ucAddServicing1;
        private Customer.ucCustomerSelect ucCustomerSelect1;
        private ucServicingDetails ucServicingDetails1;
        private Part.ucPartSelect ucPartSelect1;
    }
}
