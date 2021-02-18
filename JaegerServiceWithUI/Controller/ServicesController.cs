using JaegerServiceWithUI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JaegerServiceWithUI.Controller
{
	[Route("api/[controller]")]
	[ApiController]
	public class ServicesController : ControllerBase
	{
		[HttpGet]
		public IActionResult Get()
		{
			return new JsonResult(new ResponseModel<List<string>>() { data = new List<string> { "value1", "value2" } });
		}
	}
}
