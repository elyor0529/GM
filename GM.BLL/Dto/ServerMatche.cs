﻿namespace GM.BLL.Dto
{
    public class ServerMatche
    {
        public ServerMatche()
        {
            Scoreboard = new ScoreboardItem[0];
        }

        public string Map { get; set; }

        public string GameMode { get; set; }

        public int FragLimit { get; set; }

        public int TimeLimit { get; set; }

        public float TimeElapsed { get; set; }

        public ScoreboardItem[] Scoreboard { get; set; }
    }
}