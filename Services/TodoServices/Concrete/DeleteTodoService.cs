using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Backend.Data;
using Backend.Data.Models;

namespace Backend.Services.TodoServices.Concrete
{
    public class DeleteTodoService
    {
        private readonly BackendDbContext _context;

        public DeleteTodoService(BackendDbContext context)
        {
            _context = context;
        }

        public void DeleteTodo()
        {
            var todo = _context.Todos.First();
            _context.Remove(todo);
            _context.SaveChanges();
        }
    }
}
