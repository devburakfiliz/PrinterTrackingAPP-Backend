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
    public class TonerBrandController : ControllerBase
    {
        ITonerBrandService _tonerBrandService;

        public TonerBrandController(ITonerBrandService tonerBrandService)
        {
            _tonerBrandService = tonerBrandService;
        }
        [HttpPost("add")]
        public IActionResult Add(TonerBrand printerBrand)
        {
            var result = _tonerBrandService.Add(printerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TonerBrand tonerBrand)
        {
            var result = _tonerBrandService.Delete(tonerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TonerBrand tonerBrand)
        {
            var result = _tonerBrandService.Update(tonerBrand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _tonerBrandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
