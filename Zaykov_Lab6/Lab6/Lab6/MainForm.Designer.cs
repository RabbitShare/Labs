namespace Lab6
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveAquaDialog = new System.Windows.Forms.SaveFileDialog();
            this.openAquaDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузыитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вЭксельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вВордToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеОконКаскадомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеОконВертикальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расположениеОконГоризонтальноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заданиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.суммаВыделеныхЯчеекToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.словаНаБуквуАToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveExcelDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveWordDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveAquaDialog
            // 
            this.saveAquaDialog.DefaultExt = "aqua";
            this.saveAquaDialog.Title = "Сохранение супер таблицы";
            // 
            // openAquaDialog
            // 
            this.openAquaDialog.Filter = "Aqua files|*.aqua";
            this.openAquaDialog.Title = "Открытие супер таблиц";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.видToolStripMenuItem,
            this.заданиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.загрузыитьToolStripMenuItem,
            this.вЭксельToolStripMenuItem,
            this.вВордToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Enabled = false;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузыитьToolStripMenuItem
            // 
            this.загрузыитьToolStripMenuItem.Name = "загрузыитьToolStripMenuItem";
            this.загрузыитьToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.загрузыитьToolStripMenuItem.Text = "Загрузить";
            this.загрузыитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // вЭксельToolStripMenuItem
            // 
            this.вЭксельToolStripMenuItem.Enabled = false;
            this.вЭксельToolStripMenuItem.Name = "вЭксельToolStripMenuItem";
            this.вЭксельToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.вЭксельToolStripMenuItem.Text = "Сохранить таблицу в  Excel";
            this.вЭксельToolStripMenuItem.Click += new System.EventHandler(this.вЭксельToolStripMenuItem_Click);
            // 
            // вВордToolStripMenuItem
            // 
            this.вВордToolStripMenuItem.Enabled = false;
            this.вВордToolStripMenuItem.Name = "вВордToolStripMenuItem";
            this.вВордToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.вВордToolStripMenuItem.Text = "Сохранить таблицу в Word";
            this.вВордToolStripMenuItem.Click += new System.EventHandler(this.вВордToolStripMenuItem_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расположениеОконКаскадомToolStripMenuItem,
            this.расположениеОконВертикальноToolStripMenuItem,
            this.расположениеОконГоризонтальноToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // расположениеОконКаскадомToolStripMenuItem
            // 
            this.расположениеОконКаскадомToolStripMenuItem.Name = "расположениеОконКаскадомToolStripMenuItem";
            this.расположениеОконКаскадомToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.расположениеОконКаскадомToolStripMenuItem.Text = "Расположение окон каскадом";
            this.расположениеОконКаскадомToolStripMenuItem.Click += new System.EventHandler(this.CascadeClick);
            // 
            // расположениеОконВертикальноToolStripMenuItem
            // 
            this.расположениеОконВертикальноToolStripMenuItem.Name = "расположениеОконВертикальноToolStripMenuItem";
            this.расположениеОконВертикальноToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.расположениеОконВертикальноToolStripMenuItem.Text = "Расположение окон вертикально";
            this.расположениеОконВертикальноToolStripMenuItem.Click += new System.EventHandler(this.VerticalClick);
            // 
            // расположениеОконГоризонтальноToolStripMenuItem
            // 
            this.расположениеОконГоризонтальноToolStripMenuItem.Name = "расположениеОконГоризонтальноToolStripMenuItem";
            this.расположениеОконГоризонтальноToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.расположениеОконГоризонтальноToolStripMenuItem.Text = "Расположение окон горизонтально";
            this.расположениеОконГоризонтальноToolStripMenuItem.Click += new System.EventHandler(this.HorizontalClick);
            // 
            // заданиеToolStripMenuItem
            // 
            this.заданиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.суммаВыделеныхЯчеекToolStripMenuItem,
            this.словаНаБуквуАToolStripMenuItem});
            this.заданиеToolStripMenuItem.Enabled = false;
            this.заданиеToolStripMenuItem.Name = "заданиеToolStripMenuItem";
            this.заданиеToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.заданиеToolStripMenuItem.Text = "Задание";
            // 
            // суммаВыделеныхЯчеекToolStripMenuItem
            // 
            this.суммаВыделеныхЯчеекToolStripMenuItem.Name = "суммаВыделеныхЯчеекToolStripMenuItem";
            this.суммаВыделеныхЯчеекToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.суммаВыделеныхЯчеекToolStripMenuItem.Text = "Сумма выделеных ячеек";
            this.суммаВыделеныхЯчеекToolStripMenuItem.Click += new System.EventHandler(this.суммаВыделеныхЯчеекToolStripMenuItem_Click);
            // 
            // словаНаБуквуАToolStripMenuItem
            // 
            this.словаНаБуквуАToolStripMenuItem.Name = "словаНаБуквуАToolStripMenuItem";
            this.словаНаБуквуАToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.словаНаБуквуАToolStripMenuItem.Text = "Слова на букву \"А\"";
            this.словаНаБуквуАToolStripMenuItem.Click += new System.EventHandler(this.словаНаБуквуАToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 510);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 51);
            this.panel1.TabIndex = 2;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImage = global::Lab6.Properties.Resources.plus;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button12.Enabled = false;
            this.button12.Location = new System.Drawing.Point(619, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button12, "Сумма чисел");
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.суммаВыделеныхЯчеекToolStripMenuItem_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.BackgroundImage = global::Lab6.Properties.Resources.aa;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button13.Enabled = false;
            this.button13.Location = new System.Drawing.Point(676, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button13, "Записать все слова на букву \"А\"");
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.словаНаБуквуАToolStripMenuItem_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImage = global::Lab6.Properties.Resources.success;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button10.Enabled = false;
            this.button10.Location = new System.Drawing.Point(507, 0);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button10, "Распознать");
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.BackgroundImage = global::Lab6.Properties.Resources.growth;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(563, 0);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button11, "Построить диаграмму");
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::Lab6.Properties.Resources.iconfinder_15_2564785;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(227, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button5, "Сохранит активную таблицу в word");
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.вВордToolStripMenuItem_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImage = global::Lab6.Properties.Resources.rubbish;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(451, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button9, "Очистить");
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::Lab6.Properties.Resources.iconfinder_09_2064824;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(171, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button4, "Сохранить активную таблицу в Excel");
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.вЭксельToolStripMenuItem_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImage = global::Lab6.Properties.Resources.arrowH;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button8.Location = new System.Drawing.Point(395, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button8, "Расположить окна горизонтально");
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.HorizontalClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Lab6.Properties.Resources.page;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(115, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button3, "Загрузить таблицу");
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImage = global::Lab6.Properties.Resources.arrow;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Location = new System.Drawing.Point(339, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button7, "Расположить окна вертикально");
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.VerticalClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Lab6.Properties.Resources.save;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(59, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 50);
            this.button2.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button2, "Сохранить таблицу");
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = global::Lab6.Properties.Resources.iconfinder_cascade_display_layout_stack_sw_view_392519;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button6.Location = new System.Drawing.Point(283, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button6, "Расположить окна каскадом");
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.CascadeClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Lab6.Properties.Resources.edit;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.button1, "Создать таблицу");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Подсказка";
            // 
            // saveExcelDialog
            // 
            this.saveExcelDialog.DefaultExt = "xlsx";
            this.saveExcelDialog.Title = "Сохранение в Эксель";
            // 
            // saveWordDialog
            // 
            this.saveWordDialog.DefaultExt = "docx";
            this.saveWordDialog.Title = "Сохранение в Ворд";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AquaXel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveAquaDialog;
        private System.Windows.Forms.OpenFileDialog openAquaDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расположениеОконКаскадомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расположениеОконВертикальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расположениеОконГоризонтальноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заданиеToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузыитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вЭксельToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вВордToolStripMenuItem;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog saveExcelDialog;
        private System.Windows.Forms.SaveFileDialog saveWordDialog;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.ToolStripMenuItem суммаВыделеныхЯчеекToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem словаНаБуквуАToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}