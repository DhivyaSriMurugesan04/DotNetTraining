using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DAL_Reference.Models
{
    public partial class FlightBookingApplicationDBContext : DbContext
    {
        public FlightBookingApplicationDBContext()
        {
        }

        public FlightBookingApplicationDBContext(DbContextOptions<FlightBookingApplicationDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFlightDetail> TblFlightDetails { get; set; }
        public virtual DbSet<TblUserDataDetail> TblUserDataDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning // To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=CTSDOTNET35;Initial Catalog=FlightBookingApplicationDB;User ID=sa;Password=pass@word1;Persist security Info=True");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblFlightDetail>(entity =>
            {
                entity.HasKey(e => e.FlightId)
                    .HasName("PK__tblFligh__8A9E148E3FEFBFD6");

                entity.ToTable("tblFlightDetails");

                entity.Property(e => e.FlightId)
                    .ValueGeneratedNever()
                    .HasColumnName("FlightID");

                entity.Property(e => e.AirLineName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FromPlace)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TicketCost)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ToPlace)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserDataDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUserD__1788CCAC5AB491C7");

                entity.ToTable("tblUserDataDetails");

                entity.Property(e => e.UserId)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("UserID");

                entity.Property(e => e.Email)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PassWord)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreatedOn).HasColumnType("datetime");

                entity.Property(e => e.UserUpdatedOn).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
