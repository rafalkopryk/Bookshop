namespace Shop.DAL
{
    using Shop.DAL.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class ShopDbContext : DbContext
    {
        // Your context has been configured to use a 'ShopContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Shop.Dal.ShopContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ShopContext' 
        // connection string in the application configuration file.
        public ShopDbContext()
            : base("name=ShopDbContext")
        {

            Database.SetInitializer<ShopDbContext>(new ShopDbInitializer());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Carrier> Carriers { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .HasRequired(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(b => b.PublisherId);

            modelBuilder.Entity<Book>()
                .Property(b => b.ReleaseDate)
                .HasColumnType("datetime2");
        }

    }
}