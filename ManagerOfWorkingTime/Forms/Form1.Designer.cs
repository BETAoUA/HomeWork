namespace ManagerOfWorkingTime
{
    partial class TimeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.импортИзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортИзToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btВыход = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДнямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНеделямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.месячныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годовойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПриложенииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обратаяСвязьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.отчётToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(841, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.toolStripSeparator1,
            this.импортИзToolStripMenuItem,
            this.экспортИзToolStripMenuItem,
            this.toolStripSeparator2,
            this.btВыход});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // импортИзToolStripMenuItem
            // 
            this.импортИзToolStripMenuItem.Name = "импортИзToolStripMenuItem";
            this.импортИзToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.импортИзToolStripMenuItem.Text = "Импорт из ...";
            // 
            // экспортИзToolStripMenuItem
            // 
            this.экспортИзToolStripMenuItem.Name = "экспортИзToolStripMenuItem";
            this.экспортИзToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.экспортИзToolStripMenuItem.Text = "Экспорт из ...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // btВыход
            // 
            this.btВыход.Name = "btВыход";
            this.btВыход.Size = new System.Drawing.Size(152, 22);
            this.btВыход.Text = "Выход";
            this.btВыход.Click += new System.EventHandler(this.btВыход_Click);
            // 
            // отчётToolStripMenuItem
            // 
            this.отчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДнямToolStripMenuItem,
            this.поНеделямToolStripMenuItem,
            this.месячныйToolStripMenuItem,
            this.годовойToolStripMenuItem});
            this.отчётToolStripMenuItem.Name = "отчётToolStripMenuItem";
            this.отчётToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчётToolStripMenuItem.Text = "Отчёт";
            // 
            // поДнямToolStripMenuItem
            // 
            this.поДнямToolStripMenuItem.Name = "поДнямToolStripMenuItem";
            this.поДнямToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.поДнямToolStripMenuItem.Text = "Дневной";
            // 
            // поНеделямToolStripMenuItem
            // 
            this.поНеделямToolStripMenuItem.Name = "поНеделямToolStripMenuItem";
            this.поНеделямToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.поНеделямToolStripMenuItem.Text = "Недельный";
            // 
            // месячныйToolStripMenuItem
            // 
            this.месячныйToolStripMenuItem.Name = "месячныйToolStripMenuItem";
            this.месячныйToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.месячныйToolStripMenuItem.Text = "Месячный";
            // 
            // годовойToolStripMenuItem
            // 
            this.годовойToolStripMenuItem.Name = "годовойToolStripMenuItem";
            this.годовойToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.годовойToolStripMenuItem.Text = "Годовой";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПриложенииToolStripMenuItem,
            this.обратаяСвязьToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПриложенииToolStripMenuItem
            // 
            this.оПриложенииToolStripMenuItem.Name = "оПриложенииToolStripMenuItem";
            this.оПриложенииToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.оПриложенииToolStripMenuItem.Text = "О Приложении";
            this.оПриложенииToolStripMenuItem.Click += new System.EventHandler(this.оПриложенииToolStripMenuItem_Click);
            // 
            // обратаяСвязьToolStripMenuItem
            // 
            this.обратаяСвязьToolStripMenuItem.Name = "обратаяСвязьToolStripMenuItem";
            this.обратаяСвязьToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.обратаяСвязьToolStripMenuItem.Text = "Обратая Связь";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(651, 350);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // TimeManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 517);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TimeManager";
            this.Text = "TimeManager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem импортИзToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортИзToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btВыход;
        private System.Windows.Forms.ToolStripMenuItem отчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДнямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поНеделямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem месячныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годовойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПриложенииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обратаяСвязьToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}

