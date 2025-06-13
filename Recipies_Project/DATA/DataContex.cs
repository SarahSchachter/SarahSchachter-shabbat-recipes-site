using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Entities;

public partial class DataContex : DbContext
{
    public DataContex()
    {
    }

    public DataContex(DbContextOptions<DataContex> options)
        : base(options)
    {
    }

    public virtual DbSet<Ingredient> Ingredients { get; set; }

    public virtual DbSet<IngredientRecipe> IngredientRecipes { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=MyDB");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ingredient>(entity =>
        {
            entity.ToTable("Ingredient");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<IngredientRecipe>(entity =>
        {
            entity.ToTable("Ingredient_Recipe");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnName("amount");

            entity.HasOne(d => d.IdIngredientNavigation).WithMany(p => p.IngredientRecipes)
                .HasForeignKey(d => d.IdIngredient)
                .HasConstraintName("FK_Ingredient_Recipe_Ingredient");

            entity.HasOne(d => d.IdRecipeNavigation).WithMany(p => p.IngredientRecipes)
                .HasForeignKey(d => d.IdRecipe)
                .HasConstraintName("FK_Ingredient_Recipe_Recipe");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.ToTable("Recipe");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Descripsion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("descripsion");
            entity.Property(e => e.Duration)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("duration");
            entity.Property(e => e.Instructions)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("instructions");
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("level");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Pic)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pic");

            entity.HasOne(d => d.User).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Recipe_Users");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Fname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FName");
            entity.Property(e => e.Lname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LName");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
