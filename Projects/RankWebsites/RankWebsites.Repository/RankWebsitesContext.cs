using System.Data.Entity;
using RankWebsites.Model;

namespace RankWebsites.Repository
{
    public class RankWebsitesContext : DbContext
    {
        public RankWebsitesContext(): base("DefaultConnection")
        {
           
        }

        public DbSet<WebsiteAudit> Audits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<WebsiteAudit>().ToTable("WebsiteAudit");
        }
    }
}
