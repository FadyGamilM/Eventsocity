using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eventsocity.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class SeedingTheEventsEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[,]
                {
                    { 1, "Sports", "Egypt", new DateTime(2023, 1, 8, 14, 43, 11, 989, DateTimeKind.Utc).AddTicks(8621), "Let's play a padel game from 9 to 10 after 2 days, who is comming ! .. ", "Playing Padel", "Nasr City, Nady El Shams" },
                    { 2, "Fun", "Egypt", new DateTime(2023, 1, 7, 14, 43, 11, 989, DateTimeKind.Utc).AddTicks(8631), "I need to watch avatar 2 at cairo festival tommowrow and, anyone interested..", "Watching Avatar 2", "Cairo Festival" },
                    { 3, "Sports", "Egypt", new DateTime(2023, 1, 10, 14, 43, 11, 989, DateTimeKind.Utc).AddTicks(8633), "lets play 2 hours of football, i need 9 people", "Playing Footbal", "Nady el Shams" },
                    { 4, "Social", "Egypt", new DateTime(2023, 1, 6, 16, 43, 11, 989, DateTimeKind.Utc).AddTicks(8634), "I am having a break for 2 hours, anyone interested to have a lauch and a good talk, i need to eat in papa jones btw", "Having Launch", "Papa jones" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
