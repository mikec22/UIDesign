namespace UIDesign
{
    partial class INV
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
            this.btn_TR = new System.Windows.Forms.Button();
            this.btn_TC = new System.Windows.Forms.Button();
            this.btn_TO = new System.Windows.Forms.Button();
            this.btn_TOE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_logo
            // 
            this.ptb_logo.Location = new System.Drawing.Point(284, 12);
            this.ptb_logo.Name = "ptb_logo";
            this.ptb_logo.Size = new System.Drawing.Size(223, 141);
            this.ptb_logo.TabIndex = 3;
            this.ptb_logo.TabStop = false;
            // 
            // btn_TR
            // 
            this.btn_TR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TR.Location = new System.Drawing.Point(39, 119);
            this.btn_TR.Name = "btn_TR";
            this.btn_TR.Size = new System.Drawing.Size(196, 34);
            this.btn_TR.TabIndex = 14;
            this.btn_TR.Text = "Transfer Request";
            this.btn_TR.UseVisualStyleBackColor = true;
            // 
            // btn_TC
            // 
            this.btn_TC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TC.Location = new System.Drawing.Point(39, 169);
            this.btn_TC.Name = "btn_TC";
            this.btn_TC.Size = new System.Drawing.Size(237, 34);
            this.btn_TC.TabIndex = 15;
            this.btn_TC.Text = "Transfer Confirmation";
            this.btn_TC.UseVisualStyleBackColor = true;
            // 
            // btn_TO
            // 
            this.btn_TO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TO.Location = new System.Drawing.Point(39, 220);
            this.btn_TO.Name = "btn_TO";
            this.btn_TO.Size = new System.Drawing.Size(168, 34);
            this.btn_TO.TabIndex = 16;
            this.btn_TO.Text = "Transfer OUT";
            this.btn_TO.UseVisualStyleBackColor = true;
            // 
            // btn_TOE
            // 
            this.btn_TOE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_TOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btn_TOE.Location = new System.Drawing.Point(39, 269);
            this.btn_TOE.Name = "btn_TOE";
            this.btn_TOE.Size = new System.Drawing.Size(227, 34);
            this.btn_TOE.TabIndex = 17;
            this.btn_TOE.Text = "Transfer Outstanding Enquiry";
            this.btn_TOE.UseVisualStyleBackColor = true;
            // 
            // INV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 478);
            this.Controls.Add(this.btn_TOE);
            this.Controls.Add(this.btn_TO);
            this.Controls.Add(this.btn_TC);
            this.Controls.Add(this.btn_TR);
            this.Controls.Add(this.ptb_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "INV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INV";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_logo;
        private System.Windows.Forms.Button btn_TR;
        private System.Windows.Forms.Button btn_TC;
        private System.Windows.Forms.Button btn_TO;
        private System.Windows.Forms.Button btn_TOE;
    }
}