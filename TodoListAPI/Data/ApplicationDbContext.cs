using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoListAPI.Models.AppModels;
using TodoListAPI.Models.Authentication;

namespace TodoListAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ToDoItemModel>(entity =>
            {
                entity.Property(e => e.ItemName)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.ItemDescription)
                .IsRequired()
                .HasMaxLength(100);

                entity.Property(e => e.ItemStatus)
                .IsRequired()
                .HasMaxLength(1);
            });

            base.OnModelCreating(builder);
        }

        public DbSet<ToDoItemModel> ToDoItems { get; set; }
    }
}
