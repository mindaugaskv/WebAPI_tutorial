using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.API.Enties
{
    public class LegoToy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImageUrl { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUSer { get; set; }

        public virtual ICollection<LegoPart> Parts { get; set; } = new List<LegoPart>();
    }
}