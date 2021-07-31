using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorsGame.Models
{
    public class Cellule
    {
        public Colors Color { get; set; }
        public Cellule(Colors color)
        {
            this.Color = color; 
        }
    }
}
