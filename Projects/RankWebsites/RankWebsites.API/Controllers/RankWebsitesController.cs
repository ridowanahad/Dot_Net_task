using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using RankWebsites.API.Service;
using RankWebsites.Model;
using RankWebsites.Repository;
using RankWebsites.Repository.Repository;
using RankWebsites.Repository.Repository.Contracts;

namespace RankWebsites.API.Controllers
{
    [RoutePrefix("api/RankWebsites")]
    public class RankWebsitesController : ApiController
    {
        public IWebsiteAuditService Service => _service ?? new WebsiteAuditService(new AuditRepository(new RankWebsitesContext()));
        private IWebsiteAuditService _service;

        public RankWebsitesController()
        {
            
        }
        
        public RankWebsitesController(IWebsiteAuditService service)
        {
            _service = service;
        }
        
        [HttpGet]
        [Route("Audits")]
        public async Task<List<WebsiteAudit>> Get()
        {
            return await Service.Get();
        }

        [HttpGet]
        [Route("Top5Audits/{visitDate}")]
        public async Task<List<WebsiteAudit>> Get(DateTime visitDate)
        {
            return await Service.GetTop5(visitDate);
        }

        [HttpGet]
        [Route("visits")]
        public async Task<List<string>> GetVisitDates()
        {
            return await Service.GetVisitDates();
        }


        [HttpGet]
        [Route("HelloWorld")]
        public string HelloWorld()
        {
            return @"Hello World " + DateTime.Now;
        }

    }
}
