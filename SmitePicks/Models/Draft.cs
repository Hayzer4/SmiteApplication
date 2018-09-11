using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmitePicks.Models
{
    public class Draft
    {
        public int Id { get; set; }

        public string Team1Pick1 { get; set; }

        public string Team1Pick2 { get; set; }

        public string Team1Pick3 { get; set; }

        public string Team1Pick4 { get; set; }

        public string Team1Pick5 { get; set; }

        public string Team2Pick1 { get; set; }

        public string Team2Pick2 { get; set; }

        public string Team2Pick3 { get; set; }

        public string Team2Pick4 { get; set; }

        public string Team2Pick5 { get; set; }

        public string Team1Ban1 { get; set; }

        public string Team1Ban2 { get; set; }

        public string Team1Ban3 { get; set; }

        public string Team1Ban4 { get; set; }

        public string Team2Ban1 { get; set; }

        public string Team2Ban2 { get; set; }

        public string Team2Ban3 { get; set; }

        public string Team2Ban4 { get; set; }
    }
}