using Microsoft.AspNetCore.Mvc;

namespace KeyService.Controllers
{
	[ApiController]
	[Route("[controller]")]

	public class KeyController : ControllerBase
	{
		[HttpGet]
		public string GetSygnal()
		{
			string[] KeySignals = { "bip-bip", "whop-whop", "bark" };

			return KeySignals[(new Random()).Next(0,2)];
		}
	}
}