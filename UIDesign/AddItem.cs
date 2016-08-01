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
    public partial class AddItem : Form
    {
        SalesOrderEntry orderFrom;
        item itemDetails;

        public AddItem()
        {
            InitializeComponent();
        }

        public AddItem(item itemDetails, SalesOrderEntry orderFrom)
        {
            InitializeComponent();
            this.itemDetails = itemDetails;
            this.orderFrom = orderFrom;
        }

        private void SalesOrderEntry2_Load(object sender, EventArgs e)
        {           
            txt_itemID.Text = itemDetails.ItemID;
            txt_itemName.Text = itemDetails.ItemName;
            txt_itemType.Text = itemDetails.ItemType;
            txt_price.Text = itemDetails.ItemPrice.ToString("C2");
            lblDesc.Text = itemDetails.ItemDescription;
            txt_totalPrice.Text = calculateTotalPrice().ToString("C2");
        }

        private void np_qty_ValueChanged(object sender, EventArgs e)
        {
            txt_totalPrice.Text = calculateTotalPrice().ToString("C2");
        }

        private double calculateTotalPrice()
        {
            return Convert.ToInt32(np_qty.Value) * itemDetails.ItemPrice;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (var i in orderFrom.SelectedItem)
            {
                if (i.ItemID == itemDetails.ItemID)
                {
                    i.Qty += Convert.ToInt32(np_qty.Value);
                    i.TotalPrice += calculateTotalPrice();
                    orderFrom.selectedItemEnquiry();
                    this.Close();
                    return;
                }
            }

            sales_orderline item = new sales_orderline()
            {
                ItemID = itemDetails.ItemID,
                Qty = Convert.ToInt32(np_qty.Value),
                TotalPrice = calculateTotalPrice()
            };
            orderFrom.SelectedItem.Add(item);
            orderFrom.selectedItemEnquiry();
            this.Close();
            return;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
