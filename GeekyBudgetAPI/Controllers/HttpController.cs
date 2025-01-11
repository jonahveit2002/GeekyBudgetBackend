using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GeekyBudgetAPI;

namespace MyApp.Namespace
{
    [Route("api/[controller]")]
    [ApiController]
    public class HttpController : ControllerBase
    {
        private readonly IHttpService _httpService;

        public HttpController(IHttpService httpService)
        {
            _httpService = httpService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductAsync()
        {
            return Ok(await _httpService.ReadAsync());
        }
    }
}
