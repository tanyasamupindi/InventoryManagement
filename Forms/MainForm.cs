using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using InventoryApp.Data;
using InventoryApp.Models;

namespace InventoryApp.Forms
{
    public partial class MainForm : Form
    {
        private BindingList<Product> bindingList = new BindingList<Product>();
        private readonly ProductRepository repo = new ProductRepository();

        public MainForm()
        {
            InitializeComponent();
            LoadData();

            // Event handlers
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            btnLogout.Click += (s, e) => this.Close();
            btnExport.Click += BtnExport_Click;
            btnImport.Click += BtnImport_Click;
        }

        private void LoadData(string search = "")
        {
            var products = string.IsNullOrWhiteSpace(search) ? repo.GetAll() : repo.Search(search);
            bindingList = new BindingList<Product>(products);
            dgvProducts.DataSource = bindingList;

            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            dgvProducts.RowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Update totals
            lblTotalProducts.Text = $"Total Products: {bindingList.Count}";
            lblTotalValue.Text = $"Total Inventory Value: {bindingList.Sum(p => p.Price * p.Quantity):C}";
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            ProductForm form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                repo.Add(form.Product);
                LoadData(txtSearch.Text);
            }
        }

        private void BtnEdit_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selected)
            {
                ProductForm form = new ProductForm(selected);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    repo.Update(form.Product);
                    LoadData(txtSearch.Text);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            if (dgvProducts.CurrentRow?.DataBoundItem is Product selected)
            {
                if (MessageBox.Show($"Are you sure you want to delete {selected.Name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    repo.Delete(selected.Id);
                    LoadData(txtSearch.Text);
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtSearch_TextChanged(object? sender, EventArgs e)
        {
            LoadData(txtSearch.Text);
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV files|*.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var lines = repo.GetAll().Select(p => $"{p.Id},{p.Name},{p.Category},{p.Price},{p.Quantity}");
                    System.IO.File.WriteAllLines(sfd.FileName, lines);
                    MessageBox.Show("Export completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BtnImport_Click(object? sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "CSV files|*.csv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var lines = System.IO.File.ReadAllLines(ofd.FileName);
                    foreach (var line in lines)
                    {
                        var parts = line.Split(',');
                        if (parts.Length == 5 && decimal.TryParse(parts[3], out decimal price) && int.TryParse(parts[4], out int quantity))
                        {
                            var product = new Product
                            {
                                Id = int.Parse(parts[0]),
                                Name = parts[1],
                                Category = parts[2],
                                Price = price,
                                Quantity = quantity
                            };
                            repo.Add(product);
                        }
                    }
                    LoadData();
                    MessageBox.Show("Import completed!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
