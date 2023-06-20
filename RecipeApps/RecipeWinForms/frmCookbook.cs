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
        DataTable dtCookBook = new();
        BindingSource bindsource = new BindingSource();
        public frmCookbook()
        {
            InitializeComponent();
        }

        public static DataTable LoadBook(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookBookGet");
            cmd.Parameters["@CookbookId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public void LoadForm(int bookval)
        {
            cookbookid = bookval;
            this.Tag = cookbookid;
            dtCookBook = LoadBook(cookbookid);
            bindsource.DataSource = dtCookBook;
            if (cookbookid == 0)
            {
                dtCookBook.Rows.Add();
            }
            //DataTable dtparties = President.GetPartyList();
            //WindowsFormUtility.SetListBinding(lstPartyName, dtparties, dtpresident, "Party");
            //WindowsFormUtility.SetControlBinding(txtNum, bindsource);
            //WindowsFormUtility.SetControlBinding(txtLastName, bindsource);
            //WindowsFormUtility.SetControlBinding(txtFirstName, bindsource);
            //WindowsFormUtility.SetControlBinding(dtpDateBorn, bindsource);
            //WindowsFormUtility.SetControlBinding(txtDateDied, bindsource);
            //WindowsFormUtility.SetControlBinding(txtTermStart, bindsource);
            //WindowsFormUtility.SetControlBinding(txtTermEnd, bindsource);
            //this.Text = GetPresidentDesc();
            //LoadPresidentMedals();
            //SetButtonsEnabledBasedOnNewRecord();
        }
    }
}
