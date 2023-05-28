namespace monitoring.Forms
{
    partial class AddPos
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
            buttonOK = new Button();
            buttonCancel = new Button();
            textBoxPosName = new TextBox();
            label = new Label();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(50, 66);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(75, 23);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "Сохранить";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(174, 66);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // textBoxPosName
            // 
            textBoxPosName.Location = new Point(124, 21);
            textBoxPosName.Name = "textBoxPosName";
            textBoxPosName.Size = new Size(169, 23);
            textBoxPosName.TabIndex = 2;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(15, 24);
            label.Name = "label";
            label.Size = new Size(90, 15);
            label.TabIndex = 3;
            label.Text = "Наименование";
            // 
            // AddPos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 101);
            ControlBox = false;
            Controls.Add(label);
            Controls.Add(textBoxPosName);
            Controls.Add(buttonCancel);
            Controls.Add(buttonOK);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AddPos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label;
        public TextBox textBoxPosName;
        public Button buttonOK;
        private Button buttonCancel;
    }
}