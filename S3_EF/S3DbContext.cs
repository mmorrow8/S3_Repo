using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Migrations;
using S3_Domain;

namespace S3_EF
{
    public class S3DbContext : DbContext
    {
        public S3DbContext(DbContextOptions options) : base(options)
        {
        }

        public S3DbContext() : base() 
        { 
        }

        public DbSet<USState> USStates { get; set; }
        public DbSet<USStateDocumentType> USStateDocumentTypes { get; set; }
        public DbSet<USStateDocumentOutput> USStateDocumentOutputs { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }
        public DbSet<DocumentOutputType> DocumentOutputTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USState>().HasData(
                this.AddStateData()
            );

            modelBuilder.Entity<DocumentType>().HasData(
                this.AddDocumentTypeData()
            );

            modelBuilder.Entity<USStateDocumentType>().HasData(
                this.AddUSStateDocumentTypeData()
            );

            modelBuilder.Entity<USStateDocumentOutput>().HasData(
                this.AddUSStateDocumentOutputData()
            );

            modelBuilder.Entity<DocumentOutputType>().HasData(
                this.AddDocumentOutputTypeData()
            );

            modelBuilder.Entity<USStateDocumentType>()
                .HasOne(ud => ud.USState)
                .WithMany() 
                .HasForeignKey(ud => ud.USStateId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<USStateDocumentType>()
                .HasOne(ud => ud.DocumentType)
                .WithMany()
                .HasForeignKey(ud => ud.DocumentTypeId)
                .OnDelete(DeleteBehavior.Cascade);

            // Configure USStateDocumentOutput entity
            modelBuilder.Entity<USStateDocumentOutput>(entity =>
            {
                // Set primary key
                entity.HasKey(e => e.USStateDocumentOutputId);

                // Configure foreign key relationship to USStateDocumentType
                entity.HasOne(e => e.USStateDocumentType)
                    .WithMany()
                    .HasForeignKey(e => e.USStateDocumentTypeId)
                    .OnDelete(DeleteBehavior.Cascade); // Adjust DeleteBehavior as required

                // Configure foreign key relationship to DocumentOutputType
                entity.HasOne(e => e.DocumentOutputType)
                    .WithMany()
                    .HasForeignKey(e => e.DocumentOutputTypeId)
                    .OnDelete(DeleteBehavior.Cascade); // Adjust DeleteBehavior as required
            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\SQLEXPRESS;Database=S3_DB;Trusted_Connection=true;TrustServerCertificate=True"
                );
            }
        }
    }
}
