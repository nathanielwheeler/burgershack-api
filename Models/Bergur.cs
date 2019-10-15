using System;
using System.ComponentModel.DataAnnotations;
using bergur_api.Interfaces;

namespace bergur_api.Models
{
	public class Bergur : IItem
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