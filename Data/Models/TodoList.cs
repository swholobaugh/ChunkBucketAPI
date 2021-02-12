
namespace Backend.Data.Models
{
    public class TodoList
    {
        //Many-to-Many linking Todos and Users tables
        public int TodoId { get; set; }
        public int UserId { get; set; }

        //Relationships
        public Todo Todo { get; set; }
        public User User { get; set; }
    }
}
