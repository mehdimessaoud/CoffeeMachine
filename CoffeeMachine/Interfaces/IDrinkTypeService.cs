using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Interfaces
{
    public interface IDrinkTypeService
    {
        Task<IEnumerable<DrinkType>> GetAllDrinkTypes();
    }
}
