using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;
using System.Data.SqlClient;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        int cookbookid = 0;
        DataTable dtCookbook = new();
        DataTable dtRecipes = new();
        BindingSource bindsource = new BindingSource();
        public frmCookbook()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            //this.Activated += FrmCookbook_Activated;
            gData.CellContentClick += GData_CellContentClick;
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
                SetButtonsEnabledBasedOnNewRecord(false);
            }
            DataTable dtusers = Recipe.GetList("UsersGet");

            WindowsFormUtility.SetControlBinding(txtBookName, bindsource);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtCookbook, "Users");
            WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(chkActive, bindsource);
            
            LoadRecipeForBook(dtRecipes, "RecipeForBook", gData, "Recipe", "RecipeName");
            WindowsFormUtility.FormatGridForEdit(gData, "Cookbook");
            this.Text = GetBookName();
            
        }

        private void SetButtonsEnabledBasedOnNewRecord(bool b)
        {
            //bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void LoadRecipeForBook(DataTable dt, string sproc, DataGridView grid, string targettable, string displaymember)
        {
            string deletecolname = "deletecol";
            dt = IngredientRecipe.LoadByRecipeId(cookbookid, sproc, "@CookbookId");
            dtRecipes = dt;
            grid.Columns.Clear();
            grid.DataSource = dt;
            DataTable dtRecipe = dt;
            WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList(targettable), targettable, displaymember);
            WindowsFormUtility.FormatGridForEdit(grid, "Recipe");
            WindowsFormUtility.AddDeleteButtonToGrid(grid, deletecolname);
        }
        
        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                bool b = cookbookid == 0 ? true : false;
                Cookbook.Save(dtCookbook);
                bindsource.ResetBindings(false);
                cookbookid = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
                this.Tag = cookbookid;
                SetButtonsEnabledBasedOnNewRecord(true);
                lblDateCreated.Text = b == true ? DateTime.Now.ToString() : lblDateCreated.Text;
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
            var response = MessageBox.Show("Are you sure you whant to delete Cookbook?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtCookbook);
                this.Close();
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

        private void SaveRecipe()
        {
            try
            {
                RecipeIngredient.SaveTable(dtRecipes, cookbookid, "RecipeForBookUpdate", "CookbookId");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipe(int rowIndex, DataGridView grid, string columnname, string sproc, string param)
        {
            int id = WindowsFormUtility.GetIdFromGrid(grid, rowIndex, columnname);
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id, sproc, param);
                    LoadRecipeForBook(dtCookbook, "RecipeForBook", grid, "Recipe", "RecipeName");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < grid.Rows.Count)
            {
                grid.Rows.RemoveAt(rowIndex);
            }

        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteRecipe(e.RowIndex, gData, "BookRecipeId", "BookRecipeDelete", "@BookRecipeId");
        }

        //private void FrmCookbook_Activated(object? sender, EventArgs e)
        //{
        //    //LoadForm();
        //}


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
