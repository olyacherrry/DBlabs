namespace lab7
{
    partial class connectedTables
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
            this.onmain_button = new System.Windows.Forms.Button();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.idCategoryComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // onmain_button
            // 
            this.onmain_button.Location = new System.Drawing.Point(798, 330);
            this.onmain_button.Name = "onmain_button";
            this.onmain_button.Size = new System.Drawing.Size(142, 86);
            this.onmain_button.TabIndex = 7;
            this.onmain_button.Text = "на главную";
            this.onmain_button.UseVisualStyleBackColor = true;
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Location = new System.Drawing.Point(13, 78);
            this.dishesDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.RowHeadersWidth = 62;
            this.dishesDataGridView.Size = new System.Drawing.Size(656, 338);
            this.dishesDataGridView.TabIndex = 5;
            // 
            // idCategoryComboBox
            // 
            this.idCategoryComboBox.DisplayMember = "NameCategory";
            this.idCategoryComboBox.FormattingEnabled = true;
            this.idCategoryComboBox.Location = new System.Drawing.Point(489, 40);
            this.idCategoryComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idCategoryComboBox.Name = "idCategoryComboBox";
            this.idCategoryComboBox.Size = new System.Drawing.Size(180, 28);
            this.idCategoryComboBox.TabIndex = 6;
            this.idCategoryComboBox.ValueMember = "IdCategory";
            // 
            // connectedTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 465);
            this.Controls.Add(this.onmain_button);
            this.Controls.Add(this.dishesDataGridView);
            this.Controls.Add(this.idCategoryComboBox);
            this.Name = "connectedTables";
            this.Text = "connectedTables";
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button onmain_button;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private System.Windows.Forms.ComboBox idCategoryComboBox;
    }
}