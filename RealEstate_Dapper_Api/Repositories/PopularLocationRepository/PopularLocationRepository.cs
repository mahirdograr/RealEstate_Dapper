﻿using Dapper;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
	public class PopularLocationRepository : IPopularLocationRepository
	{
		private readonly Context _context;

		public PopularLocationRepository(Context context)
		{
			_context = context;
		}
		public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
		{
			string query = "Select * from Popularlocation";

			using (var connection = _context.CreateConnection())
			{
				var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
				return values.ToList();
			}
		}
	}
}
