using System;
using System.Collections.Generic;
using burger_api.Models;
using burger_api.Repositories;

namespace burger_api.Services
{
	public class MenuService
	{
		private readonly MenuRepository _repo;
		public MenuService(MenuRepository repo)
		{
			_repo = repo;
		}
		public IEnumerable<MenuItem> Get()
		{
			return _repo.Get();
		}

		public MenuItem Get(string id)
		{
			MenuItem exists = _repo.Get(id);
			if (exists == null) { throw new Exception("BadID"); }
			return exists;
		}

		public MenuItem Create(MenuItem newItem)
		{
			MenuItem exists = _repo.Exists("name", newItem.Name);
			if (exists != null) { throw new Exception("We already got that bruh."); }
			newItem.Id = Guid.NewGuid().ToString();
			_repo.Create(newItem);
			return newItem;
		}

		public MenuItem Edit(MenuItem itemData)
		{
			MenuItem item = _repo.Get(itemData.Id);
			if (item == null) { throw new Exception("Invalid Id"); }
			item.Name = itemData.Name;
			item.Description = itemData.Description;
			item.Price = itemData.Price;
			_repo.Edit(itemData);
			return itemData;
		}

		public string Delete(string id)
		{
			MenuItem item = _repo.Get(id);
			if (item == null) { throw new Exception("Bad ID"); }
			_repo.Remove(id);
			return "successfully deleted";
		}
	}
}