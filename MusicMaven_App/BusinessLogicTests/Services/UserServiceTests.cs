﻿using System;
using Business_Logic.Factories;
using Business_Logic.FakeRepositories;
using Business_Logic.Interfaces;
using Business_Logic.Models.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Business_Logic.Exceptions;

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

    private string GenerateRandomUsername()

    private USER_TYPE GenerateRandomUserType()

    private User GenerateRandomUser()


    [TestMethod]
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

    [TestMethod]
    {

        // Act  
        var result = userService.GetUserById(id);

        // Assert
        Assert.IsNull(result);
    }
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
    public void CreateUserTest()
        User user = GenerateRandomUser();
        // Act
        userService.CreateUser(user);

        // Assert
        User? createdUser = userRepository.GetUserByEmail(user.Email);
        Assert.IsNotNull(createdUser);
        Assert.AreEqual(user.Username, createdUser.Username);
        Assert.AreEqual(user.Password, createdUser.Password);
    }

    [TestMethod]
    public void CreateUserWithExistingEmailTest()
        User user = GenerateRandomUser();
        // Act
        userService.CreateUser(user);
        user.Username = "newUsername";
        // Assert
        Assert.ThrowsException<ArgumentException>(() =>
    }

    [TestMethod]
    public void CreateUserWithExistingUsernameTest()
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
    public void CreateUserWithEmptyEmailTest()
        User user = GenerateRandomUser();
        

        // Act & Assert
        Assert.ThrowsException<ArgumentException>(() => {
            user.Email = "";
            });
    }

    [TestMethod]
    public void CreateUserWithEmptyUsernameTest()
            });
    }

    [TestMethod]
    public void CreateUserWithEmptyPasswordTest()
            });
    }

    [TestMethod]
    public void CreateUserWithInvalidEmailTest()
            });
    }

    [TestMethod]
    public void GetUserByEmailWithValidEmailTest()
    }

    [TestMethod]
    public void GetUserByEmailWithNonExistentEmail()
    }
    
    [TestMethod]

    [TestMethod]

    [TestMethod]

}