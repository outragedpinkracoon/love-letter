using Xunit;
using LoveLetter.Domain;

namespace LoveLetterTests
{
    public class LoveLetterTests
    {
        [Fact]
        public void CardTest() 
        {
            var card = new Card();
            Assert.Equal("my name",card.Name());
        }
    }
}
