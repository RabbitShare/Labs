namespace Lab6
{
    partial class ElementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElementForm));
            this.table = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распознатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьДиаграммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAquaDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.ColumnHeadersVisible = false;
            this.table.ContextMenuStrip = this.contextMenuStrip1;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowHeadersVisible = false;
            this.table.Size = new System.Drawing.Size(800, 450);
            this.table.TabIndex = 0;
            this.table.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.table_CellBeginEdit);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.очиститьToolStripMenuItem,
            this.распознатьToolStripMenuItem,
            this.построитьДиаграммуToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(198, 70);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // распознатьToolStripMenuItem
            // 
            this.распознатьToolStripMenuItem.Name = "распознатьToolStripMenuItem";
            this.распознатьToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.распознатьToolStripMenuItem.Text = "Распознать";
            this.распознатьToolStripMenuItem.Click += new System.EventHandler(this.распознатьToolStripMenuItem_Click);
            // 
            // построитьДиаграммуToolStripMenuItem
            // 
            this.построитьДиаграммуToolStripMenuItem.Name = "построитьДиаграммуToolStripMenuItem";
            this.построитьДиаграммуToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.построитьДиаграммуToolStripMenuItem.Text = "Построить диаграмму";
            this.построитьДиаграммуToolStripMenuItem.Click += new System.EventHandler(this.построитьДиаграммуToolStripMenuItem_Click);
            // 
            // saveAquaDialog
            // 
            this.saveAquaDialog.DefaultExt = "aqua";
            this.saveAquaDialog.Title = "Сохранение супер таблицы";
            // 
            // ElementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ElementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ElementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ElementForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView table;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem распознатьToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem построитьДиаграммуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveAquaDialog;
    }
}