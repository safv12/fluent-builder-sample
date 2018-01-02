namespace TodoLists.Models
{
    public class Todo
    {
        public Todo(string description, bool isCompleted)
        {
            this.Description = description;
            this.IsCompleted = isCompleted;
        }
        public string Description { get; private set; }

        public bool IsCompleted { get; private set; }
    }
}