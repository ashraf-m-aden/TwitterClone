using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;
using TwitterClone.Models;

namespace TwitterClone.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private GeneralViewModel _generalViewModel = new GeneralViewModel();
        private ConnectionState _state;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

   

        public IActionResult Index(bool? isSignIn)
        {
            if (_state == null)
            {
                _state = new ConnectionState(false, true);

            }
            if (isSignIn==null)
            {

                _state = new ConnectionState(false, true);
                _generalViewModel.connectionState = _state;
                _generalViewModel.userDto = new UserDto();
                return View(_generalViewModel);

            }
            if (_state.IsLoggedIn)
            {
                return RedirectToAction("Index", "Tweets/Home");
            }

            _state.IsSignIn = (bool)isSignIn;
            _generalViewModel.connectionState = _state;
            _generalViewModel.userDto = new UserDto();
         
            return View(_generalViewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult SignUpForm()
        {



            return RedirectToAction("Index");


        }
        public IActionResult SignInForm()
        {

            _state.IsSignIn= true;

            return RedirectToAction("Index");


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}