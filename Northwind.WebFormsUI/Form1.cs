using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories(cbxCategory);
            LoadCategories(cbxAddCategory);
            LoadCategories(cbxUpdateCategory);
        }

        private void LoadCategories(ComboBox comboBox)
        {
            comboBox.DataSource = _categoryService.GetAll();
            comboBox.DisplayMember = "CategoryName";
            comboBox.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception)
            {

            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _productService.Add(new Product
            {
                ProductName = tbxAddProductName.Text,
                CategoryId = Convert.ToInt32(cbxAddCategory.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxAddStock.Text),
                UnitPrice = Convert.ToDecimal(tbxAddUnitPrice.Text),
                QuantityPerUnit = tbxAddStock.Text
            });
            LoadProducts();
            MessageBox.Show("Ürün eklendi!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productService.Update(new Product
            {
                ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxUpdateProductName.Text,
                CategoryId = Convert.ToInt32(cbxUpdateCategory.SelectedValue),
                UnitsInStock = Convert.ToInt16(tbxUpdateStock.Text),
                UnitPrice = Convert.ToDecimal(tbxUpdateUnitPrice.Text),
                QuantityPerUnit = tbxUpdateStock.Text
            });
            LoadProducts();
            MessageBox.Show("Ürün güncellendi!");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateProductName.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxUpdateCategory.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUpdateStock.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();
            tbxUpdateUnitPrice.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateQuantity.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgwProduct.CurrentRow != null)
            {
                try
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                        ProductName = dgwProduct.CurrentRow.Cells[2].Value.ToString(),
                        CategoryId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[1].Value),
                        UnitsInStock = Convert.ToInt16(dgwProduct.CurrentRow.Cells[3].Value),
                        UnitPrice = Convert.ToDecimal(dgwProduct.CurrentRow.Cells[3].Value),
                        QuantityPerUnit = dgwProduct.CurrentRow.Cells[4].Value.ToString()
                    });
                    LoadProducts();
                    MessageBox.Show("Ürün kaldırıldı!");
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }
    }
}
