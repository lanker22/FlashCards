using src.Factories;
using src.Models;
using src.Services;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Configuration;
using Xunit;

namespace Test
{
    public class DeckServiceTests
    {

        private readonly DeckService _sut;
        private readonly DeckRepo _deckRepo;
        private readonly RepoHelper _repoHelper;
        private readonly SqLiteFactory _dbFac;

        public DeckServiceTests()
        {
            _dbFac = new SqLiteFactory("DataSource=memory;");
            _repoHelper = new RepoHelper();
            _deckRepo = new DeckRepo(_repoHelper, _dbFac);
            _sut = new DeckService(_deckRepo);
        }

        [Fact]
        public void GetAllDecks_ShouldReturnEveryDeckInDatabase()
        {
            _dbFac.SetupSqliteDatabaseForTesting();
            // Arrange
            var firstDeck = new Deck
            {
                Name = "test1",
                Cards = new List<Card>(),
                Id = 1
            };

            var secondDeck = new Deck
            {
                Name = "test2",
                Cards = new List<Card>(),
                Id = 2
            };

            var decksToReturn = new List<Deck> { firstDeck, secondDeck };

            // Act
            var decks = _sut.GetAllDecks();

            // Assert
            Assert.Equal(decksToReturn, decks);
        }
    }
}
