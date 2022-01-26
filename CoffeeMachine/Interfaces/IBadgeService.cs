using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Interfaces
{
    public interface IBadgeService
    {
        public string GetOwner(string badgeNumber);
    }
}
