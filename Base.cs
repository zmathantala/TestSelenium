using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSelenium
{
    public class Base 
    {
        static IWebDriver driver = new ChromeDriver();


        
        public static void Main(string[] args)
        {

            //institiating the driver
            // maximase and open the browser
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.demo.guru99.com/test/newtours/");
           
            


            /*Thread.Sleep(2000);
            //driver.FindElement(By.LinkText("REGISTER")).Click();
            String PageTitle= driver.Title;
            Console.WriteLine(PageTitle);
            String expectedTitle = "Welcome: Mercury Tours";

            if (PageTitle.Contains(expectedTitle))
            {
                Console.WriteLine("Title is matching with expected value");
            }
            else
            {
                Console.WriteLine("Title is not matching with expected value");
            }


            */

            driver.Quit();

        }//end mian
        public void Register()
        {
            driver.FindElement(By.XPath("//input[@name='firstName']")).SendKeys("Zizipho");
            driver.FindElement(By.XPath("//input[@name='lastName']")).SendKeys("Zizipho");
            driver.FindElement(By.XPath("//input[@name='phone']")).SendKeys("0672995643");
            driver.FindElement(By.XPath("//input[@id='userName']")).SendKeys("Zizipho105!");

            driver.FindElement(By.XPath("//input[@name='address1']")).SendKeys("chesterville");
            driver.FindElement(By.XPath("//input[@name='city']")).SendKeys("Durban");
            driver.FindElement(By.XPath("//input[@name='state']")).SendKeys("KZN");
            driver.FindElement(By.XPath("//input[@name='postalCode']")).SendKeys("2345");

            // Create object of the Select class
            Select se = new Select(driver.findElement(By.xpath("//*[@id='oldSelectMenu']")));

            // Select the option by index
            se.selectByIndex(3);

            driver.FindElement(By.LinkText("REGISTER")).Click();
        }
    }//end class
}
