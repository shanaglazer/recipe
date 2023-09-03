using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeWinForms
{
    public class RecipeIngredient
    {

        //public static DataTable LoadByPresidentId(int presidentid)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("PresidentMedalGet");
        //    cmd.Parameters["@PresidentId"].Value = presidentid;
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        public static void SaveTable(DataTable dt, int recipeid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))//beshurut shemosifim - lesader id
            {
                r["RecipeId"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "IngredientRecipeUpdate");
        }

        public static void Delete(int ingredientrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("IngredientRecipeDelete");
            cmd.Parameters["@IngredientRecipeId"].Value = ingredientrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
