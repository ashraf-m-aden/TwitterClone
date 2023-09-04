using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Entities.Migrations
{
    /// <inheritdoc />
    public partial class TweetInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tweets",
                columns: table => new
                {
                    IdTweet = table.Column<Guid>(type: "uuid", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    IdUser = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Media = table.Column<byte[]>(type: "bytea", nullable: true),
                    Tag = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tweets", x => x.IdTweet);
                });

            migrationBuilder.InsertData(
                table: "Tweets",
                columns: new[] { "IdTweet", "Content", "CreatedTime", "IdUser", "Media", "Tag" },
                values: new object[] { new Guid("ae86ae1c-a2be-418d-9bbb-c50ca36518f9"), "Tweet enregistré à l'initialisation", null, new Guid("00000000-0000-0000-0000-000000000000"), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tweets");
        }
    }
}
