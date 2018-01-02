
using System;
using System.Collections.Generic;

namespace TodoLists.Models 
{
    public class List 
    {
        public List(string name, string description, int owner, List<Task> tasks)
        {
            if (tasks == null)
            {
                this.Tasks = new List<Task>();
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

        public List<Task> Tasks { get; private set; }

        public void AddTask(Task task)
        {
            if (task == null) 
                throw new ArgumentNullException(nameof(task));

            this.Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            this.Tasks.Remove(task);
        }
    }
}