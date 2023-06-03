﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.CompositionOfNutritionalValue", b =>
                {
                    b.Property<int>("IdCompositionOfNutritionalValue")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdCompositionOfNutritionalValue");

                    b.ToTable("CompositionOfNutritionalValue", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.DietPlan", b =>
                {
                    b.Property<int>("IdDietPlan")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanCalories")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDietPlan");

                    b.HasIndex("IdUser");

                    b.ToTable("DietPlan", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.Dish", b =>
                {
                    b.Property<int>("IdDish")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AmountOfCaloriesInTheDish")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdDish");

                    b.ToTable("Dish", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.DishDietPlan", b =>
                {
                    b.Property<int>("IdDishDietPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDietPlan")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdDish")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdDishDietPlan");

                    b.HasIndex("IdDietPlan");

                    b.ToTable("DishDietPlan", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.Recipe", b =>
                {
                    b.Property<int>("IdRecipe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredientsNeeded")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StepsToCreate")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdRecipe");

                    b.HasIndex("UserId");

                    b.ToTable("Recipe", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.Exercise", b =>
                {
                    b.Property<int>("IdExercise")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("TEXT");

                    b.Property<string>("MuscleGroups")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdExercise");

                    b.ToTable("Exercise", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseTraningPlan", b =>
                {
                    b.Property<int>("IdExerciseTraningPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdExercise")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTraningPlan")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdExerciseTraningPlan");

                    b.HasIndex("IdTraningPlan");

                    b.ToTable("ExerciseTraningPlan", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.Instrument", b =>
                {
                    b.Property<int>("IdInstrument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("IdInstrument");

                    b.ToTable("Instrument", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.TrainingPlan", b =>
                {
                    b.Property<int>("IdTrainingPlan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DegreeOfDifficulty")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdAdminAndModerator")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("NumberOfRepetitions")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfSeries")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NumberOfTrainingDaysPerWeek")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TrainingLength")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdTrainingPlan");

                    b.HasIndex("IdAdminAndModerator");

                    b.HasIndex("IdUser");

                    b.ToTable("TrainingPlan", (string)null);
                });

            modelBuilder.Entity("DishDishDietPlan", b =>
                {
                    b.Property<int>("DishDietPlansIdDishDietPlan")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DishesIdDish")
                        .HasColumnType("INTEGER");

                    b.HasKey("DishDietPlansIdDishDietPlan", "DishesIdDish");

                    b.HasIndex("DishesIdDish");

                    b.ToTable("DishDishDietPlan");
                });

            modelBuilder.Entity("ExerciseExerciseTraningPlan", b =>
                {
                    b.Property<int>("ExerciseTraningPlansIdExerciseTraningPlan")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExercisesIdExercise")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExerciseTraningPlansIdExerciseTraningPlan", "ExercisesIdExercise");

                    b.HasIndex("ExercisesIdExercise");

                    b.ToTable("ExerciseExerciseTraningPlan");
                });

            modelBuilder.Entity("ExerciseWithTheDeviceInstrument", b =>
                {
                    b.Property<int>("ExerciseWithTheDevicesIdExercise")
                        .HasColumnType("INTEGER");

                    b.Property<int>("InstrumentsIdInstrument")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExerciseWithTheDevicesIdExercise", "InstrumentsIdInstrument");

                    b.HasIndex("InstrumentsIdInstrument");

                    b.ToTable("ExerciseWithTheDeviceInstrument");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseWithTheDevice", b =>
                {
                    b.HasBaseType("API.Entities.Plans.Traning.Exercise");

                    b.Property<int>("IdExerciseDevice")
                        .HasColumnType("INTEGER");

                    b.ToTable("ExerciseWithTheDevice", (string)null);
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseWithoutTheDevice", b =>
                {
                    b.HasBaseType("API.Entities.Plans.Traning.Exercise");

                    b.Property<int>("IdExerciseDevice")
                        .HasColumnType("INTEGER");

                    b.ToTable("ExerciseWithoutTheDevice", (string)null);
                });

            modelBuilder.Entity("API.Entities.AppUserRole", b =>
                {
                    b.HasOne("API.Entities.AppRole", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.CompositionOfNutritionalValue", b =>
                {
                    b.HasOne("API.Entities.Plans.Diet.Dish", "Dish")
                        .WithOne("CompositionOfNutritionalValue")
                        .HasForeignKey("API.Entities.Plans.Diet.CompositionOfNutritionalValue", "IdCompositionOfNutritionalValue")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.DietPlan", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AdminsAndModerator")
                        .WithMany("DietPlansAdmins")
                        .HasForeignKey("IdDietPlan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "User")
                        .WithMany("DietPlans")
                        .HasForeignKey("IdUser");

                    b.Navigation("AdminsAndModerator");

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.DishDietPlan", b =>
                {
                    b.HasOne("API.Entities.Plans.Diet.DietPlan", "DietPlan")
                        .WithMany("DishDietPlans")
                        .HasForeignKey("IdDietPlan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DietPlan");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.Recipe", b =>
                {
                    b.HasOne("API.Entities.AppUser", "User")
                        .WithMany("Recipes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseTraningPlan", b =>
                {
                    b.HasOne("API.Entities.Plans.Traning.TrainingPlan", "TrainingPlan")
                        .WithMany("ExerciseTraningPlans")
                        .HasForeignKey("IdTraningPlan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrainingPlan");
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.TrainingPlan", b =>
                {
                    b.HasOne("API.Entities.AppUser", "AdminAndModerator")
                        .WithMany("TrainingPlansAdmins")
                        .HasForeignKey("IdAdminAndModerator")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.AppUser", "Users")
                        .WithMany("TrainingPlans")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AdminAndModerator");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("DishDishDietPlan", b =>
                {
                    b.HasOne("API.Entities.Plans.Diet.DishDietPlan", null)
                        .WithMany()
                        .HasForeignKey("DishDietPlansIdDishDietPlan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Plans.Diet.Dish", null)
                        .WithMany()
                        .HasForeignKey("DishesIdDish")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseExerciseTraningPlan", b =>
                {
                    b.HasOne("API.Entities.Plans.Traning.ExerciseTraningPlan", null)
                        .WithMany()
                        .HasForeignKey("ExerciseTraningPlansIdExerciseTraningPlan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Plans.Traning.Exercise", null)
                        .WithMany()
                        .HasForeignKey("ExercisesIdExercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExerciseWithTheDeviceInstrument", b =>
                {
                    b.HasOne("API.Entities.Plans.Traning.ExerciseWithTheDevice", null)
                        .WithMany()
                        .HasForeignKey("ExerciseWithTheDevicesIdExercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("API.Entities.Plans.Traning.Instrument", null)
                        .WithMany()
                        .HasForeignKey("InstrumentsIdInstrument")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("API.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseWithTheDevice", b =>
                {
                    b.HasOne("API.Entities.Plans.Traning.Exercise", null)
                        .WithOne()
                        .HasForeignKey("API.Entities.Plans.Traning.ExerciseWithTheDevice", "IdExercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.ExerciseWithoutTheDevice", b =>
                {
                    b.HasOne("API.Entities.Plans.Traning.Exercise", null)
                        .WithOne()
                        .HasForeignKey("API.Entities.Plans.Traning.ExerciseWithoutTheDevice", "IdExercise")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.AppRole", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Navigation("DietPlans");

                    b.Navigation("DietPlansAdmins");

                    b.Navigation("Recipes");

                    b.Navigation("TrainingPlans");

                    b.Navigation("TrainingPlansAdmins");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.DietPlan", b =>
                {
                    b.Navigation("DishDietPlans");
                });

            modelBuilder.Entity("API.Entities.Plans.Diet.Dish", b =>
                {
                    b.Navigation("CompositionOfNutritionalValue")
                        .IsRequired();
                });

            modelBuilder.Entity("API.Entities.Plans.Traning.TrainingPlan", b =>
                {
                    b.Navigation("ExerciseTraningPlans");
                });
#pragma warning restore 612, 618
        }
    }
}
