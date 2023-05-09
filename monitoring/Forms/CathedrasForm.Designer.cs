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
            univerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            univerBindingSource = new BindingSource(components);
            dataGridViewCathedras = new DataGridView();
            cathedraIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            univerIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            univerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cathedrasBindingSource = new BindingSource(components);
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)univerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cathedrasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUnivers
            // 
            dataGridViewUnivers.AutoGenerateColumns = false;
            dataGridViewUnivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUnivers.Columns.AddRange(new DataGridViewColumn[] { univerIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn });
            dataGridViewUnivers.DataSource = univerBindingSource;
            dataGridViewUnivers.Location = new Point(12, 12);
            dataGridViewUnivers.Name = "dataGridViewUnivers";
            dataGridViewUnivers.RowTemplate.Height = 25;
            dataGridViewUnivers.Size = new Size(354, 226);
            dataGridViewUnivers.TabIndex = 0;
            dataGridViewUnivers.SelectionChanged += dataGridViewUnivers_SelectionChanged;
            // 
            // univerIdDataGridViewTextBoxColumn
            // 
            univerIdDataGridViewTextBoxColumn.DataPropertyName = "UniverId";
            univerIdDataGridViewTextBoxColumn.HeaderText = "UniverId";
            univerIdDataGridViewTextBoxColumn.Name = "univerIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // univerBindingSource
            // 
            univerBindingSource.DataSource = typeof(Models.Univer);
            // 
            // dataGridViewCathedras
            // 
            dataGridViewCathedras.AutoGenerateColumns = false;
            dataGridViewCathedras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCathedras.Columns.AddRange(new DataGridViewColumn[] { cathedraIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn1, fullNameDataGridViewTextBoxColumn1, univerIdDataGridViewTextBoxColumn1, univerDataGridViewTextBoxColumn });
            dataGridViewCathedras.DataSource = cathedrasBindingSource;
            dataGridViewCathedras.Location = new Point(381, 12);
            dataGridViewCathedras.Name = "dataGridViewCathedras";
            dataGridViewCathedras.RowTemplate.Height = 25;
            dataGridViewCathedras.Size = new Size(355, 226);
            dataGridViewCathedras.TabIndex = 1;
            // 
            // cathedraIdDataGridViewTextBoxColumn
            // 
            cathedraIdDataGridViewTextBoxColumn.DataPropertyName = "CathedraId";
            cathedraIdDataGridViewTextBoxColumn.HeaderText = "CathedraId";
            cathedraIdDataGridViewTextBoxColumn.Name = "cathedraIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // fullNameDataGridViewTextBoxColumn1
            // 
            fullNameDataGridViewTextBoxColumn1.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn1.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn1.Name = "fullNameDataGridViewTextBoxColumn1";
            // 
            // univerIdDataGridViewTextBoxColumn1
            // 
            univerIdDataGridViewTextBoxColumn1.DataPropertyName = "UniverId";
            univerIdDataGridViewTextBoxColumn1.HeaderText = "UniverId";
            univerIdDataGridViewTextBoxColumn1.Name = "univerIdDataGridViewTextBoxColumn1";
            // 
            // univerDataGridViewTextBoxColumn
            // 
            univerDataGridViewTextBoxColumn.DataPropertyName = "Univer";
            univerDataGridViewTextBoxColumn.HeaderText = "Univer";
            univerDataGridViewTextBoxColumn.Name = "univerDataGridViewTextBoxColumn";
            // 
            // cathedrasBindingSource
            // 
            cathedrasBindingSource.DataMember = "Cathedras";
            cathedrasBindingSource.DataSource = univerBindingSource;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(649, 257);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // CathedrasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 292);
            Controls.Add(buttonSave);
            Controls.Add(dataGridViewCathedras);
            Controls.Add(dataGridViewUnivers);
            Name = "CathedrasForm";
            Text = "CathedrasForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUnivers).EndInit();
            ((System.ComponentModel.ISupportInitialize)univerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCathedras).EndInit();
            ((System.ComponentModel.ISupportInitialize)cathedrasBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUnivers;
        private DataGridView dataGridViewCathedras;
        private Button buttonSave;
        private DataGridViewTextBoxColumn univerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private BindingSource univerBindingSource;
        private DataGridViewTextBoxColumn cathedraIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn univerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn univerDataGridViewTextBoxColumn;
        private BindingSource cathedrasBindingSource;
    }
}