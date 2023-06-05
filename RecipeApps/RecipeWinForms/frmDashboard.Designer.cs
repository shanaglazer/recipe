namespace RecipeWinForms
{
    partial class frmDashboard
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
            this.tblMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tblInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lblMeals = new System.Windows.Forms.Label();
            this.lblCookbooks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRecipesNumber = new System.Windows.Forms.Label();
            this.lblMealsNumber = new System.Windows.Forms.Label();
            this.lblCookbooksNumber = new System.Windows.Forms.Label();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRecipe = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnCookbook = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblInfo.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 3;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tblMain.Controls.Add(this.lblCaption, 1, 0);
            this.tblMain.Controls.Add(this.lblWelcome, 1, 1);
            this.tblMain.Controls.Add(this.tblInfo, 1, 2);
            this.tblMain.Controls.Add(this.tblButtons, 1, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(837, 465);
            this.tblMain.TabIndex = 0;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblCaption.Location = new System.Drawing.Point(197, 0);
            this.lblCaption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(443, 104);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Hearty Hearth Desktop App";
            this.lblCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(197, 104);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(443, 104);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and " +
    "cookbooks. You can also...";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblInfo
            // 
            this.tblInfo.ColumnCount = 2;
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblInfo.Controls.Add(this.lblType, 0, 0);
            this.tblInfo.Controls.Add(this.lblRecipes, 0, 1);
            this.tblInfo.Controls.Add(this.lblMeals, 0, 2);
            this.tblInfo.Controls.Add(this.lblCookbooks, 0, 3);
            this.tblInfo.Controls.Add(this.label7, 1, 0);
            this.tblInfo.Controls.Add(this.lblRecipesNumber, 1, 1);
            this.tblInfo.Controls.Add(this.lblMealsNumber, 1, 2);
            this.tblInfo.Controls.Add(this.lblCookbooksNumber, 1, 3);
            this.tblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblInfo.Location = new System.Drawing.Point(197, 212);
            this.tblInfo.Margin = new System.Windows.Forms.Padding(4);
            this.tblInfo.Name = "tblInfo";
            this.tblInfo.RowCount = 4;
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblInfo.Size = new System.Drawing.Size(443, 96);
            this.tblInfo.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblType.Location = new System.Drawing.Point(4, 0);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(213, 24);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecipes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipes.Location = new System.Drawing.Point(4, 24);
            this.lblRecipes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(213, 24);
            this.lblRecipes.TabIndex = 1;
            this.lblRecipes.Text = "Recipes";
            this.lblRecipes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeals
            // 
            this.lblMeals.AutoSize = true;
            this.lblMeals.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMeals.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeals.Location = new System.Drawing.Point(4, 48);
            this.lblMeals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMeals.Name = "lblMeals";
            this.lblMeals.Size = new System.Drawing.Size(213, 24);
            this.lblMeals.TabIndex = 2;
            this.lblMeals.Text = "Meals";
            this.lblMeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCookbooks
            // 
            this.lblCookbooks.AutoSize = true;
            this.lblCookbooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCookbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCookbooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCookbooks.Location = new System.Drawing.Point(4, 72);
            this.lblCookbooks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCookbooks.Name = "lblCookbooks";
            this.lblCookbooks.Size = new System.Drawing.Size(213, 24);
            this.lblCookbooks.TabIndex = 3;
            this.lblCookbooks.Text = "Cookbooks";
            this.lblCookbooks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(225, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(214, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Number";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecipesNumber
            // 
            this.lblRecipesNumber.AutoSize = true;
            this.lblRecipesNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecipesNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipesNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipesNumber.Location = new System.Drawing.Point(225, 24);
            this.lblRecipesNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipesNumber.Name = "lblRecipesNumber";
            this.lblRecipesNumber.Size = new System.Drawing.Size(214, 24);
            this.lblRecipesNumber.TabIndex = 5;
            this.lblRecipesNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMealsNumber
            // 
            this.lblMealsNumber.AutoSize = true;
            this.lblMealsNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMealsNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMealsNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMealsNumber.Location = new System.Drawing.Point(225, 48);
            this.lblMealsNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMealsNumber.Name = "lblMealsNumber";
            this.lblMealsNumber.Size = new System.Drawing.Size(214, 24);
            this.lblMealsNumber.TabIndex = 6;
            this.lblMealsNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCookbooksNumber
            // 
            this.lblCookbooksNumber.AutoSize = true;
            this.lblCookbooksNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCookbooksNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCookbooksNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCookbooksNumber.Location = new System.Drawing.Point(225, 72);
            this.lblCookbooksNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCookbooksNumber.Name = "lblCookbooksNumber";
            this.lblCookbooksNumber.Size = new System.Drawing.Size(214, 24);
            this.lblCookbooksNumber.TabIndex = 7;
            this.lblCookbooksNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 3;
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblButtons.Controls.Add(this.btnRecipe, 0, 0);
            this.tblButtons.Controls.Add(this.btnMeal, 1, 0);
            this.tblButtons.Controls.Add(this.btnCookbook, 2, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButtons.Location = new System.Drawing.Point(197, 316);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(4);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tblButtons.Size = new System.Drawing.Size(443, 145);
            this.tblButtons.TabIndex = 3;
            // 
            // btnRecipe
            // 
            this.btnRecipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRecipe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecipe.Location = new System.Drawing.Point(4, 41);
            this.btnRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecipe.Name = "btnRecipe";
            this.btnRecipe.Size = new System.Drawing.Size(139, 62);
            this.btnRecipe.TabIndex = 0;
            this.btnRecipe.Text = "RecipeList";
            this.btnRecipe.UseVisualStyleBackColor = true;
            // 
            // btnMeal
            // 
            this.btnMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMeal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMeal.Location = new System.Drawing.Point(151, 41);
            this.btnMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(139, 62);
            this.btnMeal.TabIndex = 1;
            this.btnMeal.Text = "Meal List";
            this.btnMeal.UseVisualStyleBackColor = true;
            // 
            // btnCookbook
            // 
            this.btnCookbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCookbook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCookbook.Location = new System.Drawing.Point(298, 41);
            this.btnCookbook.Margin = new System.Windows.Forms.Padding(4);
            this.btnCookbook.Name = "btnCookbook";
            this.btnCookbook.Size = new System.Drawing.Size(141, 62);
            this.btnCookbook.TabIndex = 2;
            this.btnCookbook.Text = "Cookbook List";
            this.btnCookbook.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 465);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblInfo.ResumeLayout(false);
            this.tblInfo.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaption;
        private Label lblWelcome;
        private TableLayoutPanel tblInfo;
        private TableLayoutPanel tblButtons;
        private Button btnRecipe;
        private Button btnMeal;
        private Button btnCookbook;
        private Label lblType;
        private Label lblRecipes;
        private Label lblMeals;
        private Label lblCookbooks;
        private Label label7;
        private Label lblRecipesNumber;
        private Label lblMealsNumber;
        private Label lblCookbooksNumber;
    }
}