using Entities;
using Interfaces;
using Interfaces.DTO.Tweets;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Services;

namespace TwitterClone.Areas.Tweets.Controllers
{
    [Area("Tweets")]
    public class HomeController : Controller
    {

        private readonly ITweetService _tweetService;

        public HomeController()
        {
            _tweetService = new TweetService(new TweetDbContext(
                        new DbContextOptionsBuilder<TweetDbContext>().Options));
        }

        // GET: HomeController
        [Route("/")]
        public ActionResult Index()
        {
            ViewBag.tweetList = _tweetService.FetchAllTweets();
            ViewBag.newTweet = new AddTweetRequest();
            return View();
        }

        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
