using ApplicationService.Dtos;
using ApplicationService.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace View
{
    public partial class ProductForm : Form
    {
        private ProductApplicationService _productApplicationService = new ProductApplicationService();
        private int _selectedProductId = 0;
        public ProductForm()
        {
            InitializeComponent();

        }
        public void RefreshProduct()
        {
            dgvProduct.DataSource = _productApplicationService.SellectAll();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            var dto = new PostProductDto();
            dto.Code = Convert.ToInt32(txtCode.Text);
            dto.Title = txtTitle.Text;
            dto.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            dto.Quantity = Convert.ToInt32(txtQuantity.Text);
            _productApplicationService.Insert(dto);
            MessageBox.Show("اطلاعات محصول با موفقیت ثبت شد");
            txtCode.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            RefreshProduct();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProduct();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var dto = new UpdateProductDto
            {
                Id = _selectedProductId,
                Code = int.Parse(txtCode.Text),
                Title = txtTitle.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                Quantity = int.Parse(txtQuantity.Text)
            };

            _productApplicationService.Update(dto);
            MessageBox.Show("محصول با موفقیت ویرایش شد.");
            RefreshProduct();

            ClearInputs();
            btnPost.Enabled = true;
            btnRefresh.Enabled = true;
            btnUpdate.Enabled = false;
            _selectedProductId = 0;
        
        }
        private void ClearInputs()
        {
            txtCode.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
        }


        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;

            var selectedRow = dgvProduct.Rows[e.RowIndex];

            _selectedProductId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            txtCode.Text = selectedRow.Cells["Code"].Value?.ToString();
            txtTitle.Text = selectedRow.Cells["Title"].Value?.ToString();
            txtUnitPrice.Text = selectedRow.Cells["UnitPrice"].Value?.ToString();
            txtQuantity.Text = selectedRow.Cells["Quantity"].Value?.ToString();

            btnPost.Enabled = false;      
            btnRefresh.Enabled = false;
            btnUpdate.Enabled = true;
        }

    }
}

