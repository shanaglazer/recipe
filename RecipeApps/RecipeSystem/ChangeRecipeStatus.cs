using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class ChangeRecipeStatus
    {

        public static string GetRecipeStatus(DataTable dtRecipe)
        {
            return SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeStatus");
        }

       

        public static DataTable LoadRecipe(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

    }
}
