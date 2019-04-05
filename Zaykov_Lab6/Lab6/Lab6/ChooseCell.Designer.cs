namespace Lab6
{
    partial class ChooseCell
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
            this.row = new System.Windows.Forms.NumericUpDown();
            this.cell = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell)).BeginInit();
            this.SuspendLayout();
            // 
            // row
            // 
            this.row.Location = new System.Drawing.Point(123, 68);
            this.row.Name = "row";
            this.row.Size = new System.Drawing.Size(125, 25);
            this.row.TabIndex = 0;
            this.row.ValueChanged += new System.EventHandler(this.column_ValueChanged);
            // 
            // column
            // 
            this.cell.Location = new System.Drawing.Point(123, 94);
            this.cell.Name = "column";
            this.cell.Size = new System.Drawing.Size(125, 25);
            this.cell.TabIndex = 0;
            this.cell.ValueChanged += new System.EventHandler(this.column_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Столбец";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Записать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChooseCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cell);
            this.Controls.Add(this.row);
            this.Name = "ChooseCell";
            this.Text = "ChooseCell";
            ((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown row;
        private System.Windows.Forms.NumericUpDown cell;
    }
}