﻿namespace PULSE.WinUI.Pages.Bicycle
{
    partial class ucBicycleCategoryList
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlSearchWrapper = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvCategoryList = new System.Windows.Forms.DataGridView();
            this.productCategoryIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.productCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.ucBicycleCategoryDetails1 = new PULSE.WinUI.Pages.Bicycle.ucBicycleCategoryDetails();
            this.pnlSearchWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).BeginInit();
            this.pnlDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnAdd.Location = new System.Drawing.Point(697, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 40);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "+ ADD CATEGORY";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlSearchWrapper
            // 
            this.pnlSearchWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.pnlSearchWrapper.Controls.Add(this.tbSearch);
            this.pnlSearchWrapper.Location = new System.Drawing.Point(11, 60);
            this.pnlSearchWrapper.Name = "pnlSearchWrapper";
            this.pnlSearchWrapper.Size = new System.Drawing.Size(728, 35);
            this.pnlSearchWrapper.TabIndex = 20;
            this.pnlSearchWrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearchWrapper_Paint);
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
            this.tbSearch.Size = new System.Drawing.Size(715, 17);
            this.tbSearch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bicycle Categories";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnSearch.Location = new System.Drawing.Point(751, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 35);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvCategoryList
            // 
            this.dgvCategoryList.AllowUserToAddRows = false;
            this.dgvCategoryList.AllowUserToDeleteRows = false;
            this.dgvCategoryList.AutoGenerateColumns = false;
            this.dgvCategoryList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoryList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.dgvCategoryList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoryList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(177)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCategoryIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.Action});
            this.dgvCategoryList.DataSource = this.productCategoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoryList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategoryList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCategoryList.EnableHeadersVisualStyles = false;
            this.dgvCategoryList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.dgvCategoryList.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvCategoryList.Location = new System.Drawing.Point(10, 107);
            this.dgvCategoryList.Margin = new System.Windows.Forms.Padding(20);
            this.dgvCategoryList.Name = "dgvCategoryList";
            this.dgvCategoryList.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoryList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.dgvCategoryList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategoryList.RowTemplate.DividerHeight = 1;
            this.dgvCategoryList.RowTemplate.Height = 35;
            this.dgvCategoryList.Size = new System.Drawing.Size(868, 557);
            this.dgvCategoryList.TabIndex = 22;
            this.dgvCategoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellContentClick);
            this.dgvCategoryList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryList_CellContentDoubleClick);
            // 
            // productCategoryIdDataGridViewTextBoxColumn
            // 
            this.productCategoryIdDataGridViewTextBoxColumn.DataPropertyName = "ProductCategoryId";
            this.productCategoryIdDataGridViewTextBoxColumn.FillWeight = 62.1297F;
            this.productCategoryIdDataGridViewTextBoxColumn.HeaderText = "ProductCategoryId";
            this.productCategoryIdDataGridViewTextBoxColumn.Name = "productCategoryIdDataGridViewTextBoxColumn";
            this.productCategoryIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 182.7411F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.FillWeight = 55.12918F;
            this.Action.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Text = "DELETE";
            this.Action.ToolTipText = "Delete the category";
            this.Action.UseColumnTextForButtonValue = true;
            // 
            // productCategoryBindingSource
            // 
            this.productCategoryBindingSource.DataSource = typeof(PULSE.Model.ProductCategory);
            this.productCategoryBindingSource.CurrentChanged += new System.EventHandler(this.productCategoryBindingSource_CurrentChanged);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Controls.Add(this.ucBicycleCategoryDetails1);
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(888, 674);
            this.pnlDetails.TabIndex = 23;
            this.pnlDetails.Visible = false;
            // 
            // ucBicycleCategoryDetails1
            // 
            this.ucBicycleCategoryDetails1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ucBicycleCategoryDetails1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ucBicycleCategoryDetails1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucBicycleCategoryDetails1.Location = new System.Drawing.Point(0, 0);
            this.ucBicycleCategoryDetails1.Name = "ucBicycleCategoryDetails1";
            this.ucBicycleCategoryDetails1.Size = new System.Drawing.Size(888, 674);
            this.ucBicycleCategoryDetails1.TabIndex = 0;
            this.ucBicycleCategoryDetails1.TitleAdd = "Add a New Bicycle Category";
            this.ucBicycleCategoryDetails1.TitleEdit = "Edit Bicycle Category";
            // 
            // ucBicycleCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.dgvCategoryList);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlSearchWrapper);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "ucBicycleCategoryList";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(888, 674);
            this.pnlSearchWrapper.ResumeLayout(false);
            this.pnlSearchWrapper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCategoryBindingSource)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAdd;
        private Panel pnlSearchWrapper;
        private TextBox tbSearch;
        private Label label1;
        private Button btnSearch;
        private DataGridView dgvCategoryList;
        private BindingSource productCategoryBindingSource;
        private Panel pnlDetails;
        private ucBicycleCategoryDetails ucBicycleCategoryDetails1;
        private DataGridViewTextBoxColumn productCategoryIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn Action;
    }
}
