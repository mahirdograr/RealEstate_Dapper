﻿namespace RealEstate_Dapper_Api.Dtos.TodoListDtos
{
    public class ResultToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStatus { get; set; }
    }
}