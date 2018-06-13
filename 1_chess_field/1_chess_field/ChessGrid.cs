using Instruments;
using System;

namespace _1_chess_field
{
    public class ChessGrid
    {
        int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (Validator.IsPositive(value)) height = value;
            }
        }
        int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (Validator.IsPositive(value)) width = value;
            }
        }
        char agr;

        public ChessGrid(int height, int width, char agr)
        {
            try
            {
                Height = height;
                Width = width;
                this.agr = agr;
            }
            catch (Exception ex)
            {
                Console.Read();
                Environment.Exit(0);
            }
        }
        public String GetGrid()
        {
            String row = "", grid = "";
            for (int i = 0; i < width; i++)
            {
                row += agr + " ";
            }
            row = row.Trim();
            for (int i = 0; i < height; i++)
            {
                if (i % 2 != 0)
                {
                    grid += " ";
                }
                grid += row + "\n";
            }
            return grid.Trim();
        }
    }
}
