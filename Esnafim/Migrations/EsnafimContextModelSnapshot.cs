﻿// <auto-generated />
using System;
using Esnafim;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Esnafim.Migrations
{
    [DbContext(typeof(EsnafimContext))]
    partial class EsnafimContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Esnafim.Models.DukkanKategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("KategoriAdi")
                        .HasColumnName("kategori_adi");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("DukkanKategori");
                });

            modelBuilder.Entity("Esnafim.Models.Dukkanlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("DukkanAdi")
                        .HasColumnName("dukkan_adi");

                    b.Property<int?>("DukkanKategoriId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("DukkanKategoriId");

                    b.ToTable("Dukkanlar");
                });

            modelBuilder.Entity("Esnafim.Models.EsnafUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnName("ad");

                    b.Property<string>("Adres")
                        .HasColumnName("adres");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Sifre")
                        .HasColumnName("sifre");

                    b.Property<string>("Soyad")
                        .HasColumnName("soyad");

                    b.Property<string>("Telefon")
                        .HasColumnName("telefon");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("EsnafUser");
                });

            modelBuilder.Entity("Esnafim.Models.Kategoriler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("KategoriAdi")
                        .HasColumnName("kategori_adi");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Esnafim.Models.MusteriUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnName("ad");

                    b.Property<string>("Adres")
                        .HasColumnName("adres");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("Email")
                        .HasColumnName("email");

                    b.Property<string>("Sifre")
                        .HasColumnName("sifre");

                    b.Property<string>("Soyad")
                        .HasColumnName("soyad");

                    b.Property<string>("Telefon")
                        .HasColumnName("telefon");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("MusteriUser");
                });

            modelBuilder.Entity("Esnafim.Models.Sikayetler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("DukkanId")
                        .HasColumnName("dukkan_id");

                    b.Property<string>("Mesaj")
                        .HasColumnName("mesaj");

                    b.Property<int>("MusteriId")
                        .HasColumnName("musteri_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Sikayetler");
                });

            modelBuilder.Entity("Esnafim.Models.SiparisDetaylari", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdetKg")
                        .HasColumnName("adet_kg");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<double>("Fiyat")
                        .HasColumnName("fiyat");

                    b.Property<int>("SiparisId")
                        .HasColumnName("siparis_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<int>("UrunId")
                        .HasColumnName("urun_id");

                    b.HasKey("Id");

                    b.HasIndex("SiparisId");

                    b.ToTable("SiparisDetaylari");
                });

            modelBuilder.Entity("Esnafim.Models.Siparisler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<int>("DukkanId")
                        .HasColumnName("dukkan_id");

                    b.Property<int>("MusteriId")
                        .HasColumnName("musteri_id");

                    b.Property<string>("Status")
                        .HasColumnName("status");

                    b.Property<double>("ToplamSiparisTutari")
                        .HasColumnName("toplam_siparis_tutari");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.ToTable("Siparisler");
                });

            modelBuilder.Entity("Esnafim.Models.Urunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdetKg")
                        .HasColumnName("adet_kg");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<double>("Fiyat")
                        .HasColumnName("fiyat");

                    b.Property<int?>("KategoriId");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<string>("UrunAdı")
                        .HasColumnName("urun_adi");

                    b.HasKey("Id");

                    b.HasIndex("KategoriId");

                    b.ToTable("Urunler");
                });

            modelBuilder.Entity("Esnafim.Models.Dukkanlar", b =>
                {
                    b.HasOne("Esnafim.Models.DukkanKategori", "DukkanKategori")
                        .WithMany("Dukkanlar")
                        .HasForeignKey("DukkanKategoriId");
                });

            modelBuilder.Entity("Esnafim.Models.SiparisDetaylari", b =>
                {
                    b.HasOne("Esnafim.Models.Siparisler", "Siparis")
                        .WithMany("SiparisDetay")
                        .HasForeignKey("SiparisId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Esnafim.Models.Urunler", b =>
                {
                    b.HasOne("Esnafim.Models.Kategoriler", "Kategori")
                        .WithMany("Urunler")
                        .HasForeignKey("KategoriId");
                });
#pragma warning restore 612, 618
        }
    }
}
