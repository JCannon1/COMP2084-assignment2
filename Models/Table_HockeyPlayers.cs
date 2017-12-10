namespace Assignment2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Table_HockeyPlayers
    {
        [Key]
        [StringLength(10)]
        public string playerId { get; set; }

        [StringLength(10)]
        public string playerName { get; set; }

        [StringLength(10)]
        public string playerNumber { get; set; }

        [StringLength(10)]
        public string playerPoints { get; set; }
    }
}
