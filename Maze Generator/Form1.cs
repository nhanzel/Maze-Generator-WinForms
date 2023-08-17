using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Maze_Generator
{
    public partial class MazeGenerator : Form
    {
        Pen blackPen;
        Brush fusPen;
        Pen fushPen;
        Brush greenBrush;
        Graphics graph;
        Cell[] grid;
        Cell current;
        Cell checkWhat;
        Stack st;
        Color mainColor;
        Color frontColor;

        int rows = 50;
        int size = 400;
        int counter = 0;
        int w;
        int i = 0;
        int j = 0;
        float x;
        float y;
        int carlSagan = 0;
        int timeCheck = 1000;

        public MazeGenerator()
        {
            InitializeComponent();
            blackPen = new Pen(Color.Black, 1f);
            graph = Panel.CreateGraphics();
            st = new Stack();
        }

        private void InitialButton_Click(object sender, EventArgs e)
        {
            rows = int.Parse(SizeTB.Text);
            w = size / rows;
            grid = new Cell[rows * rows];
            timeCheck = 5000 - int.Parse(SpeedTB.Text);

            for (j=0; j < rows; j++)
            {
                for (i=0; i < rows; i++)
                {
                    grid[counter] = new Cell(i, j, w);
                    ShowLine();
                    counter++;
                }
            }
            carlSagan++;
            InitialButton.Enabled = false;
            StartButton.Enabled = true;

            mainColor = ColorTranslator.FromHtml(ColorTB1.Text);
            frontColor = ColorTranslator.FromHtml(ColorTB2.Text);
            fusPen = new SolidBrush(mainColor);
            fushPen = new Pen(mainColor, 1f);
            greenBrush = new SolidBrush(frontColor);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartButton.Enabled = false;
            InitialButton.Enabled = true;

            current = grid[0];

            while (grid[counter - 1].GetNumVisited() < grid[counter - 1].GetNumCells())
            {
                current.SetVisited(true);
                if (current.GetVisited())
                {
                    graph.FillRectangle(greenBrush, current.GetI() * w + 1, current.GetJ() * w + 1, w - 1, w - 1);
                }
                System.Threading.Thread.Sleep(timeCheck);

                //STEP 1
                checkWhat = (Cell)CheckNeighbors();
                if (checkWhat != current)
                {
                    Cell.numVisited++;
                    //STEP 2
                    st.Push(current);
                    //STEP 3
                    ShowLine();
                    //STEP 4
                    checkWhat.SetVisited(true);
                    if (current.GetVisited())
                    {
                        graph.FillRectangle(fusPen, current.GetI() * w + 1, current.GetJ() * w + 1, w - 1, w - 1);
                    }
                    current = checkWhat;
                    if (Cell.numVisited == (rows * rows) - 1)
                    {
                        graph.FillRectangle(fusPen, current.GetI() * w + 1, current.GetJ() * w + 1, w - 1, w - 1);
                        break;
                    }
                }
                else if (st.Count > 0)
                {
                    object temp = st.Pop();
                    graph.FillRectangle(fusPen, current.GetI() * w + 1, current.GetJ() * w + 1, w - 1, w - 1);
                    current = (Cell)temp;
                }
            }
        }

        public void ShowLine()
        {
            if (carlSagan == 0)
            {
                float ii = grid[counter].GetI();
                float jj = grid[counter].GetJ();
                x = ii * w;
                y = jj * w;

                if (grid[counter].GetWalls(0))
                {
                    graph.DrawLine(blackPen, x, y, x + w, y);
                }
                if (grid[counter].GetWalls(1))
                {
                    graph.DrawLine(blackPen, x + w, y, x + w, y + w);
                }
                if (grid[counter].GetWalls(2))
                {
                    graph.DrawLine(blackPen, x + w, y + w, x, y + w);
                }
                if (grid[counter].GetWalls(3))
                {
                    graph.DrawLine(blackPen, x, y + w, x, y);
                }
            }
            else
            {
                float iI = current.GetI();
                float jJ = current.GetJ();
                x = iI * w;
                y = jJ * w;

                float c = checkWhat.GetI();
                float d = checkWhat.GetJ();
                float e = c * w;
                float f = d * w;

                RemoveWalls();

                if (!current.GetWalls(0))
                {
                    graph.DrawLine(fushPen, x, y, x + w, y);
                }
                if (!current.GetWalls(1))
                {
                    graph.DrawLine(fushPen, x + w, y, x + w, y + w);
                }
                if (!current.GetWalls(2))
                {
                    graph.DrawLine(fushPen, x + w, y + w, x, y + w);
                }
                if (!current.GetWalls(3))
                {
                    graph.DrawLine(fushPen, x, y + w, x, y);
                }
                if (!checkWhat.GetWalls(0))
                {
                    graph.DrawLine(fushPen, e, f, e + w, f);
                }
                if (!checkWhat.GetWalls(1))
                {
                    graph.DrawLine(fushPen, e + w, f, e + w, f + w);
                }
                if (!checkWhat.GetWalls(2))
                {
                    graph.DrawLine(fushPen, e + w, f + w, e, f + w);
                }
                if (!checkWhat.GetWalls(3))
                {
                    graph.DrawLine(fushPen, e, f + w, e, f);
                }
            }
        }

        public object CheckNeighbors()
        {
            ArrayList neighbors = new ArrayList();
            int arrayCounter = 0;
            i = (int)current.GetI();
            j = (int)current.GetJ();
            Cell top, right, bottom, left;

            int topIndex = Index(i, (j - 1));
            if (topIndex > -1)
            {
                top = grid[topIndex];
            }
            else
            {
                top = null;
            }

            int rightIndex = Index((i + 1), j);
            if (rightIndex > -1)
            {
                right = grid[rightIndex];
            }
            else
            {
                right = null;
            }

            int bottomIndex = Index(i, (j + 1));
            if (bottomIndex > -1)
            {
                bottom = grid[Index(i, (j + 1))];
            }
            else
            {
                bottom = null;
            }

            int leftIndex = Index((i - 1), j);
            if (leftIndex > -1)
            {
                left = grid[leftIndex];
            }
            else
            {
                left = null;
            }

            if (top != null && !top.GetVisited())
            {
                neighbors.Add(top);
                arrayCounter++;
            }

            if (right != null && !right.GetVisited())
            {
                neighbors.Add(right);
                arrayCounter++;
            }

            if (bottom != null && !bottom.GetVisited())
            {
                neighbors.Add(bottom);
                arrayCounter++;
            }

            if (left != null && !left.GetVisited())
            {
                neighbors.Add(left);
                arrayCounter++;
            }

            if (arrayCounter > 0)
            {
                Random r = new Random();
                int randomNumber = r.Next(0, arrayCounter);
                return neighbors[randomNumber];
            }
            else
            {
                return current;
            }
        }

        public int Index(int i, int j)
        {
            if (i < 0 || j < 0 || i > rows - 1 || j > rows - 1)
            {
                return -1;
            }
            else
            {
                return i + j * rows;
            }
        }

        public void RemoveWalls()
        {
            float x = current.GetI() - checkWhat.GetI();
            if (x == 1)
            {
                current.walls[3] = false;
                checkWhat.walls[1] = false;
            }
            else if (x == -1)
            {
                current.walls[1] = false;
                checkWhat.walls[3] = false;
            }

            float y = current.GetJ() - checkWhat.GetJ();
            if (y == 1)
            {
                current.walls[0] = false;
                checkWhat.walls[2] = false;
            }
            else if (y == -1)
            {
                current.walls[2] = false;
                checkWhat.walls[0] = false;
            }
        }
    }
}
