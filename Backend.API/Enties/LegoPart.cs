using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.API.Enties
{
    public class LegoPart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Shape { get; set; }
        public string ImageUrl { get; set; }

        public DateTime? CreateDate { get; set; }
        public string CreateUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUSer { get; set; }

        public virtual ICollection<LegoToy> Toys { get; set; } = new List<LegoToy>();
    }
}