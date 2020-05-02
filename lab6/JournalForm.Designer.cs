﻿namespace lab6
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
            this.restaurantAppDataSet = new lab6.RestaurantAppDataSet();
            this.journalSalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journalSalesTableAdapter = new lab6.RestaurantAppDataSetTableAdapters.JournalSalesTableAdapter();
            this.tableAdapterManager = new lab6.RestaurantAppDataSetTableAdapters.TableAdapterManager();
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
            this.journalSalesDataGridView = new System.Windows.Forms.DataGridView();
            this.onmain_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dishesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dishesTableAdapter = new lab6.RestaurantAppDataSetTableAdapters.DishesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.restaurantLogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantLogsTableAdapter = new lab6.RestaurantAppDataSetTableAdapters.RestaurantLogsTableAdapter();
            this.restaurantLogsDataGridView = new System.Windows.Forms.DataGridView();
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDich = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingNavigator)).BeginInit();
            this.journalSalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.tableAdapterManager.RestaurantLogsTableAdapter = this.restaurantLogsTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab6.RestaurantAppDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.journalSalesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.journalSalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.journalSalesBindingNavigator.Size = new System.Drawing.Size(838, 31);
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
            // journalSalesDataGridView
            // 
            this.journalSalesDataGridView.AutoGenerateColumns = false;
            this.journalSalesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.journalSalesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.journalSalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.journalSalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.journalSalesDataGridView.DataSource = this.journalSalesBindingSource;
            this.journalSalesDataGridView.Location = new System.Drawing.Point(8, 45);
            this.journalSalesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.journalSalesDataGridView.Name = "journalSalesDataGridView";
            this.journalSalesDataGridView.RowHeadersWidth = 62;
            this.journalSalesDataGridView.RowTemplate.Height = 28;
            this.journalSalesDataGridView.Size = new System.Drawing.Size(465, 161);
            this.journalSalesDataGridView.TabIndex = 1;
            // 
            // onmain_button
            // 
            this.onmain_button.Location = new System.Drawing.Point(720, 294);
            this.onmain_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.onmain_button.Name = "onmain_button";
            this.onmain_button.Size = new System.Drawing.Size(98, 58);
            this.onmain_button.TabIndex = 2;
            this.onmain_button.Text = "на главную";
            this.onmain_button.UseVisualStyleBackColor = true;
            this.onmain_button.Click += new System.EventHandler(this.onmain_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Журнал продаж";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource, "Amount", true));
            this.textBox2.Location = new System.Drawing.Point(81, 45);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Продукт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Количество";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 21);
            this.button1.TabIndex = 10;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(5, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(157, 69);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 21);
            this.button3.TabIndex = 12;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource, "IdDich", true));
            this.comboBox1.DataSource = this.dishesBindingSource;
            this.comboBox1.DisplayMember = "NameDish";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "IdDish";
            // 
            // dishesBindingSource
            // 
            this.dishesBindingSource.DataMember = "Dishes";
            this.dishesBindingSource.DataSource = this.restaurantAppDataSet;
            // 
            // dishesTableAdapter
            // 
            this.dishesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(478, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 102);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
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
            // restaurantLogsDataGridView
            // 
            this.restaurantLogsDataGridView.AutoGenerateColumns = false;
            this.restaurantLogsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.restaurantLogsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.restaurantLogsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.restaurantLogsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.IdDich,
            this.Column1});
            this.restaurantLogsDataGridView.DataSource = this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource;
            this.restaurantLogsDataGridView.Location = new System.Drawing.Point(8, 211);
            this.restaurantLogsDataGridView.Name = "restaurantLogsDataGridView";
            this.restaurantLogsDataGridView.Size = new System.Drawing.Size(464, 141);
            this.restaurantLogsDataGridView.TabIndex = 14;
            // 
            // fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource
            // 
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.DataMember = "FK_dbo.RestaurantLogs_dbo.JournalSales_IdSale";
            this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource.DataSource = this.journalSalesBindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(483, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 102);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(156, 69);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 21);
            this.button4.TabIndex = 11;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journalSalesBindingSource, "Amount", true));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(81, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.journalSalesBindingSource, "OrderDate", true));
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(81, 19);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(147, 20);
            this.textBox3.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLog";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdLog";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdSale";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdSale";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // IdDich
            // 
            this.IdDich.DataPropertyName = "IdDich";
            this.IdDich.DataSource = this.dishesBindingSource;
            this.IdDich.DisplayMember = "NameDish";
            this.IdDich.HeaderText = "Dish";
            this.IdDich.Name = "IdDich";
            this.IdDich.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IdDich.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IdDich.ValueMember = "IdDish";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IdDich";
            this.Column1.DataSource = this.dishesBindingSource;
            this.Column1.DisplayMember = "Price";
            this.Column1.HeaderText = "Price";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.ValueMember = "IdDish";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IdSale";
            this.Column2.HeaderText = "id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn2.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 69);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 21);
            this.button5.TabIndex = 14;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // JournalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.restaurantLogsDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.onmain_button);
            this.Controls.Add(this.journalSalesDataGridView);
            this.Controls.Add(this.journalSalesBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "JournalForm";
            this.Text = "JournalForm";
            this.Load += new System.EventHandler(this.JournalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesBindingNavigator)).EndInit();
            this.journalSalesBindingNavigator.ResumeLayout(false);
            this.journalSalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.journalSalesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantLogsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView journalSalesDataGridView;
        private System.Windows.Forms.Button onmain_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dishesBindingSource;
        private RestaurantAppDataSetTableAdapters.DishesTableAdapter dishesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource restaurantLogsBindingSource;
        private RestaurantAppDataSetTableAdapters.RestaurantLogsTableAdapter restaurantLogsTableAdapter;
        private System.Windows.Forms.BindingSource fKdboRestaurantLogsdboJournalSalesIdSaleBindingSource;
        private System.Windows.Forms.DataGridView restaurantLogsDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn IdDich;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column1;
        private System.Windows.Forms.Button button5;
    }
}