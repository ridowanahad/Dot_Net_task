using System;

namespace RankWebsites.Model
{
    public class WebsiteAudit 
    {
        public int Id { get; set; }
        
        public string WebsiteName { get; set; }

        public DateTime VisitDate { get; set; }

        public int TotalVisits { get; set; }
    }
}
