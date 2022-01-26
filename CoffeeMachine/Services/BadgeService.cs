using CoffeMachine.Interfaces;
using CoffeMachine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Services
{
    public class BadgeService : IBadgeService
    {
        private readonly CoffeeDbContext coffeeDBContext;

        public BadgeService(CoffeeDbContext coffeeDBContext)
        {
            this.coffeeDBContext = coffeeDBContext;
        }

        public string GetOwner(string badgeNumber)
        {
            var badge = coffeeDBContext.Badges.FirstOrDefault(b => b.BadgeNumber == badgeNumber);

            if (badge == null)
            {
                return string.Empty;
            }

            return badge.Owner;
        }
    }
}
