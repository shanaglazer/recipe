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

        private void ChangeStatus()//pass in the sender
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStatusUpdate");
            string value = "";
            //switch (btn.Name)
            //{
            //    case "btnDraft":
            //        value = "Created";
            //        break;
            //    case btnPublish:
            //        value = "Published";
            //        break;
            //    case btnArchive:
            //        value = "Drafted";
            //        break;
            //}
            cmd.Parameters["@Date" + value].Value = DateTime.Now;//.ToString();
            cmd.Parameters["@RecipeId"].Value = recipeid;
            dtRecipe = SQLUtility.GetDataTable(cmd);
            //load form again to refresh (buttons, status and dates)
            bindsource.DataSource = dtRecipe;
        }

        private string GetRecipeStatus()
        {
            return SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeStatus");
        }

        private void SetButtonsEnabledBasedOnStatus()
        {
            string status = GetRecipeStatus();
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

        private static DataTable LoadRecipe(int cookbookid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = cookbookid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public void SetForm(int pkvalue)
        {
            recipeid = pkvalue;
            this.Tag = recipeid;
            dtRecipe = LoadRecipe(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }

            WindowsFormUtility.SetControlBinding(lblRecipeName, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormUtility.SetControlBinding(lblDatePublished, bindsource);
            string value = GetRecipeStatus();
            lblCurentStatus.Text = "Current Status: " + value;
            SetButtonsEnabledBasedOnStatus();
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
          
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            
        }


    }
}
