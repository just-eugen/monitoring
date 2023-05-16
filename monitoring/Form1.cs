using monitoring.Data;
using System.ComponentModel;
using monitoring.Forms;

namespace monitoring
{
    public partial class MainForm : Form
    {
        //private MonitoringContext? monitoringContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if (authForm.DialogResult == DialogResult.Cancel) this.Close();

            //AuthForm authForm = new AuthForm();
            //authForm.ShowDialog();

            //base.OnLoad(e);

            //this.monitoringContext = new MonitoringContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            //this.monitoringContext.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            //base.OnClosing(e);

            //this.monitoringContext?.Dispose();
            //this.monitoringContext = null;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            //CathedrasForm cathedrasForm = new CathedrasForm();
            //cathedrasForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            TeachersForm teachersForm = new TeachersForm();
            teachersForm.ShowDialog();
        }
    }
}