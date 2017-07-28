using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextMatch.Controllers;
using System.Web.Mvc;

namespace TextMatch.Tests.Controllers
{

    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Text Match", result.ViewBag.Title);
        }
    }
}
