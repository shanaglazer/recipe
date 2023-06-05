using System.Data;

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
            
        }

        //private void BindData()
        //{
        //    DataTable dt = DataMaintenance.GetDashboard();
        //    SetButtonText(dt, "president", btnPresident);
        //    SetButtonText(dt, "olympic", btnOlympics);
        //}

        private void SetLabelText(DataTable dt, string dashboardtype, Label lbl)
        {
            var rows = dt.Select($"DashboardType = '{dashboardtype}'");
            if (rows.Length > 0)
            {
                lbl.Text = rows[0]["DashboardText"].ToString();
            }
        }

    }
}
