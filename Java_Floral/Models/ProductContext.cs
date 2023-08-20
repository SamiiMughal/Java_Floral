using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Java_Floral.Models;

namespace Java_Floral.Models
{
    public class ProductContext: IdentityDbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Message> Message { get; set; }

        //public DbSet<Java_Floral.Models.SignupModel> SignupModel { get; set; }

        public DbSet<ProductMultiImages> PMultiImages { get; set; }
    }
}
