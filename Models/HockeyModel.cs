namespace Assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HockeyModel : DbContext
    {
        public HockeyModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Table_HockeyPlayers> Table_HockeyPlayers { get; set; }
        public virtual DbSet<Table_HockeyTeams> Table_HockeyTeams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table_HockeyPlayers>()
                .Property(e => e.playerId)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyPlayers>()
                .Property(e => e.playerName)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyPlayers>()
                .Property(e => e.playerNumber)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyPlayers>()
                .Property(e => e.playerPoints)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyTeams>()
                .Property(e => e.teamId)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyTeams>()
                .Property(e => e.teamCity)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyTeams>()
                .Property(e => e.teamName)
                .IsFixedLength();

            modelBuilder.Entity<Table_HockeyTeams>()
                .Property(e => e.teamStanding)
                .IsFixedLength();
        }
    }
}
