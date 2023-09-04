using Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.DTO.Tweets
{
    public class AddTweetRequest
    {
        public string? Content { get; set; }
        public Guid IdUser { get; set; }
        public DateTime? CreatedTime { get; set; }
        public byte[]? Media { get; set; }
        public string? Tag { get; set; }

        public Tweet ToTweet()
        {

            return new Tweet
            {
                Content = Content,
                IdUser = IdUser,
                CreatedTime = CreatedTime,
                Media = Media,
                Tag = Tag
            };

        }
    }
}
