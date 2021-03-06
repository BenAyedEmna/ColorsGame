using System;

namespace ColorsGame.Models
{
    public class Cellule
    {
        public Colors Color { get; set; }
        public Cellule()
        {
        }
        public Cellule(Colors color)
        {
            this.Color = color; 
        }
        public Cellule RandomCell(Grid grid)
        {
            Random rnd1 = new Random();
            int RandomColum, RandomRow;
            RandomColum = rnd1.Next(grid.Column);
            RandomRow = rnd1.Next(grid.Row);
            return grid.grid[RandomColum][RandomRow];
        }
    }
}
