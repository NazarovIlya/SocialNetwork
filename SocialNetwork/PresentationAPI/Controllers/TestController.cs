using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PresentationAPI.Controllers
{
	[ApiController]
	[Route("api/[contoller]")]
	public class TestController : ControllerBase
	{
		[HttpGet]
		public string[] Get()
		{
			return new string[] { "Hello", "world!" };
		}
	}
}
