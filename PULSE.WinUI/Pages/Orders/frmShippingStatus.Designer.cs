namespace PULSE.WinUI.Pages.Orders
{
    partial class frmShippingStatus
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.rbProcessed = new System.Windows.Forms.RadioButton();
            this.rbPacked = new System.Windows.Forms.RadioButton();
            this.rbShipped = new System.Windows.Forms.RadioButton();
            this.rbDelivered = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitle.Location = new System.Drawing.Point(14, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(178, 25);
            this.lblTitle.TabIndex = 56;
            this.lblTitle.Text = "Shipping Status";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(64)))));
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(111)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.btnNext.Location = new System.Drawing.Point(14, 220);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(392, 40);
            this.btnNext.TabIndex = 55;
            this.btnNext.Text = "NEXT STEP";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rbProcessed
            // 
            this.rbProcessed.AutoCheck = false;
            this.rbProcessed.AutoSize = true;
            this.rbProcessed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbProcessed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rbProcessed.Location = new System.Drawing.Point(14, 67);
            this.rbProcessed.Name = "rbProcessed";
            this.rbProcessed.Size = new System.Drawing.Size(100, 20);
            this.rbProcessed.TabIndex = 57;
            this.rbProcessed.TabStop = true;
            this.rbProcessed.Text = "Processed";
            this.rbProcessed.UseVisualStyleBackColor = true;
            // 
            // rbPacked
            // 
            this.rbPacked.AutoCheck = false;
            this.rbPacked.AutoSize = true;
            this.rbPacked.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbPacked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rbPacked.Location = new System.Drawing.Point(14, 104);
            this.rbPacked.Name = "rbPacked";
            this.rbPacked.Size = new System.Drawing.Size(78, 20);
            this.rbPacked.TabIndex = 58;
            this.rbPacked.TabStop = true;
            this.rbPacked.Text = "Packed";
            this.rbPacked.UseVisualStyleBackColor = true;
            // 
            // rbShipped
            // 
            this.rbShipped.AutoCheck = false;
            this.rbShipped.AutoSize = true;
            this.rbShipped.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbShipped.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rbShipped.Location = new System.Drawing.Point(14, 141);
            this.rbShipped.Name = "rbShipped";
            this.rbShipped.Size = new System.Drawing.Size(83, 20);
            this.rbShipped.TabIndex = 59;
            this.rbShipped.TabStop = true;
            this.rbShipped.Text = "Shipped";
            this.rbShipped.UseVisualStyleBackColor = true;
            // 
            // rbDelivered
            // 
            this.rbDelivered.AutoCheck = false;
            this.rbDelivered.AutoSize = true;
            this.rbDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbDelivered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.rbDelivered.Location = new System.Drawing.Point(14, 178);
            this.rbDelivered.Name = "rbDelivered";
            this.rbDelivered.Size = new System.Drawing.Size(93, 20);
            this.rbDelivered.TabIndex = 60;
            this.rbDelivered.TabStop = true;
            this.rbDelivered.Text = "Delivered";
            this.rbDelivered.UseVisualStyleBackColor = true;
            // 
            // frmShippingStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(418, 275);
            this.Controls.Add(this.rbDelivered);
            this.Controls.Add(this.rbShipped);
            this.Controls.Add(this.rbPacked);
            this.Controls.Add(this.rbProcessed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNext);
            this.Name = "frmShippingStatus";
            this.Text = "frmShippingStatus";
            this.Load += new System.EventHandler(this.frmShippingStatus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Button btnNext;
        private RadioButton rbProcessed;
        private RadioButton rbPacked;
        private RadioButton rbShipped;
        private RadioButton rbDelivered;
    }
}