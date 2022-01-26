using CoffeMachine.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Interfaces
{
    public interface IUserChoiceService
    {
        void AddUserChoice(UserDrinkChoiceDTO userDrinkChoiceDTO);

        void UpdateUserChoice(UserDrinkChoiceDTO userDrinkChoiceDTO);

        UserDrinkChoiceDTO GetUserChoice(string badgeNumber);
    }
}
