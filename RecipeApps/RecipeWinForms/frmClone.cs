using CPUFramework;
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
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), pkvalue);
            }
        } 

        private void Clone()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.CallSproc("RecipeClone", lstRecipe.Text, "@RecipeName");
                DataTable clonedrecipe = Recipe.CallSproc("ClonedRecipeGet", lstRecipe.Text, "@RecipeName");
                int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(clonedrecipe, "RecipeId");
                //
                if (this.MdiParent != null && this.MdiParent is frmMain)
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetails), pkvalue);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This recipe has a cloned version already.", "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Clone();
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
