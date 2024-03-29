﻿using Microsoft.AspNetCore.Mvc;
using PULSE.Services.Interfaces;
using System.Security.Claims;

namespace PULSE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BaseController<T, TSearch> : ControllerBase where T : class where TSearch : class
    {
        public IService<T, TSearch> Service { get; set; }

        public BaseController(IService<T, TSearch> service)
        {
            Service = service;
        }

        [HttpGet]
        public virtual ActionResult<IEnumerable<T>> Get([FromQuery] TSearch search = null)
        {
            try
            {
                return Ok(Service.Get(search));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public virtual ActionResult<T> GetById(int id, [FromQuery] TSearch? search = null)
        {
            try
            {
                return Ok(Service.GetById(id, search));
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
