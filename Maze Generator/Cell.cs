using System.Drawing;

namespace Maze_Generator
{
    class Cell
    {
        Pen blackPen;
        float i;
        float j;
        double w;
        bool visited;
        public static int numVisited = 0;
        static int numCells;

        public bool[] walls = { true, true, true, true };

        public Cell(float _i, float _j, double _w)
        {
            i = _i;
            j = _j;
            w = _w;
            blackPen = new Pen(Color.Black, 1f);
            visited = false;
            numCells++;
        }

        public float GetI()
        {
            return i;
        }

        public float GetJ()
        {
            return j;
        }

        public bool GetWalls(int index)
        {
            return walls[index];
        }

        public bool GetVisited()
        {
            return visited;
        } 

        public void SetVisited(bool option)
        {
            visited = option;
        }

        public int GetNumVisited()
        {
            return numVisited;
        }
        
        public int GetNumCells()
        {
            return numCells;
        }
    }
}
