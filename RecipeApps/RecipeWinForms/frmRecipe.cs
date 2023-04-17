using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;

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
        }

        //dto zarih hachlafa le txt paamaim!!!!!! frmrecipe
        public void ShowForm(int recipeid)
        {
            string sql = "SELECT Users = u.FirstName +' '+ u.LastName, c.CuisineType, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus FROM Recipe r JOIN Users u on u.UserID = r.UserID join Cuisine c on c.CuisineID = r.CuisineID WHERE r.Recipeid = " + recipeid;
            dtRecipe = SQLUtility.GetDataTable(sql);
            WindowsFormUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtCalories, dtRecipe);
            //WindowsFormUtility.SetListBinding(lstUsers, dtRecipe, "Users");
            WindowsFormUtility.SetListBinding(lstCuisineType, dtRecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(dtpDateCreated, dtRecipe);
            WindowsFormUtility.SetControlBinding(dtpDatePublished, dtRecipe);
            WindowsFormUtility.SetControlBinding(dtpDateArchived, dtRecipe);
            WindowsFormUtility.SetControlBinding(txtRecipeStatus, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            DataRow r = dtRecipe.Rows[0];//yesh po beaya!!!
            int id = (int)r["recipeId"];//yesh po beaya!!!

            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    //$"Userid = '{r["Userid"]}',",
                    $"Cuisineid = '{r["Cuisineid"]}',",
                    $"recipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateCreated = '{r["DateCreated"]}',",
                    $"DatePublished = '{"DatePublished"}',",
                    $"DateArchived = {r["DateArchived"]}",
                    $"where Recipeid = {r["Recipeid"]}");
            }
            else
            {
                sql = "insert recipe(userid, CuisineId, RecipeName, Calories, DateCreated, DatePublished, DateArchived, RecipeStatus)";
                sql += $"Select '{r["userid"]}', {r["CuisineId"]}, '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateCreated"]}', {r["DatePublished"]}, {r["DateArchived"]}, {r["RecipeStatus"]}";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql); 
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

        private void dtpDatePublished_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

