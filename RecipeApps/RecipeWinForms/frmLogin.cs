namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
            this.ShowLogin();
            return loginsuccess;
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            loginsuccess = true;
            this.Close();
        }
    }
}
