using System.Data.Entity;
using Parafia.Models.User;

namespace Parafia.Models.Context
{
    public partial class UserContext : DbContext
    {
        public UserContext() : base("name=UserContext") { }

        public virtual DbSet<Uzytkownicy> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Uzytkownicy>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Uzytkownicy>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Uzytkownicy>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Uzytkownicy>()
                .Property(e => e.Haslo)
                .IsUnicode(false);

            modelBuilder.Entity<Uzytkownicy>()
                .Property(e => e.KodWeryfikacyjny)
                .IsUnicode(false);
        }
    }
}
