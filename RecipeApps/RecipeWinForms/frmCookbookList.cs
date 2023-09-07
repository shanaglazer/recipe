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
            gdata.KeyDown += Gdata_KeyDown;
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;     
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gdata.Rows[rowindex].Cells["CookbookId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
        }

        private void BindData()
        {
            gdata.DataSource = Recipe.GetRecipeSummary("CookbookGet");
            WindowsFormUtility.FormatGrid(gdata, "Cookbook");
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

        private void Gdata_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void Gdata_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && gdata.SelectedRows.Count > 0)
            {
                ShowCookbookForm(gdata.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

    }
}
