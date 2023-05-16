namespace monitoring.Forms
{
    partial class CathedrasForm
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
            dataGridViewUnivers = new DataGridView();
            dataGridViewCathedras = new DataGridView();
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUnivers
            // 
            dataGridViewUnivers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewUnivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnivers.Location = new Point(12, 43);
            dataGridViewUnivers.Name = "dataGridViewUnivers";
            dataGridViewUnivers.RowTemplate.Height = 25;
            dataGridViewUnivers.Size = new Size(458, 306);
            dataGridViewUnivers.TabIndex = 0;
            dataGridViewUnivers.SelectionChanged += dataGridViewUnivers_SelectionChanged;
            // 
            // dataGridViewCathedras
            // 
            dataGridViewCathedras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCathedras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCathedras.Location = new Point(476, 43);
            dataGridViewCathedras.Name = "dataGridViewCathedras";
            dataGridViewCathedras.RowTemplate.Height = 25;
            dataGridViewCathedras.Size = new Size(459, 306);
            dataGridViewCathedras.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(860, 355);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Университет";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(476, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Кафедра";
            // 
            // CathedrasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 390);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCathedras);
            Controls.Add(dataGridViewUnivers);
            Name = "CathedrasForm";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUnivers;
        private DataGridView dataGridViewCathedras;
        private Button buttonSave;
        private Label label1;
        private Label label2;
    }
}