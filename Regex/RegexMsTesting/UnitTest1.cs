using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexPattern;

namespace UnitTest1
{
    [TestClass]
    public class Tests
    {
        Program program;
        UserRegistration userRegistration;
        string Result;
        [TestMethod]
        public void Setup()
        {
            userRegistration = new UserRegistration();
            program = new Program();
        }

        [TestMethod]
        public void Given_FirstName_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validFirstName("Satish");
            Assert.AreEqual("First Name is valid", Result);
        }
        [TestMethod]
        public void Given_LaststName_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validLastName("kamble");
            Assert.AreEqual("Last Name is valid", Result);
        }
        [TestMethod]
        public void Given_EmailId_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validEmail("kundan@bl.co.in");
            Assert.AreEqual("EmailId is valid", Result);
        }
        [TestMethod]
        public void Given_MobileNo_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validMobileNo("91 9876543210");
            Assert.AreEqual("MobileNo is valid", Result);
        }
        [TestMethod]
        public void Given_Password_When_valid_ShouldReturn_Valid()
        {
            Result = userRegistration.validPassword("AsdFg123");
            Assert.AreEqual("Password is valid", Result);
        }
      
        public void Given_Email_When_valid_ShouldReturn_Valid(string email)
        {
            Result = userRegistration.validCheckEmailSample(email);
            Assert.AreEqual("Email is valid", Result);
        }
    }
}

