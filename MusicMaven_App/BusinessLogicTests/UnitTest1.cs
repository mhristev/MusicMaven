using Business_Logic.Models;
using Business_Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BusinessLogicTests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        UserService userService = UserService.Instance;
        User? user = userService.GetUserById("1");
        Assert.AreEqual(user, null); 
    }
}
