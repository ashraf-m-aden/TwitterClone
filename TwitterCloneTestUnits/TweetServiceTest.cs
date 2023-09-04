using Interfaces;
using Interfaces.DTO.Tweets;

namespace TwitterCloneTestUnits
{
    public class TweetServiceTest
    {
        private readonly ITweetService _tweetService;
        [Fact]
        public void AddTweetHasIdUser()
        {
            //Arrange
            var request = new AddTweetRequest(
                ){
                Content = "Ceci est un test",
                CreatedTime = DateTime.Now
            } ;

            //Assert
            Assert.ThrowsAsync<ArgumentException>(async () => await _tweetService.AddTweet( request )
            );
        }
        public async void AddTweetIsCorrectlySaved()
        {
            //Arrange
            var request = new AddTweetRequest(
                )
            {
                Content = "Ceci est un test",
                IdUser = new Guid(),
                CreatedTime = DateTime.Now
            };

            //Act
            var savedTweet = await _tweetService.AddTweet(request);

            //Assert
            Assert.Equal(request.Content, savedTweet.Content);
            Assert.Equal(request.IdUser, savedTweet.IdUser);
            Assert.Equal(request.CreatedTime, savedTweet.CreatedTime);
        }
        [Fact]
        public void AddTweetHasEitherContentOrMedia()
        {
            //Arrange
            var request = new AddTweetRequest(
                )
            {
                IdUser = new Guid(),
                CreatedTime = DateTime.Now
            };

           

            //Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await _tweetService.AddTweet(request));
        }

        [Fact]
        public void AddTweetIsNotNull()
        {
            //Arrange
            AddTweetRequest? request = null;



            //Assert
            //Assert
            Assert.ThrowsAsync<ArgumentNullException>(async () => await //Act
                _tweetService.AddTweet(request)
            );
        }
    }
}