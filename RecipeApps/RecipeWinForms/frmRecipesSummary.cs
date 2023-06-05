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
        //lehitza ihie al shura bagrid 
        //lehitza ou btn liftoah amud pratim
        public frmRecipesSummary()
        {
            InitializeComponent();
            this.Activated += FrmRecipesSummary_Activated;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
        }


        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormUtility.GetIdFromGrid(gRecipe, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), id);
            }
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            //liftoah frm pratim
        }

        private void FrmRecipesSummary_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            gRecipe.DataSource = Recipe.GetRecipeSummary();
            WindowsFormUtility.FormatGridForEdit(gRecipe, "Recipe");
        }
    }
}
