using System;
using System.Collections.Generic;
using burger_api.Db;
using burger_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace burger_api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class MenuController : ControllerBase
	{
		//NOTE fake AF
		List<Burger> Burgers { get; set; } = FakeDB.Burgers;

		[HttpGet]
		public ActionResult<IEnumerable<Burger>> Get()
		{
			return Ok(Burgers);
		}

		[HttpGet("{id}")]
		public ActionResult<Burger> Get(string id)
		{
			try
			{
				Burger i = Burgers.Find(item => item.Id == id);
				if (i == null) { throw new System.Exception("Invalid Id"); }
				return Ok(i);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public ActionResult<Burger> Post([FromBody] Burger newBurger)
		{
			try
			{
				newBurger.Id = Guid.NewGuid().ToString();
				Burgers.Add(newBurger);
				return Ok(newBurger);
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}

		[HttpPut("{id}")]
		public ActionResult<BurgersController> Edit(string id, [FromBody] Burger newBurgerData)
		{
			try
			{
				Burger burgerToEdit = Burgers.Find(burger_api => burger_api.Id == id);
				if (burgerToEdit == null) { throw new Exception("Invalid Id"); }
				burgerToEdit.Name = newBurgerData.Name;
				burgerToEdit.Description = newBurgerData.Description;
				return Ok(newBurgerData);
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}
	}
}