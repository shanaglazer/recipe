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
using System.Xml.Linq;

namespace RecipeWinForms
{
    public partial class frmChangeStatus : Form
    {
        int recipeid = new();
        DataTable dtRecipe = new();
        BindingSource bindsource = new BindingSource();

        public frmChangeStatus()
        {
            InitializeComponent();
            btnArchive.Click += BtnArchive_Click;
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
        }

        private void ChangeStatus(Button btn)
        {
            var response = MessageBox.Show("Are you sure you want to change this recipe to " + btn.Name.Substring(3) + "?", "Hearty Hearth", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStatusUpdate");
            string value = "";
            switch (btn.Name)
            {
                case "btnDraft":
                    value = "Created";
                    break;
                case "btnPublish":
                    value = "Published";
                    break;
                case "btnArchive":
                    value = "Archived";
                    break;
            }
            cmd.Parameters["@ColumnToChange"].Value = "Date" + value;
            cmd.Parameters["@RecipeId"].Value = recipeid;
            SQLUtility.ExecuteSQL(cmd);
            dtRecipe = ChangeRecipeStatus.LoadRecipe(recipeid);
            //SetForm(SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId"));
            bindsource.DataSource = dtRecipe;
            SetCurrentStatutLbl();
        }

        private void SetButtonsEnabledBasedOnStatus()
        {
            string status = ChangeRecipeStatus.GetRecipeStatus(dtRecipe);
            switch (status)
            {
                case "On site":
                    btnPublish.Enabled = false;
                    btnDraft.Enabled = true;
                    btnArchive.Enabled = true;
                    break;
                case "Draft":
                    btnPublish.Enabled = true;
                    btnDraft.Enabled = false;
                    btnArchive.Enabled = true;
                    break;
                case "Archive":
                    btnPublish.Enabled = true;
                    btnDraft.Enabled = true;
                    btnArchive.Enabled = false;
                    break;
            }
        }

        private void SetCurrentStatutLbl()
        {
            string value = ChangeRecipeStatus.GetRecipeStatus(dtRecipe);
            lblCurrentStatus.Text = "Current Status: " + value;
        }

        public void SetForm(int pkvalue)
        {
            recipeid = pkvalue;
            this.Tag = recipeid;
            dtRecipe = ChangeRecipeStatus.LoadRecipe(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }

            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            SetCurrentStatutLbl();
            SetButtonsEnabledBasedOnStatus();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                ChangeStatus((Button)sender);
            }
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                ChangeStatus((Button)sender);
            }
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            if (sender is Button)
            {
                ChangeStatus((Button)sender);
            }
        }


    }
}
