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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeachersForm));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            dataGridViewPositions = new DataGridView();
            toolStripPositions = new ToolStrip();
            toolStripButtonAddPos = new ToolStripButton();
            toolStripButtonEditPos = new ToolStripButton();
            toolStripButtonDelPos = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripTextBoxFilterPos = new ToolStripTextBox();
            toolStripSeparator12 = new ToolStripSeparator();
            toolStripSeparator11 = new ToolStripSeparator();
            toolStripButtonSearchPos = new ToolStripButton();
            splitContainer2 = new SplitContainer();
            dataGridViewTeachers = new DataGridView();
            toolStripTeachers = new ToolStrip();
            toolStripLabelTeacher = new ToolStripLabel();
            toolStripSeparator8 = new ToolStripSeparator();
            toolStripSeparator7 = new ToolStripSeparator();
            toolStripButtonAddTeacher = new ToolStripButton();
            toolStripButtonEditTeacher = new ToolStripButton();
            toolStripButtonDeleteTeacher = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            toolStripTextBoxFilterTeacher = new ToolStripTextBox();
            toolStripSeparator13 = new ToolStripSeparator();
            toolStripSeparator14 = new ToolStripSeparator();
            toolStripButtonSearchTeacher = new ToolStripButton();
            dataGridViewExperiences = new DataGridView();
            toolStripExperiences = new ToolStrip();
            toolStripLabelExp = new ToolStripLabel();
            toolStripSeparator10 = new ToolStripSeparator();
            toolStripSeparator9 = new ToolStripSeparator();
            toolStripButtonAddExp = new ToolStripButton();
            toolStripButtonEditExp = new ToolStripButton();
            toolStripButtonDelExp = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            toolStripTextBoxFilterExp = new ToolStripTextBox();
            toolStripSeparator15 = new ToolStripSeparator();
            toolStripSeparator16 = new ToolStripSeparator();
            toolStripButtonSearchExp = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).BeginInit();
            toolStripPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).BeginInit();
            toolStripTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExperiences).BeginInit();
            toolStripExperiences.SuspendLayout();
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
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1154, 597);
            splitContainer1.SplitterDistance = 306;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridViewPositions
            // 
            dataGridViewPositions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewPositions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewPositions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPositions.Dock = DockStyle.Fill;
            dataGridViewPositions.Location = new Point(0, 35);
            dataGridViewPositions.Name = "dataGridViewPositions";
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewPositions.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewPositions.RowTemplate.Height = 25;
            dataGridViewPositions.Size = new Size(306, 562);
            dataGridViewPositions.TabIndex = 1;
            dataGridViewPositions.SelectionChanged += dataGridViewPositions_SelectionChanged;
            // 
            // toolStripPositions
            // 
            toolStripPositions.AutoSize = false;
            toolStripPositions.BackColor = Color.LightBlue;
            toolStripPositions.Items.AddRange(new ToolStripItem[] { toolStripButtonAddPos, toolStripButtonEditPos, toolStripButtonDelPos, toolStripSeparator1, toolStripSeparator2, toolStripTextBoxFilterPos, toolStripSeparator12, toolStripSeparator11, toolStripButtonSearchPos });
            toolStripPositions.Location = new Point(0, 0);
            toolStripPositions.Name = "toolStripPositions";
            toolStripPositions.Size = new Size(306, 35);
            toolStripPositions.TabIndex = 0;
            toolStripPositions.Text = "toolStrip1";
            // 
            // toolStripButtonAddPos
            // 
            toolStripButtonAddPos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddPos.Image = (Image)resources.GetObject("toolStripButtonAddPos.Image");
            toolStripButtonAddPos.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddPos.Name = "toolStripButtonAddPos";
            toolStripButtonAddPos.Size = new Size(23, 32);
            toolStripButtonAddPos.Text = "toolStripButtonAddPos";
            toolStripButtonAddPos.ToolTipText = "Добавить";
            toolStripButtonAddPos.Click += toolStripButtonAddPos_Click;
            // 
            // toolStripButtonEditPos
            // 
            toolStripButtonEditPos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditPos.Image = (Image)resources.GetObject("toolStripButtonEditPos.Image");
            toolStripButtonEditPos.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditPos.Name = "toolStripButtonEditPos";
            toolStripButtonEditPos.Size = new Size(23, 32);
            toolStripButtonEditPos.Text = "toolStripButtonEditPos";
            toolStripButtonEditPos.ToolTipText = "Редактировать";
            toolStripButtonEditPos.Click += toolStripButtonEditPos_Click;
            // 
            // toolStripButtonDelPos
            // 
            toolStripButtonDelPos.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelPos.Image = (Image)resources.GetObject("toolStripButtonDelPos.Image");
            toolStripButtonDelPos.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelPos.Name = "toolStripButtonDelPos";
            toolStripButtonDelPos.Size = new Size(23, 32);
            toolStripButtonDelPos.Text = "toolStripButtonDelPos";
            toolStripButtonDelPos.ToolTipText = "Удалить";
            toolStripButtonDelPos.Click += toolStripButtonDelPos_Click;
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
            // toolStripTextBoxFilterPos
            // 
            toolStripTextBoxFilterPos.Margin = new Padding(3);
            toolStripTextBoxFilterPos.Name = "toolStripTextBoxFilterPos";
            toolStripTextBoxFilterPos.Size = new Size(100, 29);
            // 
            // toolStripSeparator12
            // 
            toolStripSeparator12.Name = "toolStripSeparator12";
            toolStripSeparator12.Size = new Size(6, 35);
            // 
            // toolStripSeparator11
            // 
            toolStripSeparator11.Name = "toolStripSeparator11";
            toolStripSeparator11.Size = new Size(6, 35);
            // 
            // toolStripButtonSearchPos
            // 
            toolStripButtonSearchPos.AutoSize = false;
            toolStripButtonSearchPos.BackColor = SystemColors.Control;
            toolStripButtonSearchPos.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchPos.Image = (Image)resources.GetObject("toolStripButtonSearchPos.Image");
            toolStripButtonSearchPos.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchPos.Margin = new Padding(2);
            toolStripButtonSearchPos.Name = "toolStripButtonSearchPos";
            toolStripButtonSearchPos.Size = new Size(46, 25);
            toolStripButtonSearchPos.Text = "Поиск";
            toolStripButtonSearchPos.ToolTipText = "Поиск";
            toolStripButtonSearchPos.Click += toolStripButtonSearch_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridViewTeachers);
            splitContainer2.Panel1.Controls.Add(toolStripTeachers);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dataGridViewExperiences);
            splitContainer2.Panel2.Controls.Add(toolStripExperiences);
            splitContainer2.Size = new Size(844, 597);
            splitContainer2.SplitterDistance = 293;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridViewTeachers
            // 
            dataGridViewTeachers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewTeachers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTeachers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTeachers.Dock = DockStyle.Fill;
            dataGridViewTeachers.Location = new Point(0, 35);
            dataGridViewTeachers.Name = "dataGridViewTeachers";
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewTeachers.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTeachers.RowTemplate.Height = 25;
            dataGridViewTeachers.Size = new Size(844, 258);
            dataGridViewTeachers.TabIndex = 1;
            dataGridViewTeachers.SelectionChanged += dataGridViewTeachers_SelectionChanged;
            // 
            // toolStripTeachers
            // 
            toolStripTeachers.AutoSize = false;
            toolStripTeachers.BackColor = Color.LightBlue;
            toolStripTeachers.Items.AddRange(new ToolStripItem[] { toolStripLabelTeacher, toolStripSeparator8, toolStripSeparator7, toolStripButtonAddTeacher, toolStripButtonEditTeacher, toolStripButtonDeleteTeacher, toolStripSeparator5, toolStripSeparator6, toolStripTextBoxFilterTeacher, toolStripSeparator13, toolStripSeparator14, toolStripButtonSearchTeacher });
            toolStripTeachers.Location = new Point(0, 0);
            toolStripTeachers.Name = "toolStripTeachers";
            toolStripTeachers.Size = new Size(844, 35);
            toolStripTeachers.TabIndex = 0;
            toolStripTeachers.Text = "toolStripTeacher";
            // 
            // toolStripLabelTeacher
            // 
            toolStripLabelTeacher.Name = "toolStripLabelTeacher";
            toolStripLabelTeacher.Size = new Size(73, 32);
            toolStripLabelTeacher.Text = "Сотрудники";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 35);
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 35);
            // 
            // toolStripButtonAddTeacher
            // 
            toolStripButtonAddTeacher.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddTeacher.Image = (Image)resources.GetObject("toolStripButtonAddTeacher.Image");
            toolStripButtonAddTeacher.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddTeacher.Name = "toolStripButtonAddTeacher";
            toolStripButtonAddTeacher.Size = new Size(23, 32);
            toolStripButtonAddTeacher.Text = "toolStripButtonAddTeacher";
            toolStripButtonAddTeacher.ToolTipText = "Добавить";
            toolStripButtonAddTeacher.Click += toolStripButtonAddTeacher_Click;
            // 
            // toolStripButtonEditTeacher
            // 
            toolStripButtonEditTeacher.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditTeacher.Image = (Image)resources.GetObject("toolStripButtonEditTeacher.Image");
            toolStripButtonEditTeacher.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditTeacher.Name = "toolStripButtonEditTeacher";
            toolStripButtonEditTeacher.Size = new Size(23, 32);
            toolStripButtonEditTeacher.Text = "toolStripButtonEditTeacher";
            toolStripButtonEditTeacher.ToolTipText = "Редактировать";
            // 
            // toolStripButtonDeleteTeacher
            // 
            toolStripButtonDeleteTeacher.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDeleteTeacher.Image = (Image)resources.GetObject("toolStripButtonDeleteTeacher.Image");
            toolStripButtonDeleteTeacher.ImageTransparentColor = Color.Magenta;
            toolStripButtonDeleteTeacher.Name = "toolStripButtonDeleteTeacher";
            toolStripButtonDeleteTeacher.Size = new Size(23, 32);
            toolStripButtonDeleteTeacher.Text = "toolStripButtonDeleteTeacher";
            toolStripButtonDeleteTeacher.ToolTipText = "Удалить";
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
            // toolStripTextBoxFilterTeacher
            // 
            toolStripTextBoxFilterTeacher.Margin = new Padding(3);
            toolStripTextBoxFilterTeacher.Name = "toolStripTextBoxFilterTeacher";
            toolStripTextBoxFilterTeacher.Size = new Size(100, 29);
            // 
            // toolStripSeparator13
            // 
            toolStripSeparator13.Name = "toolStripSeparator13";
            toolStripSeparator13.Size = new Size(6, 35);
            // 
            // toolStripSeparator14
            // 
            toolStripSeparator14.Name = "toolStripSeparator14";
            toolStripSeparator14.Size = new Size(6, 35);
            // 
            // toolStripButtonSearchTeacher
            // 
            toolStripButtonSearchTeacher.AutoSize = false;
            toolStripButtonSearchTeacher.BackColor = SystemColors.Control;
            toolStripButtonSearchTeacher.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchTeacher.Image = (Image)resources.GetObject("toolStripButtonSearchTeacher.Image");
            toolStripButtonSearchTeacher.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchTeacher.Margin = new Padding(2);
            toolStripButtonSearchTeacher.Name = "toolStripButtonSearchTeacher";
            toolStripButtonSearchTeacher.Size = new Size(46, 25);
            toolStripButtonSearchTeacher.Text = "Поиск";
            // 
            // dataGridViewExperiences
            // 
            dataGridViewExperiences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewExperiences.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewExperiences.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExperiences.Dock = DockStyle.Fill;
            dataGridViewExperiences.Location = new Point(0, 35);
            dataGridViewExperiences.Name = "dataGridViewExperiences";
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewExperiences.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewExperiences.RowTemplate.Height = 25;
            dataGridViewExperiences.Size = new Size(844, 265);
            dataGridViewExperiences.TabIndex = 1;
            // 
            // toolStripExperiences
            // 
            toolStripExperiences.AutoSize = false;
            toolStripExperiences.BackColor = Color.LightBlue;
            toolStripExperiences.Items.AddRange(new ToolStripItem[] { toolStripLabelExp, toolStripSeparator10, toolStripSeparator9, toolStripButtonAddExp, toolStripButtonEditExp, toolStripButtonDelExp, toolStripSeparator3, toolStripSeparator4, toolStripTextBoxFilterExp, toolStripSeparator15, toolStripSeparator16, toolStripButtonSearchExp });
            toolStripExperiences.Location = new Point(0, 0);
            toolStripExperiences.Name = "toolStripExperiences";
            toolStripExperiences.Size = new Size(844, 35);
            toolStripExperiences.TabIndex = 0;
            toolStripExperiences.Text = "toolStripExpirences";
            // 
            // toolStripLabelExp
            // 
            toolStripLabelExp.Name = "toolStripLabelExp";
            toolStripLabelExp.Size = new Size(35, 32);
            toolStripLabelExp.Text = "Стаж";
            // 
            // toolStripSeparator10
            // 
            toolStripSeparator10.Name = "toolStripSeparator10";
            toolStripSeparator10.Size = new Size(6, 35);
            // 
            // toolStripSeparator9
            // 
            toolStripSeparator9.Name = "toolStripSeparator9";
            toolStripSeparator9.Size = new Size(6, 35);
            // 
            // toolStripButtonAddExp
            // 
            toolStripButtonAddExp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonAddExp.Image = (Image)resources.GetObject("toolStripButtonAddExp.Image");
            toolStripButtonAddExp.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddExp.Name = "toolStripButtonAddExp";
            toolStripButtonAddExp.Size = new Size(23, 32);
            toolStripButtonAddExp.Text = "toolStripButtonAddExp";
            toolStripButtonAddExp.ToolTipText = "Добавить";
            // 
            // toolStripButtonEditExp
            // 
            toolStripButtonEditExp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonEditExp.Image = (Image)resources.GetObject("toolStripButtonEditExp.Image");
            toolStripButtonEditExp.ImageTransparentColor = Color.Magenta;
            toolStripButtonEditExp.Name = "toolStripButtonEditExp";
            toolStripButtonEditExp.Size = new Size(23, 32);
            toolStripButtonEditExp.Text = "toolStripButtonEditExp";
            toolStripButtonEditExp.ToolTipText = "Редактировать";
            // 
            // toolStripButtonDelExp
            // 
            toolStripButtonDelExp.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonDelExp.Image = (Image)resources.GetObject("toolStripButtonDelExp.Image");
            toolStripButtonDelExp.ImageTransparentColor = Color.Magenta;
            toolStripButtonDelExp.Name = "toolStripButtonDelExp";
            toolStripButtonDelExp.Size = new Size(23, 32);
            toolStripButtonDelExp.Text = "toolStripButtonDelExp";
            toolStripButtonDelExp.ToolTipText = "Удалить";
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
            // toolStripTextBoxFilterExp
            // 
            toolStripTextBoxFilterExp.Margin = new Padding(3);
            toolStripTextBoxFilterExp.Name = "toolStripTextBoxFilterExp";
            toolStripTextBoxFilterExp.Size = new Size(100, 29);
            // 
            // toolStripSeparator15
            // 
            toolStripSeparator15.Name = "toolStripSeparator15";
            toolStripSeparator15.Size = new Size(6, 35);
            // 
            // toolStripSeparator16
            // 
            toolStripSeparator16.Name = "toolStripSeparator16";
            toolStripSeparator16.Size = new Size(6, 35);
            // 
            // toolStripButtonSearchExp
            // 
            toolStripButtonSearchExp.AutoSize = false;
            toolStripButtonSearchExp.BackColor = SystemColors.Control;
            toolStripButtonSearchExp.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripButtonSearchExp.Image = (Image)resources.GetObject("toolStripButtonSearchExp.Image");
            toolStripButtonSearchExp.ImageTransparentColor = Color.Magenta;
            toolStripButtonSearchExp.Margin = new Padding(2);
            toolStripButtonSearchExp.Name = "toolStripButtonSearchExp";
            toolStripButtonSearchExp.Size = new Size(46, 25);
            toolStripButtonSearchExp.Text = "Поиск";
            // 
            // TeachersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 597);
            Controls.Add(splitContainer1);
            Name = "TeachersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сотрудники и учащиеся учебных заведений";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewPositions).EndInit();
            toolStripPositions.ResumeLayout(false);
            toolStripPositions.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTeachers).EndInit();
            toolStripTeachers.ResumeLayout(false);
            toolStripTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExperiences).EndInit();
            toolStripExperiences.ResumeLayout(false);
            toolStripExperiences.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGridViewPositions;
        private ToolStrip toolStripPositions;
        private SplitContainer splitContainer2;
        private DataGridView dataGridViewTeachers;
        private ToolStrip toolStripTeachers;
        private DataGridView dataGridViewExperiences;
        private ToolStrip toolStripExperiences;
        private ToolStripButton toolStripButtonAddPos;
        private ToolStripButton toolStripButtonDelPos;
        private ToolStripButton toolStripButtonEditPos;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripTextBox toolStripTextBoxFilterPos;
        private ToolStripButton toolStripButtonSearchPos;
        private ToolStripButton toolStripButtonAddTeacher;
        private ToolStripButton toolStripButtonEditTeacher;
        private ToolStripButton toolStripButtonDeleteTeacher;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripTextBox toolStripTextBoxFilterTeacher;
        private ToolStripButton toolStripButtonSearchTeacher;
        private ToolStripButton toolStripButtonAddExp;
        private ToolStripButton toolStripButtonEditExp;
        private ToolStripButton toolStripButtonDelExp;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripTextBox toolStripTextBoxFilterExp;
        private ToolStripButton toolStripButtonSearchExp;
        private ToolStripLabel toolStripLabelTeacher;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripLabel toolStripLabelExp;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripSeparator toolStripSeparator11;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator16;
    }
}