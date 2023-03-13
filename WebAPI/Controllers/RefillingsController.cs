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
    public class RefillingsController : ControllerBase
    {
        ITonerRefillingService _tonerRefillingService;

        public RefillingsController(ITonerRefillingService tonerRefillingService)
        {
            _tonerRefillingService = tonerRefillingService;
        }
        [HttpPost("add")]
        public IActionResult Add(TonerRefilling tonerRefilling)
        {
            var result = _tonerRefillingService.Add(tonerRefilling);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TonerRefilling tonerRefilling)
        {
            var result = _tonerRefillingService.Delete(tonerRefilling);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TonerRefilling tonerRefilling)
        {
            var result = _tonerRefillingService.Update(tonerRefilling);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _tonerRefillingService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
