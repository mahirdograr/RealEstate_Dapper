using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public class CategoryRepositry : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepositry(Context context)
        {
            _context = context;
        }

        public async void CreateCategory(CreateCategoryDto createCategoryDto)
        {
            string query = "insert into Category (CategoryName,CategoryStatus) values (@categoryName , @categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName",createCategoryDto.categoryName);
            parameters.Add("@categorystatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

        public async void DeleteCategory(int id)
        {
            string query = "Delete from Category where CategoryId= @categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }


        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from Category";

            using(var connection=_context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdCategoryDto> GetCategory(int id)
        {
            string query = "Select * From Category Where CategoryID=@CategoryID";
            var parameters = new DynamicParameters();
            parameters.Add("@CategoryID", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdCategoryDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            string query = "Update Category set CategoryName= @categoryName , CategoryStatus = @categoryStatus where CategoryId= @categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", updateCategoryDto.CategoryName);
            parameters.Add("@categoryStatus", updateCategoryDto.CategoryStatus);
            parameters.Add("@categoryId", updateCategoryDto.CategoryId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
