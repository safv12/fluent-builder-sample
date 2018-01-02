using TodoLists.Models;
using Xunit;
using System.Linq;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class ListSpecs
    {
        [Fact]
        public void Should_AddTask_When_AddTaskMethodCalled()
        {
            // Arrange
            var taskToAdd = new Task("SomeTask", false);

            var builder = new ListBuilder();
            var list = builder
                .WithName("MyOwnList")
                .Build();

            // Act
            list.AddTask(taskToAdd);

            // Assert
            Assert.Equal(1, list.Tasks.Count);
            Assert.Equal("MyOwnList", list.Name);
            Assert.Equal("SomeTask", list.Tasks.First().Description);
        }

        [Fact]
        public void Should_Throws_When_AddTaskWithNullParameter()
        {
            // Arrange
            var builder = new ListBuilder();
            var list = builder.Build();

            // Act
            Assert.Throws<ArgumentNullException>(() => list.AddTask(null));
        }

        [Fact]
        public void Should_RemoveTask_When_RemoveTaskMethodCalled()
        {
            // Arrange
            var task = new Task("TodoTask", false);
            
            var builder = new ListBuilder();
            var list = builder
                .WithTask(task)
                .Build();

            // Act
            Assert.NotEmpty(list.Tasks);
            list.RemoveTask(task);

            // Assert
            Assert.Empty(list.Tasks);
        }

        [Fact]
        public void Should_Throws_When_TryToDeleteWithNullParameter()
        {
            // Arrange
            var builder = new ListBuilder();
            var list = builder.Build();
            
            // Act
            Assert.Throws<ArgumentNullException>(() => list.RemoveTask(null));
        }

        public void Should_InitializeCustomList_With_ListBuilder()
        {
            // Arrange
            var builder = new ListBuilder();

            // Act
            var list = builder
                .WithName("CustomName")
                .WithDescription("CustomDescription")
                .WithOwnerId(7)
                .WithTask(new Task("CustomTask1", false))
                .WithTask(new Task("CustomTask2", false))
                .Build();

            // Assert
            Assert.Equal("CustomName", list.Name);
            Assert.Equal("CustomDescription", list.Description);
            Assert.Equal(7, list.OwnerId);
            Assert.Equal(2, list.Tasks.Count);
        }
    }    
}