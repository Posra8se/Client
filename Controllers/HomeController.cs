using iSchool.Constants;
using iSchool.Models;
using iSchool.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iSchool.Controllers
{
    /// <summary>
    /// Controller responsible for handling all main page requests for the iSchool website.
    /// This controller manages the rendering of various views such as the home page, news, faculty listings,
    /// employment data, and academic program information.
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="apiService">The API service used to fetch data from external endpoints.</param>
        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        /// <summary>
        /// Renders the home page (About) view of the iSchool website.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the About view with school information.
        /// </returns>
        public async Task<IActionResult> Index()
        {
            var model = await _apiService.GetModelAsync<AboutViewModel>(ApiEndpoints.About);
            return View(model);
        }

        /// <summary>
        /// Renders the News view displaying the latest news and announcements from the school.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the News view with news articles.
        /// </returns>
        public async Task<IActionResult> News()
        {
            var model = await _apiService.GetModelAsync<NewsViewModel>(ApiEndpoints.News);
            return View(model);
        }

        /// <summary>
        /// Renders the Faculty view displaying information about the school's faculty members.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the Faculty view with faculty information.
        /// </returns>
        public async Task<IActionResult> Faculty()
        {
            var model = await _apiService.GetModelAsync<FacultyViewModel>(ApiEndpoints.Faculty);
            return View(model);
        }

        /// <summary>
        /// Renders the Co-Op Table view displaying co-op employment information for students.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the Co-Op Table view with co-op data.
        /// </returns>
        public async Task<IActionResult> CoOpTable()
        {
            var model = await _apiService.GetModelAsync<CoOpTableViewModel>(ApiEndpoints.CoOpTable);
            return View(model);
        }

        /// <summary>
        /// Renders the Employment Table view displaying employment information for graduates.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the Employment Table view with employment data.
        /// </returns>
        public async Task<IActionResult> EmploymentTable()
        {
            var model = await _apiService.GetModelAsync<EmploymentTableViewModel>(ApiEndpoints.EmploymentTable);
            return View(model);
        }

        /// <summary>
        /// Renders the Undergraduate view displaying information about undergraduate programs.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the Undergraduate view with program information.
        /// </returns>
        public async Task<IActionResult> Undergraduate()
        {
            var model = await _apiService.GetModelAsync<UndergraduateViewModel>(ApiEndpoints.Undergraduate);
            return View(model);
        }

        /// <summary>
        /// Renders the Graduate view displaying information about graduate programs.
        /// </summary>
        /// <returns>
        /// The <see cref="Task{IActionResult}"/> containing the Graduate view with program information.
        /// </returns>
        public async Task<IActionResult> Graduate()
        {
            var model = await _apiService.GetModelAsync<GraduateViewModel>(ApiEndpoints.Graduate);
            return View(model);
        }

        /// <summary>
        /// Handles errors that occur during request processing.
        /// </summary>
        /// <returns>
        /// The <see cref="IActionResult"/> containing the Error view with error details.
        /// </returns>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}