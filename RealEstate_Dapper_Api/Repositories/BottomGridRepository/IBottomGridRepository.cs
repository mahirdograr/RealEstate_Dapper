﻿using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();

        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);

        void DeleteBottomGrid(int id);

        void UpdateBottomGridDetail(UpdateBottomGridDto updateBottomGridDto);

        Task<List<GetBottomGridDto>> GetBottomGrid(int id);
    }
}