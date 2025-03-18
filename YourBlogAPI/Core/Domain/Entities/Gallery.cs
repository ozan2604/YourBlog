using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }        
    }
}
