using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorsGame.Models
{
    public class Grid
    {
        public int Row { get; set; }
        public int Column  { get; set; }
        public List<List<Cellule>> grid { get; set; }
        private PlayState State;
        public Colors TrueColor { get; set; }
        public Colors FalseColor { get; set; }

        /*public Grid()
        {
            this.Column = 2;
            this.Row = 1;
            this.State = PlayState.NotStarted;
            this.TrueColor = Colors.grey;
            this.FalseColor = Colors.black; 
        }*/
        public void CreateGrid() 
        {
            this.grid = new List<List<Cellule>>();
            for (var i = 0; i < this.Column; i++)
            {
                List<Cellule> ListCell = new List<Cellule>();
                Cellule cell;
                for (var j = 0; j < this.Row; j++)
                {
                    cell = new Cellule(this.FalseColor);
                    ListCell.Add(cell);                                       
                }
                grid.Add(ListCell);
            }
            // choise one random cellule to make it red 
            Random rnd1 = new Random();
            int RandomColum, RandomRow;
            RandomColum = rnd1.Next(this.Column);
            RandomRow = rnd1.Next(this.Row);
            this.grid[RandomColum][RandomRow].Color = this.TrueColor;
        }
        public void InitialGrid()
        {
            this.Column = 2;
            this.Row = 1;
            this.SetColors(1);
            CreateGrid(); 
        }
        public void RefreshGrid(int niveau)
        {
            this.SetColors(niveau); 
            this.CreateGrid(); 
        }
        public void StartGame()
        {
            this.InitialGrid(); 
            this.State = PlayState.Playing;
        }
        public void GameOver()
        {
            this.State = PlayState.GameOver; 
        }
        public bool GameIsOver()
        {
            return this.State == PlayState.GameOver;
        }
        public bool GameIsStarted()
        {
            return this.State == PlayState.Playing;
        }
        public bool GameIsNotStarted()
        {
            return this.State == PlayState.NotStarted;
        }
        public void SetColors(int Level)
        {
            switch(Level%4)
            {
                case 1:
                    this.TrueColor = Colors.grey; 
                    this.FalseColor = Colors.black;
                    break;
                case 2:
                    this.TrueColor = Colors.red; 
                    this.FalseColor = Colors.blue;
                    break;
                case 3:
                    this.TrueColor = Colors.green;
                    this.FalseColor = Colors.yellow;
                    break;
                case 0:
                    this.TrueColor = Colors.purple;
                    this.FalseColor = Colors.orange;
                    break;
            }
                
                
        }
    }

   
        
}
