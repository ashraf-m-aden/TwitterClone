using Interfaces.DTO.Tweets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITweetService
    {
        Task<TweetResponse> AddTweet(AddTweetRequest request);
        Task<List<TweetResponse>> FetchAllTweets();
        List<TweetResponse> FetchAllTweetsByIdUser(Guid id);
        List<TweetResponse> FetchAllTweetsByTag(string tag);
        TweetResponse FetchOneTweetByIdTweet(Guid id);

    }
}
