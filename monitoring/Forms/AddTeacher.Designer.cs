namespace monitoring.Forms
{
    partial class AddTeacher
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
            textBoxName = new TextBox();
            comboBoxPos = new ComboBox();
            comboBoxUniver = new ComboBox();
            comboBoxCathedra = new ComboBox();
            textBoxStudyLoad = new TextBox();
            textBoxRate = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonOK = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(187, 12);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(229, 23);
            textBoxName.TabIndex = 0;
            // 
            // comboBoxPos
            // 
            comboBoxPos.FormattingEnabled = true;
            comboBoxPos.Location = new Point(187, 41);
            comboBoxPos.Name = "comboBoxPos";
            comboBoxPos.Size = new Size(229, 23);
            comboBoxPos.TabIndex = 1;
            // 
            // comboBoxUniver
            // 
            comboBoxUniver.FormattingEnabled = true;
            comboBoxUniver.Location = new Point(187, 70);
            comboBoxUniver.Name = "comboBoxUniver";
            comboBoxUniver.Size = new Size(229, 23);
            comboBoxUniver.TabIndex = 2;
            comboBoxUniver.SelectedIndexChanged += comboBoxUniver_SelectedIndexChanged;
            // 
            // comboBoxCathedra
            // 
            comboBoxCathedra.FormattingEnabled = true;
            comboBoxCathedra.Location = new Point(187, 99);
            comboBoxCathedra.Name = "comboBoxCathedra";
            comboBoxCathedra.Size = new Size(229, 23);
            comboBoxCathedra.TabIndex = 3;
            // 
            // textBoxStudyLoad
            // 
            textBoxStudyLoad.Location = new Point(187, 128);
            textBoxStudyLoad.Name = "textBoxStudyLoad";
            textBoxStudyLoad.Size = new Size(229, 23);
            textBoxStudyLoad.TabIndex = 4;
            // 
            // textBoxRate
            // 
            textBoxRate.Location = new Point(187, 157);
            textBoxRate.Name = "textBoxRate";
            textBoxRate.Size = new Size(229, 23);
            textBoxRate.TabIndex = 5;
            textBoxRate.KeyPress += textBoxRate_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 6;
            label1.Text = "ФИО";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 7;
            label2.Text = "Должность";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 8;
            label3.Text = "Университет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 102);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 9;
            label4.Text = "Кафедра";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 131);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 10;
            label5.Text = "Объем учебной нагрузки";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 11;
            label6.Text = "Ставка";
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(67, 201);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(92, 23);
            buttonOK.TabIndex = 12;
            buttonOK.Text = "Сохранить";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(261, 201);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(92, 23);
            buttonCancel.TabIndex = 13;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // AddTeacher
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(428, 236);
            ControlBox = false;
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxRate);
            Controls.Add(textBoxStudyLoad);
            Controls.Add(comboBoxCathedra);
            Controls.Add(comboBoxUniver);
            Controls.Add(comboBoxPos);
            Controls.Add(textBoxName);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddTeacher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTeacher";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonCancel;
        public TextBox textBoxName;
        public ComboBox comboBoxPos;
        public ComboBox comboBoxUniver;
        public ComboBox comboBoxCathedra;
        public TextBox textBoxStudyLoad;
        public TextBox textBoxRate;
        public Button buttonOK;
    }
}