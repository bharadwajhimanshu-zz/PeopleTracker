namespace peopleService.CodedUITests
{
   #region using

   using Microsoft.VisualStudio.TestTools.UnitTesting;

   using OpenQA.Selenium;
   using OpenQA.Selenium.Chrome;

   #endregion

   /// <summary>
   /// Summary description for CodedUITest1
   /// </summary>
   [TestClass]
   public class SeleniumPeopleTrackerTests
   {
      #region Fields

      private string baseURL;

      #endregion

      #region Constructors and Destructors

      public SeleniumPeopleTrackerTests()
      {
      }

      #endregion

      #region Public Properties

      /// <summary>
      ///Gets or sets the test context which provides
      ///information about and functionality for the current test run.
      ///</summary>
      public TestContext TestContext { get; set; }

      #endregion

      #region Public Methods and Operators

      [TestMethod]
      public void Selenium_AboutPage()
      {
         using (var driver = new ChromeDriver())
         {
            driver.Navigate().GoToUrl(this.baseURL);
            driver.FindElement(By.LinkText("About")).Click();
            var actual = driver.FindElement(By.CssSelector("P")).Text.Trim();

            Assert.AreEqual("Fabrikam Fiber (c) 2014.", actual);
         }
      }

      // You can use the following additional attributes as you write your tests:

      ////Use TestInitialize to run code before running each test 
      [TestInitialize()]
      public void MyTestInitialize()
      {
         // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
         if (this.TestContext.Properties["webAppUrl"] != null)
         {
            this.baseURL = this.TestContext.Properties["webAppUrl"].ToString();
         }
         else
         {
            this.baseURL = "http://dlbdemodev.cloudapp.net/peopleTracker/";
         }
      }

      #endregion
   }
}