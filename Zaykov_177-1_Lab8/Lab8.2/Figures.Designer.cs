namespace Lab8._2
{
    partial class Figures
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
            this.comboFigure = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboPen = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид фигуры";
            // 
            // comboFigure
            // 
            this.comboFigure.FormattingEnabled = true;
            this.comboFigure.Items.AddRange(new object[] {
            "Круг",
            "Элипс",
            "Сектор",
            "Треугольник",
            "Прямоугольник",
            "Многоугольник"});
            this.comboFigure.Location = new System.Drawing.Point(257, 46);
            this.comboFigure.Name = "comboFigure";
            this.comboFigure.Size = new System.Drawing.Size(240, 21);
            this.comboFigure.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цвет заливки";
            // 
            // comboColor
            // 
            this.comboColor.FormattingEnabled = true;
            this.comboColor.Location = new System.Drawing.Point(257, 73);
            this.comboColor.Name = "comboColor";
            this.comboColor.Size = new System.Drawing.Size(240, 21);
            this.comboColor.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Вид кисти";
            // 
            // comboPen
            // 
            this.comboPen.FormattingEnabled = true;
            this.comboPen.Items.AddRange(new object[] {
            "Обычная",
            "Текстурированная",
            "Градиентная"});
            this.comboPen.Location = new System.Drawing.Point(257, 100);
            this.comboPen.Name = "comboPen";
            this.comboPen.Size = new System.Drawing.Size(240, 21);
            this.comboPen.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(134, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(432, 471);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Figures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboPen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboFigure);
            this.Controls.Add(this.label1);
            this.Name = "Figures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFigure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboPen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

