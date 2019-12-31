using DataLayer.Entities;
using System.Data.Entity;

namespace DataLayer
{
    public class MainContext : DbContext
    {
        public MainContext(): base("MyConnection")
        { }

        public DbSet<EncryptionSymbol> EncryptionSymbols { get; set; }

        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EncryptionSymbol>()
                .HasIndex(u => u.NewSymbol)
                .IsUnique();
            modelBuilder.Entity<EncryptionSymbol>()
                .Property(x => x.NewSymbol)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<EncryptionSymbol>()
                .HasIndex(u => u.OldSymbol)
                .IsUnique();
            modelBuilder.Entity<EncryptionSymbol>()
                .Property(x => x.OldSymbol)
                .IsRequired()
                .HasMaxLength(100);

        }
    }
}
