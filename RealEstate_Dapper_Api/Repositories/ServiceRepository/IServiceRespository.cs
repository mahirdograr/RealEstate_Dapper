using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRespository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();

        void CreateService(CreateServiceDto createServiceDto);

        void DeleteService(int id);

        void UpdateWhoWeAreDetail(UpdateServiceDtos updateServiceDtos);

        Task<List<GetByIdServiceDto>> GetService(int id);
    }
}
