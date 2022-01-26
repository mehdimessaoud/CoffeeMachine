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
    public class DrinkTypesController : ControllerBase
    {
        private readonly IDrinkTypeService drinkTypeService;

        public DrinkTypesController(IDrinkTypeService drinkTypeService)
        {
            this.drinkTypeService = drinkTypeService;
        }

        [HttpGet]
        public async Task<IEnumerable<DrinkType>> Get()
        {
            return await drinkTypeService.GetAllDrinkTypes();
        }


    }
}
