namespace бд3
{
    partial class Scienceworks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Work_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Autorsbutton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьОбразованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМестоРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИздательствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьUDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOI,
            this.Work_name,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 449);
            this.dataGridView1.TabIndex = 1;
            // 
            // DOI
            // 
            this.DOI.HeaderText = "DOI";
            this.DOI.MinimumWidth = 6;
            this.DOI.Name = "DOI";
            this.DOI.ReadOnly = true;
            this.DOI.Width = 125;
            // 
            // Work_name
            // 
            this.Work_name.HeaderText = "Work name";
            this.Work_name.MinimumWidth = 6;
            this.Work_name.Name = "Work_name";
            this.Work_name.ReadOnly = true;
            this.Work_name.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Publication date";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pages";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "UDK";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Publisher";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(12, 499);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(150, 29);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Добавить работу";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Autorsbutton
            // 
            this.Autorsbutton.Location = new System.Drawing.Point(914, 499);
            this.Autorsbutton.Name = "Autorsbutton";
            this.Autorsbutton.Size = new System.Drawing.Size(150, 29);
            this.Autorsbutton.TabIndex = 4;
            this.Autorsbutton.Text = "Авторы";
            this.Autorsbutton.UseVisualStyleBackColor = true;
            this.Autorsbutton.Click += new System.EventHandler(this.Autorsbutton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(168, 499);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(150, 29);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Удалить работу";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОбразованиеToolStripMenuItem,
            this.добавитьМестоРаботыToolStripMenuItem,
            this.добавитьИздательствоToolStripMenuItem,
            this.добавитьUDKToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // добавитьОбразованиеToolStripMenuItem
            // 
            this.добавитьОбразованиеToolStripMenuItem.Name = "добавитьОбразованиеToolStripMenuItem";
            this.добавитьОбразованиеToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.добавитьОбразованиеToolStripMenuItem.Text = "Научная степень";
            this.добавитьОбразованиеToolStripMenuItem.Click += new System.EventHandler(this.добавитьОбразованиеToolStripMenuItem_Click);
            // 
            // добавитьМестоРаботыToolStripMenuItem
            // 
            this.добавитьМестоРаботыToolStripMenuItem.Name = "добавитьМестоРаботыToolStripMenuItem";
            this.добавитьМестоРаботыToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.добавитьМестоРаботыToolStripMenuItem.Text = "Место работы";
            this.добавитьМестоРаботыToolStripMenuItem.Click += new System.EventHandler(this.добавитьМестоРаботыToolStripMenuItem_Click);
            // 
            // добавитьИздательствоToolStripMenuItem
            // 
            this.добавитьИздательствоToolStripMenuItem.Name = "добавитьИздательствоToolStripMenuItem";
            this.добавитьИздательствоToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.добавитьИздательствоToolStripMenuItem.Text = "Издательство";
            this.добавитьИздательствоToolStripMenuItem.Click += new System.EventHandler(this.добавитьИздательствоToolStripMenuItem_Click);
            // 
            // добавитьUDKToolStripMenuItem
            // 
            this.добавитьUDKToolStripMenuItem.Name = "добавитьUDKToolStripMenuItem";
            this.добавитьUDKToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.добавитьUDKToolStripMenuItem.Text = "UDK";
            this.добавитьUDKToolStripMenuItem.Click += new System.EventHandler(this.добавитьUDKToolStripMenuItem_Click);
            // 
            // Scienceworks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 540);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Autorsbutton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Scienceworks";
            this.Text = "Science works";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn DOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Work_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button Autorsbutton;
        private System.Windows.Forms.Button DeleteButton;
        public System.Windows.Forms.Button Addbutton;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьОбразованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМестоРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИздательствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьUDKToolStripMenuItem;
    }
}

