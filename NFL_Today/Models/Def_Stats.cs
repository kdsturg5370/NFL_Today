
namespace NFL_Today.Models
{
    public class Def_Stats
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string? Team { get; set; }

        public string? Player { get; set; }

        public string? Position { get; set; }

        public int GamesPlayed { get; set; }

        public int SoloTackles { get; set; }

        public int AssistedTackles { get; set; }

        public int TotalTackles { get; set; }

        public int Sacks { get; set; }

        public int SackYards { get; set; }

        public int TacklesforLoss { get; set; }

        public int PassesDefended { get; set; }

        public int Interceptions { get; set; }

        public int InterceptionReturnYards { get; set; }

        public int LongInterception { get; set; }

        public int ReturnTouchdowns { get; set; }

        public int ForcedFumbles { get; set; }

        public int FumblesRecovered { get; set; }

        public int FumbleTouchdown { get; set; }

       

    }
}
