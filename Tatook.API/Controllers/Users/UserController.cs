﻿using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection.Metadata;
using Tatook.Domain.Commands;
using Tatook.Domain.Entities.Users;
using Tatook.Shared.Commands;
using Tatook.Shared.Handlers;

namespace Tatook.API.Controllers.Users
{
    [ApiController]
    [Route("v1/users")]
    public class UserController : ControllerBase
    {
        private readonly IHandler<CreateUserCommand> _userHandler;
        public UserController(IHandler<CreateUserCommand> userHandler)
        {
            _userHandler = userHandler;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateUserCommand command)
        {
            var result = _userHandler.Handle(command);
            return StatusCode((result.StatusCode),result);
        }
    }
}
