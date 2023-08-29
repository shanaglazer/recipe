using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
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
            int id = (int)r["CookbookId"];
            //var datecreated = ((DateTime)r["DateCreated"]).ToString("yyyy-MM-dd h:mm");
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

    }
}
