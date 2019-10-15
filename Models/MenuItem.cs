using System;
using System.ComponentModel.DataAnnotations;
using burger_api.Interfaces;

namespace burger_api.Models
{
	public class Burger : IItem
	{

		[Required]
		public string Name { get; set; }
		[Required]
		public string Description { get; set; }
		[Required]
		public decimal Price { get; set; }
		public string Id { get; set; }
	}
}