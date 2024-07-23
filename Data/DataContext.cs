using INVERSER_Cobranza_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace INVERSER_Cobranza_API.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Cobranza> Cobranza { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=DESKTOP-R9E737T\\SQLEXPRESS;Database=INVERSER;TrustServerCertificate=True;Trusted_Connection=True;",
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, // Número máximo de reintentos
                        maxRetryDelay: TimeSpan.FromSeconds(30), // Retraso máximo entre reintentos
                        errorNumbersToAdd: null); // Errores adicionales que desencadenan reintentos
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cobranza>(entity =>
        {
            entity.ToTable("Tb_Cob_Cobranza"); // Nombre de la tabla en la base de datos

            // Mapeo de propiedades a columnas con prefijo
            entity.Property(e => e.Id).HasColumnName("Cob_Id");
            entity.Property(e => e.Asegurado).HasColumnName("Cob_Asegurado");
            entity.Property(e => e.IdRamo).HasColumnName("Cob_IdRamo");
            entity.Property(e => e.NumPoliza).HasColumnName("Cob_NumPoliza");
        });
    }



        



    }
}