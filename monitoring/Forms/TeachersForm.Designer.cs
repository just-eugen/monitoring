namespace monitoring.Forms
{
    partial class TeachersForm
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
            splitContainer1 = new SplitContainer();
            dataGridViewPositions = new DataGridView();
            toolStripPositions = new ToolStrip();
            dataGridViewTeachers = new DataGridView();
            toolStripTeachers = new ToolStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewPositions);
            splitContainer1.Panel1.Controls.Add(toolStripPositions);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewTeachers);
            splitContainer1.Panel2.Controls.Add(toolStripTeachers);
            splitContainer1.Size = new Size(1154, 597);
            splitContainer1.SplitterDistance = 311;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewPositions
            // 
            dataGridViewPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositions.Dock = DockStyle.Fill;
            dataGridViewPositions.Location = new Point(0, 25);
            dataGridViewPositions.Name = "dataGridViewPositions";
            dataGridViewPositions.RowTemplate.Height = 25;
            dataGridViewPositions.Size = new Size(311, 572);
            dataGridViewPositions.TabIndex = 1;
            dataGridViewPositions.SelectionChanged += dataGridViewPositions_SelectionChanged;
            // 
            // toolStripPositions
            // 
            toolStripPositions.Location = new Point(0, 0);
            toolStripPositions.Name = "toolStripPositions";
            toolStripPositions.Size = new Size(311, 25);
            toolStripPositions.TabIndex = 0;
            toolStripPositions.Text = "toolStrip1";
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Dock = DockStyle.Fill;
            dataGridViewTeachers.Location = new Point(0, 25);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewTeachers.RowTemplate.Height = 25;
            dataGridViewTeachers.Size = new Size(839, 572);
            dataGridViewTeachers.TabIndex = 1;
            // 
            // toolStripTeachers
            // 
            toolStripTeachers.Location = new Point(0, 0);
            toolStripTeachers.Name = "toolStripTeachers";
            toolStripTeachers.Size = new Size(839, 25);
            toolStripTeachers.TabIndex = 0;
            toolStripTeachers.Text = "toolStrip2";
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 597);
            Controls.Add(splitContainer1);
            Name = "TeachersForm";
            Text = "Сотрудники и учащиеся учебных заведений";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewPositions;
        private ToolStrip toolStripPositions;
        private DataGridView dataGridViewTeachers;
        private ToolStrip toolStripTeachers;
    }
}