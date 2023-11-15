using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;
using System.Xml.Linq;

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
            gSteps.CellContentClick += GSteps_CellContentClick;
            gIngredient.CellContentClick += GIngredient_CellContentClick;
            txtCalories.KeyPress += TxtCalories_KeyPress;
            this.Activated += FrmRecipeDetails_Activated;

        }

        private void FrmRecipeDetails_Activated(object? sender, EventArgs e)
        {
            lblDateCreated.DataBindings.Clear();
            lblDatePublished.DataBindings.Clear();
            lblDateArchived.DataBindings.Clear();
            lblDateCreated.ResetBindings();
            lblDatePublished.ResetBindings();
            lblDateArchived.ResetBindings();
            //bindsource.refr
            //WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            //WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            //WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
        }

        private void SaveIngredientAndSteps(string sprocname, DataTable dt)
        {
            try
            {
                RecipeIngredient.SaveTable(dt, recipeid, sprocname, "RecipeId");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void BindData()
        {
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
            this.Text = Recipe.GetRecipeName(dtRecipe);
            //loadRecipeInformation("ing");
            LoadRecipeInfo(dtingredientrecipe, "IngredientRecipe", gIngredient, "Ingredient", "IngredientType");
            LoadRecipeInfo(dtinstruction, "Instruction", gSteps, "Instruction", "InstructionStep");
        }

        public void ShowForm(int recipeidval)
        {
            recipeid = recipeidval;
            this.Tag = recipeid;
            dtRecipe = Recipe.LoadRecipe(recipeid);
            bindsource.DataSource = dtRecipe;

            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
                SetButtonsEnabledBasedOnNewRecord(false);
            }

            BindData();
            this.Show();
            
        }

        private void LoadRecipeInfo(DataTable dt, string tablename, DataGridView grid, string targettable, string displaymember)
        {
            string deletecolname = "deletecol";
            dt = IngredientRecipe.LoadByRecipeId(recipeid, tablename, "@RecipeId");
            grid.Columns.Clear();
            grid.DataSource = dt;
            
            if (tablename == "IngredientRecipe")
            {
                WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasuringType");
                WindowsFormUtility.AddComboboxToGrid(grid, DataMaintenance.GetDataList(targettable), targettable, displaymember);
                dtingredientrecipe = dt;
                gIngredient.DataSource = dtingredientrecipe;

            }
            else if(tablename == "Instruction")
            {
                dtinstruction = dt;
                gSteps.DataSource = dtinstruction;
            }
            
            WindowsFormUtility.FormatGridForEdit(grid, tablename);
            WindowsFormUtility.AddDeleteButtonToGrid(grid, deletecolname);
        }

        private void SetButtonsEnabledBasedOnNewRecord(bool b)
        {
            //bool b = recipeid == 0 ? false : true;
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
                bool b = recipeid == 0 ? true : false;
                Recipe.Save(dtRecipe);
                bindsource.ResetBindings(false);
                //bindsource.DataSource = dtRecipe;
                recipeid = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
                this.Tag = recipeid;
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

        private void ChangeStatus()
        {
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), pkvalue);
            }
        }

        private void DeleteInstructionsAndStept(int rowIndex, DataGridView grid, string columnname, string sproc, string param)
        {
            int id = WindowsFormUtility.GetIdFromGrid(grid, rowIndex, columnname);
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id, sproc, param);
                    switch(sproc)
                    {
                        case "IngredientRecipeDelete":
                            LoadRecipeInfo(dtingredientrecipe, "IngredientRecipe", gIngredient, "Ingredient", "IngredientType");
                            break;
                        case "StepRecipeDelete":
                            LoadRecipeInfo(dtinstruction, "Instruction", gSteps, "Instruction", "InstructionStep");
                            break;
                    }
                          
                          
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

        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you whant to delete recipe?", "Hearty Hearth", MessageBoxButtons.YesNo);
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


        private void GIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteInstructionsAndStept(e.RowIndex, gIngredient, "IngredientRecipeId", "IngredientRecipeDelete", "@IngredientRecipeId");
        }

        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteInstructionsAndStept(e.RowIndex, gSteps, "InstructionId", "StepRecipeDelete", "@InstructionId");
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
            SaveIngredientAndSteps("IngredientRecipeUpdate", dtingredientrecipe);
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveIngredientAndSteps("StepRecipeUpdate", dtinstruction);
        }

        private void TxtCalories_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
