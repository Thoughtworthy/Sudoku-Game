using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_Game.LoggInfo
{
    public static class LoggInfo
    {
        private static string path = "Total-Games";
        private static string info = GetInfo();

        //TODO: some work
        public static void FillInfo(int L,int W)
        {
            if (!File.Exists(path))
            {
                string msg = $"{L.ToString()} {W.ToString()}";
                File.WriteAllText(path, msg);
            }
            L += GetTotalLost();
            W += GetTotalWins();
            string msg1 = $"{L.ToString()} {W.ToString()}";
            File.WriteAllText(path, msg1);
        }
        private static string GetInfo()
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, "0 0");
            }      
             return File.ReadAllText(path);
        }
        public static int GetTotalWins()
        {
            return int.Parse(info.Split(' ')[0]);
        }
        public static int GetTotalLost()
        {
            return int.Parse(info.Split(' ')[1]);
        }

    }
}
