using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldOfASCIITanks.Rendering
{
    public class MatrixCoords
    {
        public MatrixCoords(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row { get; set; }

        public int Col { get; set; }

        public static MatrixCoords operator +(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row + b.Row, a.Col + b.Col);
        }

        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.Row - b.Row, a.Col - b.Col);
        }
    }
}
