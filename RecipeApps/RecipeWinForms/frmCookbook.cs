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
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
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
            //DataTable dtRecipes = Recipe.GetRecipeList("UsersGet");

            WindowsFormUtility.SetControlBinding(txtBookName, bindsource);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtCookbook, "Users");
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(chkActive, bindsource);
            //if(gData)
            DataTable dtRecipes = new();
            LoadRecipeForBook(dtRecipes, "RecipeForBook", gData, "Recipe", "RecipeName");
            WindowsFormUtility.FormatGrid(gData, "Cookbook");
            this.Text = GetBookName();
            //SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeForBook(DataTable dt, string sproc, DataGridView grid, string targettable, string displaymember)
        {
            string deletecolname = "deletecol";
            dt = IngredientRecipe.LoadByRecipeId(cookbookid, sproc, "@CookbookId");
            grid.Columns.Clear();
            grid.DataSource = dt;
         //   WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList(targettable), targettable, displaymember);
            WindowsFormUtility.AddDeleteButtonToGrid(grid, deletecolname);
            WindowsFormUtility.FormatGridForEdit(grid, "Recipe");
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtCookbook);
                bindsource.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void delete()
        {
            
        }

        private void SaveRecipe()
        {
            
        }

        private void FrmCookbook_Activated(object? sender, EventArgs e)
        {
            //LoadForm();
        }


        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveRecipe();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
