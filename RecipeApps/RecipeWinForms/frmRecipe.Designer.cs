namespace RecipeWinForms
{
    partial class frmRecipe
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
            this.lblRName = new System.Windows.Forms.Label();
            this.lblCalories = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblDataIngredients = new System.Windows.Forms.Label();
            this.lblSteps = new System.Windows.Forms.Label();
            this.lblDataSteps = new System.Windows.Forms.Label();
            this.txtRecipe = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.lblRName, 0, 0);
            this.tblMain.Controls.Add(this.lblCalories, 0, 1);
            this.tblMain.Controls.Add(this.lblIngredients, 0, 2);
            this.tblMain.Controls.Add(this.lblDataIngredients, 1, 2);
            this.tblMain.Controls.Add(this.lblSteps, 0, 3);
            this.tblMain.Controls.Add(this.lblDataSteps, 1, 3);
            this.tblMain.Controls.Add(this.txtRecipe, 1, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.Size = new System.Drawing.Size(369, 307);
            this.tblMain.TabIndex = 0;
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRName.Location = new System.Drawing.Point(4, 0);
            this.lblRName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(171, 37);
            this.lblRName.TabIndex = 0;
            this.lblRName.Text = "Recipe Name:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Location = new System.Drawing.Point(4, 37);
            this.lblCalories.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(171, 37);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.Text = "Calories:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIngredients.Location = new System.Drawing.Point(4, 74);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(171, 21);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Number of Ingredients:";
            // 
            // lblDataIngredients
            // 
            this.lblDataIngredients.AutoSize = true;
            this.lblDataIngredients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataIngredients.Location = new System.Drawing.Point(183, 74);
            this.lblDataIngredients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataIngredients.Name = "lblDataIngredients";
            this.lblDataIngredients.Size = new System.Drawing.Size(264, 21);
            this.lblDataIngredients.TabIndex = 3;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Location = new System.Drawing.Point(4, 95);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(171, 212);
            this.lblSteps.TabIndex = 4;
            this.lblSteps.Text = "Number of Steps:";
            // 
            // lblDataSteps
            // 
            this.lblDataSteps.AutoSize = true;
            this.lblDataSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataSteps.Location = new System.Drawing.Point(183, 95);
            this.lblDataSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataSteps.Name = "lblDataSteps";
            this.lblDataSteps.Size = new System.Drawing.Size(264, 212);
            this.lblDataSteps.TabIndex = 5;
            // 
            // txtRecipe
            // 
            this.txtRecipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipe.Location = new System.Drawing.Point(183, 4);
            this.txtRecipe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRecipe.Name = "txtRecipe";
            this.txtRecipe.Size = new System.Drawing.Size(264, 29);
            this.txtRecipe.TabIndex = 6;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(183, 41);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(264, 29);
            this.txtCalories.TabIndex = 7;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 307);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRName;
        private Label lblCalories;
        private Label lblIngredients;
        private Label lblDataIngredients;
        private Label lblSteps;
        private Label lblDataSteps;
        private TextBox txtRecipe;
        private TextBox txtCalories;
    }
}