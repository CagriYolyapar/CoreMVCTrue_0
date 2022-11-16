using CoreMVCTrue_0.DBConfiguration;
using CoreMVCTrue_0.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCTrue_0.Models.Context
{
    //EntityFrameworkCore.SqlServer kütüphanesini indirmeyi unutmayın...Options ayarları yoksa gelmeyecektir...
    public class MyContext:DbContext
    {
        //Dependency Injection yapısı Core platformumuzun arkasında otomatik olarak entegre gelir... Dolayısıyla siz bir veritabanı sınıfınızın constructor'ina parametre olarak bir DBContextOptions<> tipinde bir yapı verirseniz bu parametreye argümanı DI sayesinde Startup'dan gönderilir...


        //public MyContext(DbContextOptionsBuilder options)
        //{
        //    options.UseSqlServer(connectionString: "server = ....");
        //}

        public MyContext(DbContextOptions<MyContext> options) : base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
        }

        //.Net Core üzerinden migrate yapmak istediginiz takdirde add-migration <isim> ve sonrasında update-database demeniz gerekir...

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<UserProfile> Profiles { get; set; }

    }
}
