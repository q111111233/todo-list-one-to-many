// using Xunit;
// using System.Collections.Generic;
// using System;
// using System.Data;
// using System.Data.SqlClient;
//
// namespace ToDoList
// {
//   public class CategoryTest : IDisposable
//   {
//     public CategoryTest()
//     {
//       DBConfiguration.ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=todo_test;Integrated Security=SSPI;";
//     }
//
//     [Fact]
//     public void Test_CategoriesEmptyAtFirst()
//     {
//       //Arrange, Act
//       int result = Category.GetAll().Count;
//
//       //Assert
//       Assert.Equal(0, result);
//     }
//
//     [Fact]
//     public void Test_Equal_ReturnsTrueForSameName()
//     {
//       //Arrange, Act
//       Category firstCategory = new Category("Household chores");
//       Category secondCategory = new Category("Household chores");
//
//       //Assert
//       Assert.Equal(firstCategory, secondCategory);
//     }
//
//     [Fact]
//     public void Test_Save_SavesCategoryToDatabase()
//     {
//       //Arrange
//       Category testCategory = new Category("Household chores");
//       testCategory.Save();
//
//       //Act
//       List<Category> result = Category.GetAll();
//       List<Category> testList = new List<Category>{testCategory};
//
//       //Assert
//       Assert.Equal(testList, result);
//     }
//
//     [Fact]
//     public void Test_Save_AssignsIdToCategoryObject()
//     {
//       //Arrange
//       Category testCategory = new Category("Household chores");
//       testCategory.Save();
//
//       //Act
//       Category savedCategory = Category.GetAll()[0];
//
//       int result = savedCategory.GetId();
//       int testId = testCategory.GetId();
//
//       //Assert
//       Assert.Equal(testId, result);
//     }
//
//     [Fact]
//     public void Test_Find_FindsCategoryInDatabase()
//     {
//       //Arrange
//       Category testCategory = new Category("Household chores");
//       testCategory.Save();
//
//       //Act
//       Category foundCategory = Category.Find(testCategory.GetId());
//
//       //Assert
//       Assert.Equal(testCategory, foundCategory);
//     }
//     [Fact]
//     public void Test_EqualOverrideTrueForSameDescription()
//     {
//       //Arrange, Act
//       Task firstTask = new Task("Mow the lawn", 1);
//       Task secondTask = new Task("Mow the lawn", 1);
//
//       //Assert
//       Assert.Equal(firstTask, secondTask);
//     }
//
//     [Fact]
//     public void Test_Save()
//     {
//       //Arrange
//       Task testTask = new Task("Mow the lawn", 1);
//       testTask.Save();
//
//       //Act
//       List<Task> result = Task.GetAll();
//       List<Task> testList = new List<Task>{testTask};
//
//       //Assert
//       Assert.Equal(testList, result);
//     }
//
//     [Fact]
//     public void Test_SaveAssignsIdToObject()
//     {
//       //Arrange
//       Task testTask = new Task("Mow the lawn", 1);
//       testTask.Save();
//
//       //Act
//       Task savedTask = Task.GetAll()[0];
//
//       int result = savedTask.GetId();
//       int testId = testTask.GetId();
//
//       //Assert
//       Assert.Equal(testId, result);
//     }
//
//     [Fact]
//     public void Test_FindFindsTaskInDatabase()
//     {
//       //Arrange
//       Task testTask = new Task("Mow the lawn", 1);
//       testTask.Save();
//
//       //Act
//       Task foundTask = Task.Find(testTask.GetId());
//
//       //Assert
//       Assert.Equal(testTask, foundTask);
//     }
//     [Fact]
//     public void Test_GetTasks_RetrievesAllTasksWithCategory()
//     {
//       Category testCategory = new Category("Household chores");
//       testCategory.Save();
//
//       Task firstTask = new Task("Mow the lawn", testCategory.GetId());
//       firstTask.Save();
//       Task secondTask = new Task("Do the dishes", testCategory.GetId());
//       secondTask.Save();
//
//
//       List<Task> testTaskList = new List<Task> {firstTask, secondTask};
//       List<Task> resultTaskList = testCategory.GetTasks();
//
//       Assert.Equal(testTaskList, resultTaskList);
//     }
//     public void Dispose()
//     {
//       Task.DeleteAll();
//       Category.DeleteAll();
//     }
//   }
// }
