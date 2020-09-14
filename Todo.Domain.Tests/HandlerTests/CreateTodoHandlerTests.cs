using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Tests.Repositories;

namespace Todo.Domain.Tests.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTests
    {
        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());

        [TestMethod]
        public void GivenAnInvalidCommand_ShouldNotCreateTodo()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var result = (GenericCommandResult)_handler.Handle(command);

            Assert.IsFalse(result.Success);
        }

        [TestMethod]
        public void GivenAValidCommand_ShouldCreateTodo()
        {
            var command = new CreateTodoCommand("Study CSharp", "leandropicoli", DateTime.Now.AddDays(2));
            var result = (GenericCommandResult)_handler.Handle(command);

            Assert.IsTrue(result.Success);
        }

    }
}