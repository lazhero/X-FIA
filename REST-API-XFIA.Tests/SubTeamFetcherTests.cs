using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_API_XFIA.Modules.Fetcher;
using REST_API_XFIA.Modules.Mappers;

namespace REST_API_XFIA.Tests
{
    public class FetcherTests
    {
        [Fact]
        public void getSubTeamsLatestTest() {
            var tour = SubTeamFetcher.getSubTeamsLatest("briwag88@hotmail.com");
            Assert.True(tour[0].Name.Equals("Equipo Supermega Corredor") || tour[1].Name.Equals("Equipo Malos Corredores"));
        }
    }

}
