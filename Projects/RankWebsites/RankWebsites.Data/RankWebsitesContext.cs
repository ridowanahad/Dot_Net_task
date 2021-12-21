using Microsoft.EntityFrameworkCore;
using RankWebsites.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RankWebsites.Data
{
    public class RankWebsitesContext : DbContext
    {
        public RankWebsitesContext(DbContextOptions<RankWebsitesContext> options) : base(options)
        {
           
        }

        public DbSet<WebsiteAudit> Audits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WebsiteAudit>().ToTable("WebisteAudit");
        }
    }
}
