namespace WebPolyclinic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Speciality")]
    public partial class Speciality
    {
        public int Id { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Name { get; set; }

        public int Doctor_id { get; set; }

        public virtual Doctor Doctor { get; set; }
    }
}
