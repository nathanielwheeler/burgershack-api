using System;
using System.Collections.Generic;
using System.Data;
using burger_api.Models;
using Dapper;

namespace burger_api.Repositories
{
	public class MenuRepository
	{
		private readonly IDbConnection _db;

		public MenuRepository(IDbConnection db)
		{
			_db = db;
		}

		public IEnumerable<MenuItem> Get()
		{
			string sql = "SELECT * FROM burgershackMenu";
			return _db.Query<MenuItem>(sql);
		}

		public MenuItem Get(string id)
		{
			string sql = "SELECT * FROM burgershackMenu WHERE id = @id";
			return _db.QueryFirstOrDefault<MenuItem>(sql, new { id });
		}

		public void Create(MenuItem newItem)
		{
			string sql = @"
			INSERT INTO burgershackMenu
			(id, name, price, description)
			VALUES
			(@Id, @Name, @Price, @Description)";
			_db.Execute(sql, newItem);
		}

		public void Edit(MenuItem itemData)
		{
			string sql = @"
			UPDATE burgershackMenu
			SET
				name = @Name,
				price = @Price,
				description = @Description
			WHERE id = @Id";
			_db.Execute(sql, itemData);
		}

		public void Remove(string id)
		{
			string sql = @"DELETE FROM burgershackMenu WHERE id = @id";
			_db.Execute(sql, new { id });
		}
	}
}