using RankWebsites.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RankWebsites.Data.Repository
{
    public class AuditRepository : IAuditRepository
    {
        private readonly RankWebsitesContext _context;

        public AuditRepository(RankWebsitesContext context)
        {
            _context = context;
        }

        IEnumerable<WebsiteAudit> IAuditRepository.GetAll()
        {
            return _context.Audits.ToList();
        }

        IEnumerable<WebsiteAudit> IAuditRepository.GetTop5(DateTime visitDate)
        {
            return _context.Audits.Where(a => a.VisitDate == visitDate).Take(5).ToList();
        }
    }
}
