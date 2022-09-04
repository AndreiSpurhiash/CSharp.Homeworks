using Final_project.Domain.Entity;
using Microsoft.EntityFrameworkCore;


namespace Final_project.DAL
{
    public class SushinContext : DbContext
    {
        
        public virtual DbSet<Sushi> Sushis { get; set; }

        public SushinContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=1234");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Sushi>(entity =>
            {
                entity.ToTable("Sushi");
                entity.HasKey(x => x._Id).HasName("Id");
                entity.Property(x => x._Id).HasColumnName(@"Id").HasColumnType("uuid").IsRequired();
                entity.Property(x => x._Number).HasColumnName(@"Number").HasColumnType("int").IsRequired();
                entity.Property(x => x._Name).HasColumnName(@"Name").HasColumnType("text").IsRequired();
                entity.Property(x => x._Coast).HasColumnName(@"Coast").HasColumnType("numeric").IsRequired();
                entity.Property(x => x._Description).HasColumnName(@"Description").HasColumnType("text").IsRequired();

            });
        }
    }
}
