using RealEstate_Dapper_Api.Dtos.TodoListDtos;

namespace RealEstate_Dapper_Api.Repositories.TodoListRespository
{
    public interface ITodoListRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto ToDoListDto);
        void DeleteToDoList(int id);
        void UpdateToDoList(UpdateToDoListDto ToDoListDto);
        Task<GetByIDToDoListDto> GetToDoList(int id);
    }
}
