using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore2.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
        public int UnitsInStock { get; set; }
    }
}
