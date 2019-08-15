namespace SmartInventorySystem
{
    using DataAccess.Mapping;
    using DataAccess.Seed;
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InventoryModel : DbContext
    {
        // Your context has been configured to use a 'Inventory' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Smart_Inventory_System.Inventory' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Inventory' 
        // connection string in the application configuration file.
        public InventoryModel()
            : base("name=InventoryModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Dispense> Dispenses { get; set; }
        public virtual DbSet<StockUpdate> StockUpdates { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<DispenseSummary> DispenseSummaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var initializer = new DevelopDbInitializer(modelBuilder);
            Database.SetInitializer(initializer);

            modelBuilder.Configurations.Add(new UserTypeConfiguration());
            modelBuilder.Configurations.Add(new SupplierTypeConfiguration());
            modelBuilder.Configurations.Add(new DispenseTypeConfiguration());
            modelBuilder.Configurations.Add(new StockUpdateTypeConfiguration());
            modelBuilder.Configurations.Add(new ItemTypeConfiguration());
            modelBuilder.Configurations.Add(new DispenseSummaryTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var timeStamp = DateTime.Now;

            var addedEntities = ChangeTracker
                .Entries<IAuditable>()
                .Where(x => x.State == EntityState.Added)
                .Select(x => x.Entity);

            foreach (var entity in addedEntities)
            {
                entity.CreatedAt = timeStamp;
                entity.CreatedBy = Environment.UserName;
                entity.ModifiedAt = timeStamp;
                entity.ModifiedBy = Environment.UserName;
            }

            var modifiedEntities = ChangeTracker
                .Entries<IAuditable>()
                .Where(x => x.State == EntityState.Modified)
                .Select(x => x.Entity);

            foreach (var entity in modifiedEntities)
            {
                entity.ModifiedAt = timeStamp;
                entity.ModifiedBy = Environment.UserName;
            }

            return base.SaveChanges();
        }
    }
}