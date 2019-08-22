using EfShop.Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            FrmUser frm = new FrmUser();
            frm.ShowDialog();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            FrmProduct frm = new FrmProduct();
            frm.ShowDialog();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            FrmOrder frm = new FrmOrder();
            frm.ShowDialog();
        }
    }
}
