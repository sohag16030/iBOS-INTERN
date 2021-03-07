using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirstCrudeOperationUsingNetCore.Models
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderTest> OrderTest { get; set; }
        public virtual DbSet<PersonTest> PersonTest { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.109.133.151,41527;Database=RND;User Id=rnduser;password=userrnd@321;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderTest>(entity =>
            {
                entity.Property(e => e.IntOrderId).ValueGeneratedNever();

                entity.Property(e => e.StrOrderNumber).IsUnicode(false);

                entity.HasOne(d => d.IntPerson)
                    .WithMany(p => p.OrderTest)
                    .HasForeignKey(d => d.IntPersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__OrderTest__intPe__38996AB5");
            });

            modelBuilder.Entity<PersonTest>(entity =>
            {
                entity.Property(e => e.IntPersonId).ValueGeneratedNever();

                entity.Property(e => e.StrAddress).IsUnicode(false);

                entity.Property(e => e.StrName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
