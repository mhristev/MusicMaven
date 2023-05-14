using System;
using Business_Logic.Factories;
using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;using Business_Logic.Models;
using Business_Logic.Models.Enums;using Business_Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Logic.Exceptions;using System.Collections.Generic;using Business_Logic;namespace BusinessLogicTests;

[TestClass]
public class UserServiceTests
{
    private FakeUserRepository _fakeUserRepository;
    private UserService _userService;

    [TestInitialize]
    public void TestInitialize()
    {
        _fakeUserRepository = new FakeUserRepository();
        _userService = new UserService(_fakeUserRepository);
    }

    [TestMethod]    public void GetUserByIdTest()
    {
        // Arrange        string id = Guid.NewGuid().ToString();        string expectedUsername = "testUser";        string expectedEmail = "testEmail@email.com";        string expectedPassword = "password";        USER_TYPE expectedType = USER_TYPE.NORMAL;
        User expectedUser = new User(id, expectedUsername, expectedEmail, expectedPassword, new List<User>(), new List<User>(), expectedType, "image");

        _fakeUserRepository.Insert(expectedUser);

        // Act  
        var result = _userService.GetUserById(id);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]    public void GetUserByIdWithNonExistentIdTest()
    {        // Arrange        string id = Guid.NewGuid().ToString();

        // Act  
        var result = _userService.GetUserById(id);

        // Assert
        Assert.IsNull(result);
    }    [TestMethod]
    public void GetUserByIdWithNullAsIdTest()
    {
        // Arrange
        string? userId = null;

        // Act
        var result = _userService.GetUserById(userId);

        // Assert
        Assert.IsNull(result);
    }


    [TestMethod]
    public void CreateUserTest()    {        // Arrange        string email = "test@test.com";
        string username = "user";
        string password = "password";
        string image = "img";
        User user = UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL);
        // Act
        _userService.CreateUser(user);

        // Assert
        var createdUser = _fakeUserRepository.GetUserByEmail(email);
        Assert.IsNotNull(createdUser);
        Assert.AreEqual(username, createdUser.Username);
        Assert.IsTrue(BCrypt.Net.BCrypt.Verify(password, createdUser.Password));        Assert.AreEqual(USER_TYPE.NORMAL, createdUser.Type);
    }

    [TestMethod]
    public void CreateUserWithExistingEmailTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "password";
        string image = "img";
        User user = UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL);
        // Act
        _userService.CreateUser(user);
        user.Username = "newUsername";
        // Assert
        Assert.ThrowsException<EmailExistException>(() =>            _userService.CreateUser(user)) ;
    }

    [TestMethod]
    public void CreateUserWithExistingUsernameTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "password";        string image = "img";
        User user = UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL);

        // Act
        _userService.CreateUser(user);
        User user2 = UserFactory.CreateUser(username, "emailNew12@email.com", password, image, USER_TYPE.NORMAL);

        // Assert
        Assert.ThrowsException<UsernameExistException>(() => 
            _userService.CreateUser(user2));
    }

    [TestMethod]
        public void CreateUserWithEmptyEmailTest()        {            // Arrange            string email = "";
            string username = "testUser";
            string password = "password";            string image = "img";
            // Act & Assert
            var exception = Assert.ThrowsException<ArgumentException>(() =>
                UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL));
        }

    [TestMethod]
    public void CreateUserWithEmptyUsernameTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "";
        string password = "password";        string image = "img";        // Act & Assert        Assert.ThrowsException<ArgumentException>(() =>                UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL));
    }

    [TestMethod]
    public void CreateUserWithEmptyPasswordTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "";        string image = "img";        // Act & Assert        Assert.ThrowsException<ArgumentException>(() =>              UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL));
    }

    [TestMethod]
    public void CreateUserWithInvalidEmailTest()    {        // Arrange        string email = "asd";
        string username = "testUser";
        string password = "password";        string image = "img";        // Act & Assert        Assert.ThrowsException<ArgumentException>(() =>             UserFactory.CreateUser(username, email, password, image, USER_TYPE.NORMAL));
    }

    [TestMethod]
    public void GetUserByEmailWithValidEmailTest()    {        // Arrange        string id = Guid.NewGuid().ToString();        string email = "test@test.com";        string username = "user";        string password = "password";        string image = "image";        USER_TYPE userType = USER_TYPE.NORMAL;        User expectedUser = new User(id, username, email, password, new List<User>(), new List<User>(), userType, image);        _fakeUserRepository.Insert(expectedUser);        // Act        User? result = _userService.GetUserByEmail(email);        // Assert        Assert.IsNotNull(result);        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]
    public void GetUserByEmailWithNonExistentEmail()    {        // Arrange        string email = "nonexistent@test.com";        // Act        User? result = _userService.GetUserByEmail(email);        // Assert        Assert.IsNull(result);
    }
    
    [TestMethod]    public void GetUserByEmailWithNullEmailTest()    {        // Arrange        string? email = null;        // Act & Assert        Assert.ThrowsException<EmptyEmailException>(() =>            _userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithEmptyStringEmailTest()    {        // Arrange        string email = "";        // Act & Assert        Assert.ThrowsException<EmptyEmailException>(() =>            _userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithInvalidEmailTest()    {        // Arrange        string email = "invalidEmail";        // Act & Assert        Assert.ThrowsException<InvalidEmailException>(() =>            _userService.GetUserByEmail(email));    }

}
