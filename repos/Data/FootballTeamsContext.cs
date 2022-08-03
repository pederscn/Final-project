namespace repos.Data{
    public class FootballTeamsContext: DbContext
    {
        public FootballTeamsContext(DbContextOptions<FootballTeamsContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FootballTeam>HasData(
                new FootballTeam { Id = 1, City = "Buffalo", Name = "Bills", SuperbowlAppearances = 4"}
                new FootballTeam { Id = 2, City = "San Francisco", Name = "49ers", SuperbowlAppearances = 6"}
                
                )
        }

        public DbSet<FootballTeam> FootballTeams { get; set; }

    }
}