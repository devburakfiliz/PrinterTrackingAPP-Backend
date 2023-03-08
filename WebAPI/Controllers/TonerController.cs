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
    public class TonerController : ControllerBase
    {
        ITonerService _tonerService;

        public TonerController(ITonerService tonerService)
        {
            _tonerService = tonerService;
        }
        [HttpPost("add")]
        public IActionResult Add(Toner toner)
        {
            var result = _tonerService.Add(toner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Toner toner)
        {
            var result = _tonerService.Delete(toner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Toner toner)
        {
            var result = _tonerService.Update(toner);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getbytonerid")]
        public IActionResult GetById(int id)
        {
            var result = _tonerService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _tonerService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getdetail")]
        public IActionResult GetPrinterDtos()
        {
            var result = _tonerService.GetTonerDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
