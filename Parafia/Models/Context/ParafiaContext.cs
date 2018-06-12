using System.Data.Entity;
using Parafia.Models.Parafia;

namespace Parafia.Models.Context
{
    public partial class ParafiaContext : DbContext
    {
        public ParafiaContext() : base("name=ParafiaContext")
        { }

        public virtual DbSet<Bierzmowanie> Bierzmowania { get; set; }
        public virtual DbSet<ChodziNa> ChodziNa { get; set; }
        public virtual DbSet<Chrzest> Chrzty { get; set; }
        public virtual DbSet<Datek> Datki { get; set; }
        public virtual DbSet<JestMalzonkiem_Swiadkiem> JestMalzonkiem_Swiadkiem { get; set; }
        public virtual DbSet<JestRodzicem_Chrzestnym> JestRodzicem_Chrzestnym { get; set; }
        public virtual DbSet<Ksiadz> Ksieza { get; set; }
        public virtual DbSet<Ministrant> Ministranci { get; set; }
        public virtual DbSet<Ogloszenie> Ogloszenia { get; set; }
        public virtual DbSet<Parafianin> Parafianie { get; set; }
        public virtual DbSet<Slub> Sluby { get; set; }
        public virtual DbSet<Uczestnik> Uczestnicy { get; set; }
        public virtual DbSet<Wydarzenie> Wydarzenia { get; set; }
        public virtual DbSet<Zamowienie> Zamowienia { get; set; }
        public virtual DbSet<Koleda> Koledy { get; set; }
        public virtual DbSet<Uzytkownicy> Uzytkownicy { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Chrzest>()
                .Property(e => e.ImieDziecka)
                .IsUnicode(false);

            modelBuilder.Entity<Chrzest>()
                .Property(e => e.ImieDziecka2)
                .IsUnicode(false);

            modelBuilder.Entity<Chrzest>()
                .Property(e => e.Plec)
                .IsUnicode(false);

            modelBuilder.Entity<Datek>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Datek>()
                .Property(e => e.Typ)
                .IsUnicode(false);

            modelBuilder.Entity<Datek>()
                .Property(e => e.Wiadomosc)
                .IsUnicode(false);

            modelBuilder.Entity<Ksiadz>()
                .Property(e => e.Stanowisko)
                .IsUnicode(false);

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Bierzmowania)
                .WithRequired(e => e.Ksiadz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ministrant>()
                .HasOptional(e => e.ChodziNa)
                .WithRequired(e => e.Ministrant);

            modelBuilder.Entity<Ogloszenie>()
                .Property(e => e.Tytul)
                .IsUnicode(false);

            modelBuilder.Entity<Ogloszenie>()
                .Property(e => e.Tresc)
                .IsUnicode(false);

            modelBuilder.Entity<Ogloszenie>()
                .Property(e => e.Zdjecie)
                .IsFixedLength();

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.Ulica)
                .IsUnicode(false);

            modelBuilder.Entity<Parafianin>()
                .Property(e => e.StanCywilny)
                .IsUnicode(false);

            modelBuilder.Entity<Uczestnik>()
                .Property(e => e.Imie)
                .IsUnicode(false);

            modelBuilder.Entity<Uczestnik>()
                .Property(e => e.Nazwisko)
                .IsUnicode(false);

            modelBuilder.Entity<Uczestnik>()
                .Property(e => e.Plec)
                .IsUnicode(false);

            modelBuilder.Entity<Uczestnik>()
                .HasMany(e => e.Bierzmowania)
                .WithRequired(e => e.Uczestnik)
                .HasForeignKey(e => e.Swiadekid)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wydarzenie>()
                .Property(e => e.Typ)
                .IsUnicode(false);

            modelBuilder.Entity<Wydarzenie>()
                .HasOptional(e => e.Bierzmowanie)
                .WithRequired(e => e.Wydarzenie);

            modelBuilder.Entity<Koleda>()
                .Property(e => e.Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<Koleda>()
                .Property(e => e.Ulica)
                .IsUnicode(false);

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
