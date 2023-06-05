using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            this.Activated += FrmDashboard_Activated;
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
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

    }
}
