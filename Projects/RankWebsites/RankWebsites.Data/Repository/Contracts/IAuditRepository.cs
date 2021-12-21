using System.Collections.Generic;
using RankWebsites.Data.Entity;

namespace RankWebsites.Data.Repository
{
    public interface IAuditRepository
    {
        IEnumerable<WebsiteAudit> GetAll();

        IEnumerable<WebsiteAudit> GetTop5(System.DateTime visitDate);
    }
}