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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchive = new System.Windows.Forms.Label();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.dtpDatePublished = new System.Windows.Forms.DateTimePicker();
            this.dtpDateArchived = new System.Windows.Forms.DateTimePicker();
            this.tblSaveDelete = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtnDel = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ComboBox();
            this.txtRecipeStatus = new System.Windows.Forms.TextBox();
            this.tblMain.SuspendLayout();
            this.tblSaveDelete.SuspendLayout();
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
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Controls.Add(this.lblUser, 0, 4);
            this.tblMain.Controls.Add(this.lblCuisine, 0, 5);
            this.tblMain.Controls.Add(this.lblDateCreated, 0, 6);
            this.tblMain.Controls.Add(this.lblDatePublished, 0, 7);
            this.tblMain.Controls.Add(this.lblDateArchive, 0, 8);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 0, 9);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 5);
            this.tblMain.Controls.Add(this.dtpDateCreated, 1, 6);
            this.tblMain.Controls.Add(this.dtpDatePublished, 1, 7);
            this.tblMain.Controls.Add(this.dtpDateArchived, 1, 8);
            this.tblMain.Controls.Add(this.tblSaveDelete, 1, 10);
            this.tblMain.Controls.Add(this.lstUsers, 1, 4);
            this.tblMain.Controls.Add(this.txtRecipeStatus, 1, 9);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 11;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(452, 370);
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
            this.lblDataIngredients.Size = new System.Drawing.Size(265, 21);
            this.lblDataIngredients.TabIndex = 3;
            // 
            // lblSteps
            // 
            this.lblSteps.AutoSize = true;
            this.lblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSteps.Location = new System.Drawing.Point(4, 95);
            this.lblSteps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSteps.Name = "lblSteps";
            this.lblSteps.Size = new System.Drawing.Size(171, 21);
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
            this.lblDataSteps.Size = new System.Drawing.Size(265, 21);
            this.lblDataSteps.TabIndex = 5;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(183, 4);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(265, 29);
            this.txtRecipeName.TabIndex = 6;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(183, 41);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(265, 29);
            this.txtCalories.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(173, 29);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User:";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisine.Location = new System.Drawing.Point(3, 145);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(173, 35);
            this.lblCuisine.TabIndex = 9;
            this.lblCuisine.Text = "Cuisine:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(3, 180);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(173, 35);
            this.lblDateCreated.TabIndex = 10;
            this.lblDateCreated.Text = "Date Created:";
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Location = new System.Drawing.Point(3, 215);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(173, 35);
            this.lblDatePublished.TabIndex = 11;
            this.lblDatePublished.Text = "Date Published:";
            // 
            // lblDateArchive
            // 
            this.lblDateArchive.AutoSize = true;
            this.lblDateArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchive.Location = new System.Drawing.Point(3, 250);
            this.lblDateArchive.Name = "lblDateArchive";
            this.lblDateArchive.Size = new System.Drawing.Size(173, 35);
            this.lblDateArchive.TabIndex = 12;
            this.lblDateArchive.Text = "Date Archive:";
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Location = new System.Drawing.Point(3, 285);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(173, 35);
            this.lblRecipeStatus.TabIndex = 13;
            this.lblRecipeStatus.Text = "Recipe Status:";
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(182, 148);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(121, 29);
            this.lstCuisineType.TabIndex = 15;
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateCreated.Location = new System.Drawing.Point(182, 183);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(267, 29);
            this.dtpDateCreated.TabIndex = 17;
            // 
            // dtpDatePublished
            // 
            this.dtpDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatePublished.Location = new System.Drawing.Point(182, 218);
            this.dtpDatePublished.Name = "dtpDatePublished";
            this.dtpDatePublished.Size = new System.Drawing.Size(267, 29);
            this.dtpDatePublished.TabIndex = 18;
            // 
            // dtpDateArchived
            // 
            this.dtpDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDateArchived.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateArchived.Location = new System.Drawing.Point(182, 253);
            this.dtpDateArchived.Name = "dtpDateArchived";
            this.dtpDateArchived.Size = new System.Drawing.Size(267, 29);
            this.dtpDateArchived.TabIndex = 19;
            // 
            // tblSaveDelete
            // 
            this.tblSaveDelete.ColumnCount = 2;
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSaveDelete.Controls.Add(this.btnSave, 0, 0);
            this.tblSaveDelete.Controls.Add(this.dtnDel, 1, 0);
            this.tblSaveDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSaveDelete.Location = new System.Drawing.Point(182, 323);
            this.tblSaveDelete.Name = "tblSaveDelete";
            this.tblSaveDelete.RowCount = 1;
            this.tblSaveDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSaveDelete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSaveDelete.Size = new System.Drawing.Size(267, 44);
            this.tblSaveDelete.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dtnDel
            // 
            this.dtnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtnDel.Location = new System.Drawing.Point(136, 3);
            this.dtnDel.Name = "dtnDel";
            this.dtnDel.Size = new System.Drawing.Size(128, 38);
            this.dtnDel.TabIndex = 1;
            this.dtnDel.Text = "Delete";
            this.dtnDel.UseVisualStyleBackColor = true;
            // 
            // lstUsers
            // 
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.Location = new System.Drawing.Point(182, 119);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(121, 29);
            this.lstUsers.TabIndex = 21;
            // 
            // txtRecipeStatus
            // 
            this.txtRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeStatus.Location = new System.Drawing.Point(182, 288);
            this.txtRecipeStatus.Name = "txtRecipeStatus";
            this.txtRecipeStatus.Size = new System.Drawing.Size(267, 29);
            this.txtRecipeStatus.TabIndex = 22;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 370);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblSaveDelete.ResumeLayout(false);
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
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblUser;
        private Label lblCuisine;
        private Label lblDateCreated;
        private Label lblDatePublished;
        private Label lblDateArchive;
        private Label lblRecipeStatus;
        private ComboBox lstCuisineType;
        private DateTimePicker dtpDateCreated;
        private DateTimePicker dtpDatePublished;
        private DateTimePicker dtpDateArchived;
        private TableLayoutPanel tblSaveDelete;
        private Button btnSave;
        private Button dtnDel;
        private ComboBox lstUsers;
        private TextBox txtRecipeStatus;
    }
}