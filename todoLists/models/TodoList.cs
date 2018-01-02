
using System;
using System.Collections.Generic;

namespace TodoLists.Models 
{
    public class TodoList 
    {
        public TodoList(string name, string description, int owner, List<Todo> tasks)
        {
            if (tasks == null)
            {
                this.Tasks = new List<Todo>();
            }
            else 
            {
                this.Tasks = tasks;
            }

            this.Name = name;
            this.Description = description;
            this.OwnerId = owner;
            
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public int OwnerId { get; private set; }

        public List<Todo> Tasks { get; private set; }

        public void AddTask(Todo task)
        {
            if (task == null) 
                throw new ArgumentNullException(nameof(task));

            this.Tasks.Add(task);
        }

        public void RemoveTask(Todo task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            this.Tasks.Remove(task);
        }
    }
}