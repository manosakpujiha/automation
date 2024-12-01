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

   
            // Console.WriteLine("Successfully clicked on Login");
            

            // driver.FindElement(By.Id("manos")).SendKeys("manos");

            // driver.FindElement(By.Name("login")).SendKeys("on2eva@yahoo.com");
            // System.Threading.Thread.Sleep(2000);
            // Console.WriteLine("Successfully entered username.");
            // driver.FindElement(By.Name("password")).SendKeys("UJUnwa2020");
            // System.Threading.Thread.Sleep(2000);
            // Console.WriteLine("Successfully entered password.");
            // driver.FindElement(By.CssSelector("input[value='Login']")).Click();
            // System.Threading.Thread.Sleep(3000);
            // Console.WriteLine("Successfully logged in.");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.Id("inputLastName")).SendKeys("browser");

            // driver.FindElement(By.Id("inputFirstName")).SendKeys("Manos");
            // driver.FindElement(By.Id("inputLastName")).SendKeys("Akpujiha");
            // driver.FindElement(By.Id("inputEmailAddress")).SendKeys("manos.akpujiha@gmail.com");
            // driver.FindElement(By.Id("inputPassword")).SendKeys("ilovethis!");
            // driver.FindElement(By.Id("inputConfirmPassword")).SendKeys("ilovethis!");
            // Thread.Sleep(2000);
            // IWebElement createAccountButton = driver.FindElement(By.XPath("//a[text()='Create Account']"));
            // createAccountButton.Click();

            // Console.WriteLine("Succesfully created account for manos.");
            // Thread.Sleep(10000);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            // Close the browser
            // driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}
