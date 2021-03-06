﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Snakezzzzzzzz.Models;

namespace Snakezzzzzzzz.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[Route("GameOver")]
		public IActionResult GameOver()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
