namespace RecipeWinForms
{
    partial class frmRecipeDetails
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
            this.lblUsers = new System.Windows.Forms.Label();
            this.lblCuisine = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusDate = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtCalories = new System.Windows.Forms.TextBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.lstCuisineType = new System.Windows.Forms.ComboBox();
            this.lblRecipeStatus = new System.Windows.Forms.Label();
            this.tblButton = new System.Windows.Forms.TableLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnChangeStatus = new System.Windows.Forms.Button();
            this.tbChildRecord = new System.Windows.Forms.TabControl();
            this.tbIngredients = new System.Windows.Forms.TabPage();
            this.tbSteps = new System.Windows.Forms.TabPage();
            this.tblStatus = new System.Windows.Forms.TableLayoutPanel();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.lblDatePublished = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.tblSteps = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveSteps = new System.Windows.Forms.Button();
            this.gSteps = new System.Windows.Forms.DataGridView();
            this.tblIngredient = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveIngredient = new System.Windows.Forms.Button();
            this.gIngredient = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.tblButton.SuspendLayout();
            this.tbChildRecord.SuspendLayout();
            this.tbIngredients.SuspendLayout();
            this.tbSteps.SuspendLayout();
            this.tblStatus.SuspendLayout();
            this.tblSteps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).BeginInit();
            this.tblIngredient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.lblRName, 0, 0);
            this.tblMain.Controls.Add(this.lblCalories, 0, 1);
            this.tblMain.Controls.Add(this.lblUsers, 0, 2);
            this.tblMain.Controls.Add(this.lblCuisine, 0, 3);
            this.tblMain.Controls.Add(this.lblStatus, 0, 4);
            this.tblMain.Controls.Add(this.lblStatusDate, 0, 5);
            this.tblMain.Controls.Add(this.txtRecipeName, 1, 0);
            this.tblMain.Controls.Add(this.txtCalories, 1, 1);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.lstCuisineType, 1, 3);
            this.tblMain.Controls.Add(this.lblRecipeStatus, 1, 4);
            this.tblMain.Controls.Add(this.tblButton, 0, 6);
            this.tblMain.Controls.Add(this.tbChildRecord, 0, 7);
            this.tblMain.Controls.Add(this.tblStatus, 1, 5);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 8;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(799, 477);
            this.tblMain.TabIndex = 0;
            // 
            // lblRName
            // 
            this.lblRName.AutoSize = true;
            this.lblRName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRName.Location = new System.Drawing.Point(3, 0);
            this.lblRName.Name = "lblRName";
            this.lblRName.Size = new System.Drawing.Size(85, 29);
            this.lblRName.TabIndex = 0;
            this.lblRName.Text = "Recipe Name:";
            // 
            // lblCalories
            // 
            this.lblCalories.AutoSize = true;
            this.lblCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCalories.Location = new System.Drawing.Point(3, 29);
            this.lblCalories.Name = "lblCalories";
            this.lblCalories.Size = new System.Drawing.Size(85, 29);
            this.lblCalories.TabIndex = 1;
            this.lblCalories.Text = "Calories:";
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsers.Location = new System.Drawing.Point(3, 58);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(85, 29);
            this.lblUsers.TabIndex = 2;
            this.lblUsers.Text = "User:";
            // 
            // lblCuisine
            // 
            this.lblCuisine.AutoSize = true;
            this.lblCuisine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCuisine.Location = new System.Drawing.Point(3, 87);
            this.lblCuisine.Name = "lblCuisine";
            this.lblCuisine.Size = new System.Drawing.Size(85, 29);
            this.lblCuisine.TabIndex = 3;
            this.lblCuisine.Text = "Cuisine:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatus.Location = new System.Drawing.Point(3, 116);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Current Status:";
            // 
            // lblStatusDate
            // 
            this.lblStatusDate.AutoSize = true;
            this.lblStatusDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatusDate.Location = new System.Drawing.Point(3, 131);
            this.lblStatusDate.Name = "lblStatusDate";
            this.lblStatusDate.Size = new System.Drawing.Size(85, 106);
            this.lblStatusDate.TabIndex = 5;
            this.lblStatusDate.Text = "Status Dates:";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRecipeName.Location = new System.Drawing.Point(94, 3);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(702, 23);
            this.txtRecipeName.TabIndex = 6;
            // 
            // txtCalories
            // 
            this.txtCalories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCalories.Location = new System.Drawing.Point(94, 32);
            this.txtCalories.Name = "txtCalories";
            this.txtCalories.Size = new System.Drawing.Size(702, 23);
            this.txtCalories.TabIndex = 7;
            // 
            // lstUserName
            // 
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(94, 61);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(121, 23);
            this.lstUserName.TabIndex = 8;
            // 
            // lstCuisineType
            // 
            this.lstCuisineType.FormattingEnabled = true;
            this.lstCuisineType.Location = new System.Drawing.Point(94, 90);
            this.lstCuisineType.Name = "lstCuisineType";
            this.lstCuisineType.Size = new System.Drawing.Size(121, 23);
            this.lstCuisineType.TabIndex = 9;
            // 
            // lblRecipeStatus
            // 
            this.lblRecipeStatus.AutoSize = true;
            this.lblRecipeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeStatus.Location = new System.Drawing.Point(94, 116);
            this.lblRecipeStatus.Name = "lblRecipeStatus";
            this.lblRecipeStatus.Size = new System.Drawing.Size(702, 15);
            this.lblRecipeStatus.TabIndex = 10;
            this.lblRecipeStatus.Text = "label7";
            // 
            // tblButton
            // 
            this.tblButton.ColumnCount = 3;
            this.tblMain.SetColumnSpan(this.tblButton, 2);
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblButton.Controls.Add(this.btnSave, 0, 0);
            this.tblButton.Controls.Add(this.btnDel, 1, 0);
            this.tblButton.Controls.Add(this.btnChangeStatus, 2, 0);
            this.tblButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblButton.Location = new System.Drawing.Point(3, 240);
            this.tblButton.Name = "tblButton";
            this.tblButton.RowCount = 1;
            this.tblButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblButton.Size = new System.Drawing.Size(793, 100);
            this.tblButton.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(258, 94);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDel.Location = new System.Drawing.Point(267, 3);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(258, 94);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeStatus.Location = new System.Drawing.Point(531, 3);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Size = new System.Drawing.Size(259, 94);
            this.btnChangeStatus.TabIndex = 2;
            this.btnChangeStatus.Text = "Change Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // tbChildRecord
            // 
            this.tblMain.SetColumnSpan(this.tbChildRecord, 2);
            this.tbChildRecord.Controls.Add(this.tbIngredients);
            this.tbChildRecord.Controls.Add(this.tbSteps);
            this.tbChildRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbChildRecord.Location = new System.Drawing.Point(3, 346);
            this.tbChildRecord.Name = "tbChildRecord";
            this.tbChildRecord.SelectedIndex = 0;
            this.tbChildRecord.Size = new System.Drawing.Size(793, 128);
            this.tbChildRecord.TabIndex = 12;
            // 
            // tbIngredients
            // 
            this.tbIngredients.Controls.Add(this.tblIngredient);
            this.tbIngredients.Location = new System.Drawing.Point(4, 24);
            this.tbIngredients.Name = "tbIngredients";
            this.tbIngredients.Padding = new System.Windows.Forms.Padding(3);
            this.tbIngredients.Size = new System.Drawing.Size(785, 100);
            this.tbIngredients.TabIndex = 0;
            this.tbIngredients.Text = "Ingredients";
            this.tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tbSteps
            // 
            this.tbSteps.Controls.Add(this.tblSteps);
            this.tbSteps.Location = new System.Drawing.Point(4, 24);
            this.tbSteps.Name = "tbSteps";
            this.tbSteps.Padding = new System.Windows.Forms.Padding(3);
            this.tbSteps.Size = new System.Drawing.Size(785, 100);
            this.tbSteps.TabIndex = 1;
            this.tbSteps.Text = "Steps";
            this.tbSteps.UseVisualStyleBackColor = true;
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
            this.tblStatus.Controls.Add(this.lblDateCreated, 0, 1);
            this.tblStatus.Controls.Add(this.lblDatePublished, 1, 1);
            this.tblStatus.Controls.Add(this.lblDateArchived, 2, 1);
            this.tblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatus.Location = new System.Drawing.Point(94, 134);
            this.tblStatus.Name = "tblStatus";
            this.tblStatus.RowCount = 2;
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblStatus.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatus.Size = new System.Drawing.Size(702, 100);
            this.tblStatus.TabIndex = 13;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Location = new System.Drawing.Point(3, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(227, 15);
            this.lblDrafted.TabIndex = 0;
            this.lblDrafted.Text = "Drafted:";
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Location = new System.Drawing.Point(236, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(228, 15);
            this.lblPublished.TabIndex = 1;
            this.lblPublished.Text = "Published:";
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Location = new System.Drawing.Point(470, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(229, 15);
            this.lblArchived.TabIndex = 2;
            this.lblArchived.Text = "Archived:";
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(3, 15);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(227, 85);
            this.lblDateCreated.TabIndex = 3;
            // 
            // lblDatePublished
            // 
            this.lblDatePublished.AutoSize = true;
            this.lblDatePublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDatePublished.Location = new System.Drawing.Point(236, 15);
            this.lblDatePublished.Name = "lblDatePublished";
            this.lblDatePublished.Size = new System.Drawing.Size(228, 85);
            this.lblDatePublished.TabIndex = 4;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Location = new System.Drawing.Point(470, 15);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(229, 85);
            this.lblDateArchived.TabIndex = 5;
            // 
            // tblSteps
            // 
            this.tblSteps.ColumnCount = 1;
            this.tblSteps.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblSteps.Controls.Add(this.btnSaveSteps, 0, 0);
            this.tblSteps.Controls.Add(this.gSteps, 0, 1);
            this.tblSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblSteps.Location = new System.Drawing.Point(3, 3);
            this.tblSteps.Name = "tblSteps";
            this.tblSteps.RowCount = 2;
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblSteps.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblSteps.Size = new System.Drawing.Size(779, 94);
            this.tblSteps.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            this.btnSaveSteps.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveSteps.Location = new System.Drawing.Point(3, 3);
            this.btnSaveSteps.Name = "btnSaveSteps";
            this.btnSaveSteps.Size = new System.Drawing.Size(75, 23);
            this.btnSaveSteps.TabIndex = 0;
            this.btnSaveSteps.Text = "Save";
            this.btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            this.gSteps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gSteps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gSteps.Location = new System.Drawing.Point(3, 32);
            this.gSteps.Name = "gSteps";
            this.gSteps.RowTemplate.Height = 25;
            this.gSteps.Size = new System.Drawing.Size(773, 59);
            this.gSteps.TabIndex = 1;
            // 
            // tblIngredient
            // 
            this.tblIngredient.ColumnCount = 1;
            this.tblIngredient.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIngredient.Controls.Add(this.btnSaveIngredient, 0, 0);
            this.tblIngredient.Controls.Add(this.gIngredient, 0, 1);
            this.tblIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblIngredient.Location = new System.Drawing.Point(3, 3);
            this.tblIngredient.Name = "tblIngredient";
            this.tblIngredient.RowCount = 2;
            this.tblIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblIngredient.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblIngredient.Size = new System.Drawing.Size(779, 94);
            this.tblIngredient.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            this.btnSaveIngredient.Location = new System.Drawing.Point(3, 3);
            this.btnSaveIngredient.Name = "btnSaveIngredient";
            this.btnSaveIngredient.Size = new System.Drawing.Size(75, 23);
            this.btnSaveIngredient.TabIndex = 0;
            this.btnSaveIngredient.Text = "Save";
            this.btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredient
            // 
            this.gIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gIngredient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gIngredient.Location = new System.Drawing.Point(3, 32);
            this.gIngredient.Name = "gIngredient";
            this.gIngredient.RowTemplate.Height = 25;
            this.gIngredient.Size = new System.Drawing.Size(773, 59);
            this.gIngredient.TabIndex = 1;
            // 
            // frmRecipeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 477);
            this.Controls.Add(this.tblMain);
            this.Name = "frmRecipeDetails";
            this.Text = "frmRecipeDetails";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblButton.ResumeLayout(false);
            this.tbChildRecord.ResumeLayout(false);
            this.tbIngredients.ResumeLayout(false);
            this.tbSteps.ResumeLayout(false);
            this.tblStatus.ResumeLayout(false);
            this.tblStatus.PerformLayout();
            this.tblSteps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gSteps)).EndInit();
            this.tblIngredient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gIngredient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRName;
        private Label lblCalories;
        private Label lblUsers;
        private Label lblCuisine;
        private Label lblStatus;
        private Label lblStatusDate;
        private TextBox txtRecipeName;
        private TextBox txtCalories;
        private ComboBox lstUserName;
        private ComboBox lstCuisineType;
        private Label lblRecipeStatus;
        private TableLayoutPanel tblButton;
        private Button btnSave;
        private Button btnDel;
        private Button btnChangeStatus;
        private TabControl tbChildRecord;
        private TabPage tbIngredients;
        private TabPage tbSteps;
        private TableLayoutPanel tblStatus;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private Label lblDateCreated;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TableLayoutPanel tblIngredient;
        private Button btnSaveIngredient;
        private DataGridView gIngredient;
        private TableLayoutPanel tblSteps;
        private Button btnSaveSteps;
        private DataGridView gSteps;
    }
}