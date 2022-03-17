using Microsoft.EntityFrameworkCore;
using Module7_project_Restaurants.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7_project_Restaurants.Data
{
    public class RestaurantsContext : DbContext
    {
        public RestaurantsContext()
        {

        }
        public RestaurantsContext(DbContextOptions options)
            : base(options)
        {

        }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<MenuMeal> MenuMeals { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<StaffRestaurant> StaffRestaurants { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Company> Companies { get; set; }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer
                    (Configuration.ConnectionString);
            }
        }*/
        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MenuMeal>()
                .HasKey(bc => new { bc.MenuId, bc.MealId });
            /*modelBuilder.Entity<MenuMeal>()
                .HasOne(bc => bc.Menu)
                .WithMany()
                .HasForeignKey(bc => bc.MenuId);
            modelBuilder.Entity<BookCategory>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.BookCategories)
                .HasForeignKey(bc => bc.CategoryId);
        }*/
    }
}
