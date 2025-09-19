namespace InventoryApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvProducts;
        private Button btnAdd, btnEdit, btnDelete, btnLogout, btnExport, btnImport;
        private TextBox txtSearch;
        private Label lblTotalProducts, lblTotalValue;

        private void InitializeComponent()
        {
            this.dgvProducts = new DataGridView();
            this.btnAdd = new Button(); this.btnEdit = new Button(); this.btnDelete = new Button();
            this.btnLogout = new Button(); this.btnExport = new Button(); this.btnImport = new Button();
            this.txtSearch = new TextBox();
            this.lblTotalProducts = new Label(); this.lblTotalValue = new Label();
            this.SuspendLayout();

            // dgvProducts
            dgvProducts.Left = 20; dgvProducts.Top = 50; dgvProducts.Width = 700; dgvProducts.Height = 380;
            dgvProducts.ReadOnly = true;

            // Buttons
            btnAdd.Text = "Add"; btnAdd.Left = 20; btnAdd.Top = 10; btnAdd.Width = 80; btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen; btnAdd.ForeColor = System.Drawing.Color.White; btnAdd.FlatStyle = FlatStyle.Flat;
            btnEdit.Text = "Edit"; btnEdit.Left = 110; btnEdit.Top = 10; btnEdit.Width = 80; btnEdit.BackColor = System.Drawing.Color.DodgerBlue; btnEdit.ForeColor = System.Drawing.Color.White; btnEdit.FlatStyle = FlatStyle.Flat;
            btnDelete.Text = "Delete"; btnDelete.Left = 200; btnDelete.Top = 10; btnDelete.Width = 80; btnDelete.BackColor = System.Drawing.Color.IndianRed; btnDelete.ForeColor = System.Drawing.Color.White; btnDelete.FlatStyle = FlatStyle.Flat;
            btnExport.Text = "Export CSV"; btnExport.Left = 290; btnExport.Top = 10; btnExport.Width = 100; btnExport.BackColor = System.Drawing.Color.DarkCyan; btnExport.ForeColor = System.Drawing.Color.White; btnExport.FlatStyle = FlatStyle.Flat;
            btnImport.Text = "Import CSV"; btnImport.Left = 400; btnImport.Top = 10; btnImport.Width = 100; btnImport.BackColor = System.Drawing.Color.SeaGreen; btnImport.ForeColor = System.Drawing.Color.White; btnImport.FlatStyle = FlatStyle.Flat;
            btnLogout.Text = "Logout"; btnLogout.Left = 620; btnLogout.Top = 10; btnLogout.Width = 80; btnLogout.BackColor = System.Drawing.Color.OrangeRed; btnLogout.ForeColor = System.Drawing.Color.White; btnLogout.FlatStyle = FlatStyle.Flat;

            // Search box
            txtSearch.Left = 520; txtSearch.Top = 55; txtSearch.Width = 200; txtSearch.PlaceholderText = "Search by name...";

            // Totals
            lblTotalProducts.Left = 20; lblTotalProducts.Top = 440; lblTotalProducts.Width = 200;
            lblTotalValue.Left = 250; lblTotalValue.Top = 440; lblTotalValue.Width = 200;

            this.ClientSize = new System.Drawing.Size(750, 480);
            this.Controls.AddRange(new Control[] { dgvProducts, btnAdd, btnEdit, btnDelete, btnExport, btnImport, btnLogout, txtSearch, lblTotalProducts, lblTotalValue });
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Inventory Management";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
