using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmRecipesSummary : Form
    {
        //enter lo oved!
        public frmRecipesSummary()
        {
            InitializeComponent();
            this.Activated += FrmRecipesSummary_Activated;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            this.KeyDown += FrmRecipesSummary_KeyDown;
            btnNewRecipe.Click += BtnNewRecipe_Click;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), id);
            }
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void FrmRecipesSummary_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipe.DataSource = Recipe.GetRecipeSummary("RecipeSummaryGet");
            WindowsFormUtility.FormatGrid(gRecipe, "Recipe");
        }

        private void FrmRecipesSummary_KeyDown(object? sender, KeyEventArgs e)
        {
            //lo oved!
            if(e.KeyCode == Keys.Enter && gRecipe.SelectedRows.Count > 0)
            {
                ShowRecipeForm(gRecipe.SelectedRows[0].Index);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }
    }
}
