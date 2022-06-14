﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeBank.DAL;

namespace TeBank.Migrations
{
    [DbContext(typeof(TuBankingDbContext))]
    partial class TuBankingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeBank.Models.Cuenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Balanceactual")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fechaactualizar")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fechacrear")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombrecuenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numerocuenta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Pinhash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte>("Pinsalt")
                        .HasColumnType("tinyint");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipocuenta")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cuenta");
                });

            modelBuilder.Entity("TeBank.Models.Transaccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comentariotransaccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuentaemisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cuentareceptor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fechatransaccion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Montotransaccion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TipoTransaccion")
                        .HasColumnType("int");

                    b.Property<string>("TransaccionUnico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionStatus")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Transaccion");
                });
#pragma warning restore 612, 618
        }
    }
}
