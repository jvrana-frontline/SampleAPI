

Add to appropriate sections of PlmContext.cs:

        DbSet<Activity> Activities { get; set; }
        modelBuilder.ApplyConfiguration(new ActivityMap());
        public virtual DbSet<Activity> Activities { get; set; }


Add to appropriate sections of Startup.cs:

        services.AddScoped<IActivityService, ActivityService>();


