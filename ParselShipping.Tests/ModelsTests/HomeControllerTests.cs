using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ParselShipping.Controllers;
using ParselShipping.Models;

namespace ParselShipping.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          //Arrange
          HomeController controller = new HomeController();

          //Act
          ActionResult createParselView = controller.CreateParsel();

          //Assert
          Assert.IsInstanceOfType(createParselView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectModelTypeCorrectInput_Parsel()
      {
        //Arrange
        HomeController controller = new HomeController();
        ViewResult indexView = controller.Index(1,1,1,1) as ViewResult;

        //Act
        var result = indexView.ViewData.Model;

        //Assert
        Assert.IsInstanceOfType(result, typeof(Parsel));
      }

      [TestMethod]
      public void Index_HasCorrectModelTypeEmptyInput_Parsel()
      {
        //Arrange
        HomeController controller = new HomeController();
        ViewResult indexView = controller.Index(1,1,null,1) as ViewResult;

        ViewResult createParselView = controller.CreateParsel() as ViewResult;

        //Assert
        Assert.AreEqual(createParselView.ViewName, indexView.ViewName);
        // //Act
        // var result = indexView.ViewData.Model;
        //
        // //Assert
        // Assert.IsInstanceOfType(result, null);
      }
    }
}
