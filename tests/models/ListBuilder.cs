using System.Collections.Generic;
using TodoLists.Models;

namespace Tests
{
    public class ListBuilder
    {
        public ListBuilder()
        {
            this.Name = "ListName";
            this.Description = "ListDescription";
            this.Tasks = new List<Todo>();
            this.OwnerId = 1;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public int OwnerId { get; set; }

        public List<Todo> Tasks { get; set; }

        public ListBuilder WithName(string name)
        {
            this.Name = name;
            return this;
        }

        public ListBuilder WithDescription(string decription)
        {
            this.Description = Description;
            return this;
        }

        public ListBuilder WithTask(Todo task) 
        {
            this.Tasks.Add(task);
            return this;
        }

        public ListBuilder WithOwnerId(int ownerId) 
        {
            this.OwnerId = ownerId;
            return this;
        }

        public TodoList Build()
        {
            return new TodoList(this.Name, this.Description, this.OwnerId, this.Tasks);
        }
    }
}