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
    public partial class SOR : Form
    {
        public SOR()
        {
            InitializeComponent();
        }

        private void btn_SOE_Click(object sender, EventArgs e)
        {
            Form SOE = new SalesOrderEntry();
            SOE.Show();
        }
    }
}
