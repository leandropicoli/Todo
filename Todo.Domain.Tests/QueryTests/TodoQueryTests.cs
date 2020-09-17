using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Task 1", "user1", DateTime.Now));
            _items.Add(new TodoItem("Task 2", "user2", DateTime.Now));
            _items.Add(new TodoItem("Task 3", "user1", DateTime.Now));
            _items.Add(new TodoItem("Task 4", "user1", DateTime.Now));
        }

        [TestMethod]
        public void GivenAQuery_ShouldReturnOnlyTasksFromUser()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("user1"));
            Assert.AreEqual(3, result.Count());
        }

        //TODO: Create all tests
    }
}