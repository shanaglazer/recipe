using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {

        DataTable dtusers = Recipe.GetList("UsersGet");

        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            this.Activated += FrmAutoCreateCookbook_Activated;
            btnCreate.Click += BtnCreate_Click;
        }

        private void AutoCreate()
        {
            Recipe.CallSproc("AutoCreateBook", lstUser.Text, "@UserName");
            this.Close();
        }

        private void BindData()
        {
            lstUser.DataSource = DataMaintenance.GetDataList("Users", true);
            lstUser.DisplayMember = "UserName";
            lstUser.ValueMember = "UsersId";
        }

        private void FrmAutoCreateCookbook_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BtnCreate_Click(object? sender, EventArgs e)
        {
            AutoCreate();
        }

    }
}
