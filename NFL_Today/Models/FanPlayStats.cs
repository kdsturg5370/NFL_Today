
namespace NFL_Today.Models
{
    public class Player_Fantasy_Stats
    {
        public int Id { get; set; }
        public string? Full_Name { get; set; }
        public string? Team { get; set; }

        public string? Position { get; set; }

        public int Games { get; set; }

        public float Snaps_PG { get; set; }

        public float Pct_Team_Snaps { get; set; }

        public float Pct_Team_First_Snaps { get; set; }

        public float Pct_Team_Second_Snaps { get; set; }

        public float Pct_Team_Third_Snaps { get; set; }

        public float RZ_Snaps_PG { get; set; }

        public float Pct_Team_RZ_Snaps { get; set; }

        public float Ppr_Points { get; set; }

        public float Ppr_Points_PG { get; set; }

        public float Exp_Fpts { get; set; }

        public float Exp_Fpts_PG { get; set; }

        public float Fpoe { get; set; }

        public float Fpoe_PG { get; set; }

        public int Exp_Pass_Fpts { get; set; }

        public int Exp_Pass_Fpts_PG { get; set; }

        public float Exp_Rush_Fpts { get; set; }

        public float Exp_Rush_Fpts_PG { get; set; }

        public int Exp_Rec_Fpts { get; set; }

        public int Exp_Rec_Fpts_PG { get; set; }

    }
}
