using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColorsGame.Models
{
    public class Grid
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public List<List<Cellule>> grid { get; set; }

        private PlayState State;
        public Level ActuelLevel { get; set; }
        public Colors TrueColor { get; set; }
        public Colors FalseColor { get; set; }        
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
            this.RandomCellColored();
        }
        public void InitialGrid()
        {
            this.Column = 1;
            this.Row = 2;
            this.SetColors(1);
            CreateGrid();
        }
        public void RefreshGrid(int niveau)
        {
            this.SetColors(niveau);
            this.CreateGrid();
        }

        // colorer tous les cellules avec la couleur dominanate
        public void ColorAllTheGrid()
        {
            for (var k = 0; k < this.Column; k++)
            {
                for (var l = 0; l < this.Row; l++)
                {
                    this.grid[k][l].Color = this.FalseColor;
                }
            }
        }
        public void RandomCellColored()
        {
            Cellule RandmCell = new Cellule();
            RandmCell = RandmCell.RandomCell(this);
            RandmCell.Color = this.TrueColor;
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
        public bool CountingTime()
        {
            return this.State == PlayState.PlayingCountingTime;
        }

        public void StartCountingTime()
        {
            this.State = PlayState.PlayingCountingTime;
        }

        public void SetColors(int Level)
        {
            if (Level > 6)
            {
                return;
            }
            switch (Level % 4)
            {
                case 1:
                    this.TrueColor = Colors.grey;
                    this.FalseColor = Colors.black;
                    break;
                case 2:
                    this.TrueColor = Colors.purple;
                    this.FalseColor = Colors.orange;
                    break;
                case 3:
                    this.TrueColor = Colors.green;
                    this.FalseColor = Colors.yellow;
                    break;
                case 0:
                    this.TrueColor = Colors.red;
                    this.FalseColor = Colors.blue;
                    break;
            }
        }
    } 
}
