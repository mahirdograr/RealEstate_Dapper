﻿using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<List<ResultCategoryDto>> GetAllCategoryAsync();

        void CreateCategory(CreateCategoryDto createCategoryDto);

        void DeleteCategory(int id);

        void UpdateCategory(UpdateCategoryDto updateCategoryDto);

        Task<List<GetByIdCategoryDto>> GetCategory(int id);
    }
}
