using CPUFramework;
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
            Application.UseWaitCursor = true;
            try
            {
                Recipe.CallSproc("AutoCreateBook", lstUser.Text, "@UserName");
                DataTable NewAutoBook = Recipe.CallSproc("AutoCreatedBookGet", lstUser.Text, "@UserName");
                int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(NewAutoBook, "CookbookID");
                //
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), pkvalue);
                }
                //this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("A book with this name exists already.", "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
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
