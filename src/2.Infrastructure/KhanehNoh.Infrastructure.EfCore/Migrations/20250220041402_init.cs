using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhanehNoh.Infrastructure.EfCore.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RegisterAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RegisterAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<double>(type: "float", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "HomeServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BasePrice = table.Column<double>(type: "float", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RegisterAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomeServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HomeServices_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Admins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RequestStatus = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    HomeServiceId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Requests_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_HomeServices_HomeServiceId",
                        column: x => x.HomeServiceId,
                        principalTable: "HomeServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpertHomeService",
                columns: table => new
                {
                    ExpertsId = table.Column<int>(type: "int", nullable: false),
                    HomeServicesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpertHomeService", x => new { x.ExpertsId, x.HomeServicesId });
                    table.ForeignKey(
                        name: "FK_ExpertHomeService_Experts_ExpertsId",
                        column: x => x.ExpertsId,
                        principalTable: "Experts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpertHomeService_HomeServices_HomeServicesId",
                        column: x => x.HomeServicesId,
                        principalTable: "HomeServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ratings_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    OfferStatus = table.Column<int>(type: "int", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    RequestId = table.Column<int>(type: "int", nullable: false),
                    ExpertId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Experts_ExpertId",
                        column: x => x.ExpertId,
                        principalTable: "Experts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Offers_Requests_RequestId",
                        column: x => x.RequestId,
                        principalTable: "Requests",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "ed32aeea-1b3e-43b9-9999-851e0732230c", "Admin", "ADMIN" },
                    { 2, "ee767fb4-1d8e-499c-84a1-e53b455754a5", "Expert", "EXPERT" },
                    { 3, "b725d4cf-882e-443d-b6cf-fe1b2da90d4a", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "IsDeleted", "PictureUrl", "RegisterAt", "Title" },
                values: new object[,]
                {
                    { 1, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "تمیزکاری" },
                    { 2, false, "", new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "ساختمان" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "تهران" },
                    { 2, "مشهد" },
                    { 3, "اصفهان" },
                    { 4, "اهواز" },
                    { 5, "شیراز" },
                    { 6, "تبریز" },
                    { 7, "قم" },
                    { 8, "کرج" },
                    { 9, "رشت" },
                    { 10, "کرمانشاه" },
                    { 11, "زاهدان" },
                    { 12, "ارومیه" },
                    { 13, "یزد" },
                    { 14, "همدان" },
                    { 15, "قزوین" },
                    { 16, "سنندج" },
                    { 17, "بندر عباس" },
                    { 18, "زنجان" },
                    { 19, "ساری" },
                    { 20, "بوشهر" },
                    { 21, "مازندران" },
                    { 22, "گرگان" },
                    { 23, "کرمان" },
                    { 24, "خرم آباد" },
                    { 25, "سمنان" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Balance", "CityId", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "PictureUrl", "RegisterDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "test1", 250000.0, 1, "c373d26c-34d2-408f-9765-0e63f70fa3bd", "Admin@gmail.com", false, "Ali", "Rashedi", false, null, "ADMIN@GMAIL.COM", "ADMIN7878", "AQAAAAEAACcQAAAAELRIJi5U2SJ/IRNDPDUqqITrSWidDOloraFEi1+fSq3mvZ6wzSqOz5GuYnUxAoAKag==", "09036703412", false, "Url", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "85df8af2-f1a6-4d70-8775-a8cd438d5c1f", false, "admin7878" },
                    { 2, 0, "test2", 20000.0, 1, "b128c5f1-8beb-43f3-bcd2-dfaf2f634f2e", "Expert@gmail.com", false, "Reza", "Sadeghi", false, null, "EXPERT@GMAIL.COM", "REZA007", "AQAAAAEAACcQAAAAEC9a7xUDjAzlwnG3NheGFUvIdrgNUr3xe/PwhIEgx8kJ6P29GNAVoWCkpWccdKLyoA==", "09165168696", false, "Url1", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "eeafbc48-de41-45e5-b4e8-9f6715408999", false, "reza007" },
                    { 3, 0, "test3", 20000.0, 1, "7eaaa9c1-f5be-4ef5-92d9-98b7e25b8f63", "arvin2013@gmail.com", false, "Arvin", "Rashedi", false, null, "ARVIN2013@GMAIL.COM", "ARVIN2013", "AQAAAAEAACcQAAAAED9dwBumsbhMA63VD4FZlwLQ6SztBDUEwonETjCn7tZqqn1Aij+K6SnAVmXeDBi9+w==", "09926448610", false, "Url2", new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "94b4e75e-bdfb-484d-ba68-e3783dba828c", false, "arvin2013" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "IsDeleted", "PictureUrl", "RegisterAt", "Title" },
                values: new object[,]
                {
                    { 1, 1, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "نظافت و پذیرایی" },
                    { 2, 1, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "شستشو" },
                    { 3, 1, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "کارواش ودیتیلینگ" },
                    { 4, 2, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "سرمایش و گرمایش" },
                    { 5, 2, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "لوله کشی" },
                    { 6, 2, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), "برقکاری" }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 3 });

            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "UserId" },
                values: new object[] { 1, 2 });

            migrationBuilder.InsertData(
                table: "HomeServices",
                columns: new[] { "Id", "BasePrice", "IsDeleted", "PictureUrl", "RegisterAt", "SubCategoryId", "Title" },
                values: new object[,]
                {
                    { 1, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 1, "سرویس عادی نظافت" },
                    { 2, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 1, "نظافت راه پله" },
                    { 3, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 1, "پذیرایی" },
                    { 5, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 2, "قالی شویی" },
                    { 6, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 2, "پرده شویی" },
                    { 7, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 2, "خشک شویی" },
                    { 8, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 3, "سرامیک خودرو" },
                    { 9, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 3, "کارواش نانو" },
                    { 10, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 3, "کارواش با آب" },
                    { 11, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, "تعمیر و سرویس آبگرمکن" },
                    { 12, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, "تعمیر و نگه داری موتورخانه" },
                    { 13, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 4, "سرویس و تعمیر چیلر" },
                    { 14, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 5, "پمپ و منبع آب" },
                    { 15, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 5, "لوله کشی گاز" },
                    { 16, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 5, "نصب و تعمیر سینک ظرفشویی" },
                    { 17, 300000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 6, "نصب لوستر و چراغ" },
                    { 18, 250000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 6, "کلید و پریز" },
                    { 19, 150000.0, false, null, new DateTime(2025, 2, 16, 12, 45, 0, 0, DateTimeKind.Unspecified), 6, "سیم کشی و کابل کشی" }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "Comment", "CustomerId", "ExpertId", "IsDeleted", "Rate", "RegisterDate", "Status" },
                values: new object[,]
                {
                    { 1, "بسیار خوب", 1, 1, false, 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true },
                    { 2, "عالی بود ", 1, 1, false, 5, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true }
                });

            migrationBuilder.InsertData(
                table: "Requests",
                columns: new[] { "Id", "CityId", "CustomerId", "Description", "EndTime", "HomeServiceId", "IsDeleted", "PictureUrl", "RegisterDate", "RequestStatus", "StartTime", "Title" },
                values: new object[,]
                {
                    { 1, 1, 1, "نظافت راه پله 4طبقه ای", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, false, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "نظافت راه پله" },
                    { 2, 1, 1, "پذیرایی", new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, false, null, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "پذیرایی" }
                });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "DeliveryDate", "Description", "ExpertId", "IsAccepted", "IsDeleted", "OfferStatus", "Price", "RegisterDate", "RequestId" },
                values: new object[] { 1, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "ارزون", 1, false, false, 2, 5000m, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Offers",
                columns: new[] { "Id", "DeliveryDate", "Description", "ExpertId", "IsAccepted", "IsDeleted", "OfferStatus", "Price", "RegisterDate", "RequestId" },
                values: new object[] { 2, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "گرون", 1, false, false, 2, 6000m, new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CityId",
                table: "AspNetUsers",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_UserId",
                table: "Customers",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpertHomeService_HomeServicesId",
                table: "ExpertHomeService",
                column: "HomeServicesId");

            migrationBuilder.CreateIndex(
                name: "IX_Experts_UserId",
                table: "Experts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HomeServices_SubCategoryId",
                table: "HomeServices",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ExpertId",
                table: "Offers",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_RequestId",
                table: "Offers",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_CustomerId",
                table: "Ratings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_ExpertId",
                table: "Ratings",
                column: "ExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CityId",
                table: "Requests",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_CustomerId",
                table: "Requests",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_HomeServiceId",
                table: "Requests",
                column: "HomeServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExpertHomeService");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "Experts");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "HomeServices");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
