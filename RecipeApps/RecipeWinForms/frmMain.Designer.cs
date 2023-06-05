namespace RecipeWinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDashboard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecipeList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewRecipe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCloneRecie = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMeals = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMealList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCookbookList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCookbook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutoCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDataMaintenance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuRecipes,
            this.mnuMeals,
            this.mnuCookbook,
            this.mnuDataMaintenance,
            this.mnuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDashboard});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            this.mnuDashboard.Name = "mnuDashboard";
            this.mnuDashboard.Size = new System.Drawing.Size(131, 22);
            this.mnuDashboard.Text = "Dashboard";
            // 
            // mnuRecipes
            // 
            this.mnuRecipes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecipeList,
            this.mnuNewRecipe,
            this.mnuCloneRecie});
            this.mnuRecipes.Name = "mnuRecipes";
            this.mnuRecipes.Size = new System.Drawing.Size(59, 20);
            this.mnuRecipes.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            this.mnuRecipeList.Name = "mnuRecipeList";
            this.mnuRecipeList.Size = new System.Drawing.Size(152, 22);
            this.mnuRecipeList.Text = "List";
            // 
            // mnuNewRecipe
            // 
            this.mnuNewRecipe.Name = "mnuNewRecipe";
            this.mnuNewRecipe.Size = new System.Drawing.Size(152, 22);
            this.mnuNewRecipe.Text = "New Recipe";
            // 
            // mnuCloneRecie
            // 
            this.mnuCloneRecie.Name = "mnuCloneRecie";
            this.mnuCloneRecie.Size = new System.Drawing.Size(152, 22);
            this.mnuCloneRecie.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            this.mnuMeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMealList});
            this.mnuMeals.Name = "mnuMeals";
            this.mnuMeals.Size = new System.Drawing.Size(50, 20);
            this.mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            this.mnuMealList.Name = "mnuMealList";
            this.mnuMealList.Size = new System.Drawing.Size(92, 22);
            this.mnuMealList.Text = "List";
            // 
            // mnuCookbook
            // 
            this.mnuCookbook.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCookbookList,
            this.mnuNewCookbook,
            this.mnuAutoCreate});
            this.mnuCookbook.Name = "mnuCookbook";
            this.mnuCookbook.Size = new System.Drawing.Size(79, 20);
            this.mnuCookbook.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            this.mnuCookbookList.Name = "mnuCookbookList";
            this.mnuCookbookList.Size = new System.Drawing.Size(156, 22);
            this.mnuCookbookList.Text = "List";
            // 
            // mnuNewCookbook
            // 
            this.mnuNewCookbook.Name = "mnuNewCookbook";
            this.mnuNewCookbook.Size = new System.Drawing.Size(156, 22);
            this.mnuNewCookbook.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            this.mnuAutoCreate.Name = "mnuAutoCreate";
            this.mnuAutoCreate.Size = new System.Drawing.Size(156, 22);
            this.mnuAutoCreate.Text = "Auto-Create";
            // 
            // mnuDataMaintenance
            // 
            this.mnuDataMaintenance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditData});
            this.mnuDataMaintenance.Name = "mnuDataMaintenance";
            this.mnuDataMaintenance.Size = new System.Drawing.Size(115, 20);
            this.mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            this.mnuEditData.Name = "mnuEditData";
            this.mnuEditData.Size = new System.Drawing.Size(121, 22);
            this.mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTile,
            this.mnuCascade});
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(68, 20);
            this.mnuWindows.Text = "Windows";
            // 
            // mnuTile
            // 
            this.mnuTile.Name = "mnuTile";
            this.mnuTile.Size = new System.Drawing.Size(118, 22);
            this.mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(118, 22);
            this.mnuCascade.Text = "Cascade";
            // 
            // tsMain
            // 
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(886, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 540);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Hearty Hearth - Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipes;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuNewRecipe;
        private ToolStripMenuItem mnuCloneRecie;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbook;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuNewCookbook;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuWindows;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
    }
}