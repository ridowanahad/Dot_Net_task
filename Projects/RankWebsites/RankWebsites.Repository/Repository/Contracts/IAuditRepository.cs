using System.Collections.Generic;
using System.Threading.Tasks;
using RankWebsites.Model;

namespace RankWebsites.Repository.Repository.Contracts
{
    public interface IAuditRepository
    {
        Task<List<WebsiteAudit>> GetAll();

        Task<List<WebsiteAudit>> GetTop5(System.DateTime visitDate);
        Task<List<string>> GetVisitDates();
    }
}