namespace UIDesign
{
    partial class f13
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_searchName = new System.Windows.Forms.Label();
            this.lbl_searchDCID = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.gpb_DCID = new System.Windows.Forms.GroupBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.dgv_DC = new System.Windows.Forms.DataGridView();
            this.txt_searchName = new System.Windows.Forms.TextBox();
            this.txt_searchDCID = new System.Windows.Forms.TextBox();
            this.DCID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_back = new System.Windows.Forms.Button();
            this.gpb_DCID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dealer Customer Profile";
            // 
            // lbl_searchName
            // 
            this.lbl_searchName.AutoSize = true;
            this.lbl_searchName.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_searchName.Location = new System.Drawing.Point(142, 66);
            this.lbl_searchName.Name = "lbl_searchName";
            this.lbl_searchName.Size = new System.Drawing.Size(55, 16);
            this.lbl_searchName.TabIndex = 1;
            this.lbl_searchName.Text = "Phone :";
            // 
            // lbl_searchDCID
            // 
            this.lbl_searchDCID.AutoSize = true;
            this.lbl_searchDCID.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_searchDCID.Location = new System.Drawing.Point(142, 103);
            this.lbl_searchDCID.Name = "lbl_searchDCID";
            this.lbl_searchDCID.Size = new System.Drawing.Size(53, 16);
            this.lbl_searchDCID.TabIndex = 2;
            this.lbl_searchDCID.Text = "DCID :";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(308, 133);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 25);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(192, 224);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 25);
            this.btn_update.TabIndex = 4;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(303, 224);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 25);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // gpb_DCID
            // 
            this.gpb_DCID.BackColor = System.Drawing.Color.Gainsboro;
            this.gpb_DCID.Controls.Add(this.txt_email);
            this.gpb_DCID.Controls.Add(this.txt_address);
            this.gpb_DCID.Controls.Add(this.txt_phone);
            this.gpb_DCID.Controls.Add(this.txt_name);
            this.gpb_DCID.Controls.Add(this.btn_cancel);
            this.gpb_DCID.Controls.Add(this.lbl_email);
            this.gpb_DCID.Controls.Add(this.btn_update);
            this.gpb_DCID.Controls.Add(this.lbl_Address);
            this.gpb_DCID.Controls.Add(this.lbl_phone);
            this.gpb_DCID.Controls.Add(this.lbl_name);
            this.gpb_DCID.Location = new System.Drawing.Point(37, 295);
            this.gpb_DCID.Name = "gpb_DCID";
            this.gpb_DCID.Size = new System.Drawing.Size(439, 266);
            this.gpb_DCID.TabIndex = 6;
            this.gpb_DCID.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_email.Location = new System.Drawing.Point(147, 186);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(231, 26);
            this.txt_email.TabIndex = 7;
            // 
            // txt_address
            // 
            this.txt_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_address.Location = new System.Drawing.Point(147, 86);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(231, 89);
            this.txt_address.TabIndex = 6;
            // 
            // txt_phone
            // 
            this.txt_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_phone.Location = new System.Drawing.Point(147, 52);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(120, 26);
            this.txt_phone.TabIndex = 5;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(147, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(120, 26);
            this.txt_name.TabIndex = 4;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(27, 189);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(56, 20);
            this.lbl_email.TabIndex = 3;
            this.lbl_email.Text = "Email :";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(24, 86);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(76, 20);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address :";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.Location = new System.Drawing.Point(24, 55);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(63, 20);
            this.lbl_phone.TabIndex = 1;
            this.lbl_phone.Text = "Phone :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(24, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 20);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name :";
            // 
            // dgv_DC
            // 
            this.dgv_DC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCID,
            this.DCName,
            this.Phone});
            this.dgv_DC.Location = new System.Drawing.Point(86, 177);
            this.dgv_DC.Name = "dgv_DC";
            this.dgv_DC.RowTemplate.Height = 24;
            this.dgv_DC.Size = new System.Drawing.Size(346, 103);
            this.dgv_DC.TabIndex = 7;
            // 
            // txt_searchName
            // 
            this.txt_searchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_searchName.Location = new System.Drawing.Point(262, 60);
            this.txt_searchName.Name = "txt_searchName";
            this.txt_searchName.Size = new System.Drawing.Size(121, 26);
            this.txt_searchName.TabIndex = 8;
            // 
            // txt_searchDCID
            // 
            this.txt_searchDCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_searchDCID.Location = new System.Drawing.Point(262, 97);
            this.txt_searchDCID.Name = "txt_searchDCID";
            this.txt_searchDCID.Size = new System.Drawing.Size(121, 26);
            this.txt_searchDCID.TabIndex = 9;
            // 
            // DCID
            // 
            this.DCID.HeaderText = "DCID";
            this.DCID.Name = "DCID";
            this.DCID.ReadOnly = true;
            // 
            // DCName
            // 
            this.DCName.HeaderText = "Name";
            this.DCName.Name = "DCName";
            this.DCName.ReadOnly = true;
            this.DCName.Width = 125;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 75;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(365, 578);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            // 
            // f13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 613);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_searchDCID);
            this.Controls.Add(this.txt_searchName);
            this.Controls.Add(this.dgv_DC);
            this.Controls.Add(this.gpb_DCID);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_searchDCID);
            this.Controls.Add(this.lbl_searchName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "f13";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "f13";
            this.gpb_DCID.ResumeLayout(false);
            this.gpb_DCID.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_searchName;
        private System.Windows.Forms.Label lbl_searchDCID;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.GroupBox gpb_DCID;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.DataGridView dgv_DC;
        private System.Windows.Forms.TextBox txt_searchName;
        private System.Windows.Forms.TextBox txt_searchDCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.Button btn_back;
    }
}