using Entities;
using Interfaces;
using Interfaces.DTO.Tweets;

namespace Services
{
    public class TweetService : ITweetService
    {

        private readonly TweetDbContext _db;

        public TweetService(TweetDbContext tweetDbContext)
        {
            _db = tweetDbContext;
        }

        public async Task<TweetResponse> AddTweet(AddTweetRequest? request)
        {
            request.CreatedTime = DateTime.Now;

            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (request.Content == null && request.Media==null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            if (request.IdUser == Guid.Empty)
            {
                throw new ArgumentException("Aucun ID user");
            }
            var newTweet = request.ToTweet();
            newTweet.IdTweet = Guid.NewGuid();
            _db.Tweets.Add(newTweet);
            _db.SaveChanges();
            return newTweet.ToTweetResponse();

        }

        public async Task<List<TweetResponse>> FetchAllTweets()
        {

            return _db.Tweets.Select(tw=>tw.ToTweetResponse()).ToList();  
        }

        public List<TweetResponse> FetchAllTweetsByIdUser(Guid id)
        {
            var retrivedTweets =(List<Tweet>)  _db.Tweets.Where(tw => tw.IdUser == id);
            return retrivedTweets.Select(tw=>tw.ToTweetResponse()).ToList() ;
        }

        public List<TweetResponse> FetchAllTweetsByTag(string tag)
        {
            throw new NotImplementedException();
        }

        public TweetResponse FetchOneTweetByIdTweet(Guid id)
        {
            Tweet retrievedTweet =  _db.Tweets.FirstOrDefault(tw => tw.IdTweet == id);
            return retrievedTweet.ToTweetResponse() ;
        }
    }
}