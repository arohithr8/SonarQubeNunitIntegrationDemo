using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            //IWebDriver Driver = new ChromeDriver();
            //IWebDriver Driver = new ChromeDriver("C:\tools\selenium\chromedriver.exe");
            //IWebDriver driver = new ChromeDriver(@”C:\tools\selenium\chromedriver.exe”);
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnK")).Click();
            //Driver.FindElement(By.Name("q")).SendKeys('webdriver', Key.RETURN);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }
        
        /*[Test]
        public void GoogleTest2()
        {
            Driver.Navigate().GoToUrl("http://www.rohithrk.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnG")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }
        */
        [Test]
        public void ExecuteAutomationTest()
        {
            //IWebDriver Driver = new ChromeDriver();
            //IWebDriver Driver = new ChromeDriver("C:\tools\selenium\chromedriver.exe");
            //IWebDriver driver = new ChromeDriver(@”C:\tools\selenium\chromedriver.exe”);
            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.Name("Login")).Submit();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }


    }
}
