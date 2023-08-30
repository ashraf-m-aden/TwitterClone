using Microsoft.AspNetCore.Mvc;
using System.Configuration;
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
        private AuthController _authController;
        private IConfiguration _configuration;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _authController = new AuthController(_configuration);
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
        [HttpPost]
        public IActionResult Index(UserDto user)
        {
            if (user.Email is not null && user.Password is not null)
            {
                return RedirectToAction("Index", "Home",new {area="Tweets"});
            }
            return View();
        }

        public IActionResult SignUpForm(UserDto user)
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