namespace PULSE.WinUI.Pages.Brands
{
    partial class ucBrandList
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
            dgvBrandList = new DataGridView();
            brandBindingSource = new BindingSource(components);
            btnAdd = new Button();
            pnlSearchWrapper = new Panel();
            tbSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            pnlDetails = new Panel();
            ucBrandDetails1 = new ucBrandDetails();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBrandList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).BeginInit();
            pnlSearchWrapper.SuspendLayout();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBrandList
            // 
            dgvBrandList.AllowUserToAddRows = false;
            dgvBrandList.AllowUserToDeleteRows = false;
            dgvBrandList.AutoGenerateColumns = false;
            dgvBrandList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBrandList.BackgroundColor = Color.FromArgb(53, 53, 64);
            dgvBrandList.BorderStyle = BorderStyle.None;
            dgvBrandList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(173, 173, 177);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBrandList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBrandList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBrandList.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, Action });
            dgvBrandList.DataSource = brandBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBrandList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBrandList.Dock = DockStyle.Bottom;
            dgvBrandList.EnableHeadersVisualStyles = false;
            dgvBrandList.GridColor = Color.FromArgb(95, 95, 111);
            dgvBrandList.ImeMode = ImeMode.On;
            dgvBrandList.Location = new Point(10, 107);
            dgvBrandList.Margin = new Padding(20);
            dgvBrandList.Name = "dgvBrandList";
            dgvBrandList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBrandList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(211, 211, 213);
            dgvBrandList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvBrandList.RowTemplate.DividerHeight = 1;
            dgvBrandList.RowTemplate.Height = 35;
            dgvBrandList.Size = new Size(868, 557);
            dgvBrandList.TabIndex = 27;
            dgvBrandList.CellContentClick += dgvBrandList_CellContentClick;
            dgvBrandList.CellDoubleClick += dgvBrandList_CellDoubleClick;
            // 
            // brandBindingSource
            // 
            brandBindingSource.DataSource = typeof(Model.Brand);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(53, 53, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(211, 211, 213);
            btnAdd.Location = new Point(697, 13);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 40);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "+ ADD BRAND";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSearchWrapper
            // 
            pnlSearchWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlSearchWrapper.Controls.Add(tbSearch);
            pnlSearchWrapper.Location = new Point(11, 63);
            pnlSearchWrapper.Name = "pnlSearchWrapper";
            pnlSearchWrapper.Size = new Size(728, 35);
            pnlSearchWrapper.TabIndex = 25;
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
            tbSearch.Size = new Size(715, 17);
            tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(9, 20);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 24;
            label1.Text = "Brands";
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
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(ucBrandDetails1);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(888, 674);
            pnlDetails.TabIndex = 28;
            // 
            // ucBrandDetails1
            // 
            ucBrandDetails1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ucBrandDetails1.BackColor = Color.FromArgb(39, 39, 49);
            ucBrandDetails1.Dock = DockStyle.Fill;
            ucBrandDetails1.Location = new Point(0, 0);
            ucBrandDetails1.Name = "ucBrandDetails1";
            ucBrandDetails1.Size = new Size(888, 674);
            ucBrandDetails1.TabIndex = 0;
            ucBrandDetails1.TitleAdd = "Add a New Brand";
            ucBrandDetails1.TitleEdit = "Edit Brand";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.FillWeight = 182.7411F;
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            Action.FillWeight = 55.12918F;
            Action.FlatStyle = FlatStyle.Popup;
            Action.HeaderText = "Action";
            Action.Name = "Action";
            Action.ReadOnly = true;
            Action.Text = "DELETE";
            Action.ToolTipText = "Delete the category";
            Action.UseColumnTextForButtonValue = true;
            // 
            // ucBrandList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 49);
            Controls.Add(pnlDetails);
            Controls.Add(dgvBrandList);
            Controls.Add(btnAdd);
            Controls.Add(pnlSearchWrapper);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "ucBrandList";
            Padding = new Padding(10);
            Size = new Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)dgvBrandList).EndInit();
            ((System.ComponentModel.ISupportInitialize)brandBindingSource).EndInit();
            pnlSearchWrapper.ResumeLayout(false);
            pnlSearchWrapper.PerformLayout();
            pnlDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBrandList;
        private BindingSource brandBindingSource;
        private Button btnAdd;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private Panel pnlDetails;
        private ucBrandDetails ucBrandDetails1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
    }
}
