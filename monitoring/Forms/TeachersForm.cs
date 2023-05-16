using Microsoft.EntityFrameworkCore;
using monitoring.Data;
using monitoring.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monitoring.Forms
{
    public partial class TeachersForm : Form
    {
        private MonitoringContext? dbContext;

        public TeachersForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new MonitoringContext();

            // Uncomment the line below to start fresh with a new database.
            //this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();

            this.dbContext.Positions.Load();

            this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewPositions_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                var position = (Position)this.dataGridViewPositions.CurrentRow.DataBoundItem;

                if (position != null)
                {
                    this.dbContext.Entry(position).Collection(e => e.Teachers).Load();
                    this.dataGridViewTeachers.DataSource = position.Teachers;
                }
            }
        }
    }
}
