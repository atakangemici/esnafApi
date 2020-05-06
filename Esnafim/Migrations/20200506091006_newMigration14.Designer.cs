﻿// <auto-generated />
using System;
using Esnafim;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Esnafim.Migrations
{
    [DbContext(typeof(EsnafimContext))]
    [Migration("20200506091006_newMigration14")]
    partial class newMigration14
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CalismaSaatleri")
                        .HasColumnName("calisma_saatleri");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("DukkanAdi")
                        .HasColumnName("dukkan_adi");

                    b.Property<string>("DukkanAdres")
                        .HasColumnName("dukkan_adres");

                    b.Property<int?>("DukkanKategoriId");

                    b.Property<string>("DukkanTelefon")
                        .HasColumnName("dukkan_telefon");

                    b.Property<double>("MinimumSiparisTutari")
                        .HasColumnName("minimum_siparis_tutari");

                    b.Property<string>("TeslimatSuresi")
                        .HasColumnName("teslimat_suresi");

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

                    b.Property<int>("DukkanId");

                    b.Property<string>("KategoriAdi")
                        .HasColumnName("kategori_adi");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.HasKey("Id");

                    b.HasIndex("DukkanId");

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

            modelBuilder.Entity("Esnafim.Models.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdetKg")
                        .HasColumnName("adet_kg");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<string>("DukkanAdi")
                        .HasColumnName("dukkan_adi");

                    b.Property<int>("DukkanId")
                        .HasColumnName("dukkan_id");

                    b.Property<int>("MusteriId")
                        .HasColumnName("musteri_id");

                    b.Property<int>("SepetTutari")
                        .HasColumnName("sepet_tutari");

                    b.Property<int>("SiparisId")
                        .HasColumnName("siparis_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<string>("UrunAdi")
                        .HasColumnName("urun_adi");

                    b.Property<int>("UrunFiyat")
                        .HasColumnName("urun_fiyat");

                    b.Property<int>("UrunId")
                        .HasColumnName("urun_id");

                    b.HasKey("Id");

                    b.ToTable("Sepet");
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

            modelBuilder.Entity("Esnafim.Models.Siparis", b =>
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

                    b.Property<int>("DukkanId")
                        .HasColumnName("dukkan_id");

                    b.Property<int>("MusteriId")
                        .HasColumnName("musteri_id");

                    b.Property<string>("OdemeTipi")
                        .HasColumnName("odeme_tipi");

                    b.Property<int>("SiparisTutari")
                        .HasColumnName("siparis_tutari");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<int>("UrunId")
                        .HasColumnName("urun_id");

                    b.HasKey("Id");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("Esnafim.Models.Urunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Birim")
                        .HasColumnName("birim");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnName("created_at");

                    b.Property<int?>("CreatedById")
                        .HasColumnName("created_by");

                    b.Property<bool>("Deleted")
                        .HasColumnName("deleted");

                    b.Property<double>("Fiyat")
                        .HasColumnName("fiyat");

                    b.Property<int>("KategoriId");

                    b.Property<string>("Kg")
                        .HasColumnName("kg");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnName("updated_at");

                    b.Property<int?>("UpdatedById")
                        .HasColumnName("updated_by");

                    b.Property<string>("UrunAdi")
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

            modelBuilder.Entity("Esnafim.Models.Kategoriler", b =>
                {
                    b.HasOne("Esnafim.Models.Dukkanlar", "Dukkan")
                        .WithMany("Kategori")
                        .HasForeignKey("DukkanId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Esnafim.Models.Urunler", b =>
                {
                    b.HasOne("Esnafim.Models.Kategoriler", "Kategori")
                        .WithMany("Urun")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
