using CoffeMachine.Interfaces;
using CoffeMachine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Services
{
    public class DrinkTypeService : IDrinkTypeService
    {
        private readonly CoffeeDbContext coffeeDBContext;

        public DrinkTypeService(CoffeeDbContext coffeeDBContext)
        {
            this.coffeeDBContext = coffeeDBContext;
        }

        public async Task<IEnumerable<DrinkType>> GetAllDrinkTypes()
        {
            return await coffeeDBContext.DrinkTypes.ToListAsync();
        }
    }
}
