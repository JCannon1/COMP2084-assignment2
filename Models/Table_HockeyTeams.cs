namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_HockeyTeams
    {
        [Key]
        [StringLength(10)]
        public string teamId { get; set; }

        [StringLength(10)]
        public string teamCity { get; set; }

        [StringLength(10)]
        public string teamName { get; set; }

        [StringLength(10)]
        public string teamStanding { get; set; }
    }
}
