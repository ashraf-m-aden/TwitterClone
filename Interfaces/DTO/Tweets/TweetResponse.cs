using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO.Tweets
{
    public class TweetResponse
    {
        public Guid IdTweet { get; set; }
        public string? Content { get; set; }
        public Guid IdUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public byte[]? Media { get; set; }
        public string? Tag { get; set; }

    }
    public static class TweetExtensions
    {
        public static TweetResponse ToTweetResponse(this Tweet tweet)
        {
            return new TweetResponse()
            {
                IdTweet = tweet.IdTweet,
                Content = tweet.Content,
                IdUser = tweet.IdUser,
                CreatedTime = tweet.CreatedTime,
                Media = tweet.Media,
                Tag = tweet.Tag
            };
        }
    }
}
