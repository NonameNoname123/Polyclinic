namespace WebPolyclinic.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        public int Id { get; set; }

        public int Doctor_id { get; set; }

        public bool CommonAppontment { get; set; }

        public TimeSpan? Duration { get; set; }

        public DateTime? AppontmentDateTime { get; set; }

        public int? Status { get; set; }

        public int? Patient_id { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
