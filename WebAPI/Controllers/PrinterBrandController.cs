using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrinterBrandController : ControllerBase
    {
        IPrinterBrandService _printerBrandService;

        public PrinterBrandController(IPrinterBrandService printerBrandService)
        {
            _printerBrandService = printerBrandService;
        }
        [HttpPost("add")]
        public IActionResult Add(PrinterBrand printerBrand)
        {
            var result = _printerBrandService.Add(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PrinterBrand printerBrand)
        {
            var result = _printerBrandService.Delete(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(PrinterBrand printerBrand)
        {
            var result = _printerBrandService.Update(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _printerBrandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
