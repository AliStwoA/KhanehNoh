using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhanehNoh.Infrastructure.EfCore.Migrations
{
    public partial class SecoundInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeServices_SubCategories_SubCategoryId",
                table: "HomeServices");

            migrationBuilder.AlterColumn<string>(
                name: "PictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "FK_HomeServices_SubCategories_SubCategoryId",
                table: "HomeServices",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HomeServices_SubCategories_SubCategoryId",
                table: "HomeServices");

            migrationBuilder.AlterColumn<string>(
                name: "PictureUrl",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "ed32aeea-1b3e-43b9-9999-851e0732230c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "ee767fb4-1d8e-499c-84a1-e53b455754a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b725d4cf-882e-443d-b6cf-fe1b2da90d4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c373d26c-34d2-408f-9765-0e63f70fa3bd", "AQAAAAEAACcQAAAAELRIJi5U2SJ/IRNDPDUqqITrSWidDOloraFEi1+fSq3mvZ6wzSqOz5GuYnUxAoAKag==", "85df8af2-f1a6-4d70-8775-a8cd438d5c1f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b128c5f1-8beb-43f3-bcd2-dfaf2f634f2e", "AQAAAAEAACcQAAAAEC9a7xUDjAzlwnG3NheGFUvIdrgNUr3xe/PwhIEgx8kJ6P29GNAVoWCkpWccdKLyoA==", "eeafbc48-de41-45e5-b4e8-9f6715408999" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eaaa9c1-f5be-4ef5-92d9-98b7e25b8f63", "AQAAAAEAACcQAAAAED9dwBumsbhMA63VD4FZlwLQ6SztBDUEwonETjCn7tZqqn1Aij+K6SnAVmXeDBi9+w==", "94b4e75e-bdfb-484d-ba68-e3783dba828c" });

            migrationBuilder.AddForeignKey(
                name: "FK_HomeServices_SubCategories_SubCategoryId",
                table: "HomeServices",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id");
        }
    }
}
