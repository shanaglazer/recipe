using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class Dashboard
    {

        public static DataTable GetDashboard()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardGet");
            return SQLUtility.GetDataTable(cmd);
        }

    }
}
