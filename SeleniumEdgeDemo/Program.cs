using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;
using System.Threading;

class Scripts
{
    static void Main(string[] args)
    {
        var options = new EdgeOptions();
        IWebDriver driver = new EdgeDriver(options);

        try
        {
            driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[placeholder='Email']")).SendKeys("manos@gmail.com");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("testing123");
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("button")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement usernameElement = driver.FindElement(By.ClassName("nav__username"));
            string username = usernameElement.Text;
            Console.WriteLine(username + " is logged in!");
             System.Threading.Thread.Sleep(2000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // Close the browser
            driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}
