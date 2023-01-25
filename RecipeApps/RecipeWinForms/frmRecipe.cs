using CPUFramework;
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
            string sql = ";with x as(\r\n    SELECT NumOfIng = COUNT(ir.IngredientID), r.RecipeID\r\n    from IngredientRecipe ir\r\n    join Recipe r\r\n    on r.RecipeID = ir.RecipeID\r\n    group by r.RecipeID\r\n),\r\ny as(\r\n    SELECT NumOfSteps = COUNT(i.InstructionID), r.RecipeID\r\n    from Instruction i\r\n    join Recipe r\r\n    on r.RecipeID = i.RecipeID\r\n    group by r.RecipeID \r\n)\r\nSELECT r.RecipeName, r.Calories, x.NumOfIng, y.NumOfSteps \r\nfrom Recipe r\r\njoin Users u\r\non u.UserID = r.UserID\r\njoin x\r\non x.RecipeID = r.RecipeID\r\njoin y\r\non y.RecipeID = r.RecipeID\r\n WHERE r.Recipeid = " + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipe.DataBindings.Add("Text", dt, "recipename");
            txtCalories.DataBindings.Add("Text", dt, "calories");
            lblDataIngredients.DataBindings.Add("Text", dt, "numofing");
            lblDataSteps.DataBindings.Add("Text", dt, "numofsteps");
            this.Show();
        }
    }
}
