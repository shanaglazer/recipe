using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        //tool strip & mdi parent/child
        //cookbook doesn't work from the button in the dashboard!!! ????
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
            btnRecipe.Click += BtnRecipe_Click;
            btnMeal.Click += BtnMeal_Click;
            btnCookbook.Click += BtnCookbook_Click;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void OpenForm(Type frmtype)
        {
            bool b = WindowsFormUtility.IsFormOpen(frmtype);
            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipesSummary))
                {
                    frmRecipesSummary f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMeal))
                {
                    frmMeal f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    //newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    //newfrm.FormClosed += Newfrm_FormClosed;
                    //newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                }
            }
        }

        private void BindData()
        {
            DataTable dt = GetDashboard();
            SetLabelText(dt, "recipes", lblRecipesNumber);
            SetLabelText(dt, "meals", lblMealsNumber);
            SetLabelText(dt, "cookbooks", lblCookbooksNumber);
        }

        private static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }

        private void SetLabelText(DataTable dt, string CountItem, Label lbl)
        {
            var rows = dt.Select($"ItemType = '{CountItem}'");
            if (rows.Length > 0)
            {
                lbl.Text = rows[0]["CountItem"].ToString();
            }
        }

        private void BtnCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void BtnMeal_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeal));
        }

        private void BtnRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipesSummary));
        }

    }
}
