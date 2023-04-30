using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Linq;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDel.Click += BtnDel_Click;

            DateTime currenttime = new();
            currenttime = DateTime.Now;
            dtpDateCreated.Value = currenttime;
        }

        public void ShowForm(int recipeid)
        {
           dtRecipe = Recipe.LoadRecipe(recipeid);

            if(recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }

            DataTable dtcuisine = Recipe.GetCuisineList();
            DataTable dtusers = Recipe.GetUserList();
            
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtRecipe);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtRecipe, "Users");
            WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtRecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(dtpDateCreated, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtDatePublished, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtDateArchived, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtRecipeStatus, dtRecipe);
            
            this.Show();
        }

        private void Save()
        {
            Recipe.Save(dtRecipe);
        }

        private void Delete()
        {
            Recipe.Delete(dtRecipe);
            this.Close();
        }

        private void BtnDel_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}

