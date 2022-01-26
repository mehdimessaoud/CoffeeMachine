using CoffeMachine.DTO;
using CoffeMachine.Interfaces;
using CoffeMachine.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Services
{
    public class UserChoiceService : IUserChoiceService
    {
        private readonly CoffeeDbContext coffeeDbContext;

        public UserChoiceService(CoffeeDbContext coffeeDBContext)
        {
            this.coffeeDbContext = coffeeDBContext;
        }

        public UserDrinkChoiceDTO GetUserChoice(string badgeNumber)
        {
            var badge = coffeeDbContext.Badges
                        .Include(badge => badge.UserSelection)
                        .ThenInclude(c => c.DrinkType)
                        .FirstOrDefault(b => b.BadgeNumber == badgeNumber);

            if (badge?.UserSelection == null)
            {
                return null;
            }

            UserDrinkChoiceDTO clientSelectionDTO = new UserDrinkChoiceDTO();
            clientSelectionDTO.BadgeNumber = badgeNumber;
            clientSelectionDTO.UsePersonalMug = badge.UserSelection.UsePersonalMug;
            clientSelectionDTO.DrinkTypeId = badge.UserSelection.DrinkType.Id;
            clientSelectionDTO.SugarQuantity = badge.UserSelection.SugarQty;
            return clientSelectionDTO;
        }

        public void AddUserChoice(UserDrinkChoiceDTO userDrinkChoiceDTO)
        {
            var badge = coffeeDbContext.Badges.FirstOrDefault(b => b.BadgeNumber == userDrinkChoiceDTO.BadgeNumber);
            var drinkType = coffeeDbContext.DrinkTypes.FirstOrDefault(d => d.Id == userDrinkChoiceDTO.DrinkTypeId);
            var userSelection = new UserSelection();
            userSelection.Badge = badge;
            userSelection.DrinkType = drinkType;
            userSelection.UsePersonalMug = userDrinkChoiceDTO.UsePersonalMug;
            userSelection.SugarQty = userDrinkChoiceDTO.SugarQuantity;
            coffeeDbContext.ClientSelections.Add(userSelection);
            coffeeDbContext.SaveChanges();
        }

        public void UpdateUserChoice(UserDrinkChoiceDTO userDrinkChoiceDTO)
        {
            var badge = coffeeDbContext.Badges.FirstOrDefault(b => b.BadgeNumber == userDrinkChoiceDTO.BadgeNumber);
            var drinkType = coffeeDbContext.DrinkTypes.FirstOrDefault(d => d.Id == userDrinkChoiceDTO.DrinkTypeId);

            var clientSelection = coffeeDbContext.ClientSelections.First(cs => cs.Badge.BadgeNumber == userDrinkChoiceDTO.BadgeNumber);
            clientSelection.DrinkType = drinkType;
            clientSelection.UsePersonalMug = userDrinkChoiceDTO.UsePersonalMug;
            clientSelection.SugarQty = userDrinkChoiceDTO.SugarQuantity;

            coffeeDbContext.Entry(clientSelection).State = EntityState.Modified;
            coffeeDbContext.SaveChanges();
        }
    }
}
