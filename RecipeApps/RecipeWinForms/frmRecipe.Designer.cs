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
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblCurrentStatus = new System.Windows.Forms.Label();
            this.lblStatusDates = new System.Windows.Forms.Label();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.tblSaveDelete = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.tblStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.tbChildRecord = new System.Windows.Forms.TabControl();
            this.tbIngredients = new System.Windows.Forms.TabPage();
            this.tblIngredient = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.gIngredient = new System.Windows.Forms.DataGridView();
            this.tbSteps = new System.Windows.Forms.TabPage();
            this.tblSteps = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSteps = new System.Windows.Forms.Button();
            this.gSteps = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblSaveDelete.SuspendLayout();
            this.tblStatus.SuspendLayout();
            this.tbChildRecord.SuspendLayout();
            this.tbIngredients.SuspendLayout();
            this.tblIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).BeginInit();
            this.tbSteps.SuspendLayout();
            this.tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.Controls.Add(this.lblRName, 0, 0);
            this.tblMain.Controls.Add(this.lblCalories, 0, 1);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Controls.Add(this.lblUser, 0, 4);
            this.tblMain.Controls.Add(this.lblCuisine, 0, 5);
            this.tblMain.Controls.Add(this.lblCurrentStatus, 0, 7);
            this.tblMain.Controls.Add(this.lblStatusDates, 0, 8);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 5);
            this.tblMain.Controls.Add(this.tblSaveDelete, 0, 10);
            this.tblMain.Controls.Add(this.lstUserName, 1, 4);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 7);
            this.tblMain.Controls.Add(this.tblStatus, 1, 8);
            this.tblMain.Controls.Add(this.tbChildRecord, 0, 11);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Margin = new System.Windows.Forms.Padding(4);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 12;
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
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(741, 467);
            this.tblMain.TabIndex = 0;
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRName.Location = new System.Drawing.Point(4, 0);
            this.lblRName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(107, 37);
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
            this.lblCalories.Size = new System.Drawing.Size(107, 37);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.Text = "Calories:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(119, 4);
            this.txtRecipeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(858, 29);
            this.txtRecipeName.TabIndex = 6;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(119, 41);
            this.txtCalories.Margin = new System.Windows.Forms.Padding(4);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(858, 29);
            this.txtCalories.TabIndex = 7;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Location = new System.Drawing.Point(3, 74);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(109, 35);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User:";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisine.Location = new System.Drawing.Point(3, 109);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(109, 35);
            this.lblCuisine.TabIndex = 9;
            this.lblCuisine.Text = "Cuisine:";
            // 
            // lblCurrentStatus
            // 
            this.lblCurrentStatus.AutoSize = true;
            this.lblCurrentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentStatus.Location = new System.Drawing.Point(3, 144);
            this.lblCurrentStatus.Name = "lblCurrentStatus";
            this.lblCurrentStatus.Size = new System.Drawing.Size(109, 21);
            this.lblCurrentStatus.TabIndex = 11;
            this.lblCurrentStatus.Text = "Current Status";
            // 
            // lblStatusDates
            // 
            this.lblStatusDates.AutoSize = true;
            this.lblStatusDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusDates.Location = new System.Drawing.Point(3, 165);
            this.lblStatusDates.Name = "lblStatusDates";
            this.lblStatusDates.Size = new System.Drawing.Size(109, 106);
            this.lblStatusDates.TabIndex = 12;
            this.lblStatusDates.Text = "Status Dates";
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(118, 112);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(134, 29);
            this.lstCuisineType.TabIndex = 15;
            // 
            // tblSaveDelete
            // 
            this.tblSaveDelete.AutoSize = true;
            this.tblSaveDelete.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblSaveDelete, 2);
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSaveDelete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblSaveDelete.Controls.Add(this.btnSave, 0, 0);
            this.tblSaveDelete.Controls.Add(this.btnDel, 1, 0);
            this.tblSaveDelete.Controls.Add(this.btnChangeStatus, 2, 0);
            this.tblSaveDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSaveDelete.Location = new System.Drawing.Point(3, 274);
            this.tblSaveDelete.Name = "tblSaveDelete";
            this.tblSaveDelete.RowCount = 1;
            this.tblSaveDelete.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSaveDelete.Size = new System.Drawing.Size(975, 42);
            this.tblSaveDelete.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(319, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.AutoSize = true;
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(328, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(319, 36);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeStatus.Location = new System.Drawing.Point(653, 3);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(319, 36);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(118, 77);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(134, 29);
            this.lstUserName.TabIndex = 25;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Location = new System.Drawing.Point(118, 144);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(860, 21);
            this.lblRecipeStatus.TabIndex = 26;
            // 
            // tblStatus
            // 
            this.tblStatus.ColumnCount = 3;
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStatus.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblStatus.Controls.Add(this.lblDrafted, 0, 0);
            this.tblStatus.Controls.Add(this.lblPublished, 1, 0);
            this.tblStatus.Controls.Add(this.lblArchived, 2, 0);
            this.tblStatus.Controls.Add(this.lblDatePublished, 1, 1);
            this.tblStatus.Controls.Add(this.lblDateArchived, 2, 1);
            this.tblStatus.Controls.Add(this.lblDateCreated, 0, 1);
            this.tblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatus.Location = new System.Drawing.Point(118, 168);
            this.tblStatus.Name = "tblStatus";
            this.tblStatus.RowCount = 2;
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblStatus.Size = new System.Drawing.Size(860, 100);
            this.tblStatus.TabIndex = 27;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(280, 21);
            this.lblDrafted.TabIndex = 0;
            this.lblDrafted.Text = "Drafted";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Location = new System.Drawing.Point(289, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(280, 21);
            this.lblPublished.TabIndex = 1;
            this.lblPublished.Text = "Published";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Location = new System.Drawing.Point(575, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(282, 21);
            this.lblArchived.TabIndex = 2;
            this.lblArchived.Text = "Archived";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Location = new System.Drawing.Point(289, 21);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(280, 79);
            this.lblDatePublished.TabIndex = 4;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Location = new System.Drawing.Point(575, 21);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(282, 79);
            this.lblDateArchived.TabIndex = 5;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(3, 21);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(280, 79);
            this.lblDateCreated.TabIndex = 3;
            // 
            // tbChildRecord
            // 
            this.tblMain.SetColumnSpan(this.tbChildRecord, 2);
            this.tbChildRecord.Controls.Add(this.tbIngredients);
            this.tbChildRecord.Controls.Add(this.tbSteps);
            this.tbChildRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChildRecord.Location = new System.Drawing.Point(3, 322);
            this.tbChildRecord.Name = "tbChildRecord";
            this.tbChildRecord.SelectedIndex = 0;
            this.tbChildRecord.Size = new System.Drawing.Size(975, 142);
            this.tbChildRecord.TabIndex = 28;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Controls.Add(this.tblIngredient);
            this.tbIngredients.Location = new System.Drawing.Point(4, 30);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngredients.Size = new System.Drawing.Size(967, 108);
            this.tbIngredients.TabIndex = 0;
            this.tbIngredients.Text = "Ingredients";
            this.tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredient
            // 
            this.tblIngredient.ColumnCount = 1;
            this.tblIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblIngredient.Controls.Add(this.btnSaveIngredient, 0, 0);
            this.tblIngredient.Controls.Add(this.gIngredient, 0, 1);
            this.tblIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIngredient.Location = new System.Drawing.Point(3, 3);
            this.tblIngredient.Name = "tblIngredient";
            this.tblIngredient.RowCount = 2;
            this.tblIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIngredient.Size = new System.Drawing.Size(961, 102);
            this.tblIngredient.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Location = new System.Drawing.Point(3, 3);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(106, 31);
            this.btnSaveIngredient.TabIndex = 0;
            this.btnSaveIngredient.Text = "Save";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredient
            // 
            this.gIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredient.Location = new System.Drawing.Point(3, 40);
            this.gIngredient.Name = "gIngredient";
            this.gIngredient.RowTemplate.Height = 25;
            this.gIngredient.Size = new System.Drawing.Size(955, 59);
            this.gIngredient.TabIndex = 1;
            // 
            // tbSteps
            // 
            this.tbSteps.Controls.Add(this.tblSteps);
            this.tbSteps.Location = new System.Drawing.Point(4, 24);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tbSteps.Size = new System.Drawing.Size(967, 144);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "Steps";
            this.tbSteps.UseVisualStyleBackColor = true;
            // 
            // tblSteps
            // 
            this.tblSteps.ColumnCount = 1;
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblSteps.Controls.Add(this.btnSaveSteps, 0, 0);
            this.tblSteps.Controls.Add(this.gSteps, 0, 1);
            this.tblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSteps.Location = new System.Drawing.Point(3, 3);
            this.tblSteps.Name = "tblSteps";
            this.tblSteps.RowCount = 2;
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblSteps.Size = new System.Drawing.Size(961, 138);
            this.tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            this.btnSaveSteps.Location = new System.Drawing.Point(3, 3);
            this.btnSaveSteps.Name = "btnSaveSteps";
            this.btnSaveSteps.Size = new System.Drawing.Size(82, 28);
            this.btnSaveSteps.TabIndex = 0;
            this.btnSaveSteps.Text = "Save";
            this.btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            this.gSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSteps.Location = new System.Drawing.Point(3, 37);
            this.gSteps.Name = "gSteps";
            this.gSteps.RowTemplate.Height = 25;
            this.gSteps.Size = new System.Drawing.Size(955, 98);
            this.gSteps.TabIndex = 1;
            // 
            // frmRecipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 467);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecipe";
            this.Text = "frmRecipe";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblSaveDelete.ResumeLayout(false);
            this.tblSaveDelete.PerformLayout();
            this.tblStatus.ResumeLayout(false);
            this.tblStatus.PerformLayout();
            this.tbChildRecord.ResumeLayout(false);
            this.tbIngredients.ResumeLayout(false);
            this.tblIngredient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).EndInit();
            this.tbSteps.ResumeLayout(false);
            this.tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRName;
        private Label lblCalories;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private Label lblUser;
        private Label lblCuisine;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private ComboBox lstCuisineType;
        private TableLayoutPanel tblSaveDelete;
        private Button btnSave;
        private Button btnDel;
        private ComboBox lstUserName;
        private Button btnChangeStatus;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDateCreated;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TabControl tbChildRecord;
        private TabPage tbIngredients;
        private TableLayoutPanel tblIngredient;
        private Button btnSaveIngredient;
        private DataGridView gIngredient;
        private TabPage tbSteps;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}