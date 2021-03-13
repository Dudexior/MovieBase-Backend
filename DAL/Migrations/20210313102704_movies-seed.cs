using Microsoft.EntityFrameworkCore.Migrations;

namespace DAL.Migrations
{
    public partial class moviesseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Duration", "ImageId", "Title" },
                values: new object[,]
                {
                    { 1L, "A police officer joins a secret organization that polices and monitors extraterrestrial interactions on Earth.", 98, null, "Men in Black" },
                    { 2L, "When bitten by a genetically modified spider, a nerdy, shy, and awkward high school student gains spider-like abilities that he eventually must use to fight evil as a superhero after tragedy befalls his family.", 120, null, "Spider-Man" },
                    { 3L, "The aliens are coming and their goal is to invade and destroy Earth. Fighting superior technology, mankind's best weapon is the will to survive.", 145, null, "Independence Day" },
                    { 4L, "A chaotic battle ensues between Jerry Mouse, who has taken refuge in the Royal Gate Hotel, and Tom Cat, who is hired to drive him away before the day of a big wedding arrives.", 101, null, "Tom and Jerry" },
                    { 5L, "The epic next chapter in the cinematic Monsterverse pits two of the greatest icons in motion picture history against one another - the fearsome Godzilla and the mighty Kong - with humanity caught in the balance.", 120, null, "Godzilla vs. Kong" },
                    { 6L, "A quiet drifter is tricked into a janitorial job at the now condemned Willy's Wonderland. The mundane tasks suddenly become an all-out fight for survival against wave after wave of demonic animatronics. Fists fly, kicks land, titans clash -- and only one side will make it out alive.", 82, null, "Willy's Wonderland " },
                    { 7L, "NBA superstar LeBron James teams up with Bugs Bunny and the rest of the Looney Tunes for this long-awaited sequel.", 123, null, "Space Jam: A New Legacy" },
                    { 8L, "A couple travels to Scandinavia to visit a rural hometown's fabled Swedish mid-summer festival. What begins as an idyllic retreat quickly devolves into an increasingly violent and bizarre competition at the hands of a pagan cult.", 148, null, "Midsommar" },
                    { 9L, "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", 154, null, "Pulp Fiction" },
                    { 10L, "An insomniac office worker and a devil-may-care soapmaker form an underground fight club that evolves into something much, much more.", 139, null, "Fight Club" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
