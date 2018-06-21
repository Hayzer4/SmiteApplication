using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmitePicks.Models
{
    public class Game
    {
        public int Id { get; set; }

        public string Team1 {get; set;}

        public string Team2 { get; set; }

        public Draft Draft { get; set; }

        public DateTime DatePlayed { get; set; }

        public string ScreenshotUrl { get; set; }

        public Regions Region { get; set; }

        public Game(int id)
            : this(id, string.Empty, string.Empty, null, DateTime.Parse("01/01/2001"), string.Empty, Regions.EU)
        { }

        public Game(
            int id,
            string team1,
            string team2,
            Draft draft,
            DateTime datePlayed,
            string screenshotUrl,
            Regions region)
        {
            Id = id;
            Team1 = team1;
            Team2 = team2;
            Draft = draft;
            DatePlayed = datePlayed;
            ScreenshotUrl = screenshotUrl;
            Region = region;
        }
    }
}