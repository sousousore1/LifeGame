using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public interface IMapDrawable
    {
        void Draw(Map map);
    }

    public class ConsoleDrawer : IMapDrawable
    {
        public void Draw(Map map)
        {
            Console.Clear();
            Console.WriteLine(map.ToString());
            Console.WriteLine(string.Format("Generation:{0}", map.Generation));
        }
    }
}
