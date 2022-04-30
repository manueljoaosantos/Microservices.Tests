using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Data.AdventureWorks.Migrations
{
    public partial class IdentityInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Line1 = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    StateProvince = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CountryRegion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderAddress", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductModel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SalesAgent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    LoginId = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesAgent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Num = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    Color = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    StandardCost = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    ListPrice = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    Size = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,4)", nullable: true),
                    ProductCategoryId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ProductModelId = table.Column<Guid>(type: "TEXT", nullable: true),
                    SellStartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SellEndDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DiscontinuedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ThumbNailPhoto = table.Column<byte[]>(type: "BLOB", maxLength: 5000, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    ProductModelId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductCategoryId1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId1",
                        column: x => x.ProductCategoryId1,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_ProductModel_ProductModelId1",
                        column: x => x.ProductModelId1,
                        principalTable: "ProductModel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Num = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 512, nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", maxLength: 128, nullable: false),
                    SalesAgentId = table.Column<int>(type: "INTEGER", nullable: false),
                    EmailAddress = table.Column<string>(type: "TEXT", maxLength: 250, nullable: false),
                    Phone = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customer_SalesAgent_SalesAgentId",
                        column: x => x.SalesAgentId,
                        principalTable: "SalesAgent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AddressType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Line1 = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    Line2 = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    StateProvince = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CountryRegion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    RevisionNum = table.Column<byte>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<byte>(type: "INTEGER", nullable: false),
                    IsOnlineOrder = table.Column<bool>(type: "INTEGER", nullable: false),
                    Num = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    PurchaseOrderNum = table.Column<string>(type: "TEXT", maxLength: 25, nullable: false),
                    CustomerId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ShipToAddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    BillToAddressId = table.Column<Guid>(type: "TEXT", nullable: true),
                    ShipMethod = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    CreditCardApprovalCode = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    SubTotal = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    TaxAmt = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    Freight = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    TotalDue = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    Comment = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    CustomerId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    ShipToAddressId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderAddressId = table.Column<int>(type: "INTEGER", nullable: true),
                    OrderAddressId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_OrderAddress_OrderAddressId",
                        column: x => x.OrderAddressId,
                        principalTable: "OrderAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_OrderAddress_OrderAddressId1",
                        column: x => x.OrderAddressId1,
                        principalTable: "OrderAddress",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Order_OrderAddress_ShipToAddressId1",
                        column: x => x.ShipToAddressId1,
                        principalTable: "OrderAddress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderLineItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    OrderId = table.Column<Guid>(type: "TEXT", nullable: false),
                    OrderQty = table.Column<short>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UnitPrice = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    UnitPriceDiscount = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    LineTotal = table.Column<double>(type: "decimal(18,4)", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    CreatedOnUtc = table.Column<long>(type: "INTEGER", nullable: false),
                    UpdatedBy = table.Column<string>(type: "TEXT", maxLength: 320, nullable: false),
                    UpdatedOnUtc = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    OrderId1 = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId1 = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderLineItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderLineItem_Order_OrderId1",
                        column: x => x.OrderId1,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderLineItem_Product_ProductId1",
                        column: x => x.ProductId1,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_SalesAgentId",
                table: "Customer",
                column: "SalesAgentId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId1",
                table: "Order",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderAddressId",
                table: "Order",
                column: "OrderAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_OrderAddressId1",
                table: "Order",
                column: "OrderAddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ShipToAddressId1",
                table: "Order",
                column: "ShipToAddressId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_OrderId1",
                table: "OrderLineItem",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderLineItem_ProductId1",
                table: "OrderLineItem",
                column: "ProductId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId1",
                table: "Product",
                column: "ProductCategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductModelId1",
                table: "Product",
                column: "ProductModelId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "OrderLineItem");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "OrderAddress");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "ProductModel");

            migrationBuilder.DropTable(
                name: "SalesAgent");
        }
    }
}
