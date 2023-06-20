using CPUWindowsFormFramework;
using RecipeSystem;
using System.DirectoryServices.ActiveDirectory;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            gdata.CellDoubleClick += Gdata_CellDoubleClick;
            this.KeyDown += FrmCookbookList_KeyDown;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            BindData();
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gdata, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
            //bool b = WindowsFormUtility.IsFormOpen(frmtype);
            //if (b == false)
            //{
            //    Form? newfrm = null;
            //    if (frmtype == typeof(frmDashboard))
            //    {
            //        frmDashboard f = new();
            //        newfrm = f;
            //    }
            //    if (newfrm != null)
            //    {
            //        newfrm.MdiParent = this;
            //        newfrm.WindowState = FormWindowState.Maximized;
            //        newfrm.FormClosed += Newfrm_FormClosed;
            //        newfrm.TextChanged += Newfrm_TextChanged;
            //        newfrm.Show();
            //    }
            //    WindowsFormUtility.SetUpNav(tsMain);
        }

        private void BindData()
        {
            gdata.DataSource = Recipe.GetRecipeSummary("CookbookGet");
            WindowsFormUtility.FormatGrid(gdata, "Cookbook");
        }

        private void FrmCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            //enter iftah - lo over berecipe
        }

        private void Gdata_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            //liftoah et hapratim
        }
    }
}
