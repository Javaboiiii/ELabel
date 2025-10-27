using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELabel.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(450)", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "character varying(450)", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Category = table.Column<int>(type: "integer", nullable: false),
                    ENumber = table.Column<int>(type: "integer", nullable: true),
                    Allergen = table.Column<bool>(type: "boolean", nullable: false),
                    Custom = table.Column<bool>(type: "boolean", nullable: false),
                    LocalizableStrings = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Volume = table.Column<float>(type: "real", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    Kind = table.Column<int>(type: "integer", nullable: false),
                    WineVintage = table.Column<int>(type: "integer", nullable: true),
                    WineType = table.Column<int>(type: "integer", nullable: true),
                    WineSugarContent = table.Column<int>(type: "integer", nullable: true),
                    WineAppellation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    WineAlcohol = table.Column<float>(type: "real", nullable: true),
                    PackagingGases = table.Column<int>(type: "integer", nullable: false),
                    NutritionInformation_PortionVolume = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_Energy_Kilocalorie = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_Energy_Kilojoule = table.Column<float>(type: "real", nullable: true),
                    NutritionInformation_FatTotal = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_FatSaturates = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_CarbohydrateTotal = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_CarbohydrateSugar = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_Protein = table.Column<float>(type: "real", nullable: false),
                    NutritionInformation_Salt = table.Column<float>(type: "real", nullable: false),
                    ResponsibleConsumption_WarningDrinkingDuringPregnancy = table.Column<bool>(type: "boolean", nullable: false),
                    ResponsibleConsumption_WarningDrinkingBelowLegalAge = table.Column<bool>(type: "boolean", nullable: false),
                    ResponsibleConsumption_WarningDrinkingWhenDriving = table.Column<bool>(type: "boolean", nullable: false),
                    Certifications_Organic = table.Column<bool>(type: "boolean", nullable: false),
                    Certifications_Vegetarian = table.Column<bool>(type: "boolean", nullable: false),
                    Certifications_Vegan = table.Column<bool>(type: "boolean", nullable: false),
                    FBOType = table.Column<int>(type: "integer", nullable: false),
                    FBOName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FBOAddress = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    FBOAdditionalInfo = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Country = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: true),
                    Sku = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    Ean = table.Column<decimal>(type: "numeric(20,0)", nullable: true),
                    ExternalShortUrl = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    RedirectUrl = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UpdatedBy = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "character varying(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", Npgsql.EntityFrameworkCore.PostgreSQL.Metadata.NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "character varying(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "character varying(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "character varying(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "character varying(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "character varying(450)", nullable: false),
                    RoleId = table.Column<string>(type: "character varying(450)", nullable: false)
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
                    UserId = table.Column<string>(type: "character varying(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "character varying(450)", nullable: false),
                    Name = table.Column<string>(type: "character varying(450)", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
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
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ContentType = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Content = table.Column<byte[]>(type: "bytea", nullable: false),
                    Width = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<int>(type: "integer", nullable: false),
                    PixelDensity = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductIngredient",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    IngredientId = table.Column<Guid>(type: "uuid", nullable: false),
                    Order = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductIngredient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductIngredient_Ingredient_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductIngredient_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "NormalizedName IS NOT NULL");

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
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "NormalizedUserName IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductId_PixelDensity",
                table: "Image",
                columns: new[] { "ProductId", "PixelDensity" },
                unique: true,
                filter: "PixelDensity IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Ingredient_Name_Category",
                table: "Ingredient",
                columns: new[] { "Name", "Category" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredient_IngredientId",
                table: "ProductIngredient",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductIngredient_ProductId_IngredientId",
                table: "ProductIngredient",
                columns: new[] { "ProductId", "IngredientId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Image");

            migrationBuilder.DropTable(
                name: "ProductIngredient");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
