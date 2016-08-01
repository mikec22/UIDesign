using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIDesign
{
    public partial class SalesOrderEntry : Form
    {
        private static List<sales_orderline> selectedItem;

        public SalesOrderEntry()
        {
            InitializeComponent();
            
        }

        private void SalesOrderEntry_Load(object sender, EventArgs e)
        {
            SelectedItem = new List<sales_orderline>();
            using (var entity = new MMS_Entities())
            {
                var allItemType = (from list in entity.item     //select all item type for add item to combo box cmb_type
                                   select list.ItemType).Distinct();
                var allStore = (from list in entity.store
                                select list.Nickname);

                foreach (string store in allStore)
                {
                    cbStore.Items.Add(store);
                    cbStoreName.Items.Add(store);
                }
                
                cmb_type.Items.Add("All");
                foreach (string type in allItemType)      //add item type to combo box cmb_type
                {
                    cmb_type.Items.Add(type);
                }
                
            }
            cmb_type.SelectedIndex = 0;
            cbStore.SelectedIndex = 0;
            cbStoreName.SelectedIndex = 0;
            itemEnquiry();
            selectedItemEnquiry();
            txtOrderID.Text = genOrderID();
        }

        private void itemEnquiry()      //call when any keywords text changed
        {
            string itemIDKeyword = txtItemID.Text;
            string itemNameKeyword = txt_name.Text;
            string itemTypeKeyword = (cmb_type.Text == "All" ? "": cmb_type.Text);

            using (var entity = new MMS_Entities())
            {
                var selectedItem = (from list in entity.item
                                    join list2 in entity.store_item on list.ItemID equals list2.ItemID
                                    join list3 in entity.store on list2.StoreID equals list3.StoreID
                                    where list3.Nickname.Equals(cbStoreName.Text)
                                    && list.ItemID.Contains(itemIDKeyword)
                                    && list.ItemName.Contains(itemNameKeyword)
                                    && list.ItemType.Contains(itemTypeKeyword)
                                    select list);

                var selectedItemQty = (from list in entity.item
                                    join list2 in entity.store_item on list.ItemID equals list2.ItemID
                                    join list3 in entity.store on list2.StoreID equals list3.StoreID
                                    where list3.Nickname.Equals(cbStoreName.Text)
                                    && list.ItemID.Contains(itemIDKeyword)
                                    && list.ItemName.Contains(itemNameKeyword)
                                    && list.ItemType.Contains(itemTypeKeyword)
                                    select list2.Qty);

                if (selectedItem.FirstOrDefault() != null)
                {
                    dgv_item.Rows.Clear();
                    int index = 0;
                    foreach (var item in selectedItem.ToList())
                    {
                        string itemID = item.ItemID;
                        string itemName = item.ItemName;
                        string itemType = item.ItemType;
                        string itemPrice = item.ItemPrice.ToString("C2");
                        int qty = selectedItemQty.ToList().ElementAt(index++);
                        int rowIndex = dgv_item.Rows.Add(itemID, itemName, itemType, itemPrice, qty);
                        dgv_item.Rows[rowIndex].Tag = itemID;
                    }
                }

            }

        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            itemEnquiry();
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            itemEnquiry();
        }

        private void cmb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemEnquiry();
        }

        private void dgv_item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex == dgv_item.RowCount - 1)
                return;

            string itemID = dgv_item.Rows[e.RowIndex].Tag.ToString();

            using(var entity = new MMS_Entities())
            {
                item item = entity.item.Find(itemID);
                AddItem itemDetails = new AddItem(item, this);
                itemDetails.ShowDialog();
            }
        }

        public void selectedItemEnquiry()
        {
            double total = 0;
            dgv_selectedItem.Rows.Clear();
            using (var entity = new MMS_Entities())
            {
                foreach (var item in SelectedItem)
                {
                    item itemDetails = entity.item.Find(item.ItemID);
                    int rowIndex = dgv_selectedItem.Rows.Add(item.ItemID,
                        itemDetails.ItemName,
                        item.Qty,
                        item.TotalPrice.ToString("C2"),
                        "Remove");
                    total += item.TotalPrice;
                }
            }
            lbl_totalPrice.Text = total.ToString("C2");
        }

        public DataGridView Dgv_selectedItem
        {
            get { return dgv_selectedItem; }
        }

        public List<sales_orderline> SelectedItem
        {
            get { return selectedItem; }
            set { selectedItem = value; }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_selectedItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgv_selectedItem.Columns[4].Index && e.RowIndex >= 0 && SelectedItem.Count > 0)
            {
                SelectedItem.RemoveAt(e.RowIndex);
                selectedItemEnquiry();
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = genOrderID();
        }

        private string genOrderID()
        {
            using (var entity = new MMS_Entities())
            {
                var orderID = (from list in entity.sales_order
                               orderby list.OrderID descending
                               select list.OrderID).FirstOrDefault();

                if (orderID != null)
                {
                    int newID = Convert.ToInt32(orderID.Substring(2)) + 1;
                    return "SO" + (newID.ToString().PadLeft(5, '0'));
                }
                else
                {
                    return "SO00001";
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void cbStoreName_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemEnquiry();
        }
    }
   
}
