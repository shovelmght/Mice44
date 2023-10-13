using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesserKnown.Public
{
    /// <summary>
    /// This class holds alld the public static variables
    /// For now only the health
    /// </summary>
    public static class PublicVariables
    {
        public static int COINS;
        public static int APPLES;
        public static int MAX_COLLECTIBLES = 10;
        public static int HEALTH_FULL_PLAYER = 4;
        public static int HEALTH_FULL_BOSS = 4;
        public static int hp_player = 4;
        public static int hp_boss = 4;
        public static bool IS_FUSIONED;
        public static bool IS_BOSS_DEAD;
        public static bool IS_RESET;
        public static bool IS_IN_PAUSE_MENU;

        public static bool Lose_Health(int amount)
        {
            hp_player -= amount;

            if (hp_player <= 0)
                return true;

            return false;
        }

        public static void Reset_Level(int amount)
        {
            hp_player = amount;
        }
        public static void Reset_Health()
        {
            hp_player = HEALTH_FULL_PLAYER;
            hp_boss = HEALTH_FULL_BOSS;
            IS_RESET = true;
        }
        public static void ResetAllVariable()
        {
         COINS = 0;
         APPLES = 0;
         MAX_COLLECTIBLES = 10;
         HEALTH_FULL_PLAYER = 4;
         HEALTH_FULL_BOSS = 4;
         hp_player = 4;
         hp_boss = 4;
         IS_FUSIONED = false;
         IS_BOSS_DEAD = false;
         IS_RESET = false;
    }
    }
}
