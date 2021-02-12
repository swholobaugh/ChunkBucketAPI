using System;
using System.Collections.Generic;
using System.Linq;
using Backend.Data;
using Backend.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services.TodoServices.Concrete
{
    public class AddTodoService
    {
        private readonly BackendDbContext _context;

        public AddTodoService(BackendDbContext context)
        {
            _context = context;
        }

        public void CreateTodo()
        {
            var todo = new Todo
            {
                Title = "A New Todo",
                Content = "Some new things to do",
                PublishedOn = DateTime.Today,
                IsComplete = false
            };

            _context.Add(todo);
            _context.SaveChanges();
        }

    }
}
