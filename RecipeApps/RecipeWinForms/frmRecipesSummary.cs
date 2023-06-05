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
        public frmRecipesSummary()
        {
            InitializeComponent();
            this.Activated += FrmRecipesSummary_Activated;
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
