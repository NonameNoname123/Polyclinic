namespace WebPolyclinic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Policy { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Passport { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Address { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string PhoneNumber { get; set; }

        public int User_id { get; set; }

        public virtual User User { get; set; }
    }
}
