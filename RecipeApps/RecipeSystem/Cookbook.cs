using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Cookbook
    {

        public static void Save(DataTable dtCookbook)
        {
            if (dtCookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Save method becuase there are no rows in the tabe.");
            }
            DataRow r = dtCookbook.Rows[0];
            //int id = (int)r["CookbookId"];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(DataTable dtCookbook)
        {
            int id = (int)dtCookbook.Rows[0]["CookbookId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", id);
            SQLUtility.ExecuteSQL(cmd);
            //SQLUtility.ExecuteSQL(sql);
        }

    }
}
