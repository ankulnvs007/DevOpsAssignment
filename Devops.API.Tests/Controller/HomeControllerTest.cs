using Devops.API.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace Devops.API.Tests.Controller
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        [Fact]
        public void HomeController_Get_Validate_SmallerNumber_Result()
        {
            //AAA
            //Arrange
            HomeController controller = new HomeController();
            int GuessNumber = 90;
            string ExpectredResult = "Wrong ! Try a larger number.";

            //Act
            string result = controller.Get(GuessNumber);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ExpectredResult, result);
        }
        [TestMethod]
        [Fact]
        public void HomeController_Get_Validate_LargerNumber_Result()
        {
            //AAA
            //Arrange
            HomeController controller = new HomeController();
            int GuessNumber = 120;
            string ExpectredResult = "Wrong ! Try a smaller number.";

            //Act
            string result = controller.Get(GuessNumber);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ExpectredResult, result);
        }
        [TestMethod]
        [Fact]
        public void HomeController_Get_Validate_CorrectNumber_Result()
        {
            //AAA
            //Arrange
            HomeController controller = new HomeController();
            int GuessNumber = 100;
            string ExpectredResult = "You guessed correct number.";

            //Act
            string result=controller.Get(GuessNumber);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(ExpectredResult, result);
        }
    }
}
