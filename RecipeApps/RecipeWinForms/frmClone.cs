using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmClone : Form
    {
        public frmClone()
        {
            InitializeComponent();
            this.Activated += FrmClone_Activated;
            btnClone.Click += BtnClone_Click;
        }

        private void OpenRecipeForm(int pkvalue)
        {
            //int pkvalue = 0;
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), pkvalue);
            }
        } 

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            //shinta lli veharas
            Recipe.CallSproc("RecipeClone", lstRecipe.Text, "@RecipeName");
            //Recipe.ShowRecipeForm(newRecipeId);
            int pkvalue = new();
            this.Close();
            //Recipe.ShowRecipeForm(0);
            OpenRecipeForm(pkvalue);
        }

        private void FrmClone_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            lstRecipe.DataSource = Recipe.GetRecipeList(true);
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeId";
        }
    }
}
