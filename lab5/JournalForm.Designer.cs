namespace lab5
{
    partial class JournalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JournalForm));
            this.restaurantAppDataSet = new lab5.RestaurantAppDataSet();
            this.journalSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalSalesTableAdapter = new lab5.RestaurantAppDataSetTableAdapters.JournalSalesTableAdapter();
            this.tableAdapterManager = new lab5.RestaurantAppDataSetTableAdapters.TableAdapterManager();
            this.journalSalesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.journalSalesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.onmain_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.journalSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.waitersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantLogsTableAdapter = new lab5.RestaurantAppDataSetTableAdapters.RestaurantLogsTableAdapter();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waitersTableAdapter = new lab5.RestaurantAppDataSetTableAdapters.WaitersTableAdapter();
            this.dishesTableAdapter = new lab5.RestaurantAppDataSetTableAdapters.DishesTableAdapter();
            this.restaurantLogsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingNavigator)).BeginInit();
            this.journalSalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // restaurantAppDataSet
            // 
            this.restaurantAppDataSet.DataSetName = "RestaurantAppDataSet";
            this.restaurantAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journalSalesBindingSource
            // 
            this.journalSalesBindingSource.DataMember = "JournalSales";
            this.journalSalesBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // journalSalesTableAdapter
            // 
            this.journalSalesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryDishesTableAdapter = null;
            this.tableAdapterManager.DishesTableAdapter = null;
            this.tableAdapterManager.JournalSalesTableAdapter = this.journalSalesTableAdapter;
            this.tableAdapterManager.RestaurantLogsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab5.RestaurantAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WaitersTableAdapter = null;
            // 
            // journalSalesBindingNavigator
            // 
            this.journalSalesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.journalSalesBindingNavigator.BindingSource = this.journalSalesBindingSource;
            this.journalSalesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.journalSalesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.journalSalesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.journalSalesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.journalSalesBindingNavigatorSaveItem});
            this.journalSalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.journalSalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.journalSalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.journalSalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.journalSalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.journalSalesBindingNavigator.Name = "journalSalesBindingNavigator";
            this.journalSalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.journalSalesBindingNavigator.Size = new System.Drawing.Size(552, 31);
            this.journalSalesBindingNavigator.TabIndex = 0;
            this.journalSalesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(35, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(28, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // journalSalesBindingNavigatorSaveItem
            // 
            this.journalSalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.journalSalesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("journalSalesBindingNavigatorSaveItem.Image")));
            this.journalSalesBindingNavigatorSaveItem.Name = "journalSalesBindingNavigatorSaveItem";
            this.journalSalesBindingNavigatorSaveItem.Size = new System.Drawing.Size(28, 28);
            this.journalSalesBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.journalSalesBindingNavigatorSaveItem.Click += new System.EventHandler(this.journalSalesBindingNavigatorSaveItem_Click);
            // 
            // onmain_button
            // 
            this.onmain_button.Location = new System.Drawing.Point(467, 268);
            this.onmain_button.Margin = new System.Windows.Forms.Padding(2);
            this.onmain_button.Name = "onmain_button";
            this.onmain_button.Size = new System.Drawing.Size(65, 56);
            this.onmain_button.TabIndex = 2;
            this.onmain_button.Text = "на главную";
            this.onmain_button.UseVisualStyleBackColor = true;
            this.onmain_button.Click += new System.EventHandler(this.onmain_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Журнал продаж";
            // 
            // journalSalesDataGridView
            // 
            this.journalSalesDataGridView.AutoGenerateColumns = false;
            this.journalSalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.journalSalesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.journalSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalSalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.journalSalesDataGridView.DataSource = this.journalSalesBindingSource;
            this.journalSalesDataGridView.Location = new System.Drawing.Point(12, 37);
            this.journalSalesDataGridView.Name = "journalSalesDataGridView";
            this.journalSalesDataGridView.Size = new System.Drawing.Size(443, 139);
            this.journalSalesDataGridView.TabIndex = 5;
            // 
            // waitersBindingSource
            // 
            this.waitersBindingSource.DataMember = "Waiters";
            this.waitersBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // restaurantLogsBindingSource
            // 
            this.restaurantLogsBindingSource.DataMember = "RestaurantLogs";
            this.restaurantLogsBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // restaurantLogsTableAdapter
            // 
            this.restaurantLogsTableAdapter.ClearBeforeFill = true;
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource
            // 
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.DataMember = "FK_dbo.RestaurantLogs_dbo.JournalSales_IdSale";
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.DataSource = this.journalSalesBindingSource;
            // 
            // waitersTableAdapter
            // 
            this.waitersTableAdapter.ClearBeforeFill = true;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // restaurantLogsDataGridView
            // 
            this.restaurantLogsDataGridView.AutoGenerateColumns = false;
            this.restaurantLogsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.restaurantLogsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.restaurantLogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantLogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn6});
            this.restaurantLogsDataGridView.DataSource = this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource;
            this.restaurantLogsDataGridView.Location = new System.Drawing.Point(12, 182);
            this.restaurantLogsDataGridView.Name = "restaurantLogsDataGridView";
            this.restaurantLogsDataGridView.Size = new System.Drawing.Size(443, 142);
            this.restaurantLogsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IdDich";
            this.dataGridViewTextBoxColumn7.DataSource = this.dishesBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "NameDish";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dataGridViewTextBoxColumn7.HeaderText = "IdDich";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "IdDish";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdSale";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdSale";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 333);
            this.Controls.Add(this.restaurantLogsDataGridView);
            this.Controls.Add(this.journalSalesDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onmain_button);
            this.Controls.Add(this.journalSalesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingNavigator)).EndInit();
            this.journalSalesBindingNavigator.ResumeLayout(false);
            this.journalSalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waitersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RestaurantAppDataSet restaurantAppDataSet;
        private System.Windows.Forms.BindingSource journalSalesBindingSource;
        private RestaurantAppDataSetTableAdapters.JournalSalesTableAdapter journalSalesTableAdapter;
        private RestaurantAppDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator journalSalesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton journalSalesBindingNavigatorSaveItem;
        private System.Windows.Forms.Button onmain_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView journalSalesDataGridView;
        private System.Windows.Forms.BindingSource restaurantLogsBindingSource;
        private RestaurantAppDataSetTableAdapters.RestaurantLogsTableAdapter restaurantLogsTableAdapter;
        private System.Windows.Forms.BindingSource waitersBindingSource;
        private RestaurantAppDataSetTableAdapters.WaitersTableAdapter waitersTableAdapter;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantAppDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.BindingSource fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource;
        private System.Windows.Forms.DataGridView restaurantLogsDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}