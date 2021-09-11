using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorsGame.Models
{
    public class Level
    {
        public int Niveau { get; set; }
        public int Chance { get; set; } 
        public int Counter { get; set; }
        public Level()
        {
            this.Niveau = 1;
            this.Chance = 0;
            this.Counter = 0;
        }
        public Level(int niveau)
        {
            this.Niveau = niveau;
            this.Chance = 0;
            this.Counter = 0;
        }
        public void NextLevel(Grid grid)
        {
            this.Chance = 0;
            this.Niveau++;
            if(this.Niveau<7)
            {
                if (grid.Column > grid.Row)
                    grid.Row = grid.Row * 2;
                else
                    grid.Column = grid.Column * 2;
            }
            if(this.Niveau==7)
            {
                this.Counter = 10; 
            }
            else if(this.Niveau>7&&this.Counter>0)
            {
                this.Counter--; 
            }
            if (this.Niveau > 6)
            {
                grid.StartCountingTime();
            }
        }
    }
}