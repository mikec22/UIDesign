namespace UIDesign
{
    partial class f9_2
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
            this.lbl_quotation = new System.Windows.Forms.Label();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_itemType = new System.Windows.Forms.Label();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.txt_itemType = new System.Windows.Forms.TextBox();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_quotation
            // 
            this.lbl_quotation.AutoSize = true;
            this.lbl_quotation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_quotation.Location = new System.Drawing.Point(176, 9);
            this.lbl_quotation.Name = "lbl_quotation";
            this.lbl_quotation.Size = new System.Drawing.Size(141, 31);
            this.lbl_quotation.TabIndex = 1;
            this.lbl_quotation.Text = "Quotation";
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemID.Location = new System.Drawing.Point(61, 70);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(70, 20);
            this.lbl_itemID.TabIndex = 2;
            this.lbl_itemID.Text = "Item ID :";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(61, 350);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(91, 20);
            this.lbl_totalPrice.TabIndex = 3;
            this.lbl_totalPrice.Text = "Total Price :";
            this.lbl_totalPrice.Click += new System.EventHandler(this.lbl_totalPrice_Click);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(61, 310);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(76, 20);
            this.lbl_qty.TabIndex = 4;
            this.lbl_qty.Text = "Quantity :";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(61, 270);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(52, 20);
            this.lbl_price.TabIndex = 6;
            this.lbl_price.Text = "Price :";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(61, 190);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(97, 20);
            this.lbl_description.TabIndex = 7;
            this.lbl_description.Text = "Description :";
            // 
            // lbl_itemType
            // 
            this.lbl_itemType.AutoSize = true;
            this.lbl_itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemType.Location = new System.Drawing.Point(61, 150);
            this.lbl_itemType.Name = "lbl_itemType";
            this.lbl_itemType.Size = new System.Drawing.Size(87, 20);
            this.lbl_itemType.TabIndex = 8;
            this.lbl_itemType.Text = "Item Type :";
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(61, 111);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(95, 20);
            this.lbl_itemName.TabIndex = 9;
            this.lbl_itemName.Text = "Item Name :";
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemID.Location = new System.Drawing.Point(238, 67);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.ReadOnly = true;
            this.txt_itemID.Size = new System.Drawing.Size(205, 26);
            this.txt_itemID.TabIndex = 10;
            // 
            // txt_itemType
            // 
            this.txt_itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemType.Location = new System.Drawing.Point(238, 147);
            this.txt_itemType.Name = "txt_itemType";
            this.txt_itemType.ReadOnly = true;
            this.txt_itemType.Size = new System.Drawing.Size(205, 26);
            this.txt_itemType.TabIndex = 11;
            // 
            // txt_desc
            // 
            this.txt_desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_desc.Location = new System.Drawing.Point(238, 192);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.ReadOnly = true;
            this.txt_desc.Size = new System.Drawing.Size(205, 53);
            this.txt_desc.TabIndex = 12;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_price.Location = new System.Drawing.Point(343, 267);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(100, 26);
            this.txt_price.TabIndex = 13;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(389, 310);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(54, 20);
            this.txt_qty.TabIndex = 15;
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Location = new System.Drawing.Point(343, 350);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.ReadOnly = true;
            this.txt_totalPrice.Size = new System.Drawing.Size(100, 20);
            this.txt_totalPrice.TabIndex = 16;
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemName.Location = new System.Drawing.Point(238, 108);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.ReadOnly = true;
            this.txt_itemName.Size = new System.Drawing.Size(205, 26);
            this.txt_itemName.TabIndex = 17;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(268, 395);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(368, 395);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 19;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // f9_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 440);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_desc);
            this.Controls.Add(this.txt_itemType);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_itemType);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_itemID);
            this.Controls.Add(this.lbl_quotation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "f9_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quotation;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_itemType;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.TextBox txt_itemType;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_totalPrice;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_cancel;
    }
}