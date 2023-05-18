using Microsoft.EntityFrameworkCore;
using monitoring.Models;

namespace monitoring.Data
{
    internal class MonitoringContext : DbContext
    {
        public DbSet<Univer> Univers { get; set; }
        public DbSet<Cathedra> Cathedras { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<ExperienceType> ExperienceTypes { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<ContestType> ContestTypes { get; set; }
        public DbSet<ContestRequest> ContestRequests { get; set; }
        public DbSet<Volume> Volumes { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<AuthorType> AuthorTypes { get; set; }
        public DbSet<EditionType> EditionTypes { get; set; }
        public DbSet<Notation> Notations { get; set; }
        public DbSet<StudyBookType> StudyBookTypes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<StudyBook> StudyBooks { get; set; }
        public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        public DbSet<StudyBookAuthor> StudyBookAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=products.db");
            //optionsBuilder.UseMySql(
            //    "server=localhost;user=root;password=1234;database=monitoring;",
            //    new MySqlServerVersion(new Version(8, 0, 33))
            //);
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Article>()
            //    .HasMany(e => e.Teachers)
            //    .WithMany(e => e.Articles)
            //    .UsingEntity("ArticleAuthor");
            //    l => l.HasOne(typeof(Teacher)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Teacher.TeacherId)),
            //    r => r.HasOne(typeof(Article)).WithMany().HasForeignKey("PostsId").HasPrincipalKey(nameof(Article.ArticleId)),
            //    j => j.HasKey("ArticleId", "TeacherId"));

            //modelBuilder.Entity<StudyBook>()
            //    .HasMany(e => e.Teachers)
            //    .WithMany(e => e.StudyBooks)
            //    .UsingEntity("StudyBookAuthor");
                //    l => l.HasOne(typeof(Teacher)).WithMany().HasForeignKey("TagsId").HasPrincipalKey(nameof(Teacher.TeacherId)),
                //    r => r.HasOne(typeof(StudyBook)).WithMany().HasForeignKey("PostsId").HasPrincipalKey(nameof(StudyBook.StudyBookId)),
                //    j => j.HasKey("StudyBookId", "TeacherId"));

            modelBuilder.Entity<Univer>().HasData(
                new Univer { UniverId = 1, Name = "ТУСУР" },
                new Univer { UniverId = 2, Name = "ТГУ" });

            modelBuilder.Entity<Cathedra>().HasData(
                new Cathedra { CathedraId = 1, UniverId = 1, Name = "ЭМИС" },
                new Cathedra { CathedraId = 2, UniverId = 1, Name = "КСУП" },
                new Cathedra { CathedraId = 3, UniverId = 2, Name = "АИСУ" });

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Лаборант", Password = "1111" },
                new User { Id = 2, Name = "Зав. Кафедры", Password = "1234" });

            modelBuilder.Entity<Position>().HasData(
                new Position { PositionId = 1, Name = "Профессор" },
                new Position { PositionId = 2, Name = "Ассистент" },
                new Position { PositionId = 3, Name = "Доцент" },
                new Position { PositionId = 4, Name = "Старший преподаватель" },
                new Position { PositionId = 5, Name = "Студент" });

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, CathedraId = 1, PositionId = 4, Name = "Матолыгин А.А.", StudyLoad = "Основной" },
                new Teacher { TeacherId = 2, CathedraId = 2, PositionId = 5, Name = "Боргояков Е.Э.", StudyLoad = "Основной" },
                new Teacher { TeacherId = 3, CathedraId = 3, PositionId = 2, Name = "Никитин К.В.", StudyLoad = "Основной" },
                new Teacher { TeacherId = 4, CathedraId = 1, PositionId = 3, Name = "Шельмина Е.А.", StudyLoad = "Основной" },
                new Teacher { TeacherId = 5, CathedraId = 2, PositionId = 5, Name = "Бойко А.В.", StudyLoad = "Основной" },
                new Teacher { TeacherId = 6, CathedraId = 3, PositionId = 1, Name = "Боровской И.Г.", StudyLoad = "Основной" });

            modelBuilder.Entity<ExperienceType>().HasData(
                new ExperienceType { ExperienceTypeId = 1, Name = "По специальности" },
                new ExperienceType { ExperienceTypeId = 2, Name = "Общий стаж" });

            modelBuilder.Entity<Experience>().HasData(
                new Experience { ExperienceId = 1, ExperienceTypeId = 1, Count = 22, TeacherId = 1 },
                new Experience { ExperienceId = 2, ExperienceTypeId = 1, Count = 11, TeacherId = 4 },
                new Experience { ExperienceId = 3, ExperienceTypeId = 1, Count = 30, TeacherId = 6 },
                new Experience { ExperienceId = 4, ExperienceTypeId = 2, Count = 1, TeacherId = 2 },
                new Experience { ExperienceId = 5, ExperienceTypeId = 2, Count = 3, TeacherId = 5 },
                new Experience { ExperienceId = 6, ExperienceTypeId = 2, Count = 1, TeacherId = 3 },
                new Experience { ExperienceId = 7, ExperienceTypeId = 2, Count = 2, TeacherId = 4 });

            modelBuilder.Entity<EditionType>().HasData(
                new EditionType { EditionTypeId = 1, Name = "Статья" },
                new EditionType { EditionTypeId = 2, Name = "Статья в материалах конференций" });

            modelBuilder.Entity<Notation>().HasData(
                new Notation { NotationId = 1, Name = "Web of Science"},
                new Notation { NotationId = 2, Name = "Scoups"},
                new Notation { NotationId = 3, Name = "РИНЦ"},
                new Notation { NotationId = 4, Name = "Springer"},
                new Notation { NotationId = 5, Name = "SSRN"},
                new Notation { NotationId = 6, Name = "Иное" });

            modelBuilder.Entity<ArticleType>().HasData(
                new ArticleType { ArticleTypeId = 1, Name = "Статья" },
                new ArticleType { ArticleTypeId = 2, Name = "Материалы конференций" });

            modelBuilder.Entity<Article>().HasData(
                new Article { ArticleId = 1, Title = "ВЫЧИСЛИТЕЛЬНАЯ ПРОЦЕДУРА ВЫБОРА СТРУКТУРЫ РАСПРЕДЕЛИТЕЛЬНОЙ СЕТИ НА ОСНОВЕ МОДЕЛЕЙ КЛОДА ШЕННОНА И А.Я. ХИНЧИНА",
                    OutData = "Научно-технический вестник Поволжья. - 2021. - 4. С.38-40", ArticleTypeId = 1, EditionTypeId = 1, NotationId = 3, Year = 2021 },
                new Article { ArticleId = 2, Title = "ТЕНДЕНЦИИ РАЗВИТИЯ ОТЕЧЕСТВЕННЫХ СЕРВИСНЫХ НЕФТЕГАЗОВЫХ КОМПАНИЙ В СОВРЕМЕННЫХ УСЛОВИЯХ",
                    OutData = "E-Scio. – 2021. – 1. C. 434-438", ArticleTypeId = 1, EditionTypeId = 1, NotationId = 3, Year = 2021 },
                new Article { ArticleId = 3, Title = "Разработка простейшей модели однослойной нейронной сети методами объектно–ориентированного проектирования в рамках учебно-методического комплекса по изучению нейросетей",
                    OutData = "Научный электронный журнал «Инновации. Наука. Образование» - 2021. - №35. С.749-755", ArticleTypeId = 1, EditionTypeId = 1, NotationId = 3, Year = 2022 });
            
            modelBuilder.Entity<AuthorType>().HasData(
                new AuthorType { AuthorTypeId = 1, Name = "НПР"},
                new AuthorType { AuthorTypeId = 2, Name = "Асп."},
                new AuthorType { AuthorTypeId = 3, Name = "С"});

            modelBuilder.Entity<ArticleAuthor>().HasData(
                new ArticleAuthor { ArticleAuthorId = 1, ArticleId = 1, TeacherId = 1, AuthorTypeId = 1 },
                new ArticleAuthor { ArticleAuthorId = 2, ArticleId = 1, TeacherId = 5, AuthorTypeId = 3 },
                new ArticleAuthor { ArticleAuthorId = 3, ArticleId = 1, TeacherId = 3, AuthorTypeId = 3 },
                new ArticleAuthor { ArticleAuthorId = 4, ArticleId = 2, TeacherId = 6, AuthorTypeId = 1 },
                new ArticleAuthor { ArticleAuthorId = 5, ArticleId = 2, TeacherId = 4, AuthorTypeId = 1 },
                new ArticleAuthor { ArticleAuthorId = 6, ArticleId = 3, TeacherId = 5, AuthorTypeId = 3 },
                new ArticleAuthor { ArticleAuthorId = 7, ArticleId = 3, TeacherId = 4, AuthorTypeId = 1 },
                new ArticleAuthor { ArticleAuthorId = 8, ArticleId = 3, TeacherId = 2, AuthorTypeId = 3 });
        }
    }
}
