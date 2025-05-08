using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PakMart.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _Product_and_Related : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "ShortDescription");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Products",
                newName: "Returnable");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "SKU");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Products",
                newName: "Warehouse");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryId",
                table: "Categories",
                newName: "PictureId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                newName: "IX_Categories_PictureId");

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Aisle",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Bin",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CostPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Diameter",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Freight",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FullDescription",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Length",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinimumStock",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OpeningStock",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Rack",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RemainingDays",
                table: "Products",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SalesTax",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WarrantyEndDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "WarrantyStartDate",
                table: "Products",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Width",
                table: "Products",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FullDesc",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IncludeInTopMenu",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Publish",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowOnHomePage",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MimeType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product_Category_Mapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Category_Mapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_Mapping_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_Mapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    Publish = table.Column<bool>(type: "bit", nullable: false),
                    FullDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PictureBinary",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureId = table.Column<int>(type: "int", nullable: false),
                    BinaryData = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureBinary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PictureBinary_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Picture_Mapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PictureId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Picture_Mapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Picture_Mapping_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Picture_Mapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product_Manufacturer_Mapping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Manufacturer_Mapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer_Mapping_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Manufacturer_Mapping_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_PictureId",
                table: "Manufacturers",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureBinary_PictureId",
                table: "PictureBinary",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Mapping_CategoryId",
                table: "Product_Category_Mapping",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Category_Mapping_ProductId",
                table: "Product_Category_Mapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Manufacturer_Mapping_ManufacturerId",
                table: "Product_Manufacturer_Mapping",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Manufacturer_Mapping_ProductId",
                table: "Product_Manufacturer_Mapping",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Picture_Mapping_PictureId",
                table: "Product_Picture_Mapping",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Picture_Mapping_ProductId",
                table: "Product_Picture_Mapping",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories",
                column: "PictureId",
                principalTable: "Pictures",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Pictures_PictureId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "PictureBinary");

            migrationBuilder.DropTable(
                name: "Product_Category_Mapping");

            migrationBuilder.DropTable(
                name: "Product_Manufacturer_Mapping");

            migrationBuilder.DropTable(
                name: "Product_Picture_Mapping");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropColumn(
                name: "Aisle",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Bin",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CostPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Diameter",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Freight",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "FullDescription",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Length",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MinimumStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "OpeningStock",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rack",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "RemainingDays",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SalesTax",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WarrantyEndDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "WarrantyStartDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Width",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "FullDesc",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IncludeInTopMenu",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Publish",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ShowOnHomePage",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "Warehouse",
                table: "Products",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "ShortDescription",
                table: "Products",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SKU",
                table: "Products",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Returnable",
                table: "Products",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "PictureId",
                table: "Categories",
                newName: "ParentCategoryId");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Name");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_PictureId",
                table: "Categories",
                newName: "IX_Categories_ParentCategoryId");

            migrationBuilder.AlterColumn<int>(
                name: "VendorId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Vendors_VendorId",
                table: "Products",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
