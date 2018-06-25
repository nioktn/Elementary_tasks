using System;

namespace _1_chess_field
{
    public class ChessGrid
    {
        int _height;
        public int Height
        {
            get { return _height; }
            set => _height = value;
        }
        int _width;
        public int Width
        {
            get { return _width; }
            set => _width = value;
        }
        char _agr;
        public char Agr
        {
            get => _agr;
            set => _agr = value;
        }

        public ChessGrid(int height, int width, char agr)
        {
            Height = height;
            Width = width;
            Agr = agr;
        }
        public String GetGrid()
        {
            String row = String.Empty, grid = String.Empty;
            for (int i = 0; i < _width; i++)
            {
                row += Agr + " ";
            }
            row = row.Trim();
            for (int i = 0; i < _height; i++)
            {
                grid += i % 2 != 0 ? " " : String.Empty;
                grid += row + "\n";
            }
            return grid.Trim();
        }
    }
}