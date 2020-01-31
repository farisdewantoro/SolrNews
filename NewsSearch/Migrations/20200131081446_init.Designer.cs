﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewsSearch.Db;

namespace NewsSearch.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200131081446_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NewsSearch.Entity.NewsEntity", b =>
                {
                    b.Property<double>("Id");

                    b.Property<string>("Author");

                    b.Property<string>("Content");

                    b.Property<string>("Date");

                    b.Property<string>("Month");

                    b.Property<string>("Publication");

                    b.Property<string>("Title");

                    b.Property<string>("Url");

                    b.Property<string>("Year");

                    b.HasKey("Id");

                    b.ToTable("News");
                });
#pragma warning restore 612, 618
        }
    }
}
