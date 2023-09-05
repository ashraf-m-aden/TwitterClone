using Entities;
using Interfaces;
using Interfaces.DTO.Tweets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwitterClone.Areas.Tweets.WebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class TweetsController : ControllerBase
    {

        private readonly ITweetService _tweetService;
        private readonly TweetDbContext _db;

        public TweetsController()
        {
            _tweetService = new TweetService(new TweetDbContext(
                new DbContextOptionsBuilder<TweetDbContext>().Options));
        }

        // GET: api/<ValuesController>
        [HttpGet("all")]
        public List<TweetResponse> GetAllTweet()
        {
            var response =  _tweetService.FetchAllTweets();
            return response;
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<ActionResult<TweetResponse>> PostTweet([FromBody] AddTweetRequest request)
        {
            var response = await _tweetService.AddTweet(request);
            return Ok(response);
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
