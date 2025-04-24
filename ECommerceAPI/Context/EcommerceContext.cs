using System;
using System.Collections.Generic;
using ECommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceAPI.Context;

public partial class EcommerceContext : DbContext
{
    public EcommerceContext()
    {
    }

    public EcommerceContext(DbContextOptions<EcommerceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ItemPedido> ItemPedidos { get; set; }

    public virtual DbSet<Pagamento> Pagamentos { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Produto> Produtos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=NOTE22-S28\\SQLEXPRESS;Initial Catalog=ECommerce;User Id=sa;Password=Senai@134;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente).HasName("PK__Cliente__9B8553FC0500B2A5");

            entity.ToTable("Cliente");

            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Endereco)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NomeCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Senha)
                .HasMaxLength(6)
                .IsUnicode(false);

        });

        modelBuilder.Entity<ItemPedido>(entity =>
        {
            entity.HasKey(e => e.IditemPedido).HasName("PK__ItemPedi__51E1F2231578CA9B");

            entity.ToTable("ItemPedido");

            entity.Property(e => e.IditemPedido).HasColumnName("IDItemPedido");
            entity.Property(e => e.Idpedido).HasColumnName("IDPedido");
            entity.Property(e => e.Idproduto).HasColumnName("IDProduto");

            entity.HasOne(d => d.IdpedidoNavigation).WithMany(p => p.ItemPedidos)
                .HasForeignKey(d => d.Idpedido)
                .HasConstraintName("FK__ItemPedid__IDPed__02084FDA");

            entity.HasOne(d => d.IdprodutoNavigation).WithMany(p => p.ItemPedidos)
                .HasForeignKey(d => d.Idproduto)
                .HasConstraintName("FK__ItemPedid__IDPro__01142BA1");
        });

        modelBuilder.Entity<Pagamento>(entity =>
        {
            entity.HasKey(e => e.Idpagamento).HasName("PK__Pagament__984849FE2FD62551");

            entity.ToTable("Pagamento");

            entity.Property(e => e.Idpagamento).HasColumnName("IDPagamento");
            entity.Property(e => e.DataPagamento).HasColumnType("datetime");
            entity.Property(e => e.FormaPagamento)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Idpedido).HasColumnName("IDPedido");
            entity.Property(e => e.StatusPagamento)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.IdpedidoNavigation).WithMany(p => p.Pagamentos)
                .HasForeignKey(d => d.Idpedido)
                .HasConstraintName("FK__Pagamento__IDPed__7C4F7684");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.Idpedido).HasName("PK__Pedido__00C11F992D9B08B2");

            entity.ToTable("Pedido");

            entity.Property(e => e.Idpedido).HasColumnName("IDPedido");
            entity.Property(e => e.Idcliente).HasColumnName("IDCliente");
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ValorTotal).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.IdclienteNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.Idcliente)
                .HasConstraintName("FK__Pedido__IDClient__797309D9");
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.HasKey(e => e.Idproduto).HasName("PK__Produto__4283A371F6361954");

            entity.ToTable("Produto");

            entity.Property(e => e.Idproduto).HasColumnName("IDProduto");
            entity.Property(e => e.CategoriaProduto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descricao)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Imagem)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NomeProduto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Preco).HasColumnType("decimal(18, 6)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
