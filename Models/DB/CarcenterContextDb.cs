using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ServicioCar.Models.DB
{
    public partial class CarcenterContextDb : DbContext
    {
        public CarcenterContextDb()
        {
        }

        public CarcenterContextDb(DbContextOptions<CarcenterContextDb> options)
            : base(options)
        {
        }

        public virtual DbSet<ClienteDb> Clientes { get; set; }
        public virtual DbSet<FacturaDb> Facturas { get; set; }
        public virtual DbSet<MantenimientoDb> Mantenimientos { get; set; }
        public virtual DbSet<MecanicoDb> Mecanicos { get; set; }
        public virtual DbSet<RepuestosUsadoDb> RepuestosUsados { get; set; }
        public virtual DbSet<ServicioDb> Servicios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("SERVER=DESKTOP-H90MG00;Database=Carcenter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<ClienteDb>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerNombre");

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoNombre");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumento");
            });

            modelBuilder.Entity<FacturaDb>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdClientes, e.IdMecanicos })
                    .HasName("PK__Facturas__B354DF2A9C9FAF2A");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdClientes).HasColumnName("idClientes");

                entity.Property(e => e.IdMecanicos).HasColumnName("idMecanicos");

                entity.Property(e => e.FechaFactura)
                    .HasColumnType("date")
                    .HasColumnName("fechaFactura");

                entity.Property(e => e.TotalFactura)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("totalFactura");

                entity.HasOne(d => d.IdClientesNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdClientes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturas__idClie__300424B4");

                entity.HasOne(d => d.IdMecanicosNavigation)
                    .WithMany(p => p.Facturas)
                    .HasForeignKey(d => d.IdMecanicos)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Facturas__idMeca__30F848ED");
            });

            modelBuilder.Entity<MantenimientoDb>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.IdRepuestosUsados, e.IdServicios })
                    .HasName("PK__Mantenim__767D858DDEB6EB4B");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdRepuestosUsados).HasColumnName("idRepuestosUsados");

                entity.Property(e => e.IdServicios).HasColumnName("idServicios");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.HasOne(d => d.IdRepuestosUsadosNavigation)
                    .WithMany(p => p.Mantenimientos)
                    .HasForeignKey(d => d.IdRepuestosUsados)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mantenimi__idRep__2C3393D0");

                entity.HasOne(d => d.IdServiciosNavigation)
                    .WithMany(p => p.Mantenimientos)
                    .HasForeignKey(d => d.IdServicios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mantenimi__idSer__2D27B809");
            });

            modelBuilder.Entity<MecanicoDb>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Documento).HasColumnName("documento");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("estado");

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("primerNombre");

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");

                entity.Property(e => e.SegundoNombre)
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("segundoNombre");

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("tipoDocumento");
            });

            modelBuilder.Entity<RepuestosUsadoDb>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("descuento");

                entity.Property(e => e.NumeroUnidades).HasColumnName("numeroUnidades");

                entity.Property(e => e.PrecioUnidad)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precioUnidad");
            });

            modelBuilder.Entity<ServicioDb>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Descuento)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("descuento");

                entity.Property(e => e.PrecioManoObraMax)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("precioManoObraMax");

                entity.Property(e => e.PrecioManoObraMin)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precioManoObraMin");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
