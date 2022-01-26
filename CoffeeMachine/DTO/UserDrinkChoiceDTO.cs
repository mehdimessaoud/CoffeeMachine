using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.DTO
{
    public class UserDrinkChoiceDTO
    {
        public long DrinkTypeId { get; set; }

        public bool UsePersonalMug { get; set; }

        public string BadgeNumber { get; set; }

        public int SugarQuantity { get; set; }

        public override bool Equals(object obj)
        {
            if((obj==null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            UserDrinkChoiceDTO udc = (UserDrinkChoiceDTO)obj;
            return (DrinkTypeId, UsePersonalMug, BadgeNumber, SugarQuantity) == (udc.DrinkTypeId, udc.UsePersonalMug, udc.BadgeNumber, udc.SugarQuantity);

        }
    }
}
