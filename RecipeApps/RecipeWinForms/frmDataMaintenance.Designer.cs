namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlOptionButton = new System.Windows.Forms.FlowLayoutPanel();
            this.optUsers = new System.Windows.Forms.RadioButton();
            this.optCuisine = new System.Windows.Forms.RadioButton();
            this.optIngredient = new System.Windows.Forms.RadioButton();
            this.optMeasurement = new System.Windows.Forms.RadioButton();
            this.optCourses = new System.Windows.Forms.RadioButton();
            this.gData = new System.Windows.Forms.DataGridView();
            this.tblMain.SuspendLayout();
            this.pnlOptionButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).BeginInit();
            this.SuspendLayout();
            // 
            // tblMain
            // 
            this.tblMain.ColumnCount = 2;
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblMain.Controls.Add(this.btnSave, 0, 0);
            this.tblMain.Controls.Add(this.pnlOptionButton, 0, 1);
            this.tblMain.Controls.Add(this.gData, 1, 1);
            this.tblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMain.Location = new System.Drawing.Point(0, 0);
            this.tblMain.Name = "tblMain";
            this.tblMain.RowCount = 2;
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMain.Size = new System.Drawing.Size(719, 424);
            this.tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 32);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlOptionButton
            // 
            this.pnlOptionButton.Controls.Add(this.optUsers);
            this.pnlOptionButton.Controls.Add(this.optCuisine);
            this.pnlOptionButton.Controls.Add(this.optIngredient);
            this.pnlOptionButton.Controls.Add(this.optMeasurement);
            this.pnlOptionButton.Controls.Add(this.optCourses);
            this.pnlOptionButton.Location = new System.Drawing.Point(3, 41);
            this.pnlOptionButton.Name = "pnlOptionButton";
            this.pnlOptionButton.Size = new System.Drawing.Size(158, 380);
            this.pnlOptionButton.TabIndex = 1;
            // 
            // optUsers
            // 
            this.optUsers.AutoSize = true;
            this.optUsers.Location = new System.Drawing.Point(3, 3);
            this.optUsers.Name = "optUsers";
            this.optUsers.Size = new System.Drawing.Size(67, 25);
            this.optUsers.TabIndex = 0;
            this.optUsers.TabStop = true;
            this.optUsers.Text = "Users";
            this.optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisine
            // 
            this.optCuisine.AutoSize = true;
            this.optCuisine.Location = new System.Drawing.Point(3, 34);
            this.optCuisine.Name = "optCuisine";
            this.optCuisine.Size = new System.Drawing.Size(86, 25);
            this.optCuisine.TabIndex = 1;
            this.optCuisine.TabStop = true;
            this.optCuisine.Text = "Cuisines";
            this.optCuisine.UseVisualStyleBackColor = true;
            // 
            // optIngredient
            // 
            this.optIngredient.AutoSize = true;
            this.optIngredient.Location = new System.Drawing.Point(3, 65);
            this.optIngredient.Name = "optIngredient";
            this.optIngredient.Size = new System.Drawing.Size(106, 25);
            this.optIngredient.TabIndex = 2;
            this.optIngredient.TabStop = true;
            this.optIngredient.Text = "Ingredients";
            this.optIngredient.UseVisualStyleBackColor = true;
            // 
            // optMeasurement
            // 
            this.optMeasurement.AutoSize = true;
            this.optMeasurement.Location = new System.Drawing.Point(3, 96);
            this.optMeasurement.Name = "optMeasurement";
            this.optMeasurement.Size = new System.Drawing.Size(131, 25);
            this.optMeasurement.TabIndex = 3;
            this.optMeasurement.TabStop = true;
            this.optMeasurement.Text = "Measurements";
            this.optMeasurement.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            this.optCourses.AutoSize = true;
            this.optCourses.Location = new System.Drawing.Point(3, 127);
            this.optCourses.Name = "optCourses";
            this.optCourses.Size = new System.Drawing.Size(84, 25);
            this.optCourses.TabIndex = 4;
            this.optCourses.TabStop = true;
            this.optCourses.Text = "Courses";
            this.optCourses.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            this.gData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gData.Location = new System.Drawing.Point(167, 41);
            this.gData.Name = "gData";
            this.gData.RowTemplate.Height = 25;
            this.gData.Size = new System.Drawing.Size(549, 380);
            this.gData.TabIndex = 2;
            // 
            // frmDataMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 424);
            this.Controls.Add(this.tblMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDataMaintenance";
            this.Text = "Data Maintenance";
            this.tblMain.ResumeLayout(false);
            this.pnlOptionButton.ResumeLayout(false);
            this.pnlOptionButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private FlowLayoutPanel pnlOptionButton;
        private RadioButton optUsers;
        private RadioButton optCuisine;
        private RadioButton optIngredient;
        private RadioButton optMeasurement;
        private RadioButton optCourses;
        private DataGridView gData;
    }
}