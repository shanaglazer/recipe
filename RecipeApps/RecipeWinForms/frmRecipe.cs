using CPUWindowsFormFramework;
using System.Data;
using RecipeSystem;
using CPUFramework;
using System.Reflection.Metadata.Ecma335;

namespace RecipeWinForms
{
    //mdi, ommit the id columns, open up in the right format
    public partial class frmRecipe : Form
    {
        DataTable dtRecipe = new();
        DataTable dtingredientrecipe = new();
        DataTable dtinstruction = new();
        BindingSource bindsource = new();
        int recipeid = 0;

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDel.Click += BtnDel_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;

            //DateTime currenttime = new();
            //currenttime = DateTime.Now;
            //dtpDateCreated.Value = currenttime;
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

            if(recipeid == 0)
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
            LoadRecipeInfo(dtingredientrecipe, "IngredientRecipe", gIngredient, "Ingredient", "IngredientType");
            LoadRecipeInfo(dtinstruction, "Instruction", gSteps, "Instruction", "InstructionStep");
            //if (this.MdiParent != null && this.MdiParent is frmMain)
            //{
            //    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipe), recipeid);
            //}
           
            this.Show();
            SetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadRecipeInfo(DataTable dt, string tablename, DataGridView grid, string targettable, string displaymember)
        {
            string deletecolname = "deletecol";
            dt = IngredientRecipe.LoadByRecipeId(recipeid, tablename, "@RecipeId");
            grid.Columns.Clear();
            grid.DataSource = dt;
            WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList(targettable), targettable, displaymember);
            WindowsFormUtility.AddDeleteButtonToGrid(grid, deletecolname);
            WindowsFormUtility.FormatGridForEdit(grid, tablename); //bli amudot shel id
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hearty Hearth");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you whant to delte recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if(response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
                this.Close();
            }
            catch(Exception ex)
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
            
        }

    }
}

