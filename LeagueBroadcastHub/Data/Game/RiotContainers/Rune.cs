﻿
namespace LeagueBroadcastHub.Data.Game.RiotContainers
{
    public class Rune
    {

        public string displayName;
        public int id;

        public Rune(int id, string displayName)
        {
            this.id = id;
            this.displayName = displayName;
        }
    }
}