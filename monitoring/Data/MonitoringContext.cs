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
        //public DbSet<ArticleAuthor> ArticleAuthors { get; set; }
        //public DbSet<StudyBookAuthor> StudyBookAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=1234;database=monitoring;",
                new MySqlServerVersion(new Version(8, 0, 33))
            );
        }
        // => optionsBuilder.UseSqlite("Data Source=products.db");
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
        }
    }
}
