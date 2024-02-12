namespace Test;

[TestClass]
public class UnitTestPrincipal
{
    ValidationProvider validationService = new();

    #region EndWithUnderScore Tests
    [TestMethod]
    public void Test_EndWithUnderScore1()
    {
        string value = "hello_";
        bool expectedResult = true;
        bool actualResult = validationService.endWithUnderScore(value);
        Assert.AreEqual(expectedResult, actualResult);
    }
    [TestMethod]
    public void Test_EndWithUnderScore2()
    {
        string value = "world";
        bool expectedResult = false;
        bool actualResult = validationService.endWithUnderScore(value);
        Assert.AreEqual(expectedResult, actualResult);

    }
    [TestMethod]
    public void Test_EndWithUnderScore3()
    {
        string value = "abc_123";
        bool expectedResult = true;
        bool actualResult = validationService.endWithUnderScore(value);
        Assert.AreEqual(expectedResult, actualResult);
    }

    #endregion

    #region StarWithLetter Tests

    [TestMethod]
    public void Test_StartWithLetter1_ReturnTrue()
    {
        // Arrange
        string value = "Hello";

        // Act
        bool result = validationService.startWithLetter(value);

        // Assert
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void Test_StartWithLetter2_ReturnsFalse()
    {
        // Arrange
        string value = "123abc";

        // Act
        bool result = validationService.startWithLetter(value);

        // Assert
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void Test_StartWithLetter3_ReturnFalse()
    {
        // Arrange
        string value = " ";

        // Act
        bool result = validationService.startWithLetter(value);

        // Assert
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void Test_StartWithLetter4_ReturnFalse()
    {
        // Arrange
        string value = "_null";

        // Act
        bool result = validationService.startWithLetter(value);

        // Assert
        Assert.IsFalse(result);
    }

    #endregion

    #region UserNameRange Tests
    [TestMethod]
    public void Test_UserNameRange1_True()
    {
        string username = "john_doe";
        bool result = validationService.userNameRange(username);
        Assert.IsTrue(result);

    }
    [TestMethod]
    public void Test_UserNameRange2_True()
    {
        string username = "abcd";
        bool result = validationService.userNameRange(username);
        Assert.IsTrue(result);

    }
    [TestMethod]
    public void Test_UserNameRange3_True()
    {
        string username = "abcdefghijklmnopqrstuvwxyz";
        bool result = validationService.userNameRange(username);
        Assert.IsTrue(!result);
    }
    [TestMethod]
    public void Test_UserNameRange4_False()
    {
        string username = "abc";
        bool result = validationService.userNameRange(username);
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void Test_UserNameRange5_False()
    {
        string username = "abcdefghijklmnopqrstuvwxyz123456";
        bool result = validationService.userNameRange(username);
        Assert.IsFalse(result);

    }
    #endregion



}