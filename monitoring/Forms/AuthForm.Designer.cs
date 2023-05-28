namespace monitoring.Forms
{
    partial class AuthForm
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
            comboBoxUser = new ComboBox();
            userBindingSource = new BindingSource(components);
            textBoxPass = new TextBox();
            buttonLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUser
            // 
            comboBoxUser.DataSource = userBindingSource;
            comboBoxUser.FormattingEnabled = true;
            comboBoxUser.Location = new Point(127, 12);
            comboBoxUser.Name = "comboBoxUser";
            comboBoxUser.Size = new Size(160, 23);
            comboBoxUser.TabIndex = 0;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.User);
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(127, 41);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(160, 23);
            textBoxPass.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(112, 75);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 3;
            label1.Text = "Пользователь";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 110);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPass);
            Controls.Add(comboBoxUser);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "AuthForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация пользователя";
            Load += AuthForm_Load;
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUser;
        private BindingSource userBindingSource;
        private TextBox textBoxPass;
        private Button buttonLogin;
        private Label label1;
        private Label label2;
    }
}