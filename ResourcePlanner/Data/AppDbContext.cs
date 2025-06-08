using LankaRetail.Model.Billing;
using LankaRetail.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LankaRetail.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }
        public DbSet<Roaster> Roasters { get; set; }
        public DbSet<Role> Roles { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
        public DbSet<LoyaltyCustomer> LoyaltyCustomers { get; set; }
        public DbSet<PaymentItem> PaymentItems { get; set; }

        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<PurchaseOrderItem> PurchaseOrderItems { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<GoodsReceived> GoodsReceived { get; set; }

        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<LoyaltyProgram> LoyaltyPrograms { get; set; }

        public DbSet<EmployeePerformance> EmployeePerformances { get; set; }
        public DbSet<InventoryReport> InventoryReports { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=erp.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Inventory
            modelBuilder.Entity<Product>().ToTable("inv_products");
            modelBuilder.Entity<Category>().ToTable("inv_categories");
            modelBuilder.Entity<Batch>().ToTable("inv_batches");
            modelBuilder.Entity<Warehouse>().ToTable("inv_warehouses");
            modelBuilder.Entity<StockMovement>().ToTable("inv_stock_movements");

            // HR
            modelBuilder.Entity<Employee>().ToTable("hr_employees");
            modelBuilder.Entity<Payroll>().ToTable("hr_payrolls");
            modelBuilder.Entity<Roaster>().ToTable("hr_roasters");
            modelBuilder.Entity<Role>().ToTable("hr_roles");

            // Auth
            modelBuilder.Entity<User>().ToTable("auth_users");
            modelBuilder.Entity<AuditLog>().ToTable("auth_audit_logs");

            // Billing / POS
            modelBuilder.Entity<Invoice>().ToTable("pos_invoices");
            modelBuilder.Entity<InvoiceItem>().ToTable("pos_invoice_items");
            modelBuilder.Entity<LoyaltyCustomer>().ToTable("pos_loyalty_customers");
            modelBuilder.Entity<PaymentItem>().ToTable("pos_payment_items");

            // Purchasing
            modelBuilder.Entity<PurchaseOrder>().ToTable("pur_purchase_orders");
            modelBuilder.Entity<PurchaseOrderItem>().ToTable("pur_purchase_order_items");
            modelBuilder.Entity<Supplier>().ToTable("pur_suppliers");
            modelBuilder.Entity<GoodsReceived>().ToTable("pur_goods_received");

            // Coupons & Loyalty
            modelBuilder.Entity<Coupon>().ToTable("coup_coupons");
            modelBuilder.Entity<Promotion>().ToTable("coup_promotions");
            modelBuilder.Entity<LoyaltyProgram>().ToTable("coup_loyalty_programs");

            // Reporting
            modelBuilder.Entity<EmployeePerformance>().ToTable("rpt_employee_performance");
            modelBuilder.Entity<InventoryReport>().ToTable("rpt_inventory_reports");
            modelBuilder.Entity<SalesReport>().ToTable("rpt_sales_reports");
        }
    }
}
