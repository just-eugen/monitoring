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

            this.dbContext.Positions.Load();

            this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();

            this.dataGridViewPositions.Columns[0].Visible = false;
            this.dataGridViewPositions.Columns[1].HeaderText = "Должность";
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
                }
            }
        }

        private void toolStripButtonSearch_Click(object sender, EventArgs e)
        {
            if (dbContext != null)
            {
                var query = from p in dbContext.Set<Position>()
                            where p.Name.Contains(this.toolStripTextBoxFilterPos.Text)
                            select p;

                this.dataGridViewPositions.DataSource = query.ToList();
            }
        }

        private void toolStripButtonAddPos_Click(object sender, EventArgs e)
        {
            AddPos addPos = new AddPos();

            addPos.Text = "Добавление должности";
            addPos.buttonOK.Text = "Добавить";
            addPos.ShowDialog();

            if (addPos.DialogResult == DialogResult.OK && dbContext != null)
            {
                this.dbContext.Positions.Add(new Position { Name = addPos.textBoxPosName.Text });
                this.dbContext.SaveChanges();
                this.dbContext.Positions.Load();

                this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();
            }
        }

        private void toolStripButtonEditPos_Click(object sender, EventArgs e)
        {
            if (this.dbContext != null && dataGridViewPositions.DataSource != null)
            {
                var position = (Position)this.dataGridViewPositions.CurrentRow.DataBoundItem;

                if (position != null)
                {
                    AddPos addPos = new AddPos();

                    addPos.Text = "Редактирвание должности";
                    addPos.buttonOK.Text = "Сохранить";
                    addPos.textBoxPosName.Text = position.Name;
                    addPos.ShowDialog();

                    if (addPos.DialogResult == DialogResult.OK)
                    {
                        position.Name = addPos.textBoxPosName.Text;

                        this.dbContext.Update(position);
                        this.dbContext.SaveChanges();
                        this.dbContext.Positions.Load();

                        this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();
                    }
                }
            }
        }

        private void toolStripButtonDelPos_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Внимание!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (message == DialogResult.OK && this.dbContext != null && dataGridViewPositions.DataSource != null)
            {
                var position = (Position)this.dataGridViewPositions.CurrentRow.DataBoundItem;

                if (position != null)
                {
                    this.dbContext.Remove(position);
                    this.dbContext.SaveChanges();
                    this.dbContext.Positions.Load();

                    this.dataGridViewPositions.DataSource = this.dbContext.Positions.ToList();
                }
            }
        }

        private void toolStripButtonAddTeacher_Click(object sender, EventArgs e)
        {
            if (this.dbContext != null)
            {
                AddTeacher addTeacher = new AddTeacher();
                addTeacher.Text = "Добавление сотрудника";
                addTeacher.buttonOK.Text = "Добавить";

                this.dbContext.Positions.Load();
                this.dbContext.Univers.Load();

                addTeacher.comboBoxPos.DataSource = this.dbContext.Positions.ToList();
                addTeacher.comboBoxPos.DisplayMember = "Name";
                addTeacher.comboBoxPos.Invalidate();
                addTeacher.comboBoxUniver.DataSource = this.dbContext.Univers.ToList();
                addTeacher.comboBoxUniver.DisplayMember = "Name";
                addTeacher.comboBoxUniver.Invalidate();

                addTeacher.ShowDialog();

                if (addTeacher.DialogResult == DialogResult.OK)
                {
                    var position = (Position)addTeacher.comboBoxPos.SelectedValue;
                    var cathedra = (Cathedra)addTeacher.comboBoxCathedra.SelectedValue;

                    this.dbContext.Teachers.Add(new Teacher { 
                        Name = addTeacher.textBoxName.Text,
                        PositionId = position.PositionId,
                        CathedraId = cathedra.CathedraId,
                        StudyLoad = addTeacher.textBoxStudyLoad.Text,
                        Rate = Convert.ToDouble(addTeacher.textBoxRate.Text)
                    });
                    this.dbContext.SaveChanges();
                    this.dbContext.Teachers.Load();

                    this.dataGridViewTeachers.DataSource = this.dbContext.Teachers.ToList();
                }
            }
        }
    }
}
