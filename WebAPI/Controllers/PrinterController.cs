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
    public class PrinterController : ControllerBase
    {
        IPrinterService _printerService;

        public PrinterController(IPrinterService printerService)
        {
            _printerService = printerService;
        }

        [HttpPost("add")]
        public IActionResult Add(Printer printer)
        {
            var result = _printerService.Add(printer);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Printer printer)
        {
            var result = _printerService.Delete(printer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Printer printer)
        {
            var result = _printerService.Update(printer);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet]
        public string Get()
        {
            return "merhaba";
        }
    }
}
