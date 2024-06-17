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
    public class bizCookbook: bizObject<bizCookbook>
    {
        public bizCookbook()
        {

        }

        private int _cookbookid;
        private int _usersid;
        private string _username;
        private int _active;
        private string _bookname = "";
        private decimal _price;
        private DateTime _datecreated;
        private string _author = "";
        private int _numofrecipes;
        private int _skill;
        private string _skilldesc;

        public int CookbookId
        {
            get { return _cookbookid; }
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
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

        public int Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string BookName
        {
            get { return _bookname; }
            set
            {
                if (_bookname != value)
                {
                    _bookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
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
                }
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (_author != value)
                {
                    _author = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumOfRecipes
        {
            get { return _numofrecipes; }
            set
            {
                if (_numofrecipes != value)
                {
                    _numofrecipes = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Skill
        {
            get { return _skill; }
            set
            {
                if (_skill != value)
                {
                    _skill = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string SkillDesc
        {
            get { return _skilldesc; }
            set
            {
                if (_skilldesc != value)
                {
                    _skilldesc = value;
                    InvokePropertyChanged();
                    InvokePropertyChanged("Skill");
                }
            }
        }


        public List<bizCookbook> Search(int bookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "CookbookID", bookid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }//lehosif lasproc id.

    }
}
