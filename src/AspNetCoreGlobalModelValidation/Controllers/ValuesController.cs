﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AspNetCoreGlobalModelValidation.Models;

namespace AspNetCoreGlobalModelValidation.Controllers
{
    [Route("api/[controller]")]
    public class MoviesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/movies
        [HttpPost]
        public IActionResult Create([FromBody]Movie value)
        {
            return Json("OK");
        }
    }
}
