using System;
using System.Collections.Generic;
using System.Data;
using burger_api.Models;

namespace burger_api.Repositories
{
	public class MenuRepository
	{
		private readonly IDbConnection _db;

		public MenuRepository(IDbConnection db)
		{
			_db = db;
		}

		internal IEnumerable<MenuItem> Get()
		{
			throw new NotImplementedException();
		}

		internal MenuItem Get(string id)
		{
			throw new NotImplementedException();
		}

		internal MenuItem Exists(string v, string name)
		{
			throw new NotImplementedException();
		}

		internal void Create(MenuItem newItem)
		{
			throw new NotImplementedException();
		}

		internal void Edit(MenuItem itemData)
		{
			throw new NotImplementedException();
		}

		internal void Remove(string id)
		{
			throw new NotImplementedException();
		}
	}
}