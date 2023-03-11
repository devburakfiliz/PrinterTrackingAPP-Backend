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
    public class PrinterModelController : ControllerBase
    {
        IPrinterModelService _printerModelService;

        public PrinterModelController(IPrinterModelService printerModelService)
        {
            _printerModelService = printerModelService;
        }
        [HttpPost("add")]
        public IActionResult Add(PrinterModel printerBrand)
        {
            var result = _printerModelService.Add(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PrinterModel printerBrand)
        {
            var result = _printerModelService.Delete(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(PrinterModel printerBrand)
        {
            var result = _printerModelService.Update(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _printerModelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
