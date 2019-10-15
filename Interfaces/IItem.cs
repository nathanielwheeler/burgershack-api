using System.ComponentModel.DataAnnotations;

namespace burger_api.Interfaces
{
	public interface IItem
	{

		[Required]
		string Name { get; set; }
		[Required]
		string Description { get; set; }
		[Required]
		decimal Price { get; set; }
	}

}