using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int recipeid)
        {
            string sql = "SELECT Users = u.FirstName +' '+ u.LastName, c.CuisineType, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus FROM Recipe r JOIN Users u on u.UserID = r.UserID join Cuisine c on c.CuisineID = r.CuisineID WHERE r.Recipeid = " + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            WindowsFormUtility.SetControlBinding(txtRecipeName, dt);
            WindowsFormUtility.SetControlBinding(txtCalories, dt);
            //WindowsFormUtility.SetControlBinding(lblDataIngredients, dt);
            //WindowsFormUtility.SetControlBinding(lblDataSteps, dt);
            //WindowsFormUtility.SetListBinding(lstUsers, dt, "Users");//?
            //WindowsFormUtility.SetListBinding(lstCuisineType, dt, "Cuisine");
            WindowsFormUtility.SetControlBinding(dtpDateCreated, dt);
            WindowsFormUtility.SetControlBinding(dtpDatePublished, dt);
            WindowsFormUtility.SetControlBinding(dtpDateArchived, dt);
            WindowsFormUtility.SetControlBinding(txtRecipeStatus, dt);
            //lblDataIngredients.DataBindings.Add("Text", dt, "numofing");
            //lblDataSteps.DataBindings.Add("Text", dt, "numofsteps");
            this.Show();
        }
    }
}

