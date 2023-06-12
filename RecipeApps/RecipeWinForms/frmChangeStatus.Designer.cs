namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblCurentStatus = new System.Windows.Forms.Label();
            this.tblDates = new System.Windows.Forms.TableLayoutPanel();
            this.tblStatusButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnPublish = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lblDates = new System.Windows.Forms.Label();
            this.lblDrafted = new System.Windows.Forms.Label();
            this.lblDateArchived = new System.Windows.Forms.Label();
            this.lblPublished = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblArchived = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tblMain.SuspendLayout();
            this.tblDates.SuspendLayout();
            this.tblStatusButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 1;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Controls.Add(this.lblRecipeName, 0, 0);
            this.tblMain.Controls.Add(this.lblCurentStatus, 0, 1);
            this.tblMain.Controls.Add(this.tblDates, 0, 2);
            this.tblMain.Controls.Add(this.tblStatusButtons, 0, 3);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 4;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblMain.Size = new System.Drawing.Size(754, 473);
            this.tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(3, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(748, 118);
            this.lblRecipeName.TabIndex = 0;
            this.lblRecipeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurentStatus
            // 
            this.lblCurentStatus.AutoSize = true;
            this.lblCurentStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurentStatus.Location = new System.Drawing.Point(3, 118);
            this.lblCurentStatus.Name = "lblCurentStatus";
            this.lblCurentStatus.Size = new System.Drawing.Size(748, 118);
            this.lblCurentStatus.TabIndex = 1;
            this.lblCurentStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tblDates
            // 
            this.tblDates.ColumnCount = 4;
            this.tblDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDates.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblDates.Controls.Add(this.lblDates, 0, 1);
            this.tblDates.Controls.Add(this.lblDrafted, 1, 0);
            this.tblDates.Controls.Add(this.lblDateArchived, 1, 1);
            this.tblDates.Controls.Add(this.lblPublished, 2, 0);
            this.tblDates.Controls.Add(this.label7, 2, 1);
            this.tblDates.Controls.Add(this.lblArchived, 3, 0);
            this.tblDates.Controls.Add(this.label9, 3, 1);
            this.tblDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDates.Location = new System.Drawing.Point(3, 239);
            this.tblDates.Name = "tblDates";
            this.tblDates.RowCount = 2;
            this.tblDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDates.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDates.Size = new System.Drawing.Size(748, 112);
            this.tblDates.TabIndex = 2;
            // 
            // tblStatusButtons
            // 
            this.tblStatusButtons.ColumnCount = 3;
            this.tblStatusButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblStatusButtons.Controls.Add(this.btnArchive, 0, 0);
            this.tblStatusButtons.Controls.Add(this.btnPublish, 0, 0);
            this.tblStatusButtons.Controls.Add(this.btnDraft, 0, 0);
            this.tblStatusButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblStatusButtons.Location = new System.Drawing.Point(3, 357);
            this.tblStatusButtons.Name = "tblStatusButtons";
            this.tblStatusButtons.RowCount = 1;
            this.tblStatusButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblStatusButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblStatusButtons.Size = new System.Drawing.Size(748, 113);
            this.tblStatusButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            this.btnDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDraft.Location = new System.Drawing.Point(3, 35);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(243, 43);
            this.btnDraft.TabIndex = 0;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            this.btnPublish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublish.Location = new System.Drawing.Point(252, 35);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(243, 43);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            this.btnArchive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnArchive.Location = new System.Drawing.Point(501, 35);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(244, 43);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "Archive";
            this.btnArchive.UseVisualStyleBackColor = true;
            // 
            // lblDates
            // 
            this.lblDates.AutoSize = true;
            this.lblDates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDates.Location = new System.Drawing.Point(3, 56);
            this.lblDates.Name = "lblDates";
            this.lblDates.Size = new System.Drawing.Size(181, 56);
            this.lblDates.TabIndex = 0;
            this.lblDates.Text = "Status Dates";
            this.lblDates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDrafted
            // 
            this.lblDrafted.AutoSize = true;
            this.lblDrafted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDrafted.Location = new System.Drawing.Point(190, 0);
            this.lblDrafted.Name = "lblDrafted";
            this.lblDrafted.Size = new System.Drawing.Size(181, 56);
            this.lblDrafted.TabIndex = 1;
            this.lblDrafted.Text = "Drafted:";
            this.lblDrafted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            this.lblDateArchived.AutoSize = true;
            this.lblDateArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDateArchived.Location = new System.Drawing.Point(190, 56);
            this.lblDateArchived.Name = "lblDateArchived";
            this.lblDateArchived.Size = new System.Drawing.Size(181, 56);
            this.lblDateArchived.TabIndex = 2;
            this.lblDateArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            this.lblPublished.AutoSize = true;
            this.lblPublished.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPublished.Location = new System.Drawing.Point(377, 0);
            this.lblPublished.Name = "lblPublished";
            this.lblPublished.Size = new System.Drawing.Size(181, 56);
            this.lblPublished.TabIndex = 3;
            this.lblPublished.Text = "Published:";
            this.lblPublished.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(377, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 56);
            this.label7.TabIndex = 4;
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            this.lblArchived.AutoSize = true;
            this.lblArchived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArchived.Location = new System.Drawing.Point(564, 0);
            this.lblArchived.Name = "lblArchived";
            this.lblArchived.Size = new System.Drawing.Size(181, 56);
            this.lblArchived.TabIndex = 5;
            this.lblArchived.Text = "Archived:";
            this.lblArchived.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(564, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 56);
            this.label9.TabIndex = 6;
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 473);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChangeStatus";
            this.Text = "Recipe - Change Status";
            this.tblMain.ResumeLayout(false);
            this.tblMain.PerformLayout();
            this.tblDates.ResumeLayout(false);
            this.tblDates.PerformLayout();
            this.tblStatusButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurentStatus;
        private TableLayoutPanel tblDates;
        private TableLayoutPanel tblStatusButtons;
        private Button btnDraft;
        private Button btnArchive;
        private Button btnPublish;
        private Label lblDates;
        private Label lblDrafted;
        private Label lblDateArchived;
        private Label lblPublished;
        private Label label7;
        private Label lblArchived;
        private Label label9;
    }
}