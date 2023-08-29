using CPUWindowsFormFramework;
using RecipeSystem;

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

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Recipe.CallSproc("RecipeClone", lstRecipe.Text, "@RecipeName");
            this.Close();
            //openform recipe by pk
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
