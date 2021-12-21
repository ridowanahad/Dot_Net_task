using System;
using System.Collections.Generic;
using System.Text;

namespace RankWebsites.Data.Entity
{
    public class WebsiteAudit : BaseEntity
    {
        public string WebsiteName { get; set; }

        public DateTime VisitDate { get; set; }

        public int TotalVisits { get; set; }
    }
}
