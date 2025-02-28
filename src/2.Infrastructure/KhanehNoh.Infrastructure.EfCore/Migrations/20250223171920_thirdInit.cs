using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhanehNoh.Infrastructure.EfCore.Migrations
{
    public partial class thirdInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Requests_RequestId",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e734cc6c-15b5-471a-8ca5-a6b63c54b96d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ddfaa20b-ab0f-4374-a34c-b5ea80457403");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4ee10808-8264-4fd7-bfd0-2752e4097781");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3edff51c-4530-41b1-8b18-ee84de3b8620", "AQAAAAEAACcQAAAAEEK2y98hAmgA2YF+nRnbWGBn3n8gN4sAhhX/aM62kXt5/z0LddkouOopBHIx+XOwLg==", "08c3df74-9a36-487b-8136-41ab63900b6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ce8675c-415b-478d-855d-b9633514cd37", "AQAAAAEAACcQAAAAEP8Q256EnG1RgpvNJcYGvtb1m2Nc+CSkfru0GpKG4+3b8bs8g9R1sxW7Tdv9Y74j2g==", "f498eda1-a208-44fa-aac8-f213ba8b1226" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea3bb609-d19f-4832-9337-63fe2cc474b3", "AQAAAAEAACcQAAAAEEG9LRefdNK6LGtXkL2o0t1b1vwh/yrnHiryXkh1yASD7LVOhwzIf4zNe5WA6YVM+A==", "f77a55f7-1187-46f2-bf91-e735fa72f466" });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Requests_RequestId",
                table: "Offers",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Offers_Requests_RequestId",
                table: "Offers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "08fbebbf-19f4-4a83-8557-ffa79be217cb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7ac9bb05-2795-49c3-ba10-9a04ff420892");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "4be6ac69-b085-482c-a0ba-c19d616eaf6c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6285aafa-a906-4e4d-b035-a54f73d9dd0a", "AQAAAAEAACcQAAAAENCu5aWJ8ffMX2faLtU/XUMl5+9pLyj5et+YudS0BQIxmZV7fSeNvm8WNzA/Qb+Iwg==", "01325dee-6e2d-4668-9cae-3e1c9c8cef42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d8110a0-d81c-4f02-a5ca-4b09115e9119", "AQAAAAEAACcQAAAAEGc4xKnxpcnpgMs2JO64a5kcpMiQ7N49NQr5d88cpzyDyzn4wXjccA6BIuAlXDqw0Q==", "708b4ab8-b5c7-4c76-90b4-2a58cd06a2ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9503541c-9586-4d07-8ed1-0a5cea224efb", "AQAAAAEAACcQAAAAENC6Jafd/TY9elmsyE1FFtTOlRv/36Em5XECAo7GM/6HT8kUe6o+FY3QShnv0HVuOw==", "c07cfa38-3552-4977-b641-671c19940c1c" });

            migrationBuilder.AddForeignKey(
                name: "FK_Offers_Requests_RequestId",
                table: "Offers",
                column: "RequestId",
                principalTable: "Requests",
                principalColumn: "Id");
        }
    }
}
