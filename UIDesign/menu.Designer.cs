namespace UIDesign
{
    partial class frm_menu
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
            this.mns_menu = new System.Windows.Forms.MenuStrip();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_timeDisplay = new System.Windows.Forms.Label();
            this.btn_frontPage = new System.Windows.Forms.Button();
            this.btn_SOR = new System.Windows.Forms.Button();
            this.btn_CRM = new System.Windows.Forms.Button();
            this.btn_INV = new System.Windows.Forms.Button();
            this.btn_ENQ = new System.Windows.Forms.Button();
            this.btn_logOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mns_menu
            // 
            this.mns_menu.AutoSize = false;
            this.mns_menu.BackColor = System.Drawing.Color.Gainsboro;
            this.mns_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.mns_menu.Location = new System.Drawing.Point(0, 0);
            this.mns_menu.Name = "mns_menu";
            this.mns_menu.Size = new System.Drawing.Size(202, 482);
            this.mns_menu.TabIndex = 1;
            this.mns_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mns_menu_ItemClicked);
            // 
            // lbl_userName
            // 
            this.lbl_userName.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_userName.Location = new System.Drawing.Point(0, 40);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lbl_userName.Size = new System.Drawing.Size(202, 39);
            this.lbl_userName.TabIndex = 2;
            this.lbl_userName.Text = "User Name";
            this.lbl_userName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_time.Location = new System.Drawing.Point(12, 91);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(39, 13);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "Time : ";
            // 
            // lbl_timeDisplay
            // 
            this.lbl_timeDisplay.AutoSize = true;
            this.lbl_timeDisplay.BackColor = System.Drawing.Color.Gainsboro;
            this.lbl_timeDisplay.Location = new System.Drawing.Point(71, 91);
            this.lbl_timeDisplay.Name = "lbl_timeDisplay";
            this.lbl_timeDisplay.Size = new System.Drawing.Size(64, 13);
            this.lbl_timeDisplay.TabIndex = 4;
            this.lbl_timeDisplay.Text = "DisplayTime";
            // 
            // btn_frontPage
            // 
            this.btn_frontPage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_frontPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frontPage.Location = new System.Drawing.Point(0, 134);
            this.btn_frontPage.Name = "btn_frontPage";
            this.btn_frontPage.Size = new System.Drawing.Size(202, 38);
            this.btn_frontPage.TabIndex = 13;
            this.btn_frontPage.Text = "Front Page";
            this.btn_frontPage.UseVisualStyleBackColor = true;
            this.btn_frontPage.Click += new System.EventHandler(this.btn_frontPage_Click);
            // 
            // btn_SOR
            // 
            this.btn_SOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_SOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SOR.Location = new System.Drawing.Point(0, 195);
            this.btn_SOR.Name = "btn_SOR";
            this.btn_SOR.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_SOR.Size = new System.Drawing.Size(202, 38);
            this.btn_SOR.TabIndex = 14;
            this.btn_SOR.Text = "Sales Order and Reservation";
            this.btn_SOR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SOR.UseVisualStyleBackColor = true;
            this.btn_SOR.Click += new System.EventHandler(this.btn_SOR_Click);
            // 
            // btn_CRM
            // 
            this.btn_CRM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_CRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CRM.Location = new System.Drawing.Point(0, 239);
            this.btn_CRM.Name = "btn_CRM";
            this.btn_CRM.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_CRM.Size = new System.Drawing.Size(202, 38);
            this.btn_CRM.TabIndex = 15;
            this.btn_CRM.Text = "Customer Relationship Member";
            this.btn_CRM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CRM.UseVisualStyleBackColor = true;
            this.btn_CRM.Click += new System.EventHandler(this.btn_CRM_Click);
            // 
            // btn_INV
            // 
            this.btn_INV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_INV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_INV.Location = new System.Drawing.Point(0, 283);
            this.btn_INV.Name = "btn_INV";
            this.btn_INV.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_INV.Size = new System.Drawing.Size(202, 38);
            this.btn_INV.TabIndex = 16;
            this.btn_INV.Text = "INV";
            this.btn_INV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_INV.UseVisualStyleBackColor = true;
            this.btn_INV.Click += new System.EventHandler(this.btn_INV_Click);
            // 
            // btn_ENQ
            // 
            this.btn_ENQ.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ENQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ENQ.Location = new System.Drawing.Point(0, 327);
            this.btn_ENQ.Name = "btn_ENQ";
            this.btn_ENQ.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ENQ.Size = new System.Drawing.Size(202, 38);
            this.btn_ENQ.TabIndex = 17;
            this.btn_ENQ.Text = "ENQ";
            this.btn_ENQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ENQ.UseVisualStyleBackColor = true;
            this.btn_ENQ.Click += new System.EventHandler(this.btn_ENQ_Click);
            // 
            // btn_logOut
            // 
            this.btn_logOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_logOut.Location = new System.Drawing.Point(15, 12);
            this.btn_logOut.Name = "btn_logOut";
            this.btn_logOut.Size = new System.Drawing.Size(75, 23);
            this.btn_logOut.TabIndex = 18;
            this.btn_logOut.Text = "Log out";
            this.btn_logOut.UseVisualStyleBackColor = true;
            // 
            // frm_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 482);
            this.Controls.Add(this.btn_logOut);
            this.Controls.Add(this.btn_ENQ);
            this.Controls.Add(this.btn_INV);
            this.Controls.Add(this.btn_CRM);
            this.Controls.Add(this.btn_SOR);
            this.Controls.Add(this.btn_frontPage);
            this.Controls.Add(this.lbl_timeDisplay);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.mns_menu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mns_menu;
            this.MaximumSize = new System.Drawing.Size(750, 520);
            this.MinimumSize = new System.Drawing.Size(750, 520);
            this.Name = "frm_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mns_menu;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_timeDisplay;
        private System.Windows.Forms.Button btn_frontPage;
        private System.Windows.Forms.Button btn_SOR;
        private System.Windows.Forms.Button btn_CRM;
        private System.Windows.Forms.Button btn_INV;
        private System.Windows.Forms.Button btn_ENQ;
        private System.Windows.Forms.Button btn_logOut;
    }
}