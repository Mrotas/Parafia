using System.Data.Entity;
using Parafia.Models.Parafia;

namespace Parafia.Models.Context
{
    public partial class ParafiaContext : DbContext
    {
        public ParafiaContext() : base("name=Parafia") { }

        public virtual DbSet<Bierzmowanie> Bierzmowanie { get; set; }
        public virtual DbSet<ChodziNa> ChodziNa { get; set; }
        public virtual DbSet<Chrzest> Chrzest { get; set; }
        public virtual DbSet<Datek> Datek { get; set; }
        public virtual DbSet<Ksiadz> Ksiadz { get; set; }
        public virtual DbSet<Ministrant> Ministrant { get; set; }
        public virtual DbSet<Ogloszenie> Ogloszenie { get; set; }
        public virtual DbSet<Parafianin> Parafianin { get; set; }
        public virtual DbSet<Slub> Slub { get; set; }
        public virtual DbSet<Uczestnik> Uczestnik { get; set; }
        public virtual DbSet<Wydarzenie> Wydarzenie { get; set; }
        public virtual DbSet<Zamowienie> Zamowienie { get; set; }
        public virtual DbSet<Koleda> Koleda { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bierzmowanie>()
                .HasMany(e => e.Wydarzenia)
                .WithOptional(e => e.BIERZMOWANIE1)
                .HasForeignKey(e => e.IdWydarzenie);

            modelBuilder.Entity<Chrzest>()
                .Property(e => e.ImieDziecka)
                .IsUnicode(false);

            modelBuilder.Entity<Chrzest>()
                .Property(e => e.ImieDziecka2)
                .IsUnicode(false);

            modelBuilder.Entity<Chrzest>()
                .Property(e => e.Plec)
                .IsUnicode(false);

            modelBuilder.Entity<Chrzest>()
                .HasMany(e => e.Parafianie)
                .WithRequired(e => e.Chrzest2)
                .HasForeignKey(e => e.ChrzestId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Chrzest>()
                .HasMany(e => e.Wydarzenia)
                .WithOptional(e => e.CHRZEST1)
                .HasForeignKey(e => e.IdWydarzenie);

            modelBuilder.Entity<Chrzest>()
                .HasMany(e => e.Uczestnicy)
                .WithMany(e => e.Chrzest)
                .Map(m => m.ToTable("JESTRODZICEM_CHRZESTNYM").MapLeftKey("CHRZESTID").MapRightKey("UCZESTNIKID"));

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

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Chrzty)
                .WithRequired(e => e.Ksiadz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Koledy)
                .WithRequired(e => e.Ksiadz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Ogloszenia)
                .WithRequired(e => e.Ksiadz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Parafianie)
                .WithOptional(e => e.Ksiadz1)
                .HasForeignKey(e => e.KsiadzId);

            modelBuilder.Entity<Ksiadz>()
                .HasMany(e => e.Sluby)
                .WithRequired(e => e.Ksiadz)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ministrant>()
                .HasOptional(e => e.ChodziNa)
                .WithRequired(e => e.Ministrant);

            modelBuilder.Entity<Ministrant>()
                .HasMany(e => e.Parafianie)
                .WithOptional(e => e.Ministrant1)
                .HasForeignKey(e => e.MinistrantId);

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

            modelBuilder.Entity<Parafianin>()
                .HasMany(e => e.Chrzty)
                .WithOptional(e => e.Parafianin)
                .HasForeignKey(e => e.ParafianinId);

            modelBuilder.Entity<Parafianin>()
                .HasMany(e => e.Ksieza)
                .WithOptional(e => e.Parafianin)
                .HasForeignKey(e => e.ParafianinId);

            modelBuilder.Entity<Parafianin>()
                .HasMany(e => e.Ministranci)
                .WithRequired(e => e.Parafianin)
                .HasForeignKey(e => e.ParafianinId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parafianin>()
                .HasMany(e => e.Zamowienia)
                .WithRequired(e => e.Parafianin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Slub>()
                .HasMany(e => e.Wydarzenia)
                .WithOptional(e => e.SLUB1)
                .HasForeignKey(e => e.IdWydarzenie);

            modelBuilder.Entity<Slub>()
                .HasMany(e => e.Uczestnicy)
                .WithMany(e => e.Slub)
                .Map(m => m.ToTable("JESTMALZONKIEM_SWIADKIEM").MapLeftKey("SLUBID").MapRightKey("UCZESTNIKID"));

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
                .HasForeignKey(e => e.SwiadekId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Wydarzenie>()
                .Property(e => e.Typ)
                .IsUnicode(false);

            modelBuilder.Entity<Wydarzenie>()
                .HasOptional(e => e.Bierzmowanie)
                .WithRequired(e => e.Wydarzenie);

            modelBuilder.Entity<Wydarzenie>()
                .HasOptional(e => e.Chrzest)
                .WithRequired(e => e.Wydarzenie);

            modelBuilder.Entity<Wydarzenie>()
                .HasOptional(e => e.Slub)
                .WithRequired(e => e.Wydarzenie);

            modelBuilder.Entity<Wydarzenie>()
                .HasMany(e => e.Zamowienia)
                .WithRequired(e => e.Wydarzenie)
                .HasForeignKey(e => e.WydarzenieId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zamowienie>()
                .HasMany(e => e.Wydarzenia)
                .WithOptional(e => e.Zamowienie)
                .HasForeignKey(e => e.IdZamowienie);

            modelBuilder.Entity<Koleda>()
                .Property(e => e.Miasto)
                .IsUnicode(false);

            modelBuilder.Entity<Koleda>()
                .Property(e => e.Ulica)
                .IsUnicode(false);
        }
    }
}
