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
    public class TonerModelController : ControllerBase
    {
        ITonerModelService _tonerModelService;

        public TonerModelController(ITonerModelService tonerModelService)
        {
            _tonerModelService = tonerModelService;
        }
        [HttpPost("add")]
        public IActionResult Add(TonerModel tonerModel)
        {
            var result = _tonerModelService.Add(tonerModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(TonerModel tonerModel)
        {
            var result = _tonerModelService.Delete(tonerModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(TonerModel tonerModel)
        {
            var result = _tonerModelService.Update(tonerModel);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _tonerModelService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
