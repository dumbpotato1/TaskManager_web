using TaskManager.Core.Entities;
using TaskManager.Core.Interfaces;
using TaskManager.Infrastructure.Persistance;

namespace TaskManager.Infrastructure.Prepositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly AppDbContext _context; 
        public TaskRepository(AppDbContext context)
        {
            _context = context;
        }   
        public IEnumerable<TaskItem> GetAll() => _context.Tasks.ToList();
        public TaskItem GetById(int id) => _context.Tasks.Find(id)!;
        public void Add(TaskItem task) =>  _context.Tasks.Add(task);
        public void Update(TaskItem task) =>  _context.Tasks.Update(task);  
        public void Delete(int id)
        {
            var t = _context.Tasks.Find(id);
            if(t != null)
            {
                _context.Tasks.Remove(t);
            }   
        }
        public void Save() =>  _context.SaveChanges();  
        public void Delete(TaskItem task)
        {
            throw new NotImplementedException();
        }
        public void Save(TaskItem task)
        {
            throw new NotImplementedException();
        }
    }
}
