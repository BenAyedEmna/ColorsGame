using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorsGame.Models
{
    public class Level
    {
        public int Niveau { get; set; } 
        public Level()
        {
            this.Niveau = 1; 
        }
        public Level(int niveau)
        {
            this.Niveau = niveau; 
        }
        public void NextLevel(Grid grid)
        {
            this.Niveau++;
            if (grid.Column > grid.Row)
                grid.Row = grid.Row * 2;
            else
                grid.Column = grid.Column * 2;
        }
    }

}
