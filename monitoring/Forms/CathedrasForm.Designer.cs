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
            components = new System.ComponentModel.Container();
            dataGridViewUnivers = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            univerBindingSource = new BindingSource(components);
            dataGridViewCathedras = new DataGridView();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            cathedrasBindingSource = new BindingSource(components);
            buttonSave = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)univerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cathedrasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUnivers
            // 
            dataGridViewUnivers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewUnivers.AutoGenerateColumns = false;
            dataGridViewUnivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnivers.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn });
            dataGridViewUnivers.DataSource = univerBindingSource;
            dataGridViewUnivers.Location = new Point(12, 43);
            dataGridViewUnivers.Name = "dataGridViewUnivers";
            dataGridViewUnivers.RowTemplate.Height = 25;
            dataGridViewUnivers.Size = new Size(354, 226);
            dataGridViewUnivers.TabIndex = 0;
            dataGridViewUnivers.SelectionChanged += dataGridViewUnivers_SelectionChanged;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Аббревиатура";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "Полное название";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // univerBindingSource
            // 
            univerBindingSource.DataSource = typeof(Models.Univer);
            // 
            // dataGridViewCathedras
            // 
            dataGridViewCathedras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCathedras.AutoGenerateColumns = false;
            dataGridViewCathedras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCathedras.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn1, fullNameDataGridViewTextBoxColumn1 });
            dataGridViewCathedras.DataSource = cathedrasBindingSource;
            dataGridViewCathedras.Location = new Point(381, 43);
            dataGridViewCathedras.Name = "dataGridViewCathedras";
            dataGridViewCathedras.RowTemplate.Height = 25;
            dataGridViewCathedras.Size = new Size(355, 226);
            dataGridViewCathedras.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Аббревиатура";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn1.HeaderText = "Полное название";
            fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            fullNameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // cathedrasBindingSource
            // 
            cathedrasBindingSource.DataMember = "Cathedras";
            cathedrasBindingSource.DataSource = univerBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(661, 275);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
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
            label2.Location = new Point(381, 9);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 4;
            label2.Text = "Кафедра";
            // 
            // CathedrasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 310);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCathedras);
            Controls.Add(dataGridViewUnivers);
            Name = "CathedrasForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CathedrasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)univerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).EndInit();
            ((System.ComponentModel.ISupportInitialize)cathedrasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUnivers;
        private DataGridView dataGridViewCathedras;
        private Button buttonSave;
        private BindingSource univerBindingSource;
        private BindingSource cathedrasBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private Label label1;
        private Label label2;
    }
}