﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HW8.Models;
using HW8.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HW8.Controllers
{
    [Authorize]
    [Route("/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost(Name = nameof(Authenticate))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(200)]

        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] TokenRequest req)
        {
            if (req == null)
            {
                return BadRequest();
            }

            var result = await _userService.Authenticate(req);
            if (result == null)
            {
                return Unauthorized();
            }
            return Ok(result);
        }
    }
}
