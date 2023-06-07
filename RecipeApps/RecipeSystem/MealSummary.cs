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
    public class MealSummary
    {

        public static DataTable GetMealSummary()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            return SQLUtility.GetDataTable(cmd);
        }

    }
}
