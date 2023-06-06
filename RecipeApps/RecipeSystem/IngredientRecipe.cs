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
    public class IngredientRecipe
    {

        public static DataTable LoadByRecipeId(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            cmd.Parameters["@PresidentId"].Value = presidentid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void SaveTable(DataTable dt, int presidentid)
        {
            foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))//beshurut shemosifim - lesader id
            {
                r["PresidentId"] = presidentid;
            }
            SQLUtility.SaveDataTable(dt, "PresidentMedalUpdate");
        }

        public static void Delete(int presidentmedalid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("PresidentMedalDelete");
            cmd.Parameters["@PresidentMedalId"].Value = presidentmedalid;
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
