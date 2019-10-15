using System;
using System.Collections.Generic;
using burger_api.Models;
using burger_api.Services;
using Microsoft.AspNetCore.Mvc;

namespace burger_api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MenuController : ControllerBase
	{
		private readonly MenuService _ms;
		public MenuController(MenuService ms)
		{
			_ms = ms;
		}


		[HttpGet]
		public ActionResult<IEnumerable<MenuItem>> Get()
		{
			try
			{
				return Ok(_ms.Get());
			}
			catch (Exception e) { return BadRequest(e.Message); };
		}

		[HttpGet("{id}")]
		public ActionResult<MenuItem> Get(string id)
		{
			try
			{
				return Ok(_ms.Get(id));
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}

		[HttpPost]
		public ActionResult<MenuItem> Post([FromBody] MenuItem newItem)
		{
			try
			{
				return Ok(_ms.Create(newItem));
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}

		[HttpPut("{id}")]
		public ActionResult<MenuController> Edit(string id, [FromBody] MenuItem itemData)
		{
			try
			{
				itemData.Id = id;
				return Ok(_ms.Edit(itemData));
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}

		[HttpDelete("{id}")]
		public ActionResult<string> Delete(string id)
		{
			try
			{
				return Ok(_ms.Delete(id));
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}





	}
}