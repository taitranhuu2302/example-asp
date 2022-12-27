using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Example.Migrations
{
    /// <inheritdoc />
    public partial class filter : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "217b0aa9-74af-4597-b7a9-c12d51f5837a");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "411016bd-458c-457a-ac95-2b7ea9d3e1d7");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "8936d358-b6bb-408e-a497-2e7cd7e4e548");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "8d47d59f-3bf0-400c-b4de-12938fb4e494");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "ad6d97bd-3182-4658-b56c-fcc9161f3bfd");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "c5725e41-2731-4f41-aa43-31f3f3d10607");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "c5f1b62a-56e6-4bd8-b4f3-5fb6245de8ad");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "ca8367df-ec2c-418f-b441-a3efc3131edf");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "f6a16501-e56c-41a0-884c-d03a27adc4c6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "faa87278-04a7-4623-ac92-7d7530910cd8");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Country", "CreatedAt", "Email", "FullName", "IsDeleted", "NumberPhone", "UpdatedAt" },
                values: new object[,]
                {
                    { "3778be59-0fb3-4378-ba64-991c4707f758", "Interactions", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9435), "Lonny Krajcik@gmail.com", "Wilfredo Mayert", false, "(826) 330-6805 x44041", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9436) },
                    { "386cae1a-9c46-4b56-8e44-8daea8657e70", "Accountability", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(7865), "Iliana Ledner@gmail.com", "Zachary Weber", false, "1-936-404-4299", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(7882) },
                    { "4e068800-a3d6-40d7-b4ac-eab3ce4cea83", "Identity", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9838), "Katlyn Roberts@gmail.com", "Dorcas Wuckert", false, "(897) 973-8084 x319", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9840) },
                    { "8a9929dc-ab7f-4cd1-8363-c70063d88d7e", "Tactics", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9616), "Allan Hyatt@gmail.com", "Daniella Thiel", false, "(825) 903-8565", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9617) },
                    { "a9bcacc7-cbcc-4b45-83d6-740b6ef743c6", "Operations", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9183), "Trudie Windler@gmail.com", "Julio Bergnaum", false, "830.780.7969 x394", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9184) },
                    { "b238ea11-5ada-4c69-b115-f53cc63f8cdb", "Security", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(8977), "Waldo Ward@gmail.com", "Sally Steuber", false, "456.894.0401", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(8981) },
                    { "c1941d5b-00ad-4950-ba65-e9638d2788b3", "Assurance", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9521), "Justina Beatty@gmail.com", "Claud Thompson", false, "(795) 999-9018", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9523) },
                    { "f0156a90-f559-4c4a-b45a-d7c45e4b1ab6", "Web", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9691), "Felipe Abbott@gmail.com", "Helene Marvin", false, "881.955.9418 x924", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9692) },
                    { "f3832fff-261c-4923-879d-96c60cf96248", "Implementation", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9348), "Carrie Olson@gmail.com", "Cindy Schmeler", false, "762-496-1795 x1333", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9350) },
                    { "f44a2150-5fe9-46be-b71e-b45160e0337e", "Communications", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9087), "Kirk Corwin@gmail.com", "Cristal Jast", false, "331.422.2397 x723", new DateTime(2022, 12, 27, 16, 22, 4, 605, DateTimeKind.Local).AddTicks(9089) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "3778be59-0fb3-4378-ba64-991c4707f758");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "386cae1a-9c46-4b56-8e44-8daea8657e70");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "4e068800-a3d6-40d7-b4ac-eab3ce4cea83");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "8a9929dc-ab7f-4cd1-8363-c70063d88d7e");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "a9bcacc7-cbcc-4b45-83d6-740b6ef743c6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "b238ea11-5ada-4c69-b115-f53cc63f8cdb");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "c1941d5b-00ad-4950-ba65-e9638d2788b3");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "f0156a90-f559-4c4a-b45a-d7c45e4b1ab6");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "f3832fff-261c-4923-879d-96c60cf96248");

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: "f44a2150-5fe9-46be-b71e-b45160e0337e");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Country", "CreatedAt", "Email", "FullName", "IsDeleted", "NumberPhone", "UpdatedAt" },
                values: new object[,]
                {
                    { "217b0aa9-74af-4597-b7a9-c12d51f5837a", "Integration", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3881), "Kasey Jerde@gmail.com", "Haylie Hand", false, "(550) 592-5865 x09486", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3883) },
                    { "411016bd-458c-457a-ac95-2b7ea9d3e1d7", "Identity", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4444), "Germaine Ruecker@gmail.com", "Damion Kub", false, "776.830.5878 x078", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4445) },
                    { "8936d358-b6bb-408e-a497-2e7cd7e4e548", "Security", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4343), "Brennon Miller@gmail.com", "Missouri Leffler", false, "(451) 385-0926 x60498", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4344) },
                    { "8d47d59f-3bf0-400c-b4de-12938fb4e494", "Response", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4241), "Monica Dickinson@gmail.com", "Terence Fadel", false, "424-255-7510", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4244) },
                    { "ad6d97bd-3182-4658-b56c-fcc9161f3bfd", "Operations", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3442), "Nathanial D'Amore@gmail.com", "Rogers Kiehn", false, "(534) 333-3797 x822", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3447) },
                    { "c5725e41-2731-4f41-aa43-31f3f3d10607", "Brand", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3789), "Shaina Hane@gmail.com", "Immanuel Kris", false, "1-232-783-3418", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3790) },
                    { "c5f1b62a-56e6-4bd8-b4f3-5fb6245de8ad", "Accounts", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3688), "Brittany Stroman@gmail.com", "Eleanora Gerlach", false, "912-697-8698", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3691) },
                    { "ca8367df-ec2c-418f-b441-a3efc3131edf", "Data", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(2476), "Malcolm Turner@gmail.com", "Freida Wisozk", false, "(776) 806-4242", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(2493) },
                    { "f6a16501-e56c-41a0-884c-d03a27adc4c6", "Security", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3982), "Ebba Ward@gmail.com", "Elmer Schneider", false, "(861) 423-8554 x3634", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(3983) },
                    { "faa87278-04a7-4623-ac92-7d7530910cd8", "Infrastructure", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4082), "Jaylon Ziemann@gmail.com", "Jermey Zemlak", false, "1-663-573-4426", new DateTime(2022, 12, 27, 14, 26, 57, 469, DateTimeKind.Local).AddTicks(4083) }
                });
        }
    }
}
