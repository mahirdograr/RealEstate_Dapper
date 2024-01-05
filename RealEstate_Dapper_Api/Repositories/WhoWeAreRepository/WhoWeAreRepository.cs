using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreRepository
{
    public class WhoWeAreRepository : IWhoWeAreRepository
    {
        private readonly Context _context;

        public WhoWeAreRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto)
        {
            string query = "insert into WhoWeAreDetail (Title,Subtitle,Description1,Description2) values (@title,@subTitle,@description1,@description2)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createWhoWeAreDetailDto.Title);
            parameters.Add("@subTitle", createWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", createWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", createWhoWeAreDetailDto.Description2);
            
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void DeleteWhoWeAreDetail(int id)
        {
            string query = "Delete from WhoWeAreDetail where WhoWeAreDetailId= @whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);

            }
        }

        public async Task<List<WhoWeAreDetailDtos>> GetAllWhoWeAreDetailAsync()
        {
            string query = "Select * from WhoWeAreDetail";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<WhoWeAreDetailDtos>(query);
                return values.ToList();
            }
        }

        public async Task<List<GetByWhoWeAreDetailDto>> GetWhoWeAreDetail(int id)
        {
            string query = "Select * from WhoWeAreDetail where WhoWeAreDetailId= @whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@whoWeAreDetailId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByWhoWeAreDetailDto>(query, parameters);
                if (values != null)
                {
                    return new List<GetByWhoWeAreDetailDto> { values };
                }


                return new List<GetByWhoWeAreDetailDto>();
            }
        }

        public async void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto)
        {
            string query = "Update WhoWeAreDetail set Title= @title , Subtitle = @subtitle,Description1=@description1,Description2=@description2 where WhoWeAreDetailId= @whoWeAreDetailId";
            var parameters = new DynamicParameters();
            parameters.Add("@title", updateWhoWeAreDetailDto.Title);
            parameters.Add("@subtitle", updateWhoWeAreDetailDto.SubTitle);
            parameters.Add("@description1", updateWhoWeAreDetailDto.Description1);
            parameters.Add("@description2", updateWhoWeAreDetailDto.Description2);
            parameters.Add("@whoWeAreDetailId", updateWhoWeAreDetailDto.WhoWeAreDetailId);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
