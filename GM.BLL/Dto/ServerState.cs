﻿namespace GM.BLL.Dto
{
    public class ServerState
    {
        public ServerState()
        {
            Top5Maps = new string[0];
            Top5GameModes = new string[0];
        }

        public int TotalMatchesPlayed { get; set; }

        public int MaximumMatchesPerDay { get; set; }

        public double AverageMatchesPerDay { get; set; }

        public int MaximumPopulation { get; set; }

        public double AveragePopulation { get; set; }

        public string[] Top5GameModes { get; set; }

        public string[] Top5Maps { get; set; }
    }
}