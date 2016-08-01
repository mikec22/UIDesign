namespace UIDesign
{
    partial class SOR
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
            this.btn_SM = new System.Windows.Forms.Button();
            this.btn_SS = new System.Windows.Forms.Button();
            this.btn_RE = new System.Windows.Forms.Button();
            this.btn_RRC = new System.Windows.Forms.Button();
            this.btn_RRE = new System.Windows.Forms.Button();
            this.btn_IWGPE = new System.Windows.Forms.Button();
            this.btn_SOE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.Location = new System.Drawing.Point(426, 17);
            this.ptb_logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(334, 195);
            this.ptb_logo.TabIndex = 1;
            this.ptb_logo.TabStop = false;
            // 
            // btn_SM
            // 
            this.btn_SM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_SM.Location = new System.Drawing.Point(48, 490);
            this.btn_SM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SM.Name = "btn_SM";
            this.btn_SM.Size = new System.Drawing.Size(333, 47);
            this.btn_SM.TabIndex = 14;
            this.btn_SM.Text = "Salesman Maintance";
            this.btn_SM.UseVisualStyleBackColor = true;
            // 
            // btn_SS
            // 
            this.btn_SS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_SS.Location = new System.Drawing.Point(48, 420);
            this.btn_SS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SS.Name = "btn_SS";
            this.btn_SS.Size = new System.Drawing.Size(219, 47);
            this.btn_SS.TabIndex = 15;
            this.btn_SS.Text = "Staff Setting";
            this.btn_SS.UseVisualStyleBackColor = true;
            // 
            // btn_RE
            // 
            this.btn_RE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RE.Location = new System.Drawing.Point(48, 352);
            this.btn_RE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RE.Name = "btn_RE";
            this.btn_RE.Size = new System.Drawing.Size(356, 47);
            this.btn_RE.TabIndex = 16;
            this.btn_RE.Text = "Reservation Exchange";
            this.btn_RE.UseVisualStyleBackColor = true;
            // 
            // btn_RRC
            // 
            this.btn_RRC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RRC.Location = new System.Drawing.Point(48, 284);
            this.btn_RRC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RRC.Name = "btn_RRC";
            this.btn_RRC.Size = new System.Drawing.Size(498, 47);
            this.btn_RRC.TabIndex = 17;
            this.btn_RRC.Text = "Reservation Request Confirmation";
            this.btn_RRC.UseVisualStyleBackColor = true;
            // 
            // btn_RRE
            // 
            this.btn_RRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_RRE.Location = new System.Drawing.Point(48, 219);
            this.btn_RRE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_RRE.Name = "btn_RRE";
            this.btn_RRE.Size = new System.Drawing.Size(354, 47);
            this.btn_RRE.TabIndex = 18;
            this.btn_RRE.Text = "Reserve Request Entry";
            this.btn_RRE.UseVisualStyleBackColor = true;
            // 
            // btn_IWGPE
            // 
            this.btn_IWGPE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_IWGPE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_IWGPE.Location = new System.Drawing.Point(48, 559);
            this.btn_IWGPE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_IWGPE.Name = "btn_IWGPE";
            this.btn_IWGPE.Size = new System.Drawing.Size(435, 47);
            this.btn_IWGPE.TabIndex = 19;
            this.btn_IWGPE.Text = "Item Wholesales GP Enquiry";
            this.btn_IWGPE.UseVisualStyleBackColor = true;
            // 
            // btn_SOE
            // 
            this.btn_SOE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_SOE.Location = new System.Drawing.Point(48, 150);
            this.btn_SOE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SOE.Name = "btn_SOE";
            this.btn_SOE.Size = new System.Drawing.Size(285, 47);
            this.btn_SOE.TabIndex = 20;
            this.btn_SOE.Text = "Sales Order Entry";
            this.btn_SOE.UseVisualStyleBackColor = true;
            this.btn_SOE.Click += new System.EventHandler(this.btn_SOE_Click);
            // 
            // SOR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 662);
            this.Controls.Add(this.btn_SOE);
            this.Controls.Add(this.btn_IWGPE);
            this.Controls.Add(this.btn_RRE);
            this.Controls.Add(this.btn_RRC);
            this.Controls.Add(this.btn_RE);
            this.Controls.Add(this.btn_SS);
            this.Controls.Add(this.btn_SM);
            this.Controls.Add(this.ptb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SOR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Button btn_SM;
        private System.Windows.Forms.Button btn_SS;
        private System.Windows.Forms.Button btn_RE;
        private System.Windows.Forms.Button btn_RRC;
        private System.Windows.Forms.Button btn_RRE;
        private System.Windows.Forms.Button btn_IWGPE;
        private System.Windows.Forms.Button btn_SOE;
    }
}