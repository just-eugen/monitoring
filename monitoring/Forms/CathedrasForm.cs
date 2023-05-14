using Microsoft.EntityFrameworkCore;
using monitoring.Data;
using monitoring.Models;
using System.ComponentModel;

namespace monitoring.Forms
{
    public partial class CathedrasForm : Form
    {
        private MonitoringContext? dbContext;

        public CathedrasForm()
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

            this.dbContext.Univers.Load();

            this.univerBindingSource.DataSource = dbContext.Univers.Local.ToBindingList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewUnivers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Univer)this.dataGridViewUnivers.CurrentRow.DataBoundItem;

                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Cathedras).Load();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewUnivers.Refresh();
            this.dataGridViewCathedras.Refresh();
        }
    }
}
