using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmitePicks.Models.Mappings
{
    public class DraftMapping : ClassMap<Draft>
    {
        public DraftMapping()
        {
            Id(x => x.Id)
                .Column("Id")
                .GeneratedBy.Assigned();

            Map(x => x.Team1Pick1);
            Map(x => x.Team1Pick2);
            Map(x => x.Team1Pick3);
            Map(x => x.Team1Pick4);
            Map(x => x.Team1Pick5);
            Map(x => x.Team2Pick1);
            Map(x => x.Team2Pick2);
            Map(x => x.Team2Pick3);
            Map(x => x.Team2Pick4);
            Map(x => x.Team2Pick5);

            Map(x => x.Team1Ban1);
            Map(x => x.Team1Ban2);
            Map(x => x.Team1Ban3);
            Map(x => x.Team1Ban4);
            Map(x => x.Team2Ban1);
            Map(x => x.Team2Ban2);
            Map(x => x.Team2Ban3);
            Map(x => x.Team2Ban4);
        }
    }
}