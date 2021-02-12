using System.Collections.Generic;

namespace Backend.Data.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        
        //Relationships
        public ICollection<Todo> TodoList { get; set; }

    }
}
