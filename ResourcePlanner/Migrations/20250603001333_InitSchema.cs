using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResourcePlanner.Migrations
{
    /// <inheritdoc />
    public partial class InitSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coup_coupons",
                columns: table => new
                {
                    CouponId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Code = table.Column<string>(type: "TEXT", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coup_coupons", x => x.CouponId);
                });

            migrationBuilder.CreateTable(
                name: "coup_loyalty_programs",
                columns: table => new
                {
                    LoyaltyProgramId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Rules = table.Column<string>(type: "TEXT", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coup_loyalty_programs", x => x.LoyaltyProgramId);
                });

            migrationBuilder.CreateTable(
                name: "hr_roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PermissionsJson = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hr_roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "inv_categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inv_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "inv_warehouses",
                columns: table => new
                {
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inv_warehouses", x => x.WarehouseId);
                });

            migrationBuilder.CreateTable(
                name: "pos_loyalty_customers",
                columns: table => new
                {
                    LoyaltyCustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    Contact = table.Column<string>(type: "TEXT", nullable: false),
                    Points = table.Column<int>(type: "INTEGER", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pos_loyalty_customers", x => x.LoyaltyCustomerId);
                });

            migrationBuilder.CreateTable(
                name: "pur_suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Contact = table.Column<string>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pur_suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "auth_users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_auth_users_hr_roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "hr_roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inv_products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inv_products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_inv_products_inv_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "inv_categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pur_purchase_orders",
                columns: table => new
                {
                    PurchaseOrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SupplierId = table.Column<int>(type: "INTEGER", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pur_purchase_orders", x => x.PurchaseOrderId);
                    table.ForeignKey(
                        name: "FK_pur_purchase_orders_pur_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "pur_suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "auth_audit_logs",
                columns: table => new
                {
                    AuditLogId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    Action = table.Column<string>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auth_audit_logs", x => x.AuditLogId);
                    table.ForeignKey(
                        name: "FK_auth_audit_logs_auth_users_UserId",
                        column: x => x.UserId,
                        principalTable: "auth_users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hr_employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    NIC = table.Column<string>(type: "TEXT", nullable: false),
                    Contact = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hr_employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_hr_employees_auth_users_UserId",
                        column: x => x.UserId,
                        principalTable: "auth_users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "coup_promotions",
                columns: table => new
                {
                    PromotionId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "TEXT", nullable: false),
                    ValidFrom = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coup_promotions", x => x.PromotionId);
                    table.ForeignKey(
                        name: "FK_coup_promotions_inv_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "inv_products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inv_batches",
                columns: table => new
                {
                    BatchId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CostPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    SellingPrice = table.Column<decimal>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inv_batches", x => x.BatchId);
                    table.ForeignKey(
                        name: "FK_inv_batches_inv_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "inv_products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inv_batches_inv_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "inv_warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rpt_inventory_reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReportDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    WarehouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantityInStock = table.Column<int>(type: "INTEGER", nullable: false),
                    QuantitySold = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rpt_inventory_reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_rpt_inventory_reports_inv_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "inv_products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rpt_inventory_reports_inv_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "inv_warehouses",
                        principalColumn: "WarehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pur_purchase_order_items",
                columns: table => new
                {
                    PurchaseOrderItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PurchaseOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    Cost = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pur_purchase_order_items", x => x.PurchaseOrderItemId);
                    table.ForeignKey(
                        name: "FK_pur_purchase_order_items_inv_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "inv_products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pur_purchase_order_items_pur_purchase_orders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "pur_purchase_orders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hr_payrolls",
                columns: table => new
                {
                    PayrollId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Month = table.Column<int>(type: "INTEGER", nullable: false),
                    Year = table.Column<int>(type: "INTEGER", nullable: false),
                    BaseSalary = table.Column<decimal>(type: "TEXT", nullable: false),
                    Bonus = table.Column<decimal>(type: "TEXT", nullable: false),
                    Deductions = table.Column<decimal>(type: "TEXT", nullable: false),
                    AddedBy = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    AddedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hr_payrolls", x => x.PayrollId);
                    table.ForeignKey(
                        name: "FK_hr_payrolls_hr_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hr_roasters",
                columns: table => new
                {
                    RoasterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    ShiftDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ShiftType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hr_roasters", x => x.RoasterId);
                    table.ForeignKey(
                        name: "FK_hr_roasters_hr_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pos_invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LoyaltyCustomerId = table.Column<int>(type: "INTEGER", nullable: true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pos_invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_pos_invoices_hr_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pos_invoices_pos_loyalty_customers_LoyaltyCustomerId",
                        column: x => x.LoyaltyCustomerId,
                        principalTable: "pos_loyalty_customers",
                        principalColumn: "LoyaltyCustomerId");
                });

            migrationBuilder.CreateTable(
                name: "pur_goods_received",
                columns: table => new
                {
                    GoodsReceivedId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PurchaseOrderId = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceivedById = table.Column<int>(type: "INTEGER", nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pur_goods_received", x => x.GoodsReceivedId);
                    table.ForeignKey(
                        name: "FK_pur_goods_received_hr_employees_ReceivedById",
                        column: x => x.ReceivedById,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_pur_goods_received_pur_purchase_orders_PurchaseOrderId",
                        column: x => x.PurchaseOrderId,
                        principalTable: "pur_purchase_orders",
                        principalColumn: "PurchaseOrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rpt_employee_performance",
                columns: table => new
                {
                    PerformanceId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PeriodStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PeriodEnd = table.Column<DateTime>(type: "TEXT", nullable: false),
                    SalesHandled = table.Column<int>(type: "INTEGER", nullable: false),
                    AttendanceDays = table.Column<int>(type: "INTEGER", nullable: false),
                    LateArrivals = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalSalesAmount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rpt_employee_performance", x => x.PerformanceId);
                    table.ForeignKey(
                        name: "FK_rpt_employee_performance_hr_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rpt_sales_reports",
                columns: table => new
                {
                    ReportId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ReportDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EmployeeId = table.Column<int>(type: "INTEGER", nullable: true),
                    TotalInvoices = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalItemsSold = table.Column<int>(type: "INTEGER", nullable: false),
                    TotalRevenue = table.Column<decimal>(type: "TEXT", nullable: false),
                    TotalDiscounts = table.Column<decimal>(type: "TEXT", nullable: false),
                    PeriodType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rpt_sales_reports", x => x.ReportId);
                    table.ForeignKey(
                        name: "FK_rpt_sales_reports_hr_employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "hr_employees",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "inv_stock_movements",
                columns: table => new
                {
                    StockMovementId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BatchId = table.Column<int>(type: "INTEGER", nullable: false),
                    FromWarehouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    ToWarehouseId = table.Column<int>(type: "INTEGER", nullable: false),
                    MovementDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inv_stock_movements", x => x.StockMovementId);
                    table.ForeignKey(
                        name: "FK_inv_stock_movements_inv_batches_BatchId",
                        column: x => x.BatchId,
                        principalTable: "inv_batches",
                        principalColumn: "BatchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pos_invoice_items",
                columns: table => new
                {
                    InvoiceItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    BatchId = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pos_invoice_items", x => x.InvoiceItemId);
                    table.ForeignKey(
                        name: "FK_pos_invoice_items_pos_invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "pos_invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "pos_payment_items",
                columns: table => new
                {
                    PaymentItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InvoiceId = table.Column<int>(type: "INTEGER", nullable: false),
                    Method = table.Column<string>(type: "TEXT", nullable: false),
                    Amount = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pos_payment_items", x => x.PaymentItemId);
                    table.ForeignKey(
                        name: "FK_pos_payment_items_pos_invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "pos_invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_auth_audit_logs_UserId",
                table: "auth_audit_logs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_auth_users_RoleId",
                table: "auth_users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_coup_promotions_ProductId",
                table: "coup_promotions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_hr_employees_UserId",
                table: "hr_employees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_hr_payrolls_EmployeeId",
                table: "hr_payrolls",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_hr_roasters_EmployeeId",
                table: "hr_roasters",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_inv_batches_ProductId",
                table: "inv_batches",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_inv_batches_WarehouseId",
                table: "inv_batches",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_inv_products_CategoryId",
                table: "inv_products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_inv_stock_movements_BatchId",
                table: "inv_stock_movements",
                column: "BatchId");

            migrationBuilder.CreateIndex(
                name: "IX_pos_invoice_items_InvoiceId",
                table: "pos_invoice_items",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_pos_invoices_EmployeeId",
                table: "pos_invoices",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_pos_invoices_LoyaltyCustomerId",
                table: "pos_invoices",
                column: "LoyaltyCustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_pos_payment_items_InvoiceId",
                table: "pos_payment_items",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_pur_goods_received_PurchaseOrderId",
                table: "pur_goods_received",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_pur_goods_received_ReceivedById",
                table: "pur_goods_received",
                column: "ReceivedById");

            migrationBuilder.CreateIndex(
                name: "IX_pur_purchase_order_items_ProductId",
                table: "pur_purchase_order_items",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_pur_purchase_order_items_PurchaseOrderId",
                table: "pur_purchase_order_items",
                column: "PurchaseOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_pur_purchase_orders_SupplierId",
                table: "pur_purchase_orders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_rpt_employee_performance_EmployeeId",
                table: "rpt_employee_performance",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_rpt_inventory_reports_ProductId",
                table: "rpt_inventory_reports",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_rpt_inventory_reports_WarehouseId",
                table: "rpt_inventory_reports",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_rpt_sales_reports_EmployeeId",
                table: "rpt_sales_reports",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "auth_audit_logs");

            migrationBuilder.DropTable(
                name: "coup_coupons");

            migrationBuilder.DropTable(
                name: "coup_loyalty_programs");

            migrationBuilder.DropTable(
                name: "coup_promotions");

            migrationBuilder.DropTable(
                name: "hr_payrolls");

            migrationBuilder.DropTable(
                name: "hr_roasters");

            migrationBuilder.DropTable(
                name: "inv_stock_movements");

            migrationBuilder.DropTable(
                name: "pos_invoice_items");

            migrationBuilder.DropTable(
                name: "pos_payment_items");

            migrationBuilder.DropTable(
                name: "pur_goods_received");

            migrationBuilder.DropTable(
                name: "pur_purchase_order_items");

            migrationBuilder.DropTable(
                name: "rpt_employee_performance");

            migrationBuilder.DropTable(
                name: "rpt_inventory_reports");

            migrationBuilder.DropTable(
                name: "rpt_sales_reports");

            migrationBuilder.DropTable(
                name: "inv_batches");

            migrationBuilder.DropTable(
                name: "pos_invoices");

            migrationBuilder.DropTable(
                name: "pur_purchase_orders");

            migrationBuilder.DropTable(
                name: "inv_products");

            migrationBuilder.DropTable(
                name: "inv_warehouses");

            migrationBuilder.DropTable(
                name: "hr_employees");

            migrationBuilder.DropTable(
                name: "pos_loyalty_customers");

            migrationBuilder.DropTable(
                name: "pur_suppliers");

            migrationBuilder.DropTable(
                name: "inv_categories");

            migrationBuilder.DropTable(
                name: "auth_users");

            migrationBuilder.DropTable(
                name: "hr_roles");
        }
    }
}
