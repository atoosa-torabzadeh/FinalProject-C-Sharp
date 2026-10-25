using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnOpenPerson_Click(object sender, EventArgs e)
        {
            using (var form = new PersonForm()) {
                form.ShowDialog(this);          
            }
        }

        private void btnOpenProduct_Click(object sender, EventArgs e)
        {
           using (var form = new ProductForm()) { form.ShowDialog(this); }
        }
    }
}
