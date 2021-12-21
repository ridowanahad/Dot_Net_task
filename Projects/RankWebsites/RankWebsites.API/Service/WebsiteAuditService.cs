using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RankWebsites.Model;
using RankWebsites.Repository.Repository.Contracts;

namespace RankWebsites.API.Service
{
    public class WebsiteAuditService : IWebsiteAuditService
    {
        public IAuditRepository Repository;

        public WebsiteAuditService(IAuditRepository repository)
        {
            this.Repository = repository;
        }

        public Task<List<WebsiteAudit>> Get()
        {
            return Repository.GetAll();
        }

        public Task<List<WebsiteAudit>> GetTop5(DateTime visiDateTime)
        {
            return Repository.GetTop5(visiDateTime);
        }

        public Task<List<string>> GetVisitDates()
        {
            return Repository.GetVisitDates();
        }
    }

    public interface IWebsiteAuditService
    {
        Task<List<WebsiteAudit>> Get();

        Task<List<WebsiteAudit>> GetTop5(DateTime visiDateTime);

        Task<List<string>> GetVisitDates();
    }
}