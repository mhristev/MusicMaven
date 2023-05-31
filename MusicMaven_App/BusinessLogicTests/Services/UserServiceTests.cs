using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;using Business_Logic.Models;
using Business_Logic.Models.Enums;using Business_Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;using System.Linq;namespace BusinessLogicTests;

[TestClass]
public class UserServiceTests
{
    private IUserRepository userRepository;
    private UserService userService;

    [TestInitialize]
    public void TestInitialize()
    {
        userRepository = new FakeUserRepository();
        userService = new UserService(userRepository);
    }

    private string GenerateRandomUsername()    {
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";        Random random = new Random();        string username = new string(Enumerable.Repeat(characters, 8)            .Select(s => s[random.Next(s.Length)]).ToArray());        return username;    }    private string GenerateRandomEmail()    {
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";        Random random = new Random();        string email = new string(Enumerable.Repeat(characters, 8)            .Select(s => s[random.Next(s.Length)]).ToArray()) + "@example.com";        return email;    }    private string GenerateRandomPassword()    {
        string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";        Random random = new Random();        string password = new string(Enumerable.Repeat(characters, 10)            .Select(s => s[random.Next(s.Length)]).ToArray());        return password;    }    private string GenerateRandomImage()    {
        string[] imageUrls = { "https://example.com/image1.jpg", "https://example.com/image2.jpg" };        Random random = new Random();        string image = imageUrls[random.Next(imageUrls.Length)];        return image;    }

    private USER_TYPE GenerateRandomUserType()    {
        Array values = Enum.GetValues(typeof(USER_TYPE));        Random random = new Random();        USER_TYPE userType = (USER_TYPE)values.GetValue(random.Next(values.Length));        return userType;    }

    private User GenerateRandomUser()    {        string id = Guid.NewGuid().ToString();        string username = GenerateRandomUsername();        string email = GenerateRandomEmail();        string password = BCrypt.Net.BCrypt.HashPassword(GenerateRandomPassword());        string image = GenerateRandomImage();        USER_TYPE userType = GenerateRandomUserType();        return new User(id, username, email, password, new List<User>(), new List<User>(), userType, image);    }


    [TestMethod]    public void GetUserByIdTest()
    {
        // Arrange
        User expectedUser = GenerateRandomUser();

        userRepository.Insert(expectedUser);

        // Act  
        var result = userService.GetUserById(expectedUser.Id);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]    public void GetUserByIdWithNonExistentIdTest()
    {
        // Arrange
        string id = Guid.NewGuid().ToString();

        // Act  
        var result = userService.GetUserById(id);

        // Assert
        Assert.IsNull(result);
    }    [TestMethod]
    public void GetUserByIdWithNullAsIdTest()
    {
        // Arrange
        string? userId = null;

        // Act
        var result = userService.GetUserById(userId);

        // Assert
        Assert.IsNull(result);
    }


    [TestMethod]
    public void CreateUserTest()    {        // Arrange
        User user = GenerateRandomUser();
        // Act
        userService.CreateUser(user);

        // Assert
        User? createdUser = userRepository.GetUserByEmail(user.Email);
        Assert.IsNotNull(createdUser);
        Assert.AreEqual(user.Username, createdUser.Username);
        Assert.AreEqual(user.Password, createdUser.Password);        Assert.AreEqual(user.Type, createdUser.Type);
    }

    [TestMethod]
    public void CreateUserWithExistingEmailTest()    {        // Arrange
        User user = GenerateRandomUser();
        // Act
        userService.CreateUser(user);
        user.Username = "newUsername";
        // Assert
        Assert.ThrowsException<ArgumentException>(() =>            userService.CreateUser(user));
    }

    [TestMethod]
    public void CreateUserWithExistingUsernameTest()    {        // Arrange
        User user = GenerateRandomUser();

        // Act
        userService.CreateUser(user);
        User user2 = GenerateRandomUser();
        user2.Email = user.Email;

        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
            userService.CreateUser(user2));
    }

    [TestMethod]
    public void CreateUserWithEmptyEmailTest()    {        // Arrange
        User user = GenerateRandomUser();


        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            user.Email = "";            userService.CreateUser(user);
        });
    }

    [TestMethod]
    public void CreateUserWithEmptyUsernameTest()    {
        // Arrange
        User user = GenerateRandomUser();

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            user.Username = "";
            userService.CreateUser(user);
        });
    }

    [TestMethod]
    public void CreateUserWithEmptyPasswordTest()    {
        // Arrange
        User user = GenerateRandomUser();

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            user.Password = "";
            userService.CreateUser(user);
        });
    }

    [TestMethod]
    public void CreateUserWithInvalidEmailTest()    {
        // Arrange
        User user = GenerateRandomUser();
        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
        {
            user.Email = Guid.NewGuid().ToString();
            userService.CreateUser(user);
        });
    }

    [TestMethod]
    public void GetUserByEmailWithValidEmailTest()    {
        // Arrange
        User expectedUser = GenerateRandomUser();        userRepository.Insert(expectedUser);

        // Act
        User? result = userService.GetUserByEmail(expectedUser.Email);

        // Assert
        Assert.IsNotNull(result);        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]
    public void GetUserByEmailWithNonExistentEmail()    {
        // Arrange
        string email = GenerateRandomEmail();

        // Act
        User? result = userService.GetUserByEmail(email);

        // Assert
        Assert.IsNull(result);
    }

    [TestMethod]    public void GetUserByEmailWithNullEmailTest()    {
        // Arrange
        string? email = null;

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithEmptyStringEmailTest()    {
        // Arrange
        string email = "";

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
userService.GetUserByEmail(email));    }

    [TestMethod]    public void GetUserByEmailWithInvalidEmailTest()    {
        // Arrange
        string email = Guid.NewGuid().ToString();

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() =>
userService.GetUserByEmail(email));    }

}
