using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeMachine.Models;
using CoffeMachine.Interfaces;

namespace CoffeMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BadgesController : ControllerBase
    {
        private readonly IBadgeService badgeService;

        public BadgesController(IBadgeService badgeService)
        {
            this.badgeService = badgeService;
        }

        // api/Badge/GetOwner/BadgeNumber
        [HttpGet("GetOwner/{badgeNumber}")]
        public string GetOwner(string badgeNumber)
        {
            var owner = badgeService.GetOwner(badgeNumber);
            return owner;
        }

    }
}
