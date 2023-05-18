using Microsoft.EntityFrameworkCore;
using monitoring.Data;
using monitoring.Models;
using System.ComponentModel;
using System.Data;

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
            //this.dbContext.Database.EnsureCreated();

            this.dbContext.Positions.Load();

            this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();

            this.dataGridViewPositions.Columns[0].Visible = false;
            this.dataGridViewPositions.Columns[1].HeaderText = "Должность";
            this.dataGridViewPositions.Columns[1].Width = 250;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewPositions_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null && dataGridViewPositions.DataSource != null)
            {
                var position = (Position)this.dataGridViewPositions.CurrentRow.DataBoundItem;

                if (position != null)
                {
                    var teachers = from t in dbContext.Set<Teacher>()
                                   join c in dbContext.Set<Cathedra>()
                                   on t.CathedraId equals c.CathedraId
                                   where t.PositionId == position.PositionId
                                   select new { t.TeacherId, ФИО = t.Name, Кафедра = c.Name, Объем_нагрузки = t.StudyLoad, Ставка = t.Rate, t.PositionId };

                    this.dataGridViewTeachers.DataSource = teachers.ToList();

                    this.dataGridViewTeachers.Columns[0].Visible = false;
                    this.dataGridViewTeachers.Columns[5].Visible = false;

                    this.dataGridViewTeachers.Columns[1].Width = 200;
                    this.dataGridViewTeachers.Columns[2].Width = 200;
                    this.dataGridViewTeachers.Columns[3].Width = 200;
                    this.dataGridViewTeachers.Columns[4].Width = 200;
                }
            }
        }

        private void dataGridViewTeachers_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null && dataGridViewTeachers.CurrentRow != null)
            {
                var teacherId = (int)this.dataGridViewTeachers.CurrentRow.Cells[0].Value;

                if (teacherId != 0)
                {
                    var query = from ex in dbContext.Set<Experience>()
                                join et in dbContext.Set<ExperienceType>()
                                on ex.ExperienceTypeId equals et.ExperienceTypeId
                                where ex.TeacherId == teacherId
                                select new { Стаж = ex.Count, Тип_стажа = et.Name };

                    this.dataGridViewExperiences.DataSource = query.ToList();

                    this.dataGridViewExperiences.Columns[0].Width = 200;
                    this.dataGridViewExperiences.Columns[1].Width = 200;
                }
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
