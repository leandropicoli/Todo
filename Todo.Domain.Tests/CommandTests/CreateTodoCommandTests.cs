using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Tests.CommandTests
{
    [TestClass]
    public class CreateTodoCommandTests
    {
        [TestMethod]
        public void GivenAnInvalidCommand()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            command.Validate();

            Assert.IsTrue(command.Invalid);
        }

        [TestMethod]
        public void GivenAValidcommand()
        {
            var command = new CreateTodoCommand("Study CSharp", "leandropicoli", DateTime.Now.AddDays(2));
            command.Validate();

            Assert.IsTrue(command.Valid);
        }
    }
}