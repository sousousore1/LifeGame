using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public interface ILivingCondition
    {
        void ConfirmationAlive(Map map);
        IEnumerable<Cell> GetNaighbors(Map map, int x, int y);
    }

    public class StandardLivingCondition : ILivingCondition
    {
        public void ConfirmationAlive(Map map)
        {
            var oldMap = map.Clone() as Map;
            Parallel.ForEach(oldMap, cell =>
            {
                var aliveCount = GetNaighbors(oldMap, cell.X, cell.Y).Where(c => c.IsAlive).Count();
                if (cell.IsAlive)
                {
                    // 生存
                    if (aliveCount == 2 || aliveCount == 3)
                    {
                        map[cell.X, cell.Y].IsAlive = true;
                        map[cell.X, cell.Y].Age++;
                    }

                    // 過疎
                    if (aliveCount <= 1)
                    {
                        map[cell.X, cell.Y].IsAlive = false;
                        map[cell.X, cell.Y].Age = 0;
                    }

                    // 過密
                    if (aliveCount >= 4)
                    {
                        map[cell.X, cell.Y].IsAlive = false;
                        map[cell.X, cell.Y].Age = 0;
                    }
                }
                else
                {
                    // 誕生
                    if (aliveCount == 3)
                    {
                        map[cell.X, cell.Y].IsAlive = true;
                        map[cell.X, cell.Y].Age = 1;
                    }
                }
            });
        }

        public IEnumerable<Cell> GetNaighbors(Map map, int row, int col)
        {
            int[] rows = { row - 1, row, row + 1 };
            int[] cols = { col - 1, col, col + 1 };

            foreach (var x in rows)
            {
                foreach (var y in cols)
                {
                    if (row != x || col != y)
                    {
                        if (x >= 0 && x < map.Width &&
                            y >= 0 && y < map.Height)
                        {
                            yield return map[x, y];
                        }
                    }
                }
            }

            yield break;
        }
    }
}
