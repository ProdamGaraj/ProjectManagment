using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace CarService.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CarController : ControllerBase
	{
		private HttpClient Client;

		public CarController()
		{
			Client = new HttpClient();
			Client.BaseAddress = new Uri("http://keyservice:80");
			Client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
		}

		[HttpGet("test")]
		public IActionResult Test()
		{
			return Ok("Whiu-whiu car is locked.");
		}

		[HttpGet("key")]
		public IActionResult OpenCar()
		{
			var input = Client.GetAsync("Key").Result;
			string sound = input.Content.ReadAsStringAsync().Result;
			return Ok(sound);
		}
	};
}