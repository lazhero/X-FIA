using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_API_XFIA.Modules.Fetcher;
using REST_API_XFIA.Modules.Mappers;

namespace REST_API_XFIA.Tests
{
    public class RealTeamFetcherTests
    {
        [Fact]
        public void getRealTeamsSublistTest() {
            var Db = new REST_API_XFIA.SQL_Model.DB_Context.RESTAPIXFIA_dbContext();
            var tour = RealTeamFetcher.getRealTeamsSubList(Db.Realteams.ToList(),1,2);
            Assert.True(tour[0].Name.Equals("Equipo Supermega Corredor") || tour[1].Name.Equals("Equipo Malos Corredores"));
        }
    }

}
