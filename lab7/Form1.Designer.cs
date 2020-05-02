namespace lab7
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.waitersbutton = new System.Windows.Forms.Button();
            this.dishesbutton = new System.Windows.Forms.Button();
            this.dishcategorybutton = new System.Windows.Forms.Button();
            this.sales_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(232, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных Ресторан";
            // 
            // waitersbutton
            // 
            this.waitersbutton.Location = new System.Drawing.Point(192, 95);
            this.waitersbutton.Name = "waitersbutton";
            this.waitersbutton.Size = new System.Drawing.Size(296, 85);
            this.waitersbutton.TabIndex = 1;
            this.waitersbutton.Text = "  Офицанты";
            this.waitersbutton.UseVisualStyleBackColor = true;
            this.waitersbutton.Click += new System.EventHandler(this.waitersbutton_Click);
            // 
            // dishesbutton
            // 
            this.dishesbutton.Location = new System.Drawing.Point(192, 208);
            this.dishesbutton.Name = "dishesbutton";
            this.dishesbutton.Size = new System.Drawing.Size(296, 85);
            this.dishesbutton.TabIndex = 2;
            this.dishesbutton.Text = "Блюда";
            this.dishesbutton.UseVisualStyleBackColor = true;
            this.dishesbutton.Click += new System.EventHandler(this.dishesbutton_Click);
            // 
            // dishcategorybutton
            // 
            this.dishcategorybutton.Location = new System.Drawing.Point(192, 322);
            this.dishcategorybutton.Name = "dishcategorybutton";
            this.dishcategorybutton.Size = new System.Drawing.Size(296, 85);
            this.dishcategorybutton.TabIndex = 3;
            this.dishcategorybutton.Text = "Категория блюд";
            this.dishcategorybutton.UseVisualStyleBackColor = true;
            this.dishcategorybutton.Click += new System.EventHandler(this.dishcategorybutton_Click);
            // 
            // sales_button
            // 
            this.sales_button.Location = new System.Drawing.Point(192, 530);
            this.sales_button.Name = "sales_button";
            this.sales_button.Size = new System.Drawing.Size(296, 85);
            this.sales_button.TabIndex = 4;
            this.sales_button.Text = "Журнал продаж";
            this.sales_button.UseVisualStyleBackColor = true;
            this.sales_button.Click += new System.EventHandler(this.sales_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 85);
            this.button1.TabIndex = 5;
            this.button1.Text = "Отображение данных связанных таблиц";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 689);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sales_button);
            this.Controls.Add(this.dishcategorybutton);
            this.Controls.Add(this.dishesbutton);
            this.Controls.Add(this.waitersbutton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ресторан";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button waitersbutton;
        private System.Windows.Forms.Button dishesbutton;
        private System.Windows.Forms.Button dishcategorybutton;
        private System.Windows.Forms.Button sales_button;
        private System.Windows.Forms.Button button1;
    }
}

