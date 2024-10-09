

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace SeleniumWebDriverTestMyPortfolioWeb.Pages
{
    public class BasePage
    {

        protected IWebDriver driver;
        protected WebDriverWait wait;


        // 1.constructor - initialize the WebDriver and explicit wait mechanism 
        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver ,TimeSpan.FromSeconds(10));
        }

        //2 Find any single web element 
        protected IWebElement FindElement(By by)   
        {

            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        
        }
        //3.Find all web elements
        protected IReadOnlyCollection<IWebElement> FindElements(By by)
        { 
          return driver.FindElements(by);
        }
        //4.Clicking element
        protected void Click(By by) 
        {
          FindElement(by).Click();  
        
        }
        //5.Typing into input field
        protected void Type(By by , string text) 
        {
          var element = FindElement(by);
          element.Clear();
          element.SendKeys(text);
        }
        //6.Get Textfrom elements
        protected string GetText(By by) 
        {
          var element = FindElement(by);
          return element.Text;
          
        }   
         
         






    }
}
