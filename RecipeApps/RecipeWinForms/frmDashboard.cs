using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
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
            btnRecipe.Click += BtnRecipe_Click;
            btnMeal.Click += BtnMeal_Click;
            btnCookbook.Click += BtnCookbook_Click;
        }

       

        //private void OpenForm(Type frmtype)
        //{
        //    bool b = WindowsFormUtility.IsFormOpen(frmtype);
        //    if (b == false)
        //    {
        //        Form? newfrm = null;
        //        if (frmtype == typeof(frmRecipesSummary))
        //        {
        //            frmRecipesSummary f = new();
        //            newfrm = f;
        //        }
        //        else if (frmtype == typeof(frmMeal))
        //        {
        //            frmMeal f = new();
        //            newfrm = f;
        //        }
        //        else if (frmtype == typeof(frmCookbookList))
        //        {
        //            frmCookbookList f = new();
        //            newfrm = f;
        //        }
        //        if (newfrm != null)
        //        {
        //            //newfrm.MdiParent = this;
        //            newfrm.WindowState = FormWindowState.Maximized;
        //            //newfrm.FormClosed += Newfrm_FormClosed;
        //            //newfrm.TextChanged += Newfrm_TextChanged;
        //            newfrm.Show();
        //        }
        //    }
        //}

        private void BindData()
        {
            DataTable dt = Dashboard.GetDashboard();
            SetLabelText(dt, "recipes", lblRecipesNumber);
            SetLabelText(dt, "meals", lblMealsNumber);
            SetLabelText(dt, "cookbooks", lblCookbooksNumber);
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
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
            }
        }

        private void BtnMeal_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmMeal));
            }
        }

        private void BtnRecipe_Click(object? sender, EventArgs e)
        {
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipesSummary));
            }
        }

        private void FrmDashboard_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
