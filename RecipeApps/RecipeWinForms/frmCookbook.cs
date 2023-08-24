using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        int cookbookid = 0;
        DataTable dtCookbook = new();
        BindingSource bindsource = new BindingSource();
        public frmCookbook()
        {
            InitializeComponent();
            this.Activated += FrmCookbook_Activated;
        }

        public static DataTable LoadBook(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookInfoGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        private string GetBookName()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "BookName");
            }
            return value;
        }

        public void LoadForm(int bookval)
        {
            cookbookid = bookval;
            this.Tag = cookbookid;
            dtCookbook = LoadBook(cookbookid);
            bindsource.DataSource = dtCookbook;
            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            DataTable dtusers = Recipe.GetList("UsersGet");
            
            WindowsFormUtility.SetControlBinding(txtBookName, bindsource);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtCookbook, "Users");
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateCreated, bindsource);
            //cbActive!
            //if(gData)
            gData.DataSource = Recipe.GetRecipeSummary("CookbookInfoGet");
            WindowsFormUtility.FormatGrid(gData, "Cookbook");
            this.Text = GetBookName();
            //load recipes
            //SetButtonsEnabledBasedOnNewRecord();
        }

        private void FrmCookbook_Activated(object? sender, EventArgs e)
        {
            //LoadForm();
        }
    }
}
