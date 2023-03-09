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
    public class PrinterImagesController : ControllerBase
    {
        IPrinterImageService _printerImageService;

        public PrinterImagesController(IPrinterImageService printerImageService)
        {
            _printerImageService = printerImageService;
        }
        [HttpPost("add")]
        public IActionResult Add([FromForm] IFormFile file, [FromForm] PrinterImage printerImage)
        {
            var result = _printerImageService.Add(file, printerImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(PrinterImage printerImage)
        {
            var carDeleteImage = _printerImageService.GetByImageId(printerImage.Id).Data;
            var result = _printerImageService.Delete(carDeleteImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update([FromForm] IFormFile file, [FromForm] PrinterImage printerImage)
        {
            var result = _printerImageService.Update(file, printerImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _printerImageService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbyprinterid")]
        public IActionResult GetByCarId(int printerId)
        {
            var result = _printerImageService.GetByCarId(printerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return Ok(result);
        }
    }
}
