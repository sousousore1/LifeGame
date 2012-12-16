using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifeGame
{
    public static class Template
    {
        #region 固定型
        /// <summary>
        /// ブロック
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetBlock()
        {
            yield return "□□□□";
            yield return "□■■□";
            yield return "□■■□";
            yield return "□□□□";
            yield break;
        }

        /// <summary>
        /// 蜂の巣
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetBeehive()
        {
            yield return "□■□";
            yield return "■□■";
            yield return "■□■";
            yield return "□■□";
            yield break;
        }

        /// <summary>
        /// ボート
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetBoat()
        {
            yield return "□■□";
            yield return "■□■";
            yield return "□■■";
            yield break;
        }

        /// <summary>
        /// 船
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetShip()
        {
            yield return "■■□";
            yield return "■□■";
            yield return "□■■";
            yield break;
        }

        /// <summary>
        /// 池
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetPool()
        {
            yield return "□■■□";
            yield return "■□□■";
            yield return "■□□■";
            yield return "□■■□";
            yield break;
        }
        #endregion

        #region 振動型
        /// <summary>
        /// ブリンカー
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetBlinker()
        {
            yield return "□■□";
            yield return "□■□";
            yield return "□■□";
            yield break;
        }

        /// <summary>
        /// ペンタデカスロン
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetPentadecathlon()
        {
            yield return "□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□";
            yield return "□□□□□■□□□□■□□□□□";
            yield return "□□□□■■□□□□■■□□□□";
            yield return "□□□□□■□□□□■□□□□□";
            yield return "□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□";
            yield break;
        }

        /// <summary>
        /// ヒキガエル
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetHikigaeru()
        {
             yield return "□□■□";
             yield return "■□□■";
             yield return "■□□■";
             yield return "□■□□";
             yield break;
        }

        /// <summary>
        /// ビーコン
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetBeecon()
        {
            yield return "□□■■";
            yield return "□□■■";
            yield return "■■□□";
            yield return "■■□□";
            yield break;
        }

        /// <summary>
        /// 時計
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetClock()
        {
            yield return "□□■□";
            yield return "■□■□";
            yield return "□■□■";
            yield return "□■□□";
            yield break;
        }
        #endregion

        #region 移動型
        /// <summary>
        /// グライダー
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetGlider()
        {
            yield return "□■□";
            yield return "■□□";
            yield return "■■■";
            yield break;
        }

        /// <summary>
        /// 軽量級宇宙船
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetSmallSpaceship()
        {
            yield return "□■□□■";
            yield return "■□□□□";
            yield return "■□□□■";
            yield return "■■■■□";
            yield break;
        }

        /// <summary>
        /// 中量級宇宙船
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetMiddleSpaceship()
        {
            yield return "□□□■□□";
            yield return "□■□□□■";
            yield return "■□□□□□";
            yield return "■□□□□■";
            yield return "■■■■■□";
            yield break;
        }

        /// <summary>
        /// 重量級宇宙船
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetLargeSpaceship()
        {
            yield return "□□□■■□□";
            yield return "□■□□□□■";
            yield return "■□□□□□□";
            yield return "■□□□□□■";
            yield return "■■■■■■□";
            yield break;
        }

        /// <summary>
        /// グライダー・ガン
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetGliderGun()
        {
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□■□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□■□■□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□■■□□□□□□■■□□□□□□□□□□□□■■□";
            yield return "□□□□□□□□□□□□■□□□■□□□□■■□□□□□□□□□□□□■■□";
            yield return "□■■□□□□□□□□■□□□□□■□□□■■□□□□□□□□□□□□□□□";
            yield return "□■■□□□□□□□□■□□□■□■■□□□□■□■□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□■□□□□□■□□□□□□□■□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□■□□□■□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□■■□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield return "□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□";
            yield break;
        }

        /// <summary>
        /// 汽車ぽっぽ
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetKishaPoppo()
        {
            yield return "□□□■□";
            yield return "□□□□■";
            yield return "■□□□■";
            yield return "□■■■■";
            yield return "□□□□□";
            yield return "□□□□□";
            yield return "□□□□□";
            yield return "■□□□□";
            yield return "□■■□□";
            yield return "□□■□□";
            yield return "□□■□□";
            yield return "□■□□□";
            yield return "□□□□□";
            yield return "□□□□□";
            yield return "□□□■□";
            yield return "□□□□■";
            yield return "■□□□■";
            yield return "□■■■■";
            yield break;
        }
        #endregion

        #region 長寿型
        /// <summary>
        /// ダイハード
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetDieHard()
        {
            yield return "□□□□□□■□";
            yield return "■■□□□□□□";
            yield return "□■□□□■■■";
            yield break;
        }

        /// <summary>
        /// ドングリ
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetDongri()
        {
            yield return "□■□□□□□";
            yield return "□□□■□□□";
            yield return "■■□□■■■";
            yield break;
        }
        #endregion
    }
}
