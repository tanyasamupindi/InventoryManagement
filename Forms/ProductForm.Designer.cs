using System.Windows.Forms;

namespace InventoryApp.Forms
{
    partial class ProductForm
    {
        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblQuantity;
        private TextBox txtQuantity;
        private Button btnSave;
        private Button btnCancel;

        private void InitializeComponent()
        {
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.lblCategory = new Label();
            this.cmbCategory = new ComboBox();
            this.lblPrice = new Label();
            this.txtPrice = new TextBox();
            this.lblQuantity = new Label();
            this.txtQuantity = new TextBox();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.SuspendLayout();

            // lblName
            lblName.Text = "Name:";
            lblName.Left = 20; lblName.Top = 20; lblName.Width = 100;
            txtName.Left = 130; txtName.Top = 20; txtName.Width = 200;

            // lblCategory
            lblCategory.Text = "Category:";
            lblCategory.Left = 20; lblCategory.Top = 60; lblCategory.Width = 100;
            cmbCategory.Left = 130; cmbCategory.Top = 60; cmbCategory.Width = 200;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Items.AddRange(new string[] { "Electronics", "Grocery", "Furniture", "Clothing", "Other" });

            // lblPrice
            lblPrice.Text = "Price:";
            lblPrice.Left = 20; lblPrice.Top = 100; lblPrice.Width = 100;
            txtPrice.Left = 130; txtPrice.Top = 100; txtPrice.Width = 200;

            // lblQuantity
            lblQuantity.Text = "Quantity:";
            lblQuantity.Left = 20; lblQuantity.Top = 140; lblQuantity.Width = 100;
            txtQuantity.Left = 130; txtQuantity.Top = 140; txtQuantity.Width = 200;

            // btnSave
            btnSave.Text = "Save";
            btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Left = 130; btnSave.Top = 190; btnSave.Width = 80;

            // btnCancel
            btnCancel.Text = "Cancel";
            btnCancel.BackColor = System.Drawing.Color.IndianRed;
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Left = 250; btnCancel.Top = 190; btnCancel.Width = 80;
            btnCancel.Click += (s, e) => this.Close(); // no missing method

            // ProductForm
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.MaximizeBox = false;

            this.Controls.AddRange(new Control[] {
                lblName, txtName,
                lblCategory, cmbCategory,
                lblPrice, txtPrice,
                lblQuantity, txtQuantity,
                btnSave, btnCancel
            });

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
