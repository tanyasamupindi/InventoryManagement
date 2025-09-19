namespace InventoryApp.Forms
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;

        private void InitializeComponent()
        {
            this.lblUsername = new Label();
            this.txtUsername = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.btnExit = new Button();
            this.SuspendLayout();

            lblUsername.Text = "Username:";
            lblUsername.Left = 20; lblUsername.Top = 20; lblUsername.Width = 100;

            txtUsername.Left = 130; txtUsername.Top = 20; txtUsername.Width = 200;

            lblPassword.Text = "Password:";
            lblPassword.Left = 20; lblPassword.Top = 60; lblPassword.Width = 100;

            txtPassword.Left = 130; txtPassword.Top = 60; txtPassword.Width = 200;
            txtPassword.PasswordChar = '*';

            btnLogin.Text = "Login";
            btnLogin.BackColor = System.Drawing.Color.MediumSeaGreen;
            btnLogin.ForeColor = System.Drawing.Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Left = 130; btnLogin.Top = 110; btnLogin.Width = 80;

            btnExit.Text = "Exit";
            btnExit.BackColor = System.Drawing.Color.IndianRed;
            btnExit.ForeColor = System.Drawing.Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Left = 250; btnExit.Top = 110; btnExit.Width = 80;

            this.ClientSize = new System.Drawing.Size(400, 180);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;

            this.Controls.AddRange(new Control[] { lblUsername, txtUsername, lblPassword, txtPassword, btnLogin, btnExit });
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
