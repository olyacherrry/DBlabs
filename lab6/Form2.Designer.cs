namespace lab6
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.restaurantAppDataSet1 = new lab6.RestaurantAppDataSet();
            this.categoryDishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryDishesTableAdapter = new lab6.RestaurantAppDataSetTableAdapters.CategoryDishesTableAdapter();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new lab6.RestaurantAppDataSetTableAdapters.DishesTableAdapter();
            this.tableAdapterManager = new lab6.RestaurantAppDataSetTableAdapters.TableAdapterManager();
            this.idCategoryComboBox = new System.Windows.Forms.ComboBox();
            this.dishesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantAppDataSet1
            // 
            this.restaurantAppDataSet1.DataSetName = "RestaurantAppDataSet";
            this.restaurantAppDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryDishesBindingSource
            // 
            this.categoryDishesBindingSource.DataMember = "CategoryDishes";
            this.categoryDishesBindingSource.DataSource = this.restaurantAppDataSet1;
            // 
            // categoryDishesTableAdapter
            // 
            this.categoryDishesTableAdapter.ClearBeforeFill = true;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restaurantAppDataSet1;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryDishesTableAdapter = this.categoryDishesTableAdapter;
            this.tableAdapterManager.DishesTableAdapter = this.dishesTableAdapter;
            this.tableAdapterManager.JournalSalesTableAdapter = null;
            this.tableAdapterManager.RestaurantLogsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab6.RestaurantAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WaitersTableAdapter = null;
            // 
            // idCategoryComboBox
            // 
            this.idCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.categoryDishesBindingSource, "IdCategory", true));
            this.idCategoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryDishesBindingSource, "IdCategory", true));
            this.idCategoryComboBox.DataSource = this.categoryDishesBindingSource;
            this.idCategoryComboBox.DisplayMember = "NameCategory";
            this.idCategoryComboBox.FormattingEnabled = true;
            this.idCategoryComboBox.Location = new System.Drawing.Point(328, 14);
            this.idCategoryComboBox.Name = "idCategoryComboBox";
            this.idCategoryComboBox.Size = new System.Drawing.Size(121, 21);
            this.idCategoryComboBox.TabIndex = 2;
            this.idCategoryComboBox.ValueMember = "IdCategory";
            // 
            // dishesDataGridView
            // 
            this.dishesDataGridView.AutoGenerateColumns = false;
            this.dishesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dishesDataGridView.DataSource = this.dishesBindingSource;
            this.dishesDataGridView.Location = new System.Drawing.Point(12, 41);
            this.dishesDataGridView.Name = "dishesDataGridView";
            this.dishesDataGridView.Size = new System.Drawing.Size(437, 220);
            this.dishesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdDish";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdDish";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NameDish";
            this.dataGridViewTextBoxColumn2.HeaderText = "NameDish";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdCategory";
            this.dataGridViewTextBoxColumn4.HeaderText = "IdCategory";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 275);
            this.Controls.Add(this.dishesDataGridView);
            this.Controls.Add(this.idCategoryComboBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryDishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RestaurantAppDataSet restaurantAppDataSet1;
        private System.Windows.Forms.BindingSource categoryDishesBindingSource;
        private RestaurantAppDataSetTableAdapters.CategoryDishesTableAdapter categoryDishesTableAdapter;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantAppDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private RestaurantAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox idCategoryComboBox;
        private System.Windows.Forms.DataGridView dishesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}