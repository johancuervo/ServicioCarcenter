using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Carcenter.Models.DB
{
    public partial class CarcenterContext : DbContext
    {
        public CarcenterContext()
        {
        }

        public CarcenterContext(DbContextOptions<CarcenterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturasMantenimiento> FacturasMantenimientos { get; set; }
        public virtual DbSet<Mantenimiento> Mantenimientos { get; set; }
        public virtual DbSet<MantenimientosFactura> MantenimientosFacturas { get; set; }
        public virtual DbSet<Mecanico> Mecanicos { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<ProductoTiendaFactura> ProductoTiendaFacturas { get; set; }
        public virtual DbSet<ProductoTiendum> ProductoTienda { get; set; }
        public virtual DbSet<RepuestosUsado> RepuestosUsados { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<Tiendum> Tienda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-H90MG00;Database=Carcenter;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
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

            modelBuilder.Entity<Factura>(entity =>
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

            modelBuilder.Entity<FacturasMantenimiento>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.IdFactura).HasColumnName("idFactura");
            });

            modelBuilder.Entity<Mantenimiento>(entity =>
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

            modelBuilder.Entity<MantenimientosFactura>(entity =>
            {
                entity.HasKey(e => new { e.MantenimientosId, e.MantenimientosIdRepuestosUsados, e.MantenimientosIdServicios, e.FacturasId, e.FacturasIdClientes, e.FacturasIdMecanicos })
                    .HasName("PK__Mantenim__A4675C0BA9D76808");

                entity.Property(e => e.MantenimientosId).HasColumnName("Mantenimientos_id");

                entity.Property(e => e.MantenimientosIdRepuestosUsados).HasColumnName("Mantenimientos_idRepuestosUsados");

                entity.Property(e => e.MantenimientosIdServicios).HasColumnName("Mantenimientos_idServicios");

                entity.Property(e => e.FacturasId).HasColumnName("Facturas_id");

                entity.Property(e => e.FacturasIdClientes).HasColumnName("Facturas_idClientes");

                entity.Property(e => e.FacturasIdMecanicos).HasColumnName("Facturas_idMecanicos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Facturas)
                    .WithMany(p => p.MantenimientosFacturas)
                    .HasForeignKey(d => new { d.FacturasId, d.FacturasIdClientes, d.FacturasIdMecanicos })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MantenimientosFa__44FF419A");

                entity.HasOne(d => d.Mantenimientos)
                    .WithMany(p => p.MantenimientosFacturas)
                    .HasForeignKey(d => new { d.MantenimientosId, d.MantenimientosIdRepuestosUsados, d.MantenimientosIdServicios })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__MantenimientosFa__440B1D61");
            });

            modelBuilder.Entity<Mecanico>(entity =>
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

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio");
            });

            modelBuilder.Entity<ProductoTiendaFactura>(entity =>
            {
                entity.HasKey(e => new { e.ProductoTiendaId, e.ProductoTiendaProductoIdProducto, e.ProductoTiendaTiendaIdTienda, e.FacturasId, e.FacturasIdClientes, e.FacturasIdMecanicos })
                    .HasName("PK__Producto__5C84F499231EFB58");

                entity.Property(e => e.ProductoTiendaId).HasColumnName("ProductoTienda_id");

                entity.Property(e => e.ProductoTiendaProductoIdProducto).HasColumnName("ProductoTienda_Producto_idProducto");

                entity.Property(e => e.ProductoTiendaTiendaIdTienda).HasColumnName("ProductoTienda_Tienda_idTienda");

                entity.Property(e => e.FacturasId).HasColumnName("Facturas_id");

                entity.Property(e => e.FacturasIdClientes).HasColumnName("Facturas_idClientes");

                entity.Property(e => e.FacturasIdMecanicos).HasColumnName("Facturas_idMecanicos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.HasOne(d => d.Facturas)
                    .WithMany(p => p.ProductoTiendaFacturas)
                    .HasForeignKey(d => new { d.FacturasId, d.FacturasIdClientes, d.FacturasIdMecanicos })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoTiendaFa__5BE2A6F2");

                entity.HasOne(d => d.ProductoTienda)
                    .WithMany(p => p.ProductoTiendaFacturas)
                    .HasForeignKey(d => new { d.ProductoTiendaId, d.ProductoTiendaProductoIdProducto, d.ProductoTiendaTiendaIdTienda })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoTiendaFa__5AEE82B9");
            });

            modelBuilder.Entity<ProductoTiendum>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ProductoIdProducto, e.TiendaIdTienda })
                    .HasName("PK__Producto__35E4B385D7018FD7");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ProductoIdProducto).HasColumnName("Producto_idProducto");

                entity.Property(e => e.TiendaIdTienda).HasColumnName("Tienda_idTienda");

                entity.HasOne(d => d.ProductoIdProductoNavigation)
                    .WithMany(p => p.ProductoTienda)
                    .HasForeignKey(d => d.ProductoIdProducto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoT__Produ__571DF1D5");

                entity.HasOne(d => d.TiendaIdTiendaNavigation)
                    .WithMany(p => p.ProductoTienda)
                    .HasForeignKey(d => d.TiendaIdTienda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProductoT__Tiend__5812160E");
            });

            modelBuilder.Entity<RepuestosUsado>(entity =>
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

            modelBuilder.Entity<Servicio>(entity =>
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

            modelBuilder.Entity<Tiendum>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(45)
                    .IsUnicode(false)
                    .HasColumnName("nombre");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
