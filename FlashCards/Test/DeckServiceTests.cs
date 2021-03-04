using Newtonsoft.Json;
using src.Factories;
using src.Models;
using src.Services;
using src.Services.Repos;
using System;
using System.Collections.Generic;
using System.Configuration;
using Xunit;
using Moq;

namespace Test
{
    public class DeckServiceTests
    {
        private readonly DeckService _sut;
        private readonly Mock<IDeckRepo> _deckRepoMock = new Mock<IDeckRepo>();

        public DeckServiceTests()
        {
            _sut = new DeckService(_deckRepoMock.Object);
        }

        [Fact]
        public void GetAllDecks_ShouldReturnAllDecks()
        {
            // Arrange
            var firstDeck = new Deck
            {
                Name = "deck1",
            };

            var secondDeck = new Deck
            {
                Name = "deck2"
            };

            var expected = new List<Deck> { firstDeck, secondDeck };

            _deckRepoMock.Setup(x => x.GetAllDecksFromDatabase())
                .Returns(expected);

            // Act
            var actual = _sut.GetAllDecks();

            // Assert
            Assert.Equal(actual[0].Name, expected[0].Name);
            Assert.Equal(actual[1].Name, expected[1].Name);
        }

        [Fact]
        public void GetDeck_ShouldReturnSingleDeck()
        {
            // Arrange
            var expected = new Deck
            {
                Name = "deck1",
                Id = 1
            };
            _deckRepoMock.Setup(x => x.GetDeck(1))
                .Returns(expected);

            // Act
            var actual = _sut.GetDeck(1);

            // Assert
            Assert.Equal(expected.Name, actual.Name);
            Assert.Equal(expected.Id, actual.Id);
        }

        [Fact]
        public void GetDeckName_ShouldReturnSingleDeckName()
        {
            // Arrange
            var expected = "testName";
            _deckRepoMock.Setup(x => x.GetDeckNameFromDatabase(1))
                .Returns(expected);

            // Act
            var actual = _sut.GetDeckName(1);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
