﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System.Threading;

class Scripts
{
    static void Main(string[] args)
    {
        var options = new EdgeOptions();
        IWebDriver driver = new EdgeDriver(options);

        try
        {
            // Manos - Login
            // driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Email']")).SendKeys("manos@gmail.com");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("testing123");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("button")).Click();
            // System.Threading.Thread.Sleep(2000);
            // IWebElement usernameElement = driver.FindElement(By.ClassName("nav__username"));
            // string username = usernameElement.Text;
            // Console.WriteLine(username + " is logged in!");
            // System.Threading.Thread.Sleep(2000);

            //Manpreet - Register
            // driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.ClassName("signupScreen__link")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.XPath("//input[@placeholder='Name']")).SendKeys("Manpreet Kaur");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.XPath("//input[@placeholder='Email']")).SendKeys("A00307693@mycambrian.ca");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.XPath("//input[@placeholder='Password']")).SendKeys("Rabab101");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.XPath("//button[text()='Create Account']")).Click();
            // System.Threading.Thread.Sleep(2000);

            // Ujjwall -Play Trailers
            // driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Email']")).SendKeys("ujjiptl@gmail.com");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("ujji1234");;
            //  System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("button")).Click();
            // System.Threading.Thread.Sleep(2000);
            // WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".row__posters")));
            // IWebElement secondChild = driver.FindElement(By.CssSelector(".row__manos:nth-of-type(2)"));
            // Actions actions = new Actions(driver);
            // actions.MoveToElement(secondChild).Perform();
            // IWebElement playButton = secondChild.FindElement(By.CssSelector(".hidden-button"));
            // wait.Until(ExpectedConditions.ElementToBeClickable(playButton));
            // playButton.Click();
            // Console.WriteLine("Hovered over the second child and clicked the PLAY button successfully!");
            // System.Threading.Thread.Sleep(2000);  System.Threading.Thread.Sleep(10000);

            // Saurav - Movie Description
            // driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Email']")).SendKeys("saurav@gmail.com");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("saurav");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("button")).Click();
            // System.Threading.Thread.Sleep(2000);
            // // Locate the element using its class name
            // IWebElement descriptionElement = driver.FindElement(By.ClassName("banner__description"));
            // System.Threading.Thread.Sleep(2000);
            // // Get the text of the element
            // string descriptionText = descriptionElement.Text;
            // System.Threading.Thread.Sleep(2000);
            // // Print the text to the console
            // Console.WriteLine(descriptionText);
            // System.Threading.Thread.Sleep(2000);


            //Gurkirat Singh - Verify access to the profile page after login
            // driver.Navigate().GoToUrl("https://manos-movieszone.netlify.app/");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".loginScreen__getStarted")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Email']")).SendKeys("guri.s46@gmail.com");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("input[placeholder='Password']")).SendKeys("Welcome@123");
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector("button")).Click();
            // System.Threading.Thread.Sleep(2000);
            // driver.FindElement(By.CssSelector(".nav__avatar")).Click();
            // System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Congratulations, All Tasks Were Successful!.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            driver.Quit();
            Console.WriteLine("Browser closed.");
        }
    }
}
