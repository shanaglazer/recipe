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

        public static void SaveTable(DataTable dt, int recipeid, string sproc)
        {
            //foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
            //{
            //    r["RecipeId"] = recipeid;
            //    //r["IngredientId"] = recipeid;
            //    //r["MeasurementTypeID"] = recipeid;
            //    //r["Amount"] = recipeid;
            //    //r["IngSequence"] = recipeid;
            //}
            SQLUtility.SaveDataTable(dt, sproc);
        }

        public static void Delete(int ingredientrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("IngredientRecipeDelete");
            cmd.Parameters["@IngredientRecipeId"].Value = ingredientrecipeid;
            SQLUtility.ExecuteSQL(cmd);
        }

    }
}
