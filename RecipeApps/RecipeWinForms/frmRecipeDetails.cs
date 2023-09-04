using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeDetails : Form
    {
        DataTable dtRecipe = new();
        DataTable dtingredientrecipe = new();
        DataTable dtinstruction = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmRecipeDetails()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDel.Click += BtnDel_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
        }

        private void SaveIngredientRecipe()
        {
            try
            {
                RecipeIngredient.SaveTable(dtingredientrecipe, recipeid, "IngredientRecipeUpdate");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void SaveSteps()
        {
            //same as on top^
        }

        private string GetRecipeName()
        {
            string value = "Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = value + " - " + SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            dtRecipe = Recipe.LoadRecipe(recipeid);
            bindsource.DataSource = dtRecipe;

            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }

            DataTable dtcuisine = Recipe.GetList("CuisineGet");
            DataTable dtusers = Recipe.GetList("UsersGet");

            WindowsFormUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtRecipe, "Users");
            WindowsFormUtility.SetListBinding(lstCuisineType, dtcuisine, dtRecipe, "Cuisine");
            WindowsFormUtility.SetControlBinding(lblRecipeStatus, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            this.Text = GetRecipeName();
            //loadRecipeInformation("ing");
            LoadRecipeInfo(dtingredientrecipe, "IngredientRecipe", gIngredient, "Ingredient", "IngredientType");
            LoadRecipeInfo(dtinstruction, "Instruction", gSteps, "Instruction", "InstructionStep");
            this.Show();
            SetButtonsEnabledBasedOnNewRecord();
        }
        //private void loadRecipeInformation(string type)
        //{
        //    if (type == "IngredientRecipe")
        //    {
        //        dtingredientrecipe = IngredientRecipe.LoadByRecipeId(recipeid, type, "@RecipeId");
        //        gIngredient.Columns.Clear();
        //        gIngredient.DataSource = dtingredientrecipe;
        //    }
        //}

        private void LoadRecipeInfo(DataTable dt, string tablename, DataGridView grid, string targettable, string displaymember)
        {
            string deletecolname = "deletecol";
            dt = IngredientRecipe.LoadByRecipeId(recipeid, tablename, "@RecipeId");
            grid.Columns.Clear();
            grid.DataSource = dt;
            
            if (tablename == "IngredientRecipe")
            {
                WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasuringType");
                dtingredientrecipe = dt;
            }
            else if(tablename == "Instruction")
            {
                dtinstruction = dt;
            }
           
            WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList(targettable), targettable, displaymember);
            
           
            
            WindowsFormUtility.FormatGridForEdit(grid, tablename);
            WindowsFormUtility.AddDeleteButtonToGrid(grid, deletecolname);
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            //lo oved bchadash
            bool b = recipeid == 0 ? false : true;
            btnChangeStatus.Enabled = b;
            btnDel.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnSaveIngredient.Enabled = b;
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
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

        private void ChangeStatus()
        {
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), pkvalue);
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you whant to delte recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
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

        private void BtnDel_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveIngredientRecipe();
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveSteps();
        }

    }
}
