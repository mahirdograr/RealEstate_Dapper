﻿namespace RealEstate_Dapper_UI.Dtos.TodoListDtos
{
    public class UpdateToDoListDto
    {
        public int ToDoListID { get; set; }
        public string Description { get; set; }
        public bool ToDoListStatus { get; set; }
    }
}
