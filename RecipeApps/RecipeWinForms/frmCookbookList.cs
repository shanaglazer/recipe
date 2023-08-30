﻿using CPUWindowsFormFramework;
using RecipeSystem;
using System.DirectoryServices.ActiveDirectory;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        //doesn't bind data when opens a cookbook
        public frmCookbookList()
        {
            InitializeComponent();
            gdata.CellDoubleClick += Gdata_CellDoubleClick;
            this.KeyDown += FrmCookbookList_KeyDown;
            this.Activated += FrmCookbookList_Activated;
            btnNewCookbook.Click += BtnNewCookbook_Click;     
        }

        private void ShowCookbookForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                //Try fixing
                //id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
                id = (int)gdata.Rows[rowindex].Cells["CookbookId"].Value;
                //id = WindowsFormUtility.GetIdFromGrid(gdata, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbook), id);
            }
            frmCookbook frm = new();
            //frm.LoadForm(id);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            ShowCookbookForm(-1);
        }

        private void BindData()
        {
            gdata.DataSource = Recipe.GetRecipeSummary("CookbookGet");
            WindowsFormUtility.FormatGrid(gdata, "Cookbook");
        }

        private void FrmCookbookList_KeyDown(object? sender, KeyEventArgs e)
        {
            //enter iftah - lo over berecipe
        }

        private void Gdata_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowCookbookForm(e.RowIndex);
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }
    }
}
