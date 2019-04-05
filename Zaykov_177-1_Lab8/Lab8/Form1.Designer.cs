namespace Lab8
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
            this.components = new System.ComponentModel.Container();
            this.modBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.двигатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.неДвигатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.modBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // modHeight
            // 
            this.modBox.Location = new System.Drawing.Point(149, 38);
            this.modBox.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.modBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modBox.Name = "modHeight";
            this.modBox.Size = new System.Drawing.Size(120, 20);
            this.modBox.TabIndex = 0;
            this.modBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.modBox.ValueChanged += new System.EventHandler(this.numeric_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Модификатор";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Location = new System.Drawing.Point(69, 116);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(788, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(788, 487);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.двигатьToolStripMenuItem,
            this.неДвигатьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // двигатьToolStripMenuItem
            // 
            this.двигатьToolStripMenuItem.Name = "двигатьToolStripMenuItem";
            this.двигатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.двигатьToolStripMenuItem.Text = "Двигать";
            this.двигатьToolStripMenuItem.Click += new System.EventHandler(this.двигатьToolStripMenuItem_Click);
            // 
            // неДвигатьToolStripMenuItem
            // 
            this.неДвигатьToolStripMenuItem.Enabled = false;
            this.неДвигатьToolStripMenuItem.Name = "неДвигатьToolStripMenuItem";
            this.неДвигатьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.неДвигатьToolStripMenuItem.Text = "Не двигать";
            this.неДвигатьToolStripMenuItem.Click += new System.EventHandler(this.неДвигатьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 654);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modBox);
            this.MinimumSize = new System.Drawing.Size(960, 654);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.modBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown modBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem двигатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem неДвигатьToolStripMenuItem;
    }
}

