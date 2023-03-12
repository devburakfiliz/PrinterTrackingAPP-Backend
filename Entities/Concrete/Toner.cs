using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Toner :IEntity
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }

    }
}
