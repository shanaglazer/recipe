﻿using System.Data;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;
            gRecipes.CellDoubleClick += GRecipes_CellDoubleClick;
            FormatGrid();
        }

        private void FormatGrid()
        {
            gRecipes.AllowUserToAddRows = false;
            gRecipes.ReadOnly = true;
            gRecipes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gRecipes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void SearchForRecipeName(string recipename)
        {
            string sql = "select recipeid, recipename from recipe r where r.recipename like '%" + recipename +"%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipes.DataSource = dt;
            gRecipes.Columns["recipeid"].Visible = false;
        }

        private void ShowRecipeForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipes.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipe frm = new();
            frm.ShowForm(id);
        }

        private void GRecipes_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeForm(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeForm(-1);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchForRecipeName(txtRecipe.Text);
            txtRecipe.Text = "";
        }
    }
} 

