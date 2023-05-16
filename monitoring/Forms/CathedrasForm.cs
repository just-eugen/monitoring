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

            var query = from univers in dbContext.Set<Univer>()
                        join cathedras in dbContext.Set<Cathedra>()
                        on univers.UniverId equals cathedras.UniverId
                        select new { Универ = univers.Name, Кафедра = cathedras.Name};

            //this.dbContext.Univers.Load();

            this.dataGridViewUnivers.DataSource = query.ToList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewUnivers_SelectionChanged(object sender, EventArgs e)
        {
            //if (this.dbContext != null)
            //{
            //    var univer = (Univer)this.dataGridViewUnivers.CurrentRow.DataBoundItem;

            //    if (univer != null)
            //    {
            //        this.dbContext.Entry(univer).Collection(e => e.Cathedras).Load();
            //        this.dataGridViewCathedras.DataSource = univer.Cathedras;
            //    }
            //}
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();

            this.dataGridViewUnivers.Refresh();
            this.dataGridViewCathedras.Refresh();
        }
    }
}
