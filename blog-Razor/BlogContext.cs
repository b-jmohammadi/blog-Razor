using blog_Razor.Mapping;
using Microsoft.EntityFrameworkCore;

namespace blog_Razor
{
    public class BlogContext :DbContext 
    {
        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArticleMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
