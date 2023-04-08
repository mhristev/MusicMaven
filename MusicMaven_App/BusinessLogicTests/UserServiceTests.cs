using Business_Logic.FakeRepositories;
using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTests;

[TestClass]
public class UserServiceTests
{
    private readonly FakeUserRepository _fakeUserRepository;
    private readonly UserService _userService;

    public UserServiceTests()
    {
        _fakeUserRepository = new FakeUserRepository();
        _userService = new UserService(_fakeUserRepository);
    }

    [TestMethod]    public void GetUserByIdTest()
    {
        // Arrange
        string userId = "1";
        var expectedUser = _fakeUserRepository.GetById(userId);

        // Act
        var result = _userService.GetUserById(userId);

        // Assert
        Assert.AreEqual(expectedUser, result);
    }

    [TestMethod]
    public void CreateUserTest()    {        // Arrange        string email = "test@test.com";
        string username = "testuser";
        string password = "password";

        // Act
        _userService.CreateUser(email, username, password);

        // Assert
        var createdUser = _fakeUserRepository.GetUserByEmail(email);
        Assert.IsNotNull(createdUser);
        Assert.AreEqual(username, createdUser.Username);
        Assert.AreEqual(password, createdUser.Password);
    }
}
