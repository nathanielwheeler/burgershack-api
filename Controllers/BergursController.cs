using System;
using System.Collections.Generic;
using bergur_api.Db;
using bergur_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace bergur_api.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class BergursController : ControllerBase
	{
		//NOTE fake AF
		List<Bergur> Bergurs { get; set; } = FakeDB.Bergurs;

		[HttpGet]
		public ActionResult<IEnumerable<Bergur>> Get()
		{
			return Ok(Bergurs);
		}

		[HttpGet("{id}")]
		public ActionResult<Bergur> Get(string id)
		{
			try
			{
				Bergur i = Bergurs.Find(item => item.Id == id);
				if (i == null) { throw new System.Exception("Invalid Id"); }
				return Ok(i);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}

		[HttpPost]
		public ActionResult<Bergur> Post([FromBody] Bergur newBergur)
		{
			try
			{
				newBergur.Id = Guid.NewGuid().ToString();
				Bergurs.Add(newBergur);
				return Ok(newBergur);
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}

		[HttpPut("{id}")]
		public ActionResult<BergursController> Edit(string id, [FromBody] Bergur newBergurData)
		{
			try
			{
				Bergur bergurToEdit = Bergurs.Find(bergur_api => bergur_api.Id == id);
				if (bergurToEdit == null) { throw new Exception("Invalid Id"); }
				bergurToEdit.Name = newBergurData.Name;
				bergurToEdit.Description = newBergurData.Description;
				return Ok(newBergurData);
			}
			catch (Exception e) { return BadRequest(e.Message); }
		}
	}
}