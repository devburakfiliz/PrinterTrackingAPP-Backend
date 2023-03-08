using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TonerTracking :IEntity
    {
        public int Id { get; set; }
        public int TonerId { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public int TonerRefilling { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }
}
