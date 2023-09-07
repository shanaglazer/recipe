using CPUFramework;
using CPUWindowsFormFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { Users, Cuisine, Ingredient, MeasurementType, CourseType }
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.Users;
        string deletecolname = "deletecol";

        public frmDataMaintenance()
        {
            InitializeComponent();

            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;

            SetupRadioButtons();
            BindData(currenttabletype);
            optUsers.Checked = true;
        }
        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WindowsFormUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WindowsFormUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }
        
        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }
        
        private void Delete(int rowindex)
        {
            var response = MessageBox.Show("Are you sure you want to delete this record?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (currenttabletype == TableTypeEnum.Users)
            {
                response = MessageBox.Show("Are you sure you want to delete this user and all related recipes, meals, and cookbooks?", "Hearty Hearth", MessageBoxButtons.YesNo);
               
            }
            if (response == DialogResult.No)
            {
                return;
            }
            int id = WindowsFormUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id == 0 && rowindex < gData.Rows.Count)
            {
                gData.Rows.Remove(gData.Rows[rowindex]);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlOptionButton.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }
            optUsers.Tag = TableTypeEnum.Users;
            optCuisine.Tag = TableTypeEnum.Cuisine;
            optIngredient.Tag = TableTypeEnum.Ingredient;
            optMeasurement.Tag = TableTypeEnum.MeasurementType;
            optCourses.Tag = TableTypeEnum.CourseType;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableHaveChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
