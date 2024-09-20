using Microsoft.EntityFrameworkCore.Migrations;


namespace NFL_Today.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PTS = table.Column<int>(type: "INTEGER", nullable: false),
                    FPTS = table.Column<int>(type: "INTEGER", nullable: false),
                    Plays = table.Column<int>(type: "INTEGER", nullable: false),
                    Yds = table.Column<int>(type: "INTEGER", nullable: false),
                    Int = table.Column<int>(type: "INTEGER", nullable: false),
                    Pass_Yds = table.Column<int>(type: "INTEGER", nullable: false),
                    Pass_Att = table.Column<int>(type: "INTEGER", nullable: false),
                    Pass_Comp = table.Column<int>(type: "INTEGER", nullable: false),
                    Pass_TD = table.Column<int>(type: "INTEGER", nullable: false),
                    Rush_Yds = table.Column<int>(type: "INTEGER", nullable: false),
                    Rush_Att = table.Column<int>(type: "INTEGER", nullable: false),
                    Rush_TD = table.Column<int>(type: "INTEGER", nullable: false),
                    TD = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_Att = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_TD = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_TD1 = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_2D = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_3D = table.Column<int>(type: "INTEGER", nullable: false),
                    RZ_4D = table.Column<int>(type: "INTEGER", nullable: false),
                    TO = table.Column<int>(type: "INTEGER", nullable: false),
                    SCKS_Allow = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
