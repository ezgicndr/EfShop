using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfShop.Order
{
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();

            UserRepository userRep = new UserRepository();
            comboBoxUser.DataSource = userRep.List();

            ProductRepository proRep = new ProductRepository();
            int catId = (int)comboBoxCategory.SelectedValue;
            dataGridViewProducts.DataSource = proRep.GetProductInStock();
        }

    }
}
