using System;
using System.Windows.Forms;
using InventoryApp.Models;

namespace InventoryApp.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; private set; }

        public ProductForm(Product? product = null)
        {
            InitializeComponent();

            Product = product ?? new Product();

            // Populate fields
            txtName.Text = Product.Name;
            txtPrice.Text = Product.Price.ToString();
            txtQuantity.Text = Product.Quantity.ToString();
            cmbCategory.SelectedItem = string.IsNullOrEmpty(Product.Category) ? "Other" : Product.Category;

            // Event handlers
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter product name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Product.Name = txtName.Text.Trim();
            Product.Category = cmbCategory.SelectedItem?.ToString() ?? "Other";
            Product.Price = price;
            Product.Quantity = quantity;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
