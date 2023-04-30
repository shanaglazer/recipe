using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "select recipeid, recipename from recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            string sql = "SELECT r.recipeid, u.usersid, u.username, c.cuisineid, c.CuisineType, r.RecipeName, r.Calories, r.DateCreated, r.DatePublished, r.DateArchived, r.RecipeStatus FROM Recipe r JOIN Users u on u.UsersID = r.UsersID join Cuisine c on c.CuisineID = r.CuisineID WHERE r.Recipeid = " + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt;
        }

        public static DataTable GetUserList()
        {
            return SQLUtility.GetDataTable("select usersid, username from users");
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select cuisineid, cuisinetype from cuisine");
        }

        public static void Save(DataTable dtRecipe)
        {
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
                sql += $"Select '{r["usersid"]}', {r["CuisineId"]}, '{r["RecipeName"]}', '{r["Calories"]}', '{datecreated}'";
            }
            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
