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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            menuStripMain = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            splitContainerMain = new SplitContainer();
            buttonOther = new Button();
            buttonStudyBooks = new Button();
            buttonArticles = new Button();
            buttonVolumes = new Button();
            buttonTeachers = new Button();
            splitContainerChild = new SplitContainer();
            dataGridViewArticles = new DataGridView();
            toolStripArticle = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButtonAddArticle = new ToolStripButton();
            toolStripButtonEditArticle = new ToolStripButton();
            toolStripButtonDeleteArticle = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripTextBoxSearchArticle = new ToolStripTextBox();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripButtonSearchArticle = new ToolStripButton();
            dataGridViewAuthors = new DataGridView();
            toolStripAuthor = new ToolStrip();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButtonAddAuthor = new ToolStripButton();
            toolStripButtonEditAuthor = new ToolStripButton();
            toolStripButtonDeleteAuthor = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripTextBoxSearchAuthor = new ToolStripTextBox();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButtonSearchAuthor = new ToolStripButton();
            menuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerChild).BeginInit();
            splitContainerChild.Panel1.SuspendLayout();
            splitContainerChild.Panel2.SuspendLayout();
            splitContainerChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).BeginInit();
            toolStripArticle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).BeginInit();
            toolStripAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem });
            menuStripMain.Location = new Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Size = new Size(1427, 24);
            menuStripMain.TabIndex = 0;
            menuStripMain.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
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
            splitContainerMain.Panel1.Controls.Add(buttonOther);
            splitContainerMain.Panel1.Controls.Add(buttonStudyBooks);
            splitContainerMain.Panel1.Controls.Add(buttonArticles);
            splitContainerMain.Panel1.Controls.Add(buttonVolumes);
            splitContainerMain.Panel1.Controls.Add(buttonTeachers);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerChild);
            splitContainerMain.Size = new Size(1427, 610);
            splitContainerMain.SplitterDistance = 302;
            splitContainerMain.TabIndex = 1;
            // 
            // buttonOther
            // 
            buttonOther.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonOther.Location = new Point(12, 250);
            buttonOther.Name = "buttonOther";
            buttonOther.Size = new Size(277, 53);
            buttonOther.TabIndex = 3;
            buttonOther.Text = "Дополнительные данные";
            buttonOther.UseVisualStyleBackColor = true;
            // 
            // buttonStudyBooks
            // 
            buttonStudyBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonStudyBooks.Location = new Point(12, 191);
            buttonStudyBooks.Name = "buttonStudyBooks";
            buttonStudyBooks.Size = new Size(277, 53);
            buttonStudyBooks.TabIndex = 2;
            buttonStudyBooks.Text = "Учебники и сборники";
            buttonStudyBooks.UseVisualStyleBackColor = true;
            // 
            // buttonArticles
            // 
            buttonArticles.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonArticles.Location = new Point(12, 132);
            buttonArticles.Name = "buttonArticles";
            buttonArticles.Size = new Size(277, 53);
            buttonArticles.TabIndex = 2;
            buttonArticles.Text = "Статьи и материалы конференций";
            buttonArticles.UseVisualStyleBackColor = true;
            // 
            // buttonVolumes
            // 
            buttonVolumes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonVolumes.Location = new Point(12, 73);
            buttonVolumes.Name = "buttonVolumes";
            buttonVolumes.Size = new Size(277, 53);
            buttonVolumes.TabIndex = 1;
            buttonVolumes.Text = "Научно-исследовательские работы";
            buttonVolumes.UseVisualStyleBackColor = true;
            // 
            // buttonTeachers
            // 
            buttonTeachers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonTeachers.Location = new Point(12, 14);
            buttonTeachers.Name = "buttonTeachers";
            buttonTeachers.Size = new Size(277, 53);
            buttonTeachers.TabIndex = 0;
            buttonTeachers.Text = "Сотрудники и студенты учебных заведений";
            buttonTeachers.UseVisualStyleBackColor = true;
            buttonTeachers.Click += buttonTeachers_Click;
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
            dataGridViewArticles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewArticles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewArticles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewArticles.Dock = DockStyle.Fill;
            dataGridViewArticles.ImeMode = ImeMode.NoControl;
            dataGridViewArticles.Location = new Point(0, 35);
            dataGridViewArticles.Name = "dataGridViewArticles";
            dataGridViewArticles.ReadOnly = true;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewArticles.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewArticles.RowTemplate.Height = 25;
            dataGridViewArticles.Size = new Size(1121, 263);
            dataGridViewArticles.TabIndex = 1;
            dataGridViewArticles.SelectionChanged += dataGridViewArticles_SelectionChanged;
            // 
            // toolStripArticle
            // 
            toolStripArticle.AutoSize = false;
            toolStripArticle.BackColor = Color.LightBlue;
            toolStripArticle.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripSeparator2, toolStripButtonAddArticle, toolStripButtonEditArticle, toolStripButtonDeleteArticle, toolStripSeparator9, toolStripSeparator10, toolStripTextBoxSearchArticle, toolStripSeparator11, toolStripSeparator12, toolStripButtonSearchArticle });
            toolStripArticle.Location = new Point(0, 0);
            toolStripArticle.Name = "toolStripArticle";
            toolStripArticle.Size = new Size(1121, 35);
            toolStripArticle.TabIndex = 0;
            toolStripArticle.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(44, 32);
            toolStripLabel1.Text = "Статьи";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // toolStripButtonAddArticle
            // 
            toolStripButtonAddArticle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddArticle.Image = (Image)resources.GetObject("toolStripButtonAddArticle.Image");
            toolStripButtonAddArticle.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddArticle.Name = "toolStripButtonAddArticle";
            toolStripButtonAddArticle.Size = new Size(23, 32);
            toolStripButtonAddArticle.Text = "toolStripButtonAddArticle";
            toolStripButtonAddArticle.ToolTipText = "Добавить";
            // 
            // toolStripButtonEditArticle
            // 
            toolStripButtonEditArticle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditArticle.Image = (Image)resources.GetObject("toolStripButtonEditArticle.Image");
            toolStripButtonEditArticle.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditArticle.Name = "toolStripButtonEditArticle";
            toolStripButtonEditArticle.Size = new Size(23, 32);
            toolStripButtonEditArticle.Text = "toolStripButtonEditArticle";
            toolStripButtonEditArticle.ToolTipText = "Редактировать";
            // 
            // toolStripButtonDeleteArticle
            // 
            toolStripButtonDeleteArticle.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteArticle.Image = (Image)resources.GetObject("toolStripButtonDeleteArticle.Image");
            toolStripButtonDeleteArticle.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteArticle.Name = "toolStripButtonDeleteArticle";
            toolStripButtonDeleteArticle.Size = new Size(23, 32);
            toolStripButtonDeleteArticle.Text = "toolStripButtonDeleteArticle";
            toolStripButtonDeleteArticle.ToolTipText = "Удалить";
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 35);
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 35);
            // 
            // toolStripTextBoxSearchArticle
            // 
            toolStripTextBoxSearchArticle.Margin = new Padding(3);
            toolStripTextBoxSearchArticle.Name = "toolStripTextBoxSearchArticle";
            toolStripTextBoxSearchArticle.Size = new Size(100, 29);
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 35);
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 35);
            // 
            // toolStripButtonSearchArticle
            // 
            toolStripButtonSearchArticle.AutoSize = false;
            toolStripButtonSearchArticle.BackColor = SystemColors.Control;
            toolStripButtonSearchArticle.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchArticle.Image = (Image)resources.GetObject("toolStripButtonSearchArticle.Image");
            toolStripButtonSearchArticle.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchArticle.Margin = new Padding(2);
            toolStripButtonSearchArticle.Name = "toolStripButtonSearchArticle";
            toolStripButtonSearchArticle.Size = new Size(46, 25);
            toolStripButtonSearchArticle.Text = "Поиск";
            // 
            // dataGridViewAuthors
            // 
            dataGridViewAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewAuthors.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthors.Dock = DockStyle.Fill;
            dataGridViewAuthors.Location = new Point(0, 35);
            dataGridViewAuthors.Name = "dataGridViewAuthors";
            dataGridViewAuthors.ReadOnly = true;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewAuthors.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewAuthors.RowTemplate.Height = 25;
            dataGridViewAuthors.Size = new Size(1121, 273);
            dataGridViewAuthors.TabIndex = 1;
            // 
            // toolStripAuthor
            // 
            toolStripAuthor.AutoSize = false;
            toolStripAuthor.BackColor = Color.LightBlue;
            toolStripAuthor.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripSeparator3, toolStripSeparator4, toolStripButtonAddAuthor, toolStripButtonEditAuthor, toolStripButtonDeleteAuthor, toolStripSeparator5, toolStripSeparator6, toolStripTextBoxSearchAuthor, toolStripSeparator7, toolStripSeparator8, toolStripButtonSearchAuthor });
            toolStripAuthor.Location = new Point(0, 0);
            toolStripAuthor.Name = "toolStripAuthor";
            toolStripAuthor.Size = new Size(1121, 35);
            toolStripAuthor.TabIndex = 0;
            toolStripAuthor.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            toolStripLabel2.Name = "toolStripLabel2";
            toolStripLabel2.Size = new Size(49, 32);
            toolStripLabel2.Text = "Авторы";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 35);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 35);
            // 
            // toolStripButtonAddAuthor
            // 
            toolStripButtonAddAuthor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddAuthor.Image = (Image)resources.GetObject("toolStripButtonAddAuthor.Image");
            toolStripButtonAddAuthor.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddAuthor.Name = "toolStripButtonAddAuthor";
            toolStripButtonAddAuthor.Size = new Size(23, 32);
            toolStripButtonAddAuthor.Text = "toolStripButtonAddAuthor";
            toolStripButtonAddAuthor.ToolTipText = "Добавить";
            // 
            // toolStripButtonEditAuthor
            // 
            toolStripButtonEditAuthor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditAuthor.Image = (Image)resources.GetObject("toolStripButtonEditAuthor.Image");
            toolStripButtonEditAuthor.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditAuthor.Name = "toolStripButtonEditAuthor";
            toolStripButtonEditAuthor.Size = new Size(23, 32);
            toolStripButtonEditAuthor.Text = "toolStripButtonEditAuthor";
            toolStripButtonEditAuthor.ToolTipText = "Редактировать";
            // 
            // toolStripButtonDeleteAuthor
            // 
            toolStripButtonDeleteAuthor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteAuthor.Image = (Image)resources.GetObject("toolStripButtonDeleteAuthor.Image");
            toolStripButtonDeleteAuthor.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteAuthor.Name = "toolStripButtonDeleteAuthor";
            toolStripButtonDeleteAuthor.Size = new Size(23, 32);
            toolStripButtonDeleteAuthor.Text = "toolStripButtonDeleteAuthor";
            toolStripButtonDeleteAuthor.ToolTipText = "Удалить";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 35);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 35);
            // 
            // toolStripTextBoxSearchAuthor
            // 
            toolStripTextBoxSearchAuthor.Margin = new Padding(3);
            toolStripTextBoxSearchAuthor.Name = "toolStripTextBoxSearchAuthor";
            toolStripTextBoxSearchAuthor.Size = new Size(100, 29);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 35);
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 35);
            // 
            // toolStripButtonSearchAuthor
            // 
            toolStripButtonSearchAuthor.AutoSize = false;
            toolStripButtonSearchAuthor.BackColor = SystemColors.Control;
            toolStripButtonSearchAuthor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchAuthor.Image = (Image)resources.GetObject("toolStripButtonSearchAuthor.Image");
            toolStripButtonSearchAuthor.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchAuthor.Margin = new Padding(2);
            toolStripButtonSearchAuthor.Name = "toolStripButtonSearchAuthor";
            toolStripButtonSearchAuthor.Size = new Size(46, 25);
            toolStripButtonSearchAuthor.Text = "Поиск";
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
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            splitContainerChild.Panel1.ResumeLayout(false);
            splitContainerChild.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerChild).EndInit();
            splitContainerChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewArticles).EndInit();
            toolStripArticle.ResumeLayout(false);
            toolStripArticle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAuthors).EndInit();
            toolStripAuthor.ResumeLayout(false);
            toolStripAuthor.PerformLayout();
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
        private ToolStripMenuItem выходToolStripMenuItem;
        private Button buttonOther;
        private Button buttonStudyBooks;
        private Button buttonArticles;
        private Button buttonVolumes;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButtonAddArticle;
        private ToolStripButton toolStripButtonEditArticle;
        private ToolStripButton toolStripButtonDeleteArticle;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripTextBox toolStripTextBoxSearchArticle;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButtonSearchArticle;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButtonAddAuthor;
        private ToolStripButton toolStripButtonEditAuthor;
        private ToolStripButton toolStripButtonDeleteAuthor;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripTextBox toolStripTextBoxSearchAuthor;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButtonSearchAuthor;
    }
}