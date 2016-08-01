namespace UIDesign
{
    partial class ENQ
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
            this.ptb_logo = new System.Windows.Forms.PictureBox();
            this.btn_IPE = new System.Windows.Forms.Button();
            this.btn_CAE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.Location = new System.Drawing.Point(280, 12);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(223, 141);
            this.ptb_logo.TabIndex = 4;
            this.ptb_logo.TabStop = false;
            this.ptb_logo.Click += new System.EventHandler(this.ptb_logo_Click);
            // 
            // btn_IPE
            // 
            this.btn_IPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_IPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_IPE.Location = new System.Drawing.Point(44, 168);
            this.btn_IPE.Name = "btn_IPE";
            this.btn_IPE.Size = new System.Drawing.Size(197, 34);
            this.btn_IPE.TabIndex = 21;
            this.btn_IPE.Text = "Item Price Enquiry";
            this.btn_IPE.UseVisualStyleBackColor = true;
            // 
            // btn_CAE
            // 
            this.btn_CAE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CAE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_CAE.Location = new System.Drawing.Point(44, 220);
            this.btn_CAE.Name = "btn_CAE";
            this.btn_CAE.Size = new System.Drawing.Size(244, 34);
            this.btn_CAE.TabIndex = 22;
            this.btn_CAE.Text = "Credit Approval Enquiry";
            this.btn_CAE.UseVisualStyleBackColor = true;
            // 
            // ENQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 478);
            this.Controls.Add(this.btn_CAE);
            this.Controls.Add(this.btn_IPE);
            this.Controls.Add(this.ptb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ENQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ENQ";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Button btn_IPE;
        private System.Windows.Forms.Button btn_CAE;
    }
}