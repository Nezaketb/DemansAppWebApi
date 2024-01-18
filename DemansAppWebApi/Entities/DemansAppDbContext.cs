using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace DemansAppWebApi.Entities
{
    public partial class DemansAppDbContext:DbContext
    {
        public DemansAppDbContext(DbContextOptions<DemansAppDbContext> options): base(options)
        {
        }

        public virtual DbSet<Users> Users { get; set; } = null!;
        public virtual DbSet<Admins> Admins { get; set; } = null!;
        public virtual DbSet<AudioBooks> AudioBooks { get; set; } = null!;
        public virtual DbSet<Commands> Commands { get; set; } = null!;
        public virtual DbSet<Companions> Companions { get; set; } = null!;
        public virtual DbSet<LocationInformation> LocationInformation { get; set; } = null!;
        public virtual DbSet<Medicines> Medicines { get; set; } = null!;
        public virtual DbSet<Pictures> Pictures { get; set; } = null!;

        public virtual DbSet<MotivationSentences> MotivationSentences { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("Users");

                entity.Property(e => e.Email).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.Password).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.EmergencyPhone).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.UserName).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.Surname).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.Phone).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.Status).HasColumnType("int").IsRequired(false);
                entity.Property(e => e.Sex).HasColumnType("boolean");

            });
            modelBuilder.Entity<Admins>(entity =>
            {
                entity.ToTable("Admins");

                entity.Property(e => e.Username).HasMaxLength(255);
                entity.Property(e => e.Password).HasMaxLength(255);
            });
            modelBuilder.Entity<AudioBooks>(entity =>
            {
                entity.ToTable("AudioBooks");

                entity.Property(e => e.Name).HasMaxLength(255);
                entity.Property(e => e.Subject).HasMaxLength(255);
                entity.Property(e => e.Text).HasMaxLength(255);
                entity.Property(e => e.Url).HasMaxLength(255);
                entity.Property(e => e.Status).HasMaxLength(255);
            });
            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.ToTable("Pictures");


                entity.Property(p => p.Url).HasColumnType("string").IsRequired(false);
                entity.Property(p => p.Text).HasColumnType("string").IsRequired(false);
                entity.Property(p => p.UserId).HasColumnType("int").IsRequired(false);
                entity.Property(p => p.Status).HasColumnType("bit").IsRequired(true);
            });
            modelBuilder.Entity<Commands>(entity =>
            {
                entity.ToTable("Commands");

                entity.Property(e => e.ProcessName).HasColumnType("string").IsRequired();
                entity.Property(e => e.Status).HasColumnType("boolean").IsRequired();
                entity.Property(e => e.UserId).HasColumnType("int").IsRequired(false);
                entity.Property(e => e.CompanionId).HasColumnType("int").IsRequired(false);
            });
            modelBuilder.Entity<Companions>(entity =>
            {
                entity.ToTable("Companions");

                entity.Property(e => e.Email).HasColumnType("string").IsRequired(true);
                entity.Property(e => e.Adress).HasColumnType("string").IsRequired(true);
                entity.Property(e => e.Name).HasColumnType("string").IsRequired(true);
                entity.Property(e => e.Surname).HasColumnType("string").IsRequired(true);
                entity.Property(e => e.Phone).HasColumnType("string").IsRequired(true);
                entity.Property(e => e.Sex).HasColumnType("boolean");
                entity.Property(e => e.Password).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.UserId).HasColumnType("int").IsRequired(false);
                entity.Property(e => e.Status).HasColumnType("int").IsRequired(false);
            });
            modelBuilder.Entity<LocationInformation>(entity =>
            {
                entity.ToTable("LocationInformation");

                entity.Property(p => p.Lat).HasColumnType("string").IsRequired();
                entity.Property(p => p.Lng).HasColumnType("string").IsRequired();
                entity.Property(p => p.UserId).HasColumnType("int").IsRequired();
                entity.Property(p => p.Status).HasColumnType("bit").IsRequired();
            });
            modelBuilder.Entity<Medicines>(entity =>
            {
                entity.ToTable("Medicines");

                entity.Property(e => e.Name).HasColumnType("string").IsRequired();
                entity.Property(e => e.UsageDuration).HasColumnType("string").IsRequired();
                entity.Property(e => e.UsagePurpose).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.StartDate).HasColumnType("datetime").IsRequired();
                entity.Property(e => e.EndDate).HasColumnType("datetime").IsRequired();
                entity.Property(e => e.Moon).HasColumnType("bit").IsRequired();
                entity.Property(e => e.Afternoon).HasColumnType("bit").IsRequired();
                entity.Property(e => e.Evening).HasColumnType("bit").IsRequired();
                entity.Property(e => e.Night).HasColumnType("bit").IsRequired();
                entity.Property(e => e.MoonTime).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.AfternoonTime).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.EveningTime).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.NightTime).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.UserId).HasColumnType("int").IsRequired(false);
                entity.Property(e => e.Status).HasColumnType("bit").IsRequired(true);
            });
            modelBuilder.Entity<MotivationSentences>(entity =>
            {
                entity.ToTable("MotivationSentences");

                entity.Property(e => e.Name).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.Text).HasColumnType("string").IsRequired(false);
                entity.Property(e => e.UserId).HasColumnType("int").IsRequired(false);
                entity.Property(e => e.Status).HasColumnType("bit").IsRequired(true);
            });


            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
    
}
