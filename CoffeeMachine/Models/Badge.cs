using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeMachine.Models
{
    public class Badge
    {
        [Key]
        public long Id { get; set; }

        public string BadgeNumber { get; set; }

        public string Owner { get; set; }

        public UserSelection UserSelection { get; set; }
    }
}
