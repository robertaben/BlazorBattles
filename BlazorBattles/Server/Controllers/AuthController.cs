﻿using BlazorBattles.Server.Data;
using BlazorBattles.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBattles.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            var response = await _authRepository.Register(
                new User
                {
                    Username = request.Username,
                    Email = request.Email,
                    Bananas = request.Bananas,
                    DateOfBirth = request.DateOfBirth,
                    IsConfirmed = request.IsConfirmed,
                }, request.Password);

            if(!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
