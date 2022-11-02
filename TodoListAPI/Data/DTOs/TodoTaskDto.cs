namespace TodoListAPI.Data.DTOs
{
    public class TodoTaskDto
    {
        public Guid id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsExpired { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
