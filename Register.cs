using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelenium
{
    internal class Register
    {

        private IWebDriver driver;

        public Register()
        {
        }

        public Register(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }
        public static void RegisterUser(WebDriver driver) 
        {
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("REGISTER")).Click();

        }
    }
}
