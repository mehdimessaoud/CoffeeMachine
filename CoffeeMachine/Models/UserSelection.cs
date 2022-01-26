using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Models
{
    public class UserSelection
    {
        public long Id { get; set; }

        public DrinkType DrinkType { get; set; }

        public bool UsePersonalMug { get; set; }

        public int SugarQty { get; set; }

        public Badge Badge { get; set; }
        public long BadgeId { get; internal set; }

    }
}
