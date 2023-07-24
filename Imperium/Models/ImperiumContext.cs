using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Imperium.Models
{
    public partial class ImperiumContext : DbContext
    {
        public ImperiumContext()
        {
        }

        public ImperiumContext(DbContextOptions<ImperiumContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Casa> Casas { get; set; }
        public virtual DbSet<Comentario> Comentarios { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<RegistroUser> RegistroUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=KARINAMOO; Initial Catalog=Imperium; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Casa>(entity =>
            {
                entity.HasKey(e => e.Idcasa)
                    .HasName("PK__casa__08A3BCBF3FFFF492");

                entity.ToTable("casa");

                entity.Property(e => e.Caracteristicas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coordenadas).IsUnicode(false);

                entity.Property(e => e.DescripcionPropiedad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Imagen).IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Precio)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RentaOventa)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("RentaOVenta");

                entity.Property(e => e.Superficie)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TipoVivienda)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.ToTable("comentario");

                entity.Property(e => e.CasaIdcasa).HasColumnName("Casa_Idcasa");

                entity.Property(e => e.Comentario1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Comentario");

                entity.Property(e => e.RegistroUserIduser).HasColumnName("RegistroUser_Iduser");

                entity.HasOne(d => d.CasaIdcasaNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.CasaIdcasa)
                    .HasConstraintName("FK_Comentario_Casa_Idcasa");

                entity.HasOne(d => d.RegistroUserIduserNavigation)
                    .WithMany(p => p.Comentarios)
                    .HasForeignKey(d => d.RegistroUserIduser)
                    .HasConstraintName("FK_Comentario_Registrouser_Iduser");
            });

            modelBuilder.Entity<Contacto>(entity =>
            {
                entity.ToTable("contacto");

                entity.Property(e => e.Causa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comentario)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RegistroUser>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("PK__registro__778B8921C6015EB5");

                entity.ToTable("registroUser");

                entity.HasIndex(e => e.Telefono, "UQ_RegistroUser_Telefono")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario, "UQ_RegistroUser_Usuario")
                    .IsUnique();

                entity.Property(e => e.Contra)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .HasMaxLength(65)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Fotografia).IsUnicode(false);

                entity.Property(e => e.Localidad)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Pais)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rol)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(45)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
