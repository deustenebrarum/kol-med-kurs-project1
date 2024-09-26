using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<ServiceType> ServiceTypes { get; set; }
    public DbSet<Specialist> Specialists { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Request> Requests { get; set; }
    public DbSet<Review> Reviews { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ServiceType configuration
        modelBuilder.Entity<ServiceType>()
            .HasKey(st => st.ServiceTypeID);

        modelBuilder.Entity<ServiceType>()
            .Property(st => st.Name)
            .IsRequired()
            .HasMaxLength(255);

        // Specialist configuration
        modelBuilder.Entity<Specialist>()
            .HasKey(sp => sp.SpecialistID);

        modelBuilder.Entity<Specialist>()
            .Property(sp => sp.FullName)
            .IsRequired()
            .HasMaxLength(255);

        modelBuilder.Entity<Specialist>()
            .Property(sp => sp.Position)
            .IsRequired()
            .HasMaxLength(255);

        modelBuilder.Entity<Specialist>()
            .Property(sp => sp.Experience)
            .IsRequired();

        // User configuration
        modelBuilder.Entity<User>()
            .HasKey(u => u.UserID);

        modelBuilder.Entity<User>()
            .Property(u => u.Login)
            .IsRequired()
            .HasMaxLength(255);

        modelBuilder.Entity<User>()
            .Property(u => u.Email)
            .IsRequired()
            .HasMaxLength(255);

        modelBuilder.Entity<User>()
            .Property(u => u.Password)
            .IsRequired();

        modelBuilder.Entity<User>()
            .Property(u => u.Role)
            .IsRequired();

        // Request configuration
        modelBuilder.Entity<Request>()
            .HasKey(r => r.RequestID);

        modelBuilder.Entity<Request>()
            .Property(r => r.Number)
            .IsRequired()
            .HasMaxLength(50);

        modelBuilder.Entity<Request>()
            .HasOne(r => r.ServiceType)
            .WithMany(st => st.Requests)
            .HasForeignKey(r => r.ServiceTypeID);

        modelBuilder.Entity<Request>()
            .HasOne(r => r.Specialist)
            .WithMany(s => s.Requests)
            .HasForeignKey(r => r.SpecialistID);

        modelBuilder.Entity<Request>()
            .HasOne(r => r.Patient)
            .WithMany(u => u.Requests)
            .HasForeignKey(r => r.PatientID);

        // Review configuration
        modelBuilder.Entity<Review>()
            .HasKey(rev => rev.ReviewID);

        modelBuilder.Entity<Review>()
            .Property(rev => rev.Title)
            .HasMaxLength(255);

        modelBuilder.Entity<Review>()
            .Property(rev => rev.Content)
            .HasMaxLength(int.MaxValue);

        modelBuilder.Entity<Review>()
            .HasOne(rev => rev.Specialist)
            .WithMany(s => s.Reviews)
            .HasForeignKey(rev => rev.SpecialistID);

        base.OnModelCreating(modelBuilder);
    }
}
