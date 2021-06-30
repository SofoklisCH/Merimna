using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using merimnaSofoklis.Models;

#nullable disable

namespace merimnaSofoklis.Data
{
    public partial class merimnaDB : DbContext
    {
        public merimnaDB()
        {
        }

        public merimnaDB(DbContextOptions<merimnaDB> options)
            : base(options)
        {
        }

        public virtual DbSet<Faculty> Faculties { get; set; }
        public virtual DbSet<School> Schools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=./;Database=merimnaDB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Faculty>(entity =>
            {
                entity.ToTable("Faculty");

                entity.Property(e => e.FacultyId).HasColumnName("facultyID");

                entity.Property(e => e.FacultyText)
                    .HasMaxLength(250)
                    .HasColumnName("facultyText");

                entity.Property(e => e.SchoolId).HasColumnName("schoolID");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Faculties)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK_Faculty_School");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("School");

                entity.Property(e => e.SchoolId).HasColumnName("schoolID");

                entity.Property(e => e.ScoolText)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("scoolText");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
