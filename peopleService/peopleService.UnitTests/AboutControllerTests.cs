namespace peopleService.UnitTests
{
   #region using

   using Microsoft.VisualStudio.TestTools.UnitTesting;

   using peopleService.Controllers;

   #endregion

   [TestClass]
   public class AboutControllerTests
   {
      #region Public Methods and Operators

      [TestMethod]
      public void Unit_AboutController_Get()
      {
         // Arrange
         var target = new AboutController();

         // Act
         var actual = target.Get();

         // Assert
         Assert.AreEqual("Fabrikam Fiber (c) 2014.", actual);
         //Assert.AreEqual("Your application description page.", actual);
      }

      #endregion
   }
}