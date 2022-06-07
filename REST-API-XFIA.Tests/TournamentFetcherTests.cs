using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using REST_API_XFIA.Modules.Fetcher;
using REST_API_XFIA.Modules.Mappers;

namespace REST_API_XFIA.Tests
{
    public class TournamentFetcherTests
    {
        [Fact]
        public void GetActiveOrFutureTournamentTest() {
            var tour = TournamentFetcher.GetActiveTournament();
            Assert.True(tour.InitialDate > DateTime.Today || (tour.InitialDate == DateTime.Today && tour.InitialHour >= DateTime.Now.TimeOfDay));
        }
        [Fact]
        public void GetTournamentTestIfReturnsSpecified()
        {
            var tour = TournamentFetcher.GetTournament();
            Assert.True(TournamentFetcher.GetActiveTournament().Key.Equals(tour.Key));

            tour = TournamentFetcher.GetTournament("QWE123");
            Assert.True(tour.Key.Equals("QWE123"));
        }
    }

}
