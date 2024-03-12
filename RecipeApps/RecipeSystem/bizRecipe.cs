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
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe() //: base("Recipe")
        {

        }

        private int _recipeid;
        private int _usersid;
        private int _cuisineid;
        private string _recipename = "";
        private int _calories;
        private DateTime _datecreated;
        private DateTime _datearchived;
        private DateTime _datepublished;
        private string _recipestatus;
        private string _username;
        private string _cuisinetype;
        private int _numingredients;


        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UsersId
        {
            get { return _usersid; }
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get { return _cuisineid; }
            set
            {
                if (_cuisineid != value)
                {
                    _cuisineid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CuisineType
        {
            get { return _cuisinetype; }
            set
            {
                if (_cuisinetype != value)
                {
                    _cuisinetype = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get { return _calories; }
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        //not working!!
        public int NumIngredients
        {
            get { return _numingredients; }
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateCreated
        {
            get { return _datecreated; }
            set
            {
                if (_datecreated != value)
                {
                    _datecreated = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("RecipeStatus");
                }
            }
        }

        public DateTime DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("RecipeStatus");
                }
            }
        }

        public DateTime DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("RecipeStatus");
                }
            }
        }

        public string RecipeStatus
        {
            get { return _recipestatus; }
            set
            {
                if (_recipestatus != value)
                {
                    _recipestatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }
    }
}
