using Microsoft.EntityFrameworkCore;
using monitoring.Data;
using monitoring.Models;
using System.ComponentModel;

namespace monitoring.Forms
{
    public partial class AuthForm : Form
    {
        private MonitoringContext? dbContext;

        public AuthForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new MonitoringContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Users.Load();

            this.comboBoxUser.DataSource = this.dbContext.Users.ToList();
            this.comboBoxUser.DisplayMember = "Name";
            this.comboBoxUser.Invalidate();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var user = (User)this.comboBoxUser.SelectedValue;

                if (user != null && user.Password == textBoxPass.Text)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Неверный пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
