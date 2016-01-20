namespace Vinder.Business.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Vinder : DbContext
    {
        public Vinder()
            : base("name=VinderEntities")
        {
        }

        public virtual DbSet<Dealer> Dealers { get; set; }
        public virtual DbSet<Profile> Profiles { get; set; }
        public virtual DbSet<Usage> Usages { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dealer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Dealer>()
                .Property(e => e.PotalCode)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.Users)
                .WithMany(e => e.Profiles)
                .Map(m => m.ToTable("UserProfiles").MapLeftKey("ProfileId").MapRightKey("UserId"));

            modelBuilder.Entity<Usage>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<Usage>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Usage>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Phone)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Vin)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.StockNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Make)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Model)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Series)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.BodyDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.TransmissionDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.ExteriorColor)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.InteriorColor)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.InteriorType)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.NewUsed)
                .IsUnicode(false);
        }
    }
}
