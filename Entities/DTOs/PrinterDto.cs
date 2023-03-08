using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class PrinterDto :IDto
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public int BrandId { get; set; }
        public int ModelId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
    }
}
