using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    [Serializable]
    public class Cell
    {
        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.Age = 0;
        }

        public override string ToString()
        {
            return string.Format("cell is alive:{0} age:{1} x:{2} y:{3}", IsAlive, Age, X, Y);
        }
    }
}
