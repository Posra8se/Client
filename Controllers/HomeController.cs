using iSchool.Constants;
using iSchool.Models;
using iSchool.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApiService _apiService;

        public HomeController(ApiService apiService)
        {
            _apiService = apiService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _apiService.GetModelAsync<AboutViewModel>(ApiEndpoints.About);
            return View(model);
        }

        public async Task<IActionResult> News()
        {
            var model = await _apiService.GetModelAsync<NewsViewModel>(ApiEndpoints.News);
            return View(model);
        }

        public async Task<IActionResult> Faculty()
        {
            var model = await _apiService.GetModelAsync<FacultyViewModel>(ApiEndpoints.Faculty);
            return View(model);
        }
        public async Task<IActionResult> CoOpTable()
        {
            var model = await _apiService.GetModelAsync<CoOpTableViewModel>(ApiEndpoints.CoOpTable);
            return View(model);
        }

        public async Task<IActionResult> EmploymentTable()
        {
            var model = await _apiService.GetModelAsync<EmploymentTableViewModel>(ApiEndpoints.EmploymentTable);
            return View(model);
        }

        public async Task<IActionResult> Undergraduate()
        {
            var model = await _apiService.GetModelAsync<UndergraduateViewModel>(ApiEndpoints.Undergraduate);
            return View(model);
        }

        public async Task<IActionResult> Graduate()
        {
            var model = await _apiService.GetModelAsync<GraduateViewModel>(ApiEndpoints.Graduate);
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}