﻿// <auto-generated />
using GameStore2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GameStore2.Migrations
{
    [DbContext(typeof(GameStore2Context))]
    partial class GameStore2ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GameStore2.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CartGameID");

                    b.Property<string>("CartGameTitle");

                    b.Property<decimal>("CartGameUnitPrice");

                    b.Property<int>("Quantity");

                    b.Property<string>("ShoppingCartID");

                    b.Property<int?>("gameInCartGameID");

                    b.HasKey("CartID");

                    b.HasIndex("gameInCartGameID");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("GameStore2.Models.Game", b =>
                {
                    b.Property<int>("GameID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Genre");

                    b.Property<string>("Image");

                    b.Property<string>("Title");

                    b.Property<decimal>("UnitPrice");

                    b.Property<int>("UnitsInStock");

                    b.HasKey("GameID");

                    b.ToTable("Game");
                });

            modelBuilder.Entity("GameStore2.Models.Cart", b =>
                {
                    b.HasOne("GameStore2.Models.Game", "gameInCart")
                        .WithMany()
                        .HasForeignKey("gameInCartGameID");
                });
#pragma warning restore 612, 618
        }
    }
}