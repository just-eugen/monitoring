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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStripMain = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            splitContainerMain = new SplitContainer();
            buttonTeachers = new Button();
            splitContainerChild = new SplitContainer();
            dataGridViewArticles = new DataGridView();
            toolStripArticle = new ToolStrip();
            dataGridViewAuthors = new DataGridView();
            toolStripAuthor = new ToolStrip();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            toolStripLabel1 = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripLabel2 = new ToolStripLabel();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            toolStripButton5 = new ToolStripButton();
            toolStripButton6 = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripTextBox1 = new ToolStripTextBox();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripButton7 = new ToolStripButton();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripTextBox2 = new ToolStripTextBox();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripButton8 = new ToolStripButton();
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
            splitContainerMain.Panel1.Controls.Add(button4);
            splitContainerMain.Panel1.Controls.Add(button3);
            splitContainerMain.Panel1.Controls.Add(button2);
            splitContainerMain.Panel1.Controls.Add(button1);
            splitContainerMain.Panel1.Controls.Add(buttonTeachers);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.Controls.Add(splitContainerChild);
            splitContainerMain.Size = new Size(1427, 610);
            splitContainerMain.SplitterDistance = 302;
            splitContainerMain.TabIndex = 1;
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
            dataGridViewArticles.Location = new Point(0, 35);
            dataGridViewArticles.Name = "dataGridViewArticles";
            dataGridViewArticles.RowTemplate.Height = 25;
            dataGridViewArticles.Size = new Size(1121, 263);
            dataGridViewArticles.TabIndex = 1;
            dataGridViewArticles.SelectionChanged += dataGridViewArticles_SelectionChanged;
            // 
            // toolStripArticle
            // 
            toolStripArticle.AutoSize = false;
            toolStripArticle.BackColor = Color.LightBlue;
            toolStripArticle.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripSeparator1, toolStripSeparator2, toolStripButton1, toolStripButton2, toolStripButton3, toolStripSeparator9, toolStripSeparator10, toolStripTextBox2, toolStripSeparator11, toolStripSeparator12, toolStripButton8 });
            toolStripArticle.Location = new Point(0, 0);
            toolStripArticle.Name = "toolStripArticle";
            toolStripArticle.Size = new Size(1121, 35);
            toolStripArticle.TabIndex = 0;
            toolStripArticle.Text = "toolStrip1";
            // 
            // dataGridViewAuthors
            // 
            dataGridViewAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAuthors.Dock = DockStyle.Fill;
            dataGridViewAuthors.Location = new Point(0, 35);
            dataGridViewAuthors.Name = "dataGridViewAuthors";
            dataGridViewAuthors.RowTemplate.Height = 25;
            dataGridViewAuthors.Size = new Size(1121, 273);
            dataGridViewAuthors.TabIndex = 1;
            // 
            // toolStripAuthor
            // 
            toolStripAuthor.AutoSize = false;
            toolStripAuthor.BackColor = Color.LightBlue;
            toolStripAuthor.Items.AddRange(new ToolStripItem[] { toolStripLabel2, toolStripSeparator3, toolStripSeparator4, toolStripButton4, toolStripButton5, toolStripButton6, toolStripSeparator5, toolStripSeparator6, toolStripTextBox1, toolStripSeparator7, toolStripSeparator8, toolStripButton7 });
            toolStripAuthor.Location = new Point(0, 0);
            toolStripAuthor.Name = "toolStripAuthor";
            toolStripAuthor.Size = new Size(1121, 35);
            toolStripAuthor.TabIndex = 0;
            toolStripAuthor.Text = "toolStrip2";
            // 
            // button1
            // 
            button1.Location = new Point(12, 73);
            button1.Name = "button1";
            button1.Size = new Size(277, 53);
            button1.TabIndex = 1;
            button1.Text = "Научно-исследовательские работы";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 132);
            button2.Name = "button2";
            button2.Size = new Size(277, 53);
            button2.TabIndex = 2;
            button2.Text = "Статьи и материалы конференций";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(12, 191);
            button3.Name = "button3";
            button3.Size = new Size(277, 53);
            button3.TabIndex = 2;
            button3.Text = "Учебники и сборники";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(12, 250);
            button4.Name = "button4";
            button4.Size = new Size(277, 53);
            button4.TabIndex = 3;
            button4.Text = "Дополнительные данные";
            button4.UseVisualStyleBackColor = true;
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
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 32);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 32);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(23, 32);
            toolStripButton3.Text = "toolStripButton3";
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
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(23, 32);
            toolStripButton4.Text = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            toolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton5.Image = (Image)resources.GetObject("toolStripButton5.Image");
            toolStripButton5.ImageTransparentColor = Color.Magenta;
            toolStripButton5.Name = "toolStripButton5";
            toolStripButton5.Size = new Size(23, 32);
            toolStripButton5.Text = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            toolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton6.Image = (Image)resources.GetObject("toolStripButton6.Image");
            toolStripButton6.ImageTransparentColor = Color.Magenta;
            toolStripButton6.Name = "toolStripButton6";
            toolStripButton6.Size = new Size(23, 32);
            toolStripButton6.Text = "toolStripButton6";
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
            // toolStripTextBox1
            // 
            toolStripTextBox1.Margin = new Padding(3);
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 29);
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
            // toolStripButton7
            // 
            toolStripButton7.AutoSize = false;
            toolStripButton7.BackColor = SystemColors.Control;
            toolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton7.Image = (Image)resources.GetObject("toolStripButton7.Image");
            toolStripButton7.ImageTransparentColor = Color.Magenta;
            toolStripButton7.Margin = new Padding(2);
            toolStripButton7.Name = "toolStripButton7";
            toolStripButton7.Size = new Size(46, 25);
            toolStripButton7.Text = "Поиск";
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
            // toolStripTextBox2
            // 
            toolStripTextBox2.Margin = new Padding(3);
            toolStripTextBox2.Name = "toolStripTextBox2";
            toolStripTextBox2.Size = new Size(100, 29);
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
            // toolStripButton8
            // 
            toolStripButton8.AutoSize = false;
            toolStripButton8.BackColor = SystemColors.Control;
            toolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButton8.Image = (Image)resources.GetObject("toolStripButton8.Image");
            toolStripButton8.ImageTransparentColor = Color.Magenta;
            toolStripButton8.Margin = new Padding(2);
            toolStripButton8.Name = "toolStripButton8";
            toolStripButton8.Size = new Size(46, 25);
            toolStripButton8.Text = "Поиск";
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
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripTextBox toolStripTextBox2;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButton8;
        private ToolStripLabel toolStripLabel2;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton7;
    }
}