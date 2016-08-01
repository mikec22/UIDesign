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
    public partial class frm_menu : Form
    {
        Form childForm;
        public frm_menu()
        {
            InitializeComponent();
        }

        private void mns_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void frm_menu_Load(object sender, EventArgs e)
        {   
            childForm = new frontPage();
            showForm(childForm);
        }

        private void showForm(Form f)
        {
            f.MdiParent = this;
            f.Show();
        }

        private void btn_ENQ_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new ENQ();
            showForm(childForm);
        }

        private void btn_frontPage_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new frontPage();
            showForm(childForm);
        }

        private void btn_SOR_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new SOR();
            showForm(childForm);
        }

        private void btn_INV_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new INV();
            showForm(childForm);
        }

        private void btn_CRM_Click(object sender, EventArgs e)
        {
            childForm.Close();
            childForm = new CRM();
            showForm(childForm);
        }
    }
}
