using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    [Serializable]
    public class Map : IEnumerable<Cell>, ICloneable
    {
        private Cell[,] _cells;

        public int Width { get; private set; }
        public int Height { get; private set; }
        public Cell this[int x, int y]
        {
            get
            {
                return _cells[x, y];
            }
        }

        public long Generation { get; set; }

        public Map(int width, int height)
        {
            this.Height = height;
            this.Width = width;

            _cells = new Cell[Width, Height];
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    _cells[x, y] = new Cell(x, y);
                }
            }
        }

        public Map(IEnumerable<string> template)
        {
            var mapInfo = from map in template
                          where map.Length == template.Max(x => x.Length)
                          let count = template.Count()
                          select new { width = template.Max(x => x.Length), height = count };

            foreach (var item in mapInfo)
            {
                this._cells = new Cell[item.width, item.height];
                this.Width = item.width;
                this.Height = item.height;

                var r = -1;
                foreach (var row in template)
                {
                    r++;
                    var record = row.ToCharArray();
                    for (int x = 0; x < item.width; x++)
                    {
                        this._cells[x, r] = new Cell(x, r);
                        if (record[x] == '■')
                            this._cells[x, r].IsAlive = true;
                    }
                }
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    sb.Append(_cells[x, y].IsAlive ? "■" : "□");
                }
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        public IEnumerator<Cell> GetEnumerator()
        {
            foreach (var cell in _cells)
            {
                yield return cell;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw null;
        }

        public object Clone()
        {
            object clone = null;
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);
                stream.Position = 0;

                clone = formatter.Deserialize(stream);
            }
            return clone;
        }
    }
}
