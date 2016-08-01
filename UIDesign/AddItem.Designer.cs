namespace UIDesign
{
    partial class AddItem
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_itemName = new System.Windows.Forms.TextBox();
            this.txt_totalPrice = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_itemType = new System.Windows.Forms.TextBox();
            this.txt_itemID = new System.Windows.Forms.TextBox();
            this.lbl_itemName = new System.Windows.Forms.Label();
            this.lbl_itemType = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_itemID = new System.Windows.Forms.Label();
            this.lbl_SOE = new System.Windows.Forms.Label();
            this.np_qty = new System.Windows.Forms.NumericUpDown();
            this.lblDesc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.np_qty)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(675, 608);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(112, 32);
            this.btn_cancel.TabIndex = 36;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(525, 608);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(112, 32);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_itemName
            // 
            this.txt_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemName.Location = new System.Drawing.Point(480, 211);
            this.txt_itemName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemName.Name = "txt_itemName";
            this.txt_itemName.ReadOnly = true;
            this.txt_itemName.Size = new System.Drawing.Size(306, 35);
            this.txt_itemName.TabIndex = 34;
            // 
            // txt_totalPrice
            // 
            this.txt_totalPrice.Location = new System.Drawing.Point(637, 546);
            this.txt_totalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txt_totalPrice.Name = "txt_totalPrice";
            this.txt_totalPrice.ReadOnly = true;
            this.txt_totalPrice.Size = new System.Drawing.Size(148, 29);
            this.txt_totalPrice.TabIndex = 33;
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_price.Location = new System.Drawing.Point(637, 431);
            this.txt_price.Margin = new System.Windows.Forms.Padding(4);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(148, 35);
            this.txt_price.TabIndex = 31;
            // 
            // txt_itemType
            // 
            this.txt_itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemType.Location = new System.Drawing.Point(480, 265);
            this.txt_itemType.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemType.Name = "txt_itemType";
            this.txt_itemType.ReadOnly = true;
            this.txt_itemType.Size = new System.Drawing.Size(306, 35);
            this.txt_itemType.TabIndex = 29;
            // 
            // txt_itemID
            // 
            this.txt_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_itemID.Location = new System.Drawing.Point(480, 154);
            this.txt_itemID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_itemID.Name = "txt_itemID";
            this.txt_itemID.ReadOnly = true;
            this.txt_itemID.Size = new System.Drawing.Size(306, 35);
            this.txt_itemID.TabIndex = 28;
            // 
            // lbl_itemName
            // 
            this.lbl_itemName.AutoSize = true;
            this.lbl_itemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemName.Location = new System.Drawing.Point(215, 215);
            this.lbl_itemName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemName.Name = "lbl_itemName";
            this.lbl_itemName.Size = new System.Drawing.Size(142, 29);
            this.lbl_itemName.TabIndex = 27;
            this.lbl_itemName.Text = "Item Name :";
            // 
            // lbl_itemType
            // 
            this.lbl_itemType.AutoSize = true;
            this.lbl_itemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemType.Location = new System.Drawing.Point(215, 269);
            this.lbl_itemType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemType.Name = "lbl_itemType";
            this.lbl_itemType.Size = new System.Drawing.Size(132, 29);
            this.lbl_itemType.TabIndex = 26;
            this.lbl_itemType.Text = "Item Type :";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.Location = new System.Drawing.Point(215, 324);
            this.lbl_description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(147, 29);
            this.lbl_description.TabIndex = 25;
            this.lbl_description.Text = "Description :";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.Location = new System.Drawing.Point(215, 435);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(81, 29);
            this.lbl_price.TabIndex = 24;
            this.lbl_price.Text = "Price :";
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qty.Location = new System.Drawing.Point(215, 490);
            this.lbl_qty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(112, 29);
            this.lbl_qty.TabIndex = 23;
            this.lbl_qty.Text = "Quantity :";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(215, 546);
            this.lbl_totalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(142, 29);
            this.lbl_totalPrice.TabIndex = 22;
            this.lbl_totalPrice.Text = "Total Price :";
            // 
            // lbl_itemID
            // 
            this.lbl_itemID.AutoSize = true;
            this.lbl_itemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itemID.Location = new System.Drawing.Point(215, 158);
            this.lbl_itemID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_itemID.Name = "lbl_itemID";
            this.lbl_itemID.Size = new System.Drawing.Size(100, 29);
            this.lbl_itemID.TabIndex = 21;
            this.lbl_itemID.Text = "Item ID :";
            // 
            // lbl_SOE
            // 
            this.lbl_SOE.AutoSize = true;
            this.lbl_SOE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SOE.Location = new System.Drawing.Point(302, 65);
            this.lbl_SOE.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SOE.Name = "lbl_SOE";
            this.lbl_SOE.Size = new System.Drawing.Size(361, 46);
            this.lbl_SOE.TabIndex = 20;
            this.lbl_SOE.Text = "Sales Order Entity";
            // 
            // np_qty
            // 
            this.np_qty.Location = new System.Drawing.Point(715, 490);
            this.np_qty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.np_qty.Name = "np_qty";
            this.np_qty.Size = new System.Drawing.Size(72, 29);
            this.np_qty.TabIndex = 37;
            this.np_qty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.np_qty.ValueChanged += new System.EventHandler(this.np_qty_ValueChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc.Location = new System.Drawing.Point(475, 324);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(515, 103);
            this.lblDesc.TabIndex = 38;
            this.lblDesc.Text = "XXXXXXXXXXXX";
            // 
            // SalesOrderEntry2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.np_qty);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_itemName);
            this.Controls.Add(this.txt_totalPrice);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_itemType);
            this.Controls.Add(this.txt_itemID);
            this.Controls.Add(this.lbl_itemName);
            this.Controls.Add(this.lbl_itemType);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.lbl_totalPrice);
            this.Controls.Add(this.lbl_itemID);
            this.Controls.Add(this.lbl_SOE);
            this.Name = "SalesOrderEntry2";
            this.Text = "SalesOrderEntry";
            this.Load += new System.EventHandler(this.SalesOrderEntry2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.np_qty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_itemName;
        private System.Windows.Forms.TextBox txt_totalPrice;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_itemType;
        private System.Windows.Forms.TextBox txt_itemID;
        private System.Windows.Forms.Label lbl_itemName;
        private System.Windows.Forms.Label lbl_itemType;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_itemID;
        private System.Windows.Forms.Label lbl_SOE;
        private System.Windows.Forms.NumericUpDown np_qty;
        private System.Windows.Forms.Label lblDesc;
    }
}