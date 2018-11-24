namespace WebPolyclinic.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ConnectionModel : DbContext
    {
        public ConnectionModel()
            : base("name=ConnectionModel")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasMany(e => e.Speciality)
                .WithRequired(e => e.Doctor)
                .HasForeignKey(e => e.Doctor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Policy)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Passport)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Patient>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Speciality>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Surname)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Admin)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointment)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.Doctor_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Appointment1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.Patient_id);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Doctor)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Patient)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.User_id)
                .WillCascadeOnDelete(false);
        }
    }
}
