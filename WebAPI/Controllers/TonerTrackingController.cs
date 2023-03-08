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
    public class TonerTrackingController : ControllerBase
    {
        ITonerTrackingService _tonerTrackingService;

        public TonerTrackingController(ITonerTrackingService tonerTrackingService)
        {
            _tonerTrackingService = tonerTrackingService;
        }
        [HttpPost("add")]
        public IActionResult Add(TonerTracking entity)
        {
            var result = _tonerTrackingService.Add(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TonerTracking entity)
        {
            var result = _tonerTrackingService.Delete(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TonerTracking entity)
        {
            var result = _tonerTrackingService.Update(entity);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("gettonerdetails")]
        public IActionResult GetRentalDetails()
        {
            var result = _tonerTrackingService.GetTonerTrackingDtos();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
