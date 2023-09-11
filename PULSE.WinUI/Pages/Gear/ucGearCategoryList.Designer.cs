﻿namespace PULSE.WinUI.Pages.Gear
{
    partial class ucGearCategoryList
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
            dgvCategoryList = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Action = new DataGridViewButtonColumn();
            productCategoryBindingSource = new BindingSource(components);
            btnAdd = new Button();
            pnlSearchWrapper = new Panel();
            tbSearch = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            pnlDetails = new Panel();
            ucGearCategoryDetails1 = new ucGearCategoryDetails();
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productCategoryBindingSource).BeginInit();
            pnlSearchWrapper.SuspendLayout();
            pnlDetails.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCategoryList
            // 
            dgvCategoryList.AllowUserToAddRows = false;
            dgvCategoryList.AllowUserToDeleteRows = false;
            dgvCategoryList.AutoGenerateColumns = false;
            dgvCategoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCategoryList.BackgroundColor = Color.FromArgb(53, 53, 64);
            dgvCategoryList.BorderStyle = BorderStyle.None;
            dgvCategoryList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(173, 173, 177);
            dataGridViewCellStyle1.Padding = new Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCategoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoryList.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, Action });
            dgvCategoryList.DataSource = productCategoryBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCategoryList.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCategoryList.Dock = DockStyle.Bottom;
            dgvCategoryList.EnableHeadersVisualStyles = false;
            dgvCategoryList.GridColor = Color.FromArgb(95, 95, 111);
            dgvCategoryList.ImeMode = ImeMode.On;
            dgvCategoryList.Location = new Point(10, 107);
            dgvCategoryList.Margin = new Padding(20);
            dgvCategoryList.Name = "dgvCategoryList";
            dgvCategoryList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCategoryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(53, 53, 64);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(211, 211, 213);
            dgvCategoryList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCategoryList.RowTemplate.DividerHeight = 1;
            dgvCategoryList.RowTemplate.Height = 35;
            dgvCategoryList.Size = new Size(868, 557);
            dgvCategoryList.TabIndex = 27;
            dgvCategoryList.CellContentClick += dgvCategoryList_CellContentClick;
            dgvCategoryList.CellDoubleClick += dgvCategoryList_CellDoubleClick;
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
            // productCategoryBindingSource
            // 
            productCategoryBindingSource.DataSource = typeof(Model.ProductCategory);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(53, 53, 64);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderColor = Color.FromArgb(95, 95, 111);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.FromArgb(211, 211, 213);
            btnAdd.Location = new Point(698, 10);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(181, 40);
            btnAdd.TabIndex = 26;
            btnAdd.Text = "+ ADD CATEGORY";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // pnlSearchWrapper
            // 
            pnlSearchWrapper.BackColor = Color.FromArgb(53, 53, 64);
            pnlSearchWrapper.Controls.Add(tbSearch);
            pnlSearchWrapper.Location = new Point(12, 60);
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
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 24;
            label1.Text = "Gear Categories";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(53, 53, 64);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(211, 211, 213);
            btnSearch.Location = new Point(752, 60);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(127, 35);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // pnlDetails
            // 
            pnlDetails.Controls.Add(ucGearCategoryDetails1);
            pnlDetails.Location = new Point(0, 0);
            pnlDetails.Name = "pnlDetails";
            pnlDetails.Size = new Size(888, 674);
            pnlDetails.TabIndex = 28;
            // 
            // ucGearCategoryDetails1
            // 
            ucGearCategoryDetails1.AutoValidate = AutoValidate.EnableAllowFocusChange;
            ucGearCategoryDetails1.BackColor = Color.FromArgb(39, 39, 49);
            ucGearCategoryDetails1.Dock = DockStyle.Fill;
            ucGearCategoryDetails1.Location = new Point(0, 0);
            ucGearCategoryDetails1.Name = "ucGearCategoryDetails1";
            ucGearCategoryDetails1.Size = new Size(888, 674);
            ucGearCategoryDetails1.TabIndex = 0;
            ucGearCategoryDetails1.TitleAdd = "Add a New Gear Category";
            ucGearCategoryDetails1.TitleEdit = "Edit Gear Category";
            // 
            // ucGearCategoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(39, 39, 49);
            Controls.Add(pnlDetails);
            Controls.Add(dgvCategoryList);
            Controls.Add(btnAdd);
            Controls.Add(pnlSearchWrapper);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Name = "ucGearCategoryList";
            Padding = new Padding(10);
            Size = new Size(888, 674);
            ((System.ComponentModel.ISupportInitialize)dgvCategoryList).EndInit();
            ((System.ComponentModel.ISupportInitialize)productCategoryBindingSource).EndInit();
            pnlSearchWrapper.ResumeLayout(false);
            pnlSearchWrapper.PerformLayout();
            pnlDetails.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCategoryList;
        private DataGridViewTextBoxColumn productCategoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
        private BindingSource productCategoryBindingSource;
        private Button btnAdd;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private Panel pnlDetails;
        private ucGearCategoryDetails ucGearCategoryDetails1;
    }
}
