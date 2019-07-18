using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Citizen4a.Models
{
    public partial class db_citizen4Context : DbContext
    {
        public db_citizen4Context()
        {
        }

        public db_citizen4Context(DbContextOptions<db_citizen4Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Candidates> Candidates { get; set; }
        public virtual DbSet<Citizen4> Citizen4 { get; set; }
        public virtual DbSet<Focus> Focus { get; set; }
        public virtual DbSet<FocusCitizen4> FocusCitizen4 { get; set; }
        public virtual DbSet<Messagetype> Messagetype { get; set; }
        public virtual DbSet<MsgCitizen4Candidates> MsgCitizen4Candidates { get; set; }
        public virtual DbSet<Needs> Needs { get; set; }
        public virtual DbSet<NeedsCitizen4> NeedsCitizen4 { get; set; }
        public virtual DbSet<Profiles> Profiles { get; set; }
        public virtual DbSet<Sector> Sector { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersProfiles> UsersProfiles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=a123;database=db_citizen4");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidates>(entity =>
            {
                entity.HasKey(e => e.IdCandidates);

                entity.ToTable("candidates");

                entity.HasIndex(e => e.IdTown)
                    .HasName("fk_Candidates_Town1_idx");

                entity.HasIndex(e => e.IdUsers)
                    .HasName("idUsers_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdCandidates)
                    .HasColumnName("idCandidates")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Description).HasColumnType("varchar(255)");

                entity.Property(e => e.DescriptionCampaign).HasColumnType("varchar(700)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.FullName).HasColumnType("varchar(100)");

                entity.Property(e => e.IdCard)
                    .HasColumnName("idCard")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTown)
                    .HasColumnName("idTown")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdUsers)
                    .HasColumnName("idUsers")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Image).HasColumnType("mediumblob");

                entity.Property(e => e.LinkCampaign).HasColumnType("varchar(255)");

                entity.Property(e => e.LogoCampaign).HasColumnType("mediumblob");

                entity.HasOne(d => d.IdTownNavigation)
                    .WithMany(p => p.Candidates)
                    .HasForeignKey(d => d.IdTown)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Candidates_Town1");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithOne(p => p.Candidates)
                    .HasForeignKey<Candidates>(d => d.IdUsers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Candidates_Users1");
            });

            modelBuilder.Entity<Citizen4>(entity =>
            {
                entity.HasKey(e => e.IdCitizen4);

                entity.ToTable("citizen4");

                entity.HasIndex(e => e.IdCandidates)
                    .HasName("fk_Citizen4_Candidates1_idx");

                entity.HasIndex(e => e.IdTown)
                    .HasName("fk_Citizen4_Town1_idx");

                entity.HasIndex(e => e.IdUsers)
                    .HasName("idUsers_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.IdCitizen4)
                    .HasColumnName("idCitizen4")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Adress).HasColumnType("varchar(45)");

                entity.Property(e => e.Age).HasColumnType("int(3)");

                entity.Property(e => e.CellPhone).HasColumnType("varchar(10)");

                entity.Property(e => e.EconomicActivity).HasColumnType("varchar(45)");

                entity.Property(e => e.EducationLevel).HasColumnType("varchar(45)");

                entity.Property(e => e.Email).HasColumnType("varchar(50)");

                entity.Property(e => e.EmployeedNow).HasColumnType("tinyint(4)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Gender).HasColumnType("varchar(45)");

                entity.Property(e => e.HeadFamily).HasColumnType("tinyint(4)");

                entity.Property(e => e.IdCandidates)
                    .HasColumnName("idCandidates")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdTown)
                    .HasColumnName("idTown")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdUsers)
                    .HasColumnName("idUsers")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Phone).HasColumnType("varchar(10)");

                entity.Property(e => e.Profession).HasColumnType("varchar(45)");

                entity.Property(e => e.TypeTransportUse).HasColumnType("varchar(45)");

                entity.Property(e => e.WageLevel).HasColumnType("varchar(45)");

                entity.Property(e => e.WorkEast).HasColumnType("tinyint(4)");

                entity.HasOne(d => d.IdCandidatesNavigation)
                    .WithMany(p => p.Citizen4)
                    .HasForeignKey(d => d.IdCandidates)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Citizen4_Candidates1");

                entity.HasOne(d => d.IdTownNavigation)
                    .WithMany(p => p.Citizen4)
                    .HasForeignKey(d => d.IdTown)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Citizen4_Town1");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithOne(p => p.Citizen4)
                    .HasForeignKey<Citizen4>(d => d.IdUsers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Citizen4_Users1");
            });

            modelBuilder.Entity<Focus>(entity =>
            {
                entity.HasKey(e => e.IdFocus);

                entity.ToTable("focus");

                entity.Property(e => e.IdFocus)
                    .HasColumnName("idFocus")
                    .HasColumnType("int(4)");

                entity.Property(e => e.DescriptionFocus)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<FocusCitizen4>(entity =>
            {
                entity.HasKey(e => e.IdFocusCitizen4col);

                entity.ToTable("focus_citizen4");

                entity.HasIndex(e => e.IdCitizen4)
                    .HasName("fk_Focus_has_Citizen4_Citizen41_idx");

                entity.HasIndex(e => e.IdFocus)
                    .HasName("fk_Focus_has_Citizen4_Focus1_idx");

                entity.Property(e => e.IdFocusCitizen4col)
                    .HasColumnName("idFocus_Citizen4col")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdCitizen4)
                    .HasColumnName("idCitizen4")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdFocus)
                    .HasColumnName("idFocus")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.IdCitizen4Navigation)
                    .WithMany(p => p.FocusCitizen4)
                    .HasForeignKey(d => d.IdCitizen4)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Focus_has_Citizen4_Citizen41");

                entity.HasOne(d => d.IdFocusNavigation)
                    .WithMany(p => p.FocusCitizen4)
                    .HasForeignKey(d => d.IdFocus)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Focus_has_Citizen4_Focus1");
            });

            modelBuilder.Entity<Messagetype>(entity =>
            {
                entity.HasKey(e => e.IdMessageType);

                entity.ToTable("messagetype");

                entity.Property(e => e.IdMessageType)
                    .HasColumnName("id MessageType")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DescriptionType)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<MsgCitizen4Candidates>(entity =>
            {
                entity.HasKey(e => e.IdMessageCitizen4);

                entity.ToTable("msg_citizen4_candidates");

                entity.HasIndex(e => e.IdCandidates)
                    .HasName("fk_MessageCitizen4_Candidates1_idx");

                entity.HasIndex(e => e.IdCitizen4)
                    .HasName("fk_MessageCitizen4_Citizen41_idx");

                entity.HasIndex(e => e.IdMessageType)
                    .HasName("fk_MessageCitizen4_ MessageType1_idx");

                entity.Property(e => e.IdMessageCitizen4)
                    .HasColumnName("idMessageCitizen4")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Answer).HasColumnType("varchar(45)");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("varchar(150)");

                entity.Property(e => e.IdCandidates)
                    .HasColumnName("idCandidates")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdCitizen4)
                    .HasColumnName("idCitizen4")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdMessageType)
                    .HasColumnName("idMessageType")
                    .HasColumnType("int(5)");

                entity.Property(e => e.Image).HasColumnType("mediumblob");

                entity.Property(e => e.Link).HasColumnType("varchar(300)");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdCandidatesNavigation)
                    .WithMany(p => p.MsgCitizen4Candidates)
                    .HasForeignKey(d => d.IdCandidates)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MessageCitizen4_Candidates1");

                entity.HasOne(d => d.IdCitizen4Navigation)
                    .WithMany(p => p.MsgCitizen4Candidates)
                    .HasForeignKey(d => d.IdCitizen4)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MessageCitizen4_Citizen41");

                entity.HasOne(d => d.IdMessageTypeNavigation)
                    .WithMany(p => p.MsgCitizen4Candidates)
                    .HasForeignKey(d => d.IdMessageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_MessageCitizen4_ MessageType1");
            });

            modelBuilder.Entity<Needs>(entity =>
            {
                entity.HasKey(e => e.IdNeeds);

                entity.ToTable("needs");

                entity.Property(e => e.IdNeeds)
                    .HasColumnName("idNeeds")
                    .HasColumnType("int(4)");

                entity.Property(e => e.DescriptionNeed)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<NeedsCitizen4>(entity =>
            {
                entity.HasKey(e => e.IdNeedsCitizen4);

                entity.ToTable("needs_citizen4");

                entity.HasIndex(e => e.IdCitizen4)
                    .HasName("fk_Needs_Citizen4_Citizen41_idx");

                entity.HasIndex(e => e.IdNeeds)
                    .HasName("fk_Needs_Citizen4_Needs1_idx");

                entity.Property(e => e.IdNeedsCitizen4)
                    .HasColumnName("idNeeds_Citizen4")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdCitizen4)
                    .HasColumnName("idCitizen4")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdNeeds)
                    .HasColumnName("idNeeds")
                    .HasColumnType("int(4)");

                entity.HasOne(d => d.IdCitizen4Navigation)
                    .WithMany(p => p.NeedsCitizen4)
                    .HasForeignKey(d => d.IdCitizen4)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Needs_Citizen4_Citizen41");

                entity.HasOne(d => d.IdNeedsNavigation)
                    .WithMany(p => p.NeedsCitizen4)
                    .HasForeignKey(d => d.IdNeeds)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Needs_Citizen4_Needs1");
            });

            modelBuilder.Entity<Profiles>(entity =>
            {
                entity.HasKey(e => e.IdProfiles);

                entity.ToTable("profiles");

                entity.Property(e => e.IdProfiles)
                    .HasColumnName("idProfiles")
                    .HasColumnType("int(5)");

                entity.Property(e => e.DescriptionProfile).HasColumnType("varchar(45)");

                entity.Property(e => e.NameProfile).HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.IdSector);

                entity.ToTable("sector");

                entity.HasIndex(e => e.IdTown)
                    .HasName("fk_Sector_Town1_idx");

                entity.Property(e => e.IdSector)
                    .HasColumnName("idSector")
                    .HasColumnType("int(5)");

                entity.Property(e => e.IdTown)
                    .HasColumnName("idTown")
                    .HasColumnType("int(4)");

                entity.Property(e => e.NameSector)
                    .IsRequired()
                    .HasColumnType("varchar(45)");

                entity.HasOne(d => d.IdTownNavigation)
                    .WithMany(p => p.Sector)
                    .HasForeignKey(d => d.IdTown)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Sector_Town1");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(e => e.IdTown);

                entity.ToTable("town");

                entity.Property(e => e.IdTown)
                    .HasColumnName("idTown")
                    .HasColumnType("int(4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.IdUsers);

                entity.ToTable("users");

                entity.Property(e => e.IdUsers)
                    .HasColumnName("idUsers")
                    .HasColumnType("int(5)");

                entity.Property(e => e.LoginUsers).HasColumnType("varchar(30)");

                entity.Property(e => e.PassUsers).HasColumnType("varchar(10)");
            });

            modelBuilder.Entity<UsersProfiles>(entity =>
            {
                entity.HasKey(e => e.IdUsersProfiles);

                entity.ToTable("users_profiles");

                entity.HasIndex(e => e.IdProfiles)
                    .HasName("fk_Users_Profiles_Profiles1_idx");

                entity.HasIndex(e => e.IdUsers)
                    .HasName("fk_Users_Profiles_Users1_idx");

                entity.Property(e => e.IdUsersProfiles)
                    .HasColumnName("idUsers_Profiles")
                    .HasColumnType("int(4)");

                entity.Property(e => e.IdProfiles)
                    .HasColumnName("idProfiles")
                    .HasColumnType("int(5)");

                entity.Property(e => e.IdUsers)
                    .HasColumnName("idUsers")
                    .HasColumnType("int(5)");

                entity.HasOne(d => d.IdProfilesNavigation)
                    .WithMany(p => p.UsersProfiles)
                    .HasForeignKey(d => d.IdProfiles)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_Profiles_Profiles1");

                entity.HasOne(d => d.IdUsersNavigation)
                    .WithMany(p => p.UsersProfiles)
                    .HasForeignKey(d => d.IdUsers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Users_Profiles_Users1");
            });
        }
    }
}
