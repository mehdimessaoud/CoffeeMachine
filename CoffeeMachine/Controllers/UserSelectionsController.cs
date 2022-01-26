using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoffeMachine.Models;
using CoffeMachine.Interfaces;
using CoffeMachine.DTO;

namespace CoffeMachine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserSelectionsController : ControllerBase
    {
        private readonly IUserChoiceService userChoiceService;

        public UserSelectionsController(IUserChoiceService userChoiceService)
        {
            this.userChoiceService = userChoiceService;
        }


        // api/ClientSelection/GetClientSelection/BadgeNumber
        [HttpGet("GetUserSelection/{badgeNumber}")]
        public IActionResult GetUserSelection(string badgeNumber)
        {
            var clientSelection = userChoiceService.GetUserChoice(badgeNumber);

            if (clientSelection == null)
            {
                return NotFound();
            }

            return Ok(clientSelection);
        }

        [HttpPost]
        public IActionResult AddSelection(UserDrinkChoiceDTO userDrinkChoiceDTO)
        {
            userChoiceService.AddUserChoice(userDrinkChoiceDTO);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateSelection(UserDrinkChoiceDTO userDrinkChoiceDTO)
        {
            userChoiceService.UpdateUserChoice(userDrinkChoiceDTO);
            return Ok();
        }
    }
}
