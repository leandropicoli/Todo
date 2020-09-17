using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        [TestMethod]
        public void GivenANewTodo_ShouldBeDoneEqualsFalse()
        {
            var todo = new TodoItem("Some title", "leandropicoli", DateTime.Now);

            Assert.IsFalse(todo.Done);
        }
    }
}