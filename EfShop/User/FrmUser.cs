﻿using DataAccessLayer;
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
    public partial class FrmUser : BaseForm<Users>
    {
        public FrmUser()
        {
            InitializeComponent();
            rep = new UserRepository();
            refresh();
        }

        protected override void btnAdd_Click(object sender, EventArgs e)
        {
            FrmUserEdit frm = new FrmUserEdit();
            frm.ShowDialog();
            refresh();
        }

        protected override void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Row To Edit");
                return;
            }

            Users entity = (Users)dataGridView1.SelectedRows[0].DataBoundItem;

            FrmUserEdit frm = new FrmUserEdit(entity);
            frm.ShowDialog();
            refresh();

        }
    }
}
