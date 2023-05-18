using monitoring.Data;
using System.ComponentModel;
using monitoring.Forms;
using monitoring.Models;

namespace monitoring
{
    public partial class MainForm : Form
    {
        private MonitoringContext? dbContext;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();

            if (authForm.DialogResult == DialogResult.Cancel) this.Close();

            this.dbContext = new MonitoringContext();

            var articles = from a in dbContext.Set<Article>()
                           join et in dbContext.Set<EditionType>()
                           on a.EditionTypeId equals et.EditionTypeId
                           join n in dbContext.Set<Notation>()
                           on a.NotationId equals n.NotationId
                           where a.ArticleTypeId == 1
                           select new
                           {
                               a.ArticleId,
                               Год = a.Year,
                               Наименование_работы = a.Title,
                               Выходные_данные = a.OutData,
                               Вид_издания = et.Name,
                               Входит_в_ВАК = a.IsPublishedInVak,
                               В_зарубежном_издании = a.IsPublishedInEng,
                               Индексация = n.Name,
                               Количество_пл = a.Count,
                               Тираж = a.Edition,
                               Импакт_фактор = a.ImpactFactor
                           };

            dataGridViewArticles.DataSource = articles.ToList();

            this.dataGridViewArticles.Columns[0].Visible = false;

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            //this.monitoringContext.Database.EnsureCreated();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
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

        private void dataGridViewArticles_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dbContext != null && dataGridViewArticles.CurrentRow != null)
            {
                var articleId = (int)this.dataGridViewArticles.CurrentRow.Cells[0].Value;
                if (articleId != 0)
                {
                    var query = from aa in dbContext.Set<ArticleAuthor>()
                                join t in dbContext.Set<Teacher>()
                                on aa.TeacherId equals t.TeacherId
                                join c in dbContext.Set<Cathedra>()
                                on t.CathedraId equals c.CathedraId
                                join u in dbContext.Set<Univer>()
                                on c.UniverId equals u.UniverId
                                join at in dbContext.Set<AuthorType>()
                                on aa.AuthorTypeId equals at.AuthorTypeId
                                where aa.ArticleId == articleId
                                select new
                                {
                                    Университет = u.Name,
                                    Кафедра = c.Name,
                                    ФИО = t.Name,
                                    Тип_автора = at.Name
                                };

                    dataGridViewAuthors.DataSource = query.ToList();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}