using CPUFramework;
using CPUWindowsFormFramework;
using System.Data;
using System.Linq;

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

        public void ShowForm(int recipeid)
        {
            string sql = "SELECT r.recipeid, u.usersid, u.username, c.cuisineid, c.CuisineType, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus FROM Recipe r JOIN Users u on u.UsersID = r.UsersID join Cuisine c on c.CuisineID = r.CuisineID WHERE r.Recipeid = " + recipeid;
            dtRecipe = SQLUtility.GetDataTable(sql);

            DataTable dtcuisine = SQLUtility.GetDataTable("select cuisineid, cuisinetype from cuisine");
            DataTable dtusers = SQLUtility.GetDataTable("select usersid, username from users");
            
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

        private void Save(DataTable dtRecipe)
        {
            //be-new lo motze datarow venofel al ze
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["recipeId"];

            var datecreated = ((DateTime)r["DateCreated"]).ToString("yyyy-MM-dd h:mm");
            
            string sql = "";
            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update recipe set",
                    $"Usersid = '{r["Usersid"]}',",
                    $"Cuisineid = '{r["Cuisineid"]}',",
                    $"recipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"DateCreated = '{datecreated}'",
                    $"where Recipeid = {r["Recipeid"]}");
            }
            else
            {
                sql = "insert recipe(usersid, CuisineId, RecipeName, Calories, DateCreated)";
                sql += $"Select '{r["usersid"]}', {r["CuisineId"]}, '{r["RecipeName"]}', '{r["Calories"]}', '{r["DateCreated"]}'";
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
            Save(dtRecipe);
        }

    }
}

