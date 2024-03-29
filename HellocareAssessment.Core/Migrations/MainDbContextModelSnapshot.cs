﻿// <auto-generated />
using System;
using HellocareAssessment.Core.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HellocareAssessment.Core.Migrations
{
    [DbContext(typeof(MainDbContext))]
    partial class MainDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CompanyUser", b =>
                {
                    b.Property<Guid>("FollowedCompaniesId")
                        .HasColumnType("uuid")
                        .HasColumnName("followed_companies_id");

                    b.Property<Guid>("FollowersId")
                        .HasColumnType("uuid")
                        .HasColumnName("followers_id");

                    b.HasKey("FollowedCompaniesId", "FollowersId")
                        .HasName("pk_company_user");

                    b.HasIndex("FollowersId")
                        .HasDatabaseName("ix_company_user_followers_id");

                    b.ToTable("company_user", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_admins");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_admins_company_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_admins_user_id");

                    b.ToTable("admins", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_companies");

                    b.ToTable("companies", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_employees");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_employees_company_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_employees_user_id");

                    b.ToTable("employees", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Post", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<Guid?>("ProductId")
                        .HasColumnType("uuid")
                        .HasColumnName("product_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id")
                        .HasName("pk_posts");

                    b.HasIndex("CompanyId")
                        .HasDatabaseName("ix_posts_company_id");

                    b.HasIndex("ProductId")
                        .HasDatabaseName("ix_posts_product_id");

                    b.HasIndex("UserId")
                        .HasDatabaseName("ix_posts_user_id");

                    b.ToTable("posts", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid>("ParentCompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("parent_company_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_products");

                    b.HasIndex("ParentCompanyId")
                        .HasDatabaseName("ix_products_parent_company_id");

                    b.ToTable("products", (string)null);
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime>("InsertedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("inserted_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid>("InsertedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("inserted_by");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("boolean")
                        .HasDefaultValue(false)
                        .HasColumnName("is_deleted");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnUpdate()
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("updated_at")
                        .HasDefaultValueSql("NOW()");

                    b.Property<Guid?>("UpdatedBy")
                        .HasColumnType("uuid")
                        .HasColumnName("updated_by");

                    b.HasKey("Id")
                        .HasName("pk_users");

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.Property<Guid>("FollowedProductsId")
                        .HasColumnType("uuid")
                        .HasColumnName("followed_products_id");

                    b.Property<Guid>("FollowersId")
                        .HasColumnType("uuid")
                        .HasColumnName("followers_id");

                    b.HasKey("FollowedProductsId", "FollowersId")
                        .HasName("pk_product_user");

                    b.HasIndex("FollowersId")
                        .HasDatabaseName("ix_product_user_followers_id");

                    b.ToTable("product_user", (string)null);
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.Property<Guid>("FollowedUsersId")
                        .HasColumnType("uuid")
                        .HasColumnName("followed_users_id");

                    b.Property<Guid>("FollowersId")
                        .HasColumnType("uuid")
                        .HasColumnName("followers_id");

                    b.HasKey("FollowedUsersId", "FollowersId")
                        .HasName("pk_user_user");

                    b.HasIndex("FollowersId")
                        .HasDatabaseName("ix_user_user_followers_id");

                    b.ToTable("user_user", (string)null);
                });

            modelBuilder.Entity("CompanyUser", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Company", null)
                        .WithMany()
                        .HasForeignKey("FollowedCompaniesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_company_user_companies_followed_companies_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_company_user_users_followers_id");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Admin", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Company", "Company")
                        .WithMany("Admins")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_admins_companies_company_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_admins_users_user_id");

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Employee", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Company", "Company")
                        .WithMany("Employees")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_companies_company_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_employees_users_user_id");

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Post", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Company", "Company")
                        .WithMany("Posts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_posts_companies_company_id");

                    b.HasOne("HellocareAssessment.Model.Entities.Product", "Product")
                        .WithMany("Posts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_posts_products_product_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_posts_users_user_id");

                    b.Navigation("Company");

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Product", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Company", "ParentCompany")
                        .WithMany("Products")
                        .HasForeignKey("ParentCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_products_companies_parent_company_id");

                    b.Navigation("ParentCompany");
                });

            modelBuilder.Entity("ProductUser", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("FollowedProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_user_products_followed_products_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_product_user_users_followers_id");
                });

            modelBuilder.Entity("UserUser", b =>
                {
                    b.HasOne("HellocareAssessment.Model.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("FollowedUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_user_users_followed_users_id");

                    b.HasOne("HellocareAssessment.Model.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("FollowersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_user_user_users_followers_id");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Company", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Employees");

                    b.Navigation("Posts");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.Product", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("HellocareAssessment.Model.Entities.User", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
