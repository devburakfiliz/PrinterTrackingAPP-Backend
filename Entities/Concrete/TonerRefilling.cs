using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TonerRefilling :IEntity
    {
        public int Id { get; set; }
        public int TonerId { get; set; }
        public int Refilling { get; set; }

    }
}
