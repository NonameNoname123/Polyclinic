namespace WebPolyclinic.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Security.Principal;

    [Table("User")]
    public partial class User : IdentityUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Admin = new HashSet<Admin>();
            //Appointment = new HashSet<Appointment>();
            //Appointment1 = new HashSet<Appointment>();
            Doctor = new HashSet<Doctor>();
            Patient = new HashSet<Patient>();
        }
        
        //public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Surname { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Patronymic { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Login { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Password { get; set; }

        //[Column(TypeName = "text")]
        //[Required]
        //public string Email { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public string DateOfBirth { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Admin> Admin { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointment1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Patient> Patient { get; set; }

    }
}
