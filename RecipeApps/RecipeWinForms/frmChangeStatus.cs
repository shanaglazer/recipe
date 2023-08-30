using CPUWindowsFormFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        //BindingSource bindsource = new BindingSource();

        public frmChangeStatus()
        {
            InitializeComponent();
        }

        private void SetForm(int pkvalue)
        {
            //lblRecipeName.Text = 
            recipeid = pkvalue;
            this.Tag = recipeid;
            //dtRecipe = LoadBook(recipeid); //load book from cookbook should go into sqlutility!!!
            //bindsource.DataSource = dtCookbook;
            //if (cookbookid == 0)
            //{
            //    dtCookbook.Rows.Add();
            //}
            //DataTable dtusers = Recipe.GetList("UsersGet");
            ////DataTable dtRecipes = Recipe.GetRecipeList("UsersGet");

            //WindowsFormUtility.SetControlBinding(txtBookName, bindsource);
            //WindowsFormUtility.SetListBinding(lstUserName, dtusers, dtCookbook, "Users");
            //WindowsFormUtility.SetControlBinding(txtPrice, bindsource);
            //WindowsFormUtility.SetControlBinding(txtDateCreated, bindsource);
            //WindowsFormUtility.SetControlBinding(chkActive, bindsource);
            ////if(gData)
            //DataTable dtRecipes = new();
            //LoadRecipeForBook(dtRecipes, "RecipeForBook", gData, "Recipe", "RecipeName");
            //WindowsFormUtility.FormatGrid(gData, "Cookbook");
            //this.Text = GetBookName();
            ////SetButtonsEnabledBasedOnNewRecord();
        }
    }
    }
}
