namespace monitoring
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripMain = new MenuStrip();
            splitContainerMain = new SplitContainer();
            splitContainerChild = new SplitContainer();
            dataGridViewArticles = new DataGridView();
            toolStripArticle = new ToolStrip();
            dataGridViewAuthors = new DataGridView();
            toolStripAuthor = new ToolStrip();
            buttonTeachers = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChild).BeginInit();
            splitContainerChild.Panel1.SuspendLayout();
            splitContainerChild.Panel2.SuspendLayout();
            splitContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).BeginInit();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1427, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 24);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.BackColor = SystemColors.ControlDark;
            splitContainerMain.Panel1.Controls.Add(buttonTeachers);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerChild);
            splitContainerMain.Size = new Size(1427, 610);
            splitContainerMain.SplitterDistance = 302;
            splitContainerMain.TabIndex = 1;
            // 
            // splitContainerChild
            // 
            splitContainerChild.Dock = DockStyle.Fill;
            splitContainerChild.Location = new Point(0, 0);
            splitContainerChild.Name = "splitContainerChild";
            splitContainerChild.Orientation = Orientation.Horizontal;
            // 
            // splitContainerChild.Panel1
            // 
            splitContainerChild.Panel1.Controls.Add(dataGridViewArticles);
            splitContainerChild.Panel1.Controls.Add(toolStripArticle);
            // 
            // splitContainerChild.Panel2
            // 
            splitContainerChild.Panel2.Controls.Add(dataGridViewAuthors);
            splitContainerChild.Panel2.Controls.Add(toolStripAuthor);
            splitContainerChild.Size = new Size(1121, 610);
            splitContainerChild.SplitterDistance = 298;
            splitContainerChild.TabIndex = 0;
            // 
            // dataGridViewArticles
            // 
            dataGridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArticles.Dock = DockStyle.Fill;
            dataGridViewArticles.ImeMode = ImeMode.NoControl;
            dataGridViewArticles.Location = new Point(0, 25);
            dataGridViewArticles.Name = "dataGridViewArticles";
            dataGridViewArticles.RowTemplate.Height = 25;
            dataGridViewArticles.Size = new Size(1121, 273);
            dataGridViewArticles.TabIndex = 1;
            // 
            // toolStripArticle
            // 
            toolStripArticle.Location = new Point(0, 0);
            toolStripArticle.Name = "toolStripArticle";
            toolStripArticle.Size = new Size(1121, 25);
            toolStripArticle.TabIndex = 0;
            toolStripArticle.Text = "toolStrip1";
            // 
            // dataGridViewAuthors
            // 
            dataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthors.Dock = DockStyle.Fill;
            dataGridViewAuthors.Location = new Point(0, 25);
            dataGridViewAuthors.Name = "dataGridViewAuthors";
            dataGridViewAuthors.RowTemplate.Height = 25;
            dataGridViewAuthors.Size = new Size(1121, 283);
            dataGridViewAuthors.TabIndex = 1;
            // 
            // toolStripAuthor
            // 
            toolStripAuthor.Location = new Point(0, 0);
            toolStripAuthor.Name = "toolStripAuthor";
            toolStripAuthor.Size = new Size(1121, 25);
            toolStripAuthor.TabIndex = 0;
            toolStripAuthor.Text = "toolStrip2";
            // 
            // buttonTeachers
            // 
            buttonTeachers.Location = new Point(12, 14);
            buttonTeachers.Name = "buttonTeachers";
            buttonTeachers.Size = new Size(277, 53);
            buttonTeachers.TabIndex = 0;
            buttonTeachers.Text = "Сотрудники и студенты учебных заведений";
            buttonTeachers.UseVisualStyleBackColor = true;
            buttonTeachers.Click += buttonTeachers_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 634);
            Controls.Add(splitContainerMain);
            Controls.Add(menuStripMain);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Мониторинг";
            Load += MainForm_Load;
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            splitContainerChild.Panel1.ResumeLayout(false);
            splitContainerChild.Panel1.PerformLayout();
            splitContainerChild.Panel2.ResumeLayout(false);
            splitContainerChild.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChild).EndInit();
            splitContainerChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMain;
        private SplitContainer splitContainerMain;
        private SplitContainer splitContainerChild;
        private DataGridView dataGridViewArticles;
        private ToolStrip toolStripArticle;
        private DataGridView dataGridViewAuthors;
        private ToolStrip toolStripAuthor;
        private Button buttonTeachers;
    }
}