using System;

namespace RankWebsites.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }
    }
}