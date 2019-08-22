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

namespace EfShop
{
    public partial class FrmProductEdit : Form
    {
        public int id;
        public FrmProductEdit()
        {
            InitializeComponent();
            id = -1;

            myShopEntities db = new myShopEntities();
            List<CustomProduct> cat = (from c in db.Categories
                       select new CustomProduct()
                       {
                           CategoryName = c.Name
                           
                       }).ToList();

            comboBox1.DataSource = cat;
            comboBox1.DisplayMember = "CategoryName";
        }

        public FrmProductEdit(Products p)
        {
            InitializeComponent();
            id = p.Id;
            var catRep = new CategoryRepository();
            textBoxName.Text = p.Name;
            textBoxPrice.Text = p.Price.ToString();
            textBoxStocks.Text = p.stocks.ToString();
            textBoxProductCode.Text = p.productCode;
            comboBox1.SelectedValue = p.categoryId;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Products p = new Products();
            p.Name = textBoxName.Text;
            p.Price = Convert.ToInt32(textBoxPrice.Text);
            p.stocks = Convert.ToInt32(textBoxStocks.Text);
            p.productCode = textBoxProductCode.Text;
            p.categoryId = (int)comboBox1.SelectedValue;

            ProductRepository rep = new ProductRepository();

            if (id == -1)
            {
                rep.Insert(p);
            }

            else
            {
                p.Id = id;
                p = rep.Update(p);
            }

            Close();
        }

        private void FrmProductEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myShopDataSet1.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.myShopDataSet1.Categories);

        }
    }
}
