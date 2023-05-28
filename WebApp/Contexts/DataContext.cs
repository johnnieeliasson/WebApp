using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using WebApp.Models.Entities;
using static System.Net.WebRequestMethods;

namespace WebApp.Contexts;

public class DataContext : IdentityDbContext<UserEntity>

{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<UserAddressEntity> UserAddresses { get; set; }
    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<ContactFormEntity> ContactForms { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var adminRoleId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole
            {
                Id = "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1",
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            },

            new IdentityRole
            {
                Id = "519fdfeb-7151-40ef-b1a3-368b66346c92",
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });


        var passwordHasher = new PasswordHasher<UserEntity>();

        var userEntity = new UserEntity
        {
            Id = "bd91b606-3b0a-4a45-9d8c-fb9a2245a082",
            UserName = "admin@domain.com",
            NormalizedUserName = "ADMIN@DOMAIN.COM",
            Email = "admin@domain.com",
            NormalizedEmail = "ADMIN@DOMAIN.COM",
            ConcurrencyStamp = Guid.NewGuid().ToString(),
        };
        userEntity.PasswordHash = passwordHasher.HashPassword(userEntity, "Changepassword1!");

        builder.Entity<UserEntity>().HasData(userEntity);

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            UserId = userEntity.Id,
            RoleId = "d0f3cef6-1ade-4c26-8ae2-3384ec2f4dd1"
        });

        builder.Entity<TagEntity>().HasData(
            new TagEntity { Id = 1, TagName = "new" },
            new TagEntity { Id = 2, TagName = "featured" },
            new TagEntity { Id = 3, TagName = "popular" }
            );

        builder.Entity<ProductEntity>().HasData(
            new ProductEntity { Id = 1, Title = "Apple iPhone 13 mini 128GB Midnight", Price = 8290, ImageUrl = "https://www.netonnet.se/art/mobil-smartwatch/mobiltelefoner/iphone/apple-iphone-13-mini-128gb-midnight/1020710.9044/#", Description = "iPhone 13 mini. Det mest avancerade dubbelkamerasystemet någonsin på en iPhone. Blixtsnabbt A15 Bionic-chip. Ett språng för batteritiden. Tålig design. Supersnabbt 5G1. Och en ljusare Super Retina XDR-skärm." }
            );

        builder.Entity<ProductTagEntity>().HasData(
            new ProductTagEntity { ProductId = 1, TagId = 1 }
            );

            }
}

