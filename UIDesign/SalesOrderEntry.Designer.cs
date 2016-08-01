namespace UIDesign
{
    partial class SalesOrderEntry
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
            this.tc = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblItemStoreName = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblItemID = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dgv_item = new System.Windows.Forms.DataGridView();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lblSalesOrderEntry = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtRemark = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.gbCustomerType = new System.Windows.Forms.GroupBox();
            this.rbDealer = new System.Windows.Forms.RadioButton();
            this.rbMenber = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.cbStore = new System.Windows.Forms.ComboBox();
            this.lblStore = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.dgv_selectedItem = new System.Windows.Forms.DataGridView();
            this.selectedItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectItemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedItemTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_totalPrice = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_item = new System.Windows.Forms.Label();
            this.btnGen = new System.Windows.Forms.Button();
            this.cbStoreName = new System.Windows.Forms.ComboBox();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbCustomerType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedItem)).BeginInit();
            this.SuspendLayout();
            // 
            // tc
            // 
            this.tc.Controls.Add(this.tabPage1);
            this.tc.Controls.Add(this.tabPage2);
            this.tc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc.Location = new System.Drawing.Point(0, 0);
            this.tc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc.Name = "tc";
            this.tc.SelectedIndex = 0;
            this.tc.Size = new System.Drawing.Size(668, 475);
            this.tc.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbStoreName);
            this.tabPage1.Controls.Add(this.lblItemStoreName);
            this.tabPage1.Controls.Add(this.txtItemID);
            this.tabPage1.Controls.Add(this.lblItemID);
            this.tabPage1.Controls.Add(this.btn_back);
            this.tabPage1.Controls.Add(this.dgv_item);
            this.tabPage1.Controls.Add(this.cmb_type);
            this.tabPage1.Controls.Add(this.txt_name);
            this.tabPage1.Controls.Add(this.lbl_type);
            this.tabPage1.Controls.Add(this.lbl_name);
            this.tabPage1.Controls.Add(this.lblSalesOrderEntry);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(660, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Item";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblItemStoreName
            // 
            this.lblItemStoreName.AutoSize = true;
            this.lblItemStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemStoreName.Location = new System.Drawing.Point(413, 80);
            this.lblItemStoreName.Name = "lblItemStoreName";
            this.lblItemStoreName.Size = new System.Drawing.Size(56, 20);
            this.lblItemStoreName.TabIndex = 27;
            this.lblItemStoreName.Text = "Store :";
            // 
            // txtItemID
            // 
            this.txtItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemID.Location = new System.Drawing.Point(105, 80);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(281, 26);
            this.txtItemID.TabIndex = 26;
            this.txtItemID.TextChanged += new System.EventHandler(this.txtItemID_TextChanged);
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemID.Location = new System.Drawing.Point(5, 82);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(70, 20);
            this.lblItemID.TabIndex = 25;
            this.lblItemID.Text = "Item ID :";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(567, 421);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(92, 21);
            this.btn_back.TabIndex = 24;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dgv_item
            // 
            this.dgv_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.itemName,
            this.Type,
            this.Price,
            this.Qty});
            this.dgv_item.Location = new System.Drawing.Point(8, 157);
            this.dgv_item.Name = "dgv_item";
            this.dgv_item.Size = new System.Drawing.Size(544, 286);
            this.dgv_item.TabIndex = 23;
            this.dgv_item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_item_CellDoubleClick);
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Location = new System.Drawing.Point(511, 122);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(141, 28);
            this.cmb_type.TabIndex = 22;
            this.cmb_type.SelectedIndexChanged += new System.EventHandler(this.cmb_type_SelectedIndexChanged);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(105, 122);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(281, 26);
            this.txt_name.TabIndex = 21;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(413, 124);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(91, 20);
            this.lbl_type.TabIndex = 20;
            this.lbl_type.Text = "Item Type : ";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(5, 124);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(95, 20);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Item Name :";
            // 
            // lblSalesOrderEntry
            // 
            this.lblSalesOrderEntry.AutoSize = true;
            this.lblSalesOrderEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesOrderEntry.Location = new System.Drawing.Point(201, 11);
            this.lblSalesOrderEntry.Name = "lblSalesOrderEntry";
            this.lblSalesOrderEntry.Size = new System.Drawing.Size(246, 31);
            this.lblSalesOrderEntry.TabIndex = 18;
            this.lblSalesOrderEntry.Text = "Sales Order Entry";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGen);
            this.tabPage2.Controls.Add(this.txtRemark);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.lblEmail);
            this.tabPage2.Controls.Add(this.txtTel);
            this.tabPage2.Controls.Add(this.lblTel);
            this.tabPage2.Controls.Add(this.txtMemberID);
            this.tabPage2.Controls.Add(this.lbl);
            this.tabPage2.Controls.Add(this.gbCustomerType);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.lblStaffID);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.lblOrderDate);
            this.tabPage2.Controls.Add(this.cbStore);
            this.tabPage2.Controls.Add(this.lblStore);
            this.tabPage2.Controls.Add(this.txtOrderID);
            this.tabPage2.Controls.Add(this.lblOrderID);
            this.tabPage2.Controls.Add(this.dgv_selectedItem);
            this.tabPage2.Controls.Add(this.lbl_totalPrice);
            this.tabPage2.Controls.Add(this.lbl_total);
            this.tabPage2.Controls.Add(this.btn_cancel);
            this.tabPage2.Controls.Add(this.btn_save);
            this.tabPage2.Controls.Add(this.lbl_item);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(660, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(509, 28);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.txtRemark.Size = new System.Drawing.Size(149, 125);
            this.txtRemark.TabIndex = 31;
            this.txtRemark.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "Remark:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(315, 127);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 22);
            this.textBox2.TabIndex = 29;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(276, 134);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 12);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(315, 86);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(173, 22);
            this.txtTel.TabIndex = 27;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(274, 89);
            this.lblTel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(23, 12);
            this.lblTel.TabIndex = 26;
            this.lblTel.Text = "Tel:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(344, 49);
            this.txtMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(144, 22);
            this.txtMemberID.TabIndex = 25;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(274, 53);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(62, 12);
            this.lbl.TabIndex = 24;
            this.lbl.Text = "Member ID:";
            // 
            // gbCustomerType
            // 
            this.gbCustomerType.Controls.Add(this.rbDealer);
            this.gbCustomerType.Controls.Add(this.rbMenber);
            this.gbCustomerType.Location = new System.Drawing.Point(276, 4);
            this.gbCustomerType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCustomerType.Name = "gbCustomerType";
            this.gbCustomerType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbCustomerType.Size = new System.Drawing.Size(156, 41);
            this.gbCustomerType.TabIndex = 23;
            this.gbCustomerType.TabStop = false;
            this.gbCustomerType.Text = "Customer Type";
            // 
            // rbDealer
            // 
            this.rbDealer.AutoSize = true;
            this.rbDealer.Location = new System.Drawing.Point(81, 19);
            this.rbDealer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbDealer.Name = "rbDealer";
            this.rbDealer.Size = new System.Drawing.Size(53, 16);
            this.rbDealer.TabIndex = 1;
            this.rbDealer.TabStop = true;
            this.rbDealer.Text = "Dealer";
            this.rbDealer.UseVisualStyleBackColor = true;
            // 
            // rbMenber
            // 
            this.rbMenber.AutoSize = true;
            this.rbMenber.Location = new System.Drawing.Point(4, 19);
            this.rbMenber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMenber.Name = "rbMenber";
            this.rbMenber.Size = new System.Drawing.Size(62, 16);
            this.rbMenber.TabIndex = 0;
            this.rbMenber.TabStop = true;
            this.rbMenber.Text = "Member";
            this.rbMenber.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 86);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 22;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(16, 89);
            this.lblStaffID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(45, 12);
            this.lblStaffID.TabIndex = 21;
            this.lblStaffID.Text = "Staff ID:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 127);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 22);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(14, 132);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(57, 12);
            this.lblOrderDate.TabIndex = 19;
            this.lblOrderDate.Text = "Order date:";
            // 
            // cbStore
            // 
            this.cbStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStore.FormattingEnabled = true;
            this.cbStore.Location = new System.Drawing.Point(80, 50);
            this.cbStore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbStore.Name = "cbStore";
            this.cbStore.Size = new System.Drawing.Size(135, 20);
            this.cbStore.TabIndex = 18;
            // 
            // lblStore
            // 
            this.lblStore.AutoSize = true;
            this.lblStore.Location = new System.Drawing.Point(16, 51);
            this.lblStore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStore.Name = "lblStore";
            this.lblStore.Size = new System.Drawing.Size(32, 12);
            this.lblStore.TabIndex = 17;
            this.lblStore.Text = "Store:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(80, 13);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(95, 22);
            this.txtOrderID.TabIndex = 16;
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(14, 15);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(50, 12);
            this.lblOrderID.TabIndex = 15;
            this.lblOrderID.Text = "Order ID:";
            // 
            // dgv_selectedItem
            // 
            this.dgv_selectedItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_selectedItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectedItemID,
            this.selectItemName,
            this.selectItemQty,
            this.selectedItemTotalPrice,
            this.Remove});
            this.dgv_selectedItem.Location = new System.Drawing.Point(5, 217);
            this.dgv_selectedItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_selectedItem.Name = "dgv_selectedItem";
            this.dgv_selectedItem.RowTemplate.Height = 31;
            this.dgv_selectedItem.Size = new System.Drawing.Size(652, 158);
            this.dgv_selectedItem.TabIndex = 14;
            this.dgv_selectedItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_selectedItem_CellContentClick);
            // 
            // selectedItemID
            // 
            this.selectedItemID.HeaderText = "Item ID";
            this.selectedItemID.Name = "selectedItemID";
            this.selectedItemID.ReadOnly = true;
            // 
            // selectItemName
            // 
            this.selectItemName.HeaderText = "Item Name";
            this.selectItemName.Name = "selectItemName";
            this.selectItemName.ReadOnly = true;
            // 
            // selectItemQty
            // 
            this.selectItemQty.HeaderText = "Qty";
            this.selectItemQty.Name = "selectItemQty";
            this.selectItemQty.ReadOnly = true;
            // 
            // selectedItemTotalPrice
            // 
            this.selectedItemTotalPrice.HeaderText = "Item Total Price";
            this.selectedItemTotalPrice.Name = "selectedItemTotalPrice";
            this.selectedItemTotalPrice.ReadOnly = true;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            // 
            // lbl_totalPrice
            // 
            this.lbl_totalPrice.AutoSize = true;
            this.lbl_totalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalPrice.Location = new System.Drawing.Point(506, 388);
            this.lbl_totalPrice.Name = "lbl_totalPrice";
            this.lbl_totalPrice.Size = new System.Drawing.Size(35, 17);
            this.lbl_totalPrice.TabIndex = 12;
            this.lbl_totalPrice.Text = "total";
            this.lbl_totalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(362, 388);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(48, 17);
            this.lbl_total.TabIndex = 11;
            this.lbl_total.Text = "Total :";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(458, 420);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 21);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(365, 420);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(82, 21);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_item
            // 
            this.lbl_item.AutoSize = true;
            this.lbl_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_item.Location = new System.Drawing.Point(17, 195);
            this.lbl_item.Name = "lbl_item";
            this.lbl_item.Size = new System.Drawing.Size(49, 20);
            this.lbl_item.TabIndex = 7;
            this.lbl_item.Text = "Item :";
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(180, 12);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(35, 23);
            this.btnGen.TabIndex = 32;
            this.btnGen.Text = "gen";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // cbStoreName
            // 
            this.cbStoreName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStoreName.FormattingEnabled = true;
            this.cbStoreName.Location = new System.Drawing.Point(511, 80);
            this.cbStoreName.Name = "cbStoreName";
            this.cbStoreName.Size = new System.Drawing.Size(121, 20);
            this.cbStoreName.TabIndex = 28;
            this.cbStoreName.SelectedIndexChanged += new System.EventHandler(this.cbStoreName_SelectedIndexChanged);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 75;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Name";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            this.itemName.Width = 200;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 54;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 53;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // SalesOrderEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 475);
            this.Controls.Add(this.tc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SalesOrderEntry";
            this.Text = "SalesOrderEntry";
            this.Load += new System.EventHandler(this.SalesOrderEntry_Load);
            this.tc.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbCustomerType.ResumeLayout(false);
            this.gbCustomerType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_selectedItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dgv_item;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lblSalesOrderEntry;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.DataGridView dgv_selectedItem;
        private System.Windows.Forms.Label lbl_totalPrice;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_item;
        private System.Windows.Forms.RichTextBox txtRemark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox gbCustomerType;
        private System.Windows.Forms.RadioButton rbDealer;
        private System.Windows.Forms.RadioButton rbMenber;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.ComboBox cbStore;
        private System.Windows.Forms.Label lblStore;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectItemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedItemTotalPrice;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Label lblItemStoreName;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.ComboBox cbStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
    }
}