using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public class Game
    {
        public void Play(IMapDrawable drawer, ILivingCondition condition)
        {
            var map = new Map(Template.GetPentadecathlon());
            while (true)
            {
                map.Generation++;
                drawer.Draw(map);
                condition.ConfirmationAlive(map);
                var read = Console.ReadLine();
                if (read == "end") break;
            }
        }
    }
}
