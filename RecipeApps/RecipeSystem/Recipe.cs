using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadRecipe(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetList(string sproc)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(sproc);
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
        public static DataTable GetRecipeList(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", includeblank);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call Save method becuase there are no rows in the tabe.");
            }
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["recipeId"];
            var datecreated = ((DateTime)r["DateCreated"]).ToString("yyyy-MM-dd h:mm");
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            //string sql = "delete Recipe where RecipeId = " + id;
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
            //SQLUtility.ExecuteSQL(sql);
        }


        public static DataTable GetRecipeSummary(string sprocname)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable CloneRecipe(string sprocname, object value)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(sprocname);
            SQLUtility.SetParamValue(cmd, "@RecipeName", value);
            return SQLUtility.GetDataTable(cmd);
        }
    }
}
