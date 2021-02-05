

Add to appropriate sections of PlmContext.cs:

        DbSet<Building> Buildings { get; set; }
        modelBuilder.ApplyConfiguration(new BuildingMap());
        public virtual DbSet<Building> Buildings { get; set; }


Add to appropriate sections of Startup.cs:

        services.AddScoped<IBuildingService, BuildingService>();


