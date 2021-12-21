using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Threading.Tasks;
using RankWebsites.Model;
using RankWebsites.Repository.Repository.Contracts;

namespace RankWebsites.Repository.Repository
{
    public class AuditRepository : IAuditRepository
    {
        private readonly RankWebsitesContext _context;

        public AuditRepository(RankWebsitesContext context)
        {
            _context = context;
        }

        public async Task<List<WebsiteAudit>> GetAll()
        {
            return await _context.Audits.ToListAsync();
        }

        public async Task<List<WebsiteAudit>> GetTop5(DateTime visitDate)
        {
            return await _context.Audits.Where(a => a.VisitDate == visitDate).Take(5).ToListAsync();
        }

        public async Task<List<string>> GetVisitDates()
        {
            return await _context.Audits.Select(p => SqlFunctions.DateName("day", p.VisitDate) + "-" + SqlFunctions.DateName("month", p.VisitDate) + "-" + SqlFunctions.DateName("year", p.VisitDate)).Distinct().ToListAsync();
        }
    }
}
