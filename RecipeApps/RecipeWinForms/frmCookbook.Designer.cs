namespace RecipeWinForms
{
    partial class frmCookbook
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCookbookName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.tblgrid = new System.Windows.Forms.TableLayoutPanel();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.gData = new System.Windows.Forms.DataGridView();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.lstUserName = new System.Windows.Forms.ComboBox();
            this.tblPrice = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDateCreated = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMain.SuspendLayout();
            this.tblgrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.tblPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Controls.Add(this.btnDelete, 1, 0);
            this.tblMain.Controls.Add(this.lblCookbookName, 0, 1);
            this.tblMain.Controls.Add(this.lblUserName, 0, 2);
            this.tblMain.Controls.Add(this.lblPrice, 0, 3);
            this.tblMain.Controls.Add(this.lblActive, 0, 4);
            this.tblMain.Controls.Add(this.tblgrid, 0, 5);
            this.tblMain.Controls.Add(this.txtBookName, 1, 1);
            this.tblMain.Controls.Add(this.chkActive, 1, 4);
            this.tblMain.Controls.Add(this.lstUserName, 1, 2);
            this.tblMain.Controls.Add(this.tblPrice, 1, 3);
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 6;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.Size = new System.Drawing.Size(721, 469);
            this.tblMain.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(136, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 36);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCookbookName
            // 
            this.lblCookbookName.AutoSize = true;
            this.lblCookbookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCookbookName.Location = new System.Drawing.Point(3, 42);
            this.lblCookbookName.Name = "lblCookbookName";
            this.lblCookbookName.Size = new System.Drawing.Size(127, 35);
            this.lblCookbookName.TabIndex = 2;
            this.lblCookbookName.Text = "Cookbook Name";
            this.lblCookbookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUserName.Location = new System.Drawing.Point(3, 77);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(127, 35);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User";
            this.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPrice.Location = new System.Drawing.Point(3, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(127, 60);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActive.Location = new System.Drawing.Point(3, 172);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(127, 21);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblgrid
            // 
            this.tblgrid.ColumnCount = 2;
            this.tblMain.SetColumnSpan(this.tblgrid, 2);
            this.tblgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblgrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblgrid.Controls.Add(this.btnSaveRecipe, 0, 0);
            this.tblgrid.Controls.Add(this.gData, 0, 1);
            this.tblgrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblgrid.Location = new System.Drawing.Point(3, 196);
            this.tblgrid.Name = "tblgrid";
            this.tblgrid.RowCount = 2;
            this.tblgrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblgrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblgrid.Size = new System.Drawing.Size(715, 270);
            this.tblgrid.TabIndex = 6;
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSaveRecipe.AutoSize = true;
            this.btnSaveRecipe.Location = new System.Drawing.Point(3, 3);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(115, 36);
            this.btnSaveRecipe.TabIndex = 1;
            this.btnSaveRecipe.Text = "Save";
            this.btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblgrid.SetColumnSpan(this.gData, 2);
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(3, 45);
            this.gData.Name = "gData";
            this.gData.RowTemplate.Height = 25;
            this.gData.Size = new System.Drawing.Size(709, 222);
            this.gData.TabIndex = 2;
            // 
            // txtBookName
            // 
            this.txtBookName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBookName.Location = new System.Drawing.Point(136, 45);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(582, 29);
            this.txtBookName.TabIndex = 7;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkActive.Location = new System.Drawing.Point(143, 175);
            this.chkActive.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(575, 15);
            this.chkActive.TabIndex = 8;
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // lstUserName
            // 
            this.lstUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstUserName.FormattingEnabled = true;
            this.lstUserName.Location = new System.Drawing.Point(136, 80);
            this.lstUserName.Name = "lstUserName";
            this.lstUserName.Size = new System.Drawing.Size(582, 29);
            this.lstUserName.TabIndex = 9;
            // 
            // tblPrice
            // 
            this.tblPrice.ColumnCount = 2;
            this.tblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.Controls.Add(this.lblDate, 1, 0);
            this.tblPrice.Controls.Add(this.txtPrice, 0, 1);
            this.tblPrice.Controls.Add(this.lblDateCreated, 1, 1);
            this.tblPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPrice.Location = new System.Drawing.Point(136, 115);
            this.tblPrice.Name = "tblPrice";
            this.tblPrice.RowCount = 2;
            this.tblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPrice.Size = new System.Drawing.Size(582, 54);
            this.tblPrice.TabIndex = 10;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDate.Location = new System.Drawing.Point(294, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(285, 27);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date Created:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Location = new System.Drawing.Point(3, 30);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(285, 29);
            this.txtPrice.TabIndex = 1;
            // 
            // lblDateCreated
            // 
            this.lblDateCreated.AutoSize = true;
            this.lblDateCreated.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateCreated.Location = new System.Drawing.Point(294, 27);
            this.lblDateCreated.Name = "lblDateCreated";
            this.lblDateCreated.Size = new System.Drawing.Size(285, 27);
            this.lblDateCreated.TabIndex = 2;
            this.lblDateCreated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 36);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmCookbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 469);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCookbook";
            this.Text = "Cookbook";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblgrid.ResumeLayout(false);
            this.tblgrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.tblPrice.ResumeLayout(false);
            this.tblPrice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnDelete;
        private Label lblCookbookName;
        private Label lblUserName;
        private Label lblPrice;
        private Label lblActive;
        private TableLayoutPanel tblgrid;
        private TextBox txtBookName;
        private CheckBox chkActive;
        private ComboBox lstUserName;
        private TableLayoutPanel tblPrice;
        private Label lblDate;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnSaveRecipe;
        private DataGridView gData;
        private Label lblDateCreated;
    }
}