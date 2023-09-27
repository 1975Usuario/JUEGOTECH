using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace JuegotecH.Models
{
    public partial class administrajuegotechContext : DbContext
    {
        public administrajuegotechContext()
        {
        }

        public administrajuegotechContext(DbContextOptions<administrajuegotechContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bodega> Bodegas { get; set; } = null!;
        public virtual DbSet<Bodeguero> Bodegueros { get; set; } = null!;
        public virtual DbSet<Cajero> Cajeros { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Despachador> Despachadors { get; set; } = null!;
        public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Pago> Pagos { get; set; } = null!;
        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<TipoPago> TipoPagos { get; set; } = null!;
        public virtual DbSet<Vendedor> Vendedors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=127.0.0.1;port=3306;user=root;password=1234567;database=administrajuegotech", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8_spanish_ci")
                .HasCharSet("utf8");

            modelBuilder.Entity<Bodega>(entity =>
            {
                entity.HasKey(e => e.BodeCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("bodega");

                entity.HasIndex(e => e.BodeBodRut, "Bode_Bod_Rut")
                    .IsUnique();

                entity.HasIndex(e => e.BodeDesRut, "Bode_Des_Rut")
                    .IsUnique();

                entity.HasIndex(e => e.BodeProCodigo, "Bode_Pro_Codigo")
                    .IsUnique();

                entity.Property(e => e.BodeCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Bode_Codigo");

                entity.Property(e => e.BodeBodRut)
                    .HasMaxLength(13)
                    .HasColumnName("Bode_Bod_Rut");

                entity.Property(e => e.BodeDesRut)
                    .HasMaxLength(13)
                    .HasColumnName("Bode_Des_Rut");

                entity.Property(e => e.BodeNombre)
                    .HasMaxLength(11)
                    .HasColumnName("Bode_Nombre");

                entity.Property(e => e.BodeProCodigo)
                    .HasColumnType("int(13)")
                    .HasColumnName("Bode_Pro_Codigo");

                entity.HasOne(d => d.BodeBodRutNavigation)
                    .WithOne(p => p.Bodega)
                    .HasForeignKey<Bodega>(d => d.BodeBodRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bodega_ibfk_2");

                entity.HasOne(d => d.BodeDesRutNavigation)
                    .WithOne(p => p.Bodega)
                    .HasForeignKey<Bodega>(d => d.BodeDesRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bodega_ibfk_1");

                entity.HasOne(d => d.BodeProCodigoNavigation)
                    .WithOne(p => p.Bodega)
                    .HasForeignKey<Bodega>(d => d.BodeProCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("bodega_ibfk_3");
            });

            modelBuilder.Entity<Bodeguero>(entity =>
            {
                entity.HasKey(e => e.BodRut)
                    .HasName("PRIMARY");

                entity.ToTable("bodeguero");

                entity.Property(e => e.BodRut)
                    .HasMaxLength(13)
                    .HasColumnName("Bod_Rut");

                entity.Property(e => e.BodApellido1)
                    .HasMaxLength(11)
                    .HasColumnName("Bod_Apellido1");

                entity.Property(e => e.BodApellido2)
                    .HasMaxLength(11)
                    .HasColumnName("Bod_Apellido2");

                entity.Property(e => e.BodCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Bod_Ciudad");

                entity.Property(e => e.BodDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("Bod_Direccion");

                entity.Property(e => e.BodEmail)
                    .HasMaxLength(30)
                    .HasColumnName("Bod_Email");

                entity.Property(e => e.BodFono)
                    .HasColumnType("int(9)")
                    .HasColumnName("Bod_Fono");

                entity.Property(e => e.BodNombre1)
                    .HasMaxLength(11)
                    .HasColumnName("Bod_Nombre1");

                entity.Property(e => e.BodNombre2)
                    .HasMaxLength(11)
                    .HasColumnName("Bod_Nombre2");
            });

            modelBuilder.Entity<Cajero>(entity =>
            {
                entity.HasKey(e => e.CajRut)
                    .HasName("PRIMARY");

                entity.ToTable("cajero");

                entity.Property(e => e.CajRut)
                    .HasMaxLength(13)
                    .HasColumnName("Caj_Rut");

                entity.Property(e => e.CajApellido1)
                    .HasMaxLength(11)
                    .HasColumnName("Caj_Apellido1");

                entity.Property(e => e.CajApellido2)
                    .HasMaxLength(11)
                    .HasColumnName("Caj_Apellido2");

                entity.Property(e => e.CajCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Caj_Ciudad");

                entity.Property(e => e.CajDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("Caj_Direccion");

                entity.Property(e => e.CajEmail)
                    .HasMaxLength(30)
                    .HasColumnName("Caj_Email");

                entity.Property(e => e.CajFono)
                    .HasColumnType("int(9)")
                    .HasColumnName("Caj_Fono");

                entity.Property(e => e.CajNombre1)
                    .HasMaxLength(11)
                    .HasColumnName("Caj_Nombre1");

                entity.Property(e => e.CajNombre2)
                    .HasMaxLength(11)
                    .HasColumnName("Caj_Nombre2");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.CliRut)
                    .HasName("PRIMARY");

                entity.ToTable("cliente");

                entity.Property(e => e.CliRut)
                    .HasMaxLength(13)
                    .HasColumnName("Cli_Rut");

                entity.Property(e => e.CliApellido1)
                    .HasMaxLength(11)
                    .HasColumnName("Cli_Apellido1");

                entity.Property(e => e.CliApellido2)
                    .HasMaxLength(11)
                    .HasColumnName("Cli_Apellido2");

                entity.Property(e => e.CliCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Cli_Ciudad");

                entity.Property(e => e.CliDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("Cli_Direccion");

                entity.Property(e => e.CliEmail)
                    .HasMaxLength(30)
                    .HasColumnName("Cli_Email");

                entity.Property(e => e.CliFono)
                    .HasColumnType("int(9)")
                    .HasColumnName("Cli_Fono");

                entity.Property(e => e.CliNombre1)
                    .HasMaxLength(11)
                    .HasColumnName("Cli_Nombre1");

                entity.Property(e => e.CliNombre2)
                    .HasMaxLength(11)
                    .HasColumnName("Cli_Nombre2");
            });

            modelBuilder.Entity<Despachador>(entity =>
            {
                entity.HasKey(e => e.DesRut)
                    .HasName("PRIMARY");

                entity.ToTable("despachador");

                entity.Property(e => e.DesRut)
                    .HasMaxLength(13)
                    .HasColumnName("Des_Rut");

                entity.Property(e => e.DesApellido1)
                    .HasMaxLength(11)
                    .HasColumnName("Des_Apellido1");

                entity.Property(e => e.DesApellido2)
                    .HasMaxLength(11)
                    .HasColumnName("Des_Apellido2");

                entity.Property(e => e.DesCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Des_Ciudad");

                entity.Property(e => e.DesDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("Des_Direccion");

                entity.Property(e => e.DesEmail)
                    .HasMaxLength(30)
                    .HasColumnName("Des_Email");

                entity.Property(e => e.DesFono)
                    .HasColumnType("int(9)")
                    .HasColumnName("Des_Fono");

                entity.Property(e => e.DesNombre1)
                    .HasMaxLength(11)
                    .HasColumnName("Des_Nombre1");

                entity.Property(e => e.DesNombre2)
                    .HasMaxLength(11)
                    .HasColumnName("Des_Nombre2");
            });

            modelBuilder.Entity<DetalleFactura>(entity =>
            {
                entity.HasKey(e => e.DfaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("detalle_factura");

                entity.HasIndex(e => e.DfaFacCodigo, "Dfa_Fac_Codigo")
                    .IsUnique();

                entity.HasIndex(e => e.DfaProCodigo, "Dfa_Pro_Codigo")
                    .IsUnique();

                entity.Property(e => e.DfaCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Dfa_Codigo");

                entity.Property(e => e.DfaCantidad)
                    .HasColumnType("int(7)")
                    .HasColumnName("Dfa_Cantidad");

                entity.Property(e => e.DfaFacCodigo)
                    .HasColumnType("int(13)")
                    .HasColumnName("Dfa_Fac_Codigo");

                entity.Property(e => e.DfaProCodigo)
                    .HasColumnType("int(13)")
                    .HasColumnName("Dfa_Pro_Codigo");

                entity.HasOne(d => d.DfaFacCodigoNavigation)
                    .WithOne(p => p.DetalleFactura)
                    .HasForeignKey<DetalleFactura>(d => d.DfaFacCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detalle_factura_ibfk_1");

                entity.HasOne(d => d.DfaProCodigoNavigation)
                    .WithOne(p => p.DetalleFactura)
                    .HasForeignKey<DetalleFactura>(d => d.DfaProCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("detalle_factura_ibfk_2");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasKey(e => e.FacCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("factura");

                entity.HasIndex(e => e.FacCliRut, "Fac_Cli_Rut")
                    .IsUnique();

                entity.HasIndex(e => e.FacVenRut, "Fac_Ven_Rut")
                    .IsUnique();

                entity.Property(e => e.FacCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Fac_Codigo");

                entity.Property(e => e.FacCliRut)
                    .HasMaxLength(13)
                    .HasColumnName("Fac_Cli_Rut");

                entity.Property(e => e.FacFecha).HasColumnName("Fac_Fecha");

                entity.Property(e => e.FacPago)
                    .HasColumnType("int(7)")
                    .HasColumnName("Fac_Pago");

                entity.Property(e => e.FacVenRut)
                    .HasMaxLength(13)
                    .HasColumnName("Fac_Ven_Rut");

                entity.HasOne(d => d.FacCliRutNavigation)
                    .WithOne(p => p.Factura)
                    .HasForeignKey<Factura>(d => d.FacCliRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("factura_ibfk_1");

                entity.HasOne(d => d.FacVenRutNavigation)
                    .WithOne(p => p.Factura)
                    .HasForeignKey<Factura>(d => d.FacVenRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("factura_ibfk_2");
            });

            modelBuilder.Entity<Pago>(entity =>
            {
                entity.HasKey(e => e.PagCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("pago");

                entity.HasIndex(e => e.PagCajRut, "Pag_Caj_Rut")
                    .IsUnique();

                entity.HasIndex(e => e.PagCliRut, "Pag_Cli_Rut")
                    .IsUnique();

                entity.HasIndex(e => e.PagTpaCodigo, "Pag_Tpa_Codigo")
                    .IsUnique();

                entity.Property(e => e.PagCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Pag_Codigo");

                entity.Property(e => e.PagCajRut)
                    .HasMaxLength(13)
                    .HasColumnName("Pag_Caj_Rut");

                entity.Property(e => e.PagCliRut)
                    .HasMaxLength(13)
                    .HasColumnName("Pag_Cli_Rut");

                entity.Property(e => e.PagFecha).HasColumnName("Pag_Fecha");

                entity.Property(e => e.PagMonto)
                    .HasColumnType("int(7)")
                    .HasColumnName("Pag_Monto");

                entity.Property(e => e.PagTpaCodigo)
                    .HasColumnType("int(13)")
                    .HasColumnName("Pag_Tpa_Codigo");

                entity.HasOne(d => d.PagCajRutNavigation)
                    .WithOne(p => p.Pago)
                    .HasForeignKey<Pago>(d => d.PagCajRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pago_ibfk_3");

                entity.HasOne(d => d.PagCliRutNavigation)
                    .WithOne(p => p.Pago)
                    .HasForeignKey<Pago>(d => d.PagCliRut)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pago_ibfk_2");

                entity.HasOne(d => d.PagTpaCodigoNavigation)
                    .WithOne(p => p.Pago)
                    .HasForeignKey<Pago>(d => d.PagTpaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pago_ibfk_1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.ProCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("producto");

                entity.Property(e => e.ProCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Pro_Codigo");

                entity.Property(e => e.ProNombre)
                   .HasMaxLength(11)
                   .HasColumnName("Pro_Nombre");

                entity.Property(e => e.ProDescripcion)
                    .HasMaxLength(30)
                    .HasColumnName("Pro_Descripcion");
                
                entity.Property(e => e.ProStock)
                    .HasColumnType("int(7)")
                    .HasColumnName("Pro_Stock");

                entity.Property(e => e.ProUnidad)
                    .HasColumnType("int(7)")
                    .HasColumnName("Pro_Unidad");

                entity.Property(e => e.ProPrecioUnitario)
                  .HasColumnType("int(7)")
                  .HasColumnName("Pro_Precio_Unitario");
            });

            modelBuilder.Entity<TipoPago>(entity =>
            {
                entity.HasKey(e => e.TpaCodigo)
                    .HasName("PRIMARY");

                entity.ToTable("tipo_pago");

                entity.Property(e => e.TpaCodigo)
                    .HasColumnType("int(13)")
                    .ValueGeneratedNever()
                    .HasColumnName("Tpa_Codigo");

                entity.Property(e => e.TpaNombrePago)
                    .HasMaxLength(13)
                    .HasColumnName("Tpa_Nombre_Pago");
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.HasKey(e => e.VenRut)
                    .HasName("PRIMARY");

                entity.ToTable("vendedor");

                entity.Property(e => e.VenRut)
                    .HasMaxLength(13)
                    .HasColumnName("Ven_Rut");

                entity.Property(e => e.VenApellido1)
                    .HasMaxLength(11)
                    .HasColumnName("Ven_Apellido1");

                entity.Property(e => e.VenApellido2)
                    .HasMaxLength(11)
                    .HasColumnName("Ven_Apellido2");

                entity.Property(e => e.VenCiudad)
                    .HasMaxLength(20)
                    .HasColumnName("Ven_Ciudad");

                entity.Property(e => e.VenDireccion)
                    .HasMaxLength(30)
                    .HasColumnName("Ven_Direccion");

                entity.Property(e => e.VenEmail)
                    .HasMaxLength(30)
                    .HasColumnName("Ven_Email");

                entity.Property(e => e.VenFono)
                    .HasColumnType("int(9)")
                    .HasColumnName("Ven_Fono");

                entity.Property(e => e.VenNombre1)
                    .HasMaxLength(11)
                    .HasColumnName("Ven_Nombre1");

                entity.Property(e => e.VenNombre2)
                    .HasMaxLength(11)
                    .HasColumnName("Ven_Nombre2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
