namespace TaskManager.Core.Entities
{
    public class TaskItem
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public bool IsDone { get; private set; }
        public TaskItem(string title, string? description = null)
        {
            Title = title;
            Description = description;
            IsDone = false;
        }
        public void MarkDone()
        {
            IsDone = true;
        }
        public void Reopen()
        {
            IsDone = false;
        }
    }
}
