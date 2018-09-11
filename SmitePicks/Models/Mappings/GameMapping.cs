using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmitePicks.Models.Mappings
{
    public class GameMapping : ClassMap<Game>
    {
        public GameMapping()
        {
            Id(x => x.Id)
                .Column("Id")
                .GeneratedBy.Assigned();

            Map(x => x.Team1);
            Map(x => x.Team2);
            Map(x => x.Draft);
            Map(x => x.DatePlayed);
            Map(x => x.ScreenshotUrl);
            Map(x => x.Region);
        }
    }
}