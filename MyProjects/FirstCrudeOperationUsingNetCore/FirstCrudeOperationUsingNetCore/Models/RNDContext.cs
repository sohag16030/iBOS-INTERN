using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class RNDContext : DbContext
    {

        public RNDContext(DbContextOptions<RNDContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderTest> OrderTest { get; set; }
        public virtual DbSet<PersonTest> PersonTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.109.133.151,41527;Database=RND; User Id =rnduser;Password = userrnd@321;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OrderTest>(entity =>
            {
                entity.HasKey(e => e.IntOrderId)
                    .HasName("PK_OrderTest_1");

                entity.Property(e => e.IntOrderId).HasColumnName("intOrderID");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.StrOrderNumber)
                    .IsRequired()
                    .HasColumnName("strOrderNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonTest>(entity =>
            {
                entity.HasKey(e => e.IntPersonId);

                entity.Property(e => e.IntPersonId).HasColumnName("intPersonID");

                entity.Property(e => e.StrAddress)
                    .IsRequired()
                    .HasColumnName("strAddress")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StrName)
                    .IsRequired()
                    .HasColumnName("strName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.HasSequence("seq_ts_nanoseconds")
                .StartsAt(0)
                .IncrementsBy(100)
                .HasMin(0)
                .HasMax(99999900)
                .IsCyclic();

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
