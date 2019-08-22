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
    public partial class FrmCategoryEdit : Form
    {
        public int id;

        public FrmCategoryEdit()
        {
            id = -1;
            InitializeComponent();
        }

        public FrmCategoryEdit(Categories cat)
        {
            InitializeComponent();
            id = cat.Id;
            textBoxName.Text = cat.Name;
            textBoxDescription.Text = cat.Description;
            textBoxCatOrder.Text = cat.CatOrder.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Categories cat = new Categories();
            cat.Name = textBoxName.Text;
            cat.Description = textBoxDescription.Text;
            cat.CatOrder = Convert.ToInt32(textBoxCatOrder.Text);

            CategoryRepository rep = new CategoryRepository();

            if (id == -1) 
            {
                rep.Insert(cat);
            }

            else
            {
                cat.Id = id;
                cat = rep.Update(cat);
            }

            Close();
        }
    }
}
