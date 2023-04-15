using System;
using Business_Logic.Factories;
using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;using Business_Logic.Models;
using Business_Logic.Models.Enums;using Business_Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Logic.Exceptions;using System.Collections.Generic;namespace BusinessLogicTests;

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
        User expectedUser = new User(id, expectedUsername, expectedEmail, expectedPassword, new List<User>(), expectedType);

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

        // Act
        _userService.CreateUser(email, username, password);

        // Assert
        var createdUser = _fakeUserRepository.GetUserByEmail(email);
        Assert.IsNotNull(createdUser);
        Assert.AreEqual(username, createdUser.Username);
        Assert.AreEqual(password, createdUser.Password);        Assert.AreEqual(USER_TYPE.NORMAL, createdUser.Type);
    }

    [TestMethod]
    public void CreateUserWithExistingEmailTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "password";

        // Act
        _userService.CreateUser(email, username, password);

        // Assert
        Assert.ThrowsException<EmailExistException>(() =>            _userService.CreateUser(email, "newUsername", password));
    }

    [TestMethod]
    public void CreateUserWithExistingUsernameTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "password";

        // Act
        _userService.CreateUser(email, username, password);

        // Assert
        Assert.ThrowsException<UsernameExistException>(() => 
            _userService.CreateUser("newMail@email.com", username, password));
    }

    [TestMethod]
    public void CreateUserWithEmptyEmailTest()    {        // Arrange        string email = "";
        string username = "testUser";
        string password = "password";

        // Act & Assert
        Assert.ThrowsException<EmptyEmailException>(() =>            _userService.CreateUser(email, username, password));
    }

    [TestMethod]
    public void CreateUserWithEmptyUsernameTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "";
        string password = "password";
        // Act & Assert        Assert.ThrowsException<EmptyUsernameException>(() =>                _userService.CreateUser(email, username, password));
    }

    [TestMethod]
    public void CreateUserWithEmptyPasswordTest()    {        // Arrange        string email = "testEmail@email.com";
        string username = "testUser";
        string password = "";
        // Act & Assert        Assert.ThrowsException<EmptyPasswordException>(() =>              _userService.CreateUser(email, username, password));
    }

    [TestMethod]
    public void CreateUserWithInvalidEmailTest()    {        // Arrange        string email = "asd";
        string username = "testUser";
        string password = "password";
        // Act & Assert        Assert.ThrowsException<InvalidEmailException>(() =>             _userService.CreateUser(email, username, password));
    }

    [TestMethod]
    public void GetUserByEmailWithValidEmailTest()    {        // Arrange        string id = Guid.NewGuid().ToString();        string email = "test@test.com";        string username = "user";        string password = "password";        USER_TYPE userType = USER_TYPE.NORMAL;        User expectedUser = new User(id, username, email, password, new List<User>(), userType);        _fakeUserRepository.Insert(expectedUser);        // Act        User? result = _userService.GetUserByEmail(email);        // Assert        Assert.IsNotNull(result);        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]
    public void GetUserByEmailWithNonExistentEmail()    {        // Arrange        string email = "nonexistent@test.com";        // Act        User? result = _userService.GetUserByEmail(email);        // Assert        Assert.IsNull(result);
    }
    
    [TestMethod]    public void GetUserByEmailWithNullEmailTest()    {        // Arrange        string? email = null;        // Act & Assert        Assert.ThrowsException<EmptyEmailException>(() =>            _userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithEmptyStringEmailTest()    {        // Arrange        string email = "";        // Act & Assert        Assert.ThrowsException<EmptyEmailException>(() =>            _userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithInvalidEmailTest()    {        // Arrange        string email = "invalidEmail";        // Act & Assert        Assert.ThrowsException<InvalidEmailException>(() =>            _userService.GetUserByEmail(email));    }

}
