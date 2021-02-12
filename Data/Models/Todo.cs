using System;
using System.Collections.Generic;

namespace Backend.Data.Models
{
    public class Todo
    {
        public int TodoId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool IsComplete { get; set; }

        //Relationships
        public ICollection<TodoList> UserLink { get; set; }
    }
}
