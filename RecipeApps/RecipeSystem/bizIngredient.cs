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
    public class bizIngredient : bizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredienttype = "";

        public List<bizIngredient> Search(string ingredienttypeval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "IngredientType", ingredienttypeval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientType
        {
            get { return _ingredienttype; }
            set
            {
                if (_ingredienttype != value)
                {
                    _ingredienttype = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
