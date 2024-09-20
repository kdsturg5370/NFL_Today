
namespace NFL_Today.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Season { get; set; }
        public int PTS { get; set; }

        public int FPTS { get; set; }

        public int Plays { get; set; }

        public int Yds { get; set; }

        public int Int { get; set; }

        public int Pass_Yds { get; set; }

        public int Pass_Att { get; set; }

        public int Pass_Comp { get; set; }

        public int Pass_TD { get; set; }

        public int Rush_Yds { get; set; }

        public int Rush_Att { get; set; }

        public int Rush_TD { get; set; }

        public int TD { get; set; }

        public int RZ_Att { get; set; }

        public int RZ_TD { get; set; }

        public int RZ_TD1 { get; set; }

        public int RZ_2D { get; set; }

        public int RZ_3D { get; set; }

        public int RZ_4D { get; set; }

        public int TO { get; set; }

        public int SCKS_Allow { get; set; }
    }

    public class Team_Roster
    {
        public int Id { get; set; }
        public string? Team { get; set; }
        public string? Pos { get; set; }
        public string? Name { get; set; }
        public int No { get; set; }
        public int Rating { get; set; }
        public int Ranking { get; set; }
        public string? Height { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }
        public string? Birthday { get; set; }
        public int Exp { get; set; }
        public int Drafted { get; set; }
        public int DraftRound { get; set; }
        public int DraftPick { get;set; }
        public string? College { get; set; }

       
    }
}
